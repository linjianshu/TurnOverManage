using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AutoMapper;
using HZH_Controls;
using HZH_Controls.Forms;
using MachineryProcessingDemo;
using WorkPlatForm.Public_Classes;

namespace TurnOverManage.Forms
{
    public partial class PutInForm : FrmWithOKCancel1
    {
        public PutInForm()
        {
            InitializeComponent();
        }

        private static Base_DataDictionaryDetail _baseDataDictionaryDetail;
        private static A_PlanProductInfomation _aPlanProductInfomation;
        public Action RegetAction; 
        private void ScanOfflineForm_Load(object sender, EventArgs e)
        {
            DataFill();

            if (serialPort1.IsOpen) { serialPort1.Close(); }
            string portName = ConfigAppSettingsHelper.ReadSetting("PortName");
            string baudRate = ConfigAppSettingsHelper.ReadSetting("BaudRate");
            serialPort1.Dispose();//释放扫描枪所有资源
            serialPort1.PortName = portName;
            serialPort1.BaudRate = int.Parse(baudRate);
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void DataFill()
        {
            var tuple = new Tuple<string, string>("产品", "A_fa_cube");
            var tuple1 = new Tuple<string, string>("货架", "E_icon_house");
            FontIcons icon1 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple1.Item2);
            FontIcons icon2 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple.Item2);
            var pictureBox1 = new PictureBox
            {
                AutoSize = false,
                Size = new Size(40, 40),
                ForeColor = Color.FromArgb(255, 77, 59),
                Image = FontImages.GetImage(icon1, 40, Color.FromArgb(255, 77, 59)),
                Location = new Point(this.Size.Width / 4 - 20, 15)
            };
            panel3.Controls.Add(pictureBox1);

            var pictureBox2 = new PictureBox
            {
                AutoSize = false,
                Size = new Size(40, 40),
                ForeColor = Color.FromArgb(255, 77, 59),
                Image = FontImages.GetImage(icon2, 36, Color.FromArgb(255, 77, 59)),
                Location = new Point(this.Size.Width / 4 * 3 - 20, 15)
            };
            panel3.Controls.Add(pictureBox2);
        }


        protected override void DoEnter()
        {
            if (string.IsNullOrEmpty(ProductNameTxt.Text) || string.IsNullOrEmpty(ProductBornCodeTxt.Text))
            {
                FrmDialog.ShowDialog(this, "产品信息不准确,请重新扫码");
                return;
            }
            if (string.IsNullOrEmpty(ShelvesNameTxt.Text) || string.IsNullOrEmpty(ShelvesIdTxt.Text))
            {
                FrmDialog.ShowDialog(this, "货架信息不准确,请重新扫码");
                return;
            }

             if (AlreadyInJudge())
             {
                 BeginInvoke(new Action((() =>
                 {
                     ProductBornCodeTxt.Clear();
                     ProductNameTxt.Clear();
                     ShelvesNameTxt.Clear();
                     ShelvesIdTxt.Clear();
                 }))); 
                 return; 
             }

            var dialogResult = FrmDialog.ShowDialog(this, "是否确认入库?", "确认", true);
            if (dialogResult == DialogResult.OK)
            {
                PutIn();
            }

            FrmDialog.ShowDialog(this, "入库成功!");
            Close();
            serialPort1.Close();
        }

        private bool AlreadyInJudge()
        {
            using (var context = new Model())
            {
                //判断是否已经入库过了 最好在扫码的时候就做一下判断
                //有的话就转档 , 没有的话就提示
                var firstOrDefault = context.C_TurnoverWarehouseProcessing.FirstOrDefault(s =>
                    s.ProductBornCode == _aPlanProductInfomation.ProductBornCode);

                if (firstOrDefault != null)
                {
                    FrmDialog.ShowDialog(this, "该产品已入库!");
                    return true;
                }

                return false; 
            }
        }

        protected override void DoEsc()
        {
            serialPort1.Close();
            Close();
        }

        private void PutIn()
        {
            using (var context = new Model())
            {
                var apsProcedureTaskDetail = context.APS_ProcedureTaskDetail.First(s =>
                    s.ProductBornCode == _aPlanProductInfomation.ProductBornCode && s.IsAvailable == true);

                var mapperConfiguration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<APS_ProcedureTaskDetail, C_TurnoverWarehouseProcessing>());
                var mapper = mapperConfiguration.CreateMapper();
                var cTurnoverWarehouseProcessing = mapper.Map<C_TurnoverWarehouseProcessing>(apsProcedureTaskDetail);


                cTurnoverWarehouseProcessing.ProductName = _aPlanProductInfomation.ProductName;
                cTurnoverWarehouseProcessing.CreateTime = context.GetServerDate();
                cTurnoverWarehouseProcessing.InStaffCode = "";
                cTurnoverWarehouseProcessing.InStaffID = 2020;
                cTurnoverWarehouseProcessing.InStaffName = "";
                cTurnoverWarehouseProcessing.ShelvesCode = _baseDataDictionaryDetail.Code;
                cTurnoverWarehouseProcessing.ShelvesName = _baseDataDictionaryDetail.FullName;

                context.C_TurnoverWarehouseProcessing.Add(cTurnoverWarehouseProcessing);
                context.SaveChanges();
                RegetAction();
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var receivedData = GetDataFromSerialPort(serialPort1);

            EnrichTextbox(receivedData);
        }

        private void EnrichTextbox(string receivedData)
        {
            using (var context = new Model())
            {
                var baseDataDictionaryDetail = context.Base_DataDictionaryDetail.FirstOrDefault(s => s.DataDictionaryDetailId == receivedData);
                if (baseDataDictionaryDetail != null)
                {
                    BeginInvoke(new Action((() =>
                    {
                        ShelvesIdTxt.Clear();
                        ShelvesNameTxt.Clear();
                    })));

                    BeginInvoke(new Action((() =>
                     {
                         ShelvesIdTxt.Text = _baseDataDictionaryDetail.Code;
                         ShelvesNameTxt.Text = _baseDataDictionaryDetail.FullName;
                     })));
                    _baseDataDictionaryDetail = baseDataDictionaryDetail;
                }


                var aPlanProductInfomation =
                    context.A_PlanProductInfomation.FirstOrDefault(s =>
                        s.IsAvailable == true && s.ProductBornCode == receivedData);
                if (aPlanProductInfomation!=null)
                {
                    BeginInvoke(new Action((() =>
                    {
                        ProductNameTxt.Clear();
                        ProductBornCodeTxt.Clear();
                    })));

                    _aPlanProductInfomation = aPlanProductInfomation;
                    BeginInvoke(new Action((() =>
                    {
                        ProductNameTxt.Text = aPlanProductInfomation.ProductName;
                        ProductBornCodeTxt.Text = aPlanProductInfomation.ProductBornCode; 
                    }))); 
                }
            }
        }

        /// <summary>
        /// 扫描枪扫描调用方法
        /// </summary>
        /// <param name="serialPort"></param>
        /// <returns></returns>
        private static string GetDataFromSerialPort(SerialPort serialPort)
        {
            Thread.Sleep(300);
            byte[] buffer = new byte[serialPort.BytesToRead];
            string receiveString = "";
            try
            {
                serialPort.Read(buffer, 0, buffer.Length);
                foreach (var t in buffer)
                {
                    receiveString += (char)t;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            if (receiveString.Length > 2)
            {
                receiveString = receiveString.Substring(0, receiveString.Length - 1);
            }
            return receiveString;
        }
    }
}
