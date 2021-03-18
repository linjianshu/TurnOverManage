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
    public partial class PutOutForm : FrmWithOKCancel1
    {
        public PutOutForm()
        {
            InitializeComponent();
        }

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
            FontIcons icon2 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple.Item2);
            var pictureBox2 = new PictureBox
            {
                AutoSize = false,
                Size = new Size(40, 40),
                ForeColor = Color.FromArgb(255, 77, 59),
                Image = FontImages.GetImage(icon2, 36, Color.FromArgb(255, 77, 59)),
                Location = new Point(this.Size.Width / 2 - 20, 15)
            };
            panel3.Controls.Add(pictureBox2);
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
                    return true;
                }

                return false;
            }
        }
        protected override void DoEnter()
        {
            if (string.IsNullOrEmpty(ProductNameTxt.Text) || string.IsNullOrEmpty(ProductBornCodeTxt.Text))
            {
                FrmDialog.ShowDialog(this, "产品信息不准确,请重新扫码");
                return;
            }

            if (!AlreadyInJudge())
            {
                FrmDialog.ShowDialog(this, "周转库中暂无该产品库存信息");
                BeginInvoke(new Action((() =>
                {
                    ProductBornCodeTxt.Clear();
                    ProductNameTxt.Clear();
                })));
                return;
            }

            var dialogResult = FrmDialog.ShowDialog(this, "是否确认出库?", "确认", true);
            if (dialogResult == DialogResult.OK)
            {
                PutOut();
            }

            FrmDialog.ShowDialog(this, "出库成功!");
            Close();
            serialPort1.Close();
        }

        protected override void DoEsc()
        {
            serialPort1.Close();
            Close();
        }

        private void PutOut()
        {
            using (var context = new Model())
            {
                //判断是否已经入库过了 最好在扫码的时候就做一下判断
                //有的话就转档 , 没有的话就提示
                var firstOrDefault = context.C_TurnoverWarehouseProcessing.FirstOrDefault(s =>
                    s.ProductBornCode == _aPlanProductInfomation.ProductBornCode);

                if (firstOrDefault != null)
                {
                    var mapperConfiguration1 = new MapperConfiguration(cfg =>
                    cfg.CreateMap<C_TurnoverWarehouseProcessing, C_TurnoverWarehouseDocument>());
                    var mapper1 = mapperConfiguration1.CreateMapper();
                    var cTurnoverWarehouseDocument = mapper1.Map<C_TurnoverWarehouseDocument>(firstOrDefault);
                    context.C_TurnoverWarehouseDocument.Add(cTurnoverWarehouseDocument);
                    context.C_TurnoverWarehouseProcessing.Remove(firstOrDefault);
                    context.SaveChanges();
                    RegetAction();
                }
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
                BeginInvoke(new Action((() =>
                {
                    ProductNameTxt.Clear();
                    ProductBornCodeTxt.Clear();
                }))); 
                var aPlanProductInfomation =
                    context.A_PlanProductInfomation.FirstOrDefault(s =>
                        s.IsAvailable == true && s.ProductBornCode == receivedData);
                if (aPlanProductInfomation != null)
                {
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
