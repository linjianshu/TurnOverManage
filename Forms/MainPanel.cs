using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using MachineryProcessingDemo;

namespace TurnOverManage.Forms
{
    public partial class MainPanel : FrmBase
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        //图标间宽度
        private static int _widthX = 800;
        //tuple计数器
        private static int _tupleI = 0;
        //全局静态只读tuple
        private static readonly List<Tuple<string, string>> MuneList = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("出库", "E_arrow_carrot_2up_alt"),
            new Tuple<string, string>("入库", "E_arrow_carrot_2dwnn_alt"),
            new Tuple<string, string>("退出", "A_fa_power_off"),
        };

        private void MainPanel_Load(object sender, EventArgs e)
        {
            // var dateTime = context.GetServerDate();
            //使用hzh控件自带的图标库 tuple

            //解析tuple 加载顶部菜单栏 绑定事件

            InialLabel();

            InitialColumns();

            InitialDidTasks();

            ucSignalLamp1.LampColor = new Color[] { Color.Green };
            ucSignalLamp2.LampColor = new Color[] { Color.Red };

            timer1.Enabled = true;

            IsFullSize = false;
        }

        private async void InialLabel()
        {
            var PutInLabel = await GenerateLabel();
            FirstTitlePanel.Controls.Add(PutInLabel);
            PutInLabel.Click += OpenPutInForm;
            
            var PutOutLabel = await GenerateLabel();
            FirstTitlePanel.Controls.Add(PutOutLabel);
            PutOutLabel.Click += OpenPutOutForm;

            var exitLabel = await GenerateLabel();
            FirstTitlePanel.Controls.Add(exitLabel);
            exitLabel.Click += CloseForms;
        }

        private void OpenPutOutForm(object sender, EventArgs e)
        {
            var putOutForm = new PutOutForm()
            {
                BackColor = Color.FromArgb(82, 82, 136),
                RegetAction = () => InitialDidTasks()
            };
            putOutForm.ShowDialog();
        }

        private void InitialColumns()
        {
            // 自定义表格 装载图片等资源
            List<DataGridViewColumnEntity> lstColumns = new List<DataGridViewColumnEntity>
            {
                new DataGridViewColumnEntity()
                {
                    DataField = "ProductBornCode", HeadText = "产品出生证", Width = 30, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "ProductName", HeadText = "产品名称", Width = 25, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "ShelvesCode", HeadText = "货架编号", Width = 25, WidthType = SizeType.Percent
                } ,
                new DataGridViewColumnEntity()
                {
                    DataField = "ShelvesName", HeadText = "货架名称", Width = 20, WidthType = SizeType.Percent
                },
            };
            ucDataGridView1.Columns = lstColumns;
        }

        private void OpenPutInForm(object sender, EventArgs e)
        {
            var putInForm = new PutInForm()
            {
                BackColor = Color.FromArgb(200, 200, 247),
                RegetAction = () => InitialDidTasks()
            };
            putInForm.ShowDialog();
        }

        private async void InitialDidTasks()
        {
            ucDataGridView1.DataSource = await GetDidProcedureTask();
        }

        private async Task<List<C_TurnoverWarehouseProcessing>> GetDidProcedureTask()
        {
            return await GetDetailAsync();
        }

        private async Task<List<C_TurnoverWarehouseProcessing>> GetDetailAsync()
        {
            var turnoverWarehouseProcessings = new List<C_TurnoverWarehouseProcessing>();
            using (var context = new Model())
            {
                await Task.Run(() =>
                {
                    turnoverWarehouseProcessings = context.C_TurnoverWarehouseProcessing.ToList();
                });
                return turnoverWarehouseProcessings;
            }
        }
        private List<C_TurnoverWarehouseProcessing> GetDetail()
        {
            using (var context = new Model())
            {
                return context.C_TurnoverWarehouseProcessing.ToList();
            }
        }
        private void CloseForms(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async Task<Label> GenerateLabel()
        {
            var label = new Label();
            await Task.Run((() =>
            {
                var icon = (FontIcons)Enum.Parse(typeof(FontIcons), MuneList[_tupleI].Item2);
                label.AutoSize = false;
                label.Size = new Size(90, 60);
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.BottomCenter;
                label.ImageAlign = ContentAlignment.TopCenter;
                label.Margin = new Padding(5);
                label.Text = MuneList[_tupleI].Item1;
                label.Image = FontImages.GetImage(icon, 32, Color.White);
                label.Location = new Point(_widthX, 0);
                label.Font = new Font("微软雅黑", 12, FontStyle.Bold);
                _widthX += 90;
                _tupleI++;
            }));
            return label;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ucDataGridView1.DataSource = GetSomething();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            ucDataGridView1.DataSource = GetSomething();
        }

        private List<C_TurnoverWarehouseProcessing> GetByProductName()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            using (var context = new Model())
            {
                return context.C_TurnoverWarehouseProcessing
                    .Where(s => s.ProductName.Contains(textBox1.Text.Trim())).ToList();
            }
        }
        private List<C_TurnoverWarehouseProcessing> GetByProductBornCode()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            using (var context = new Model())
            {
                return context.C_TurnoverWarehouseProcessing
                    .Where(s => s.ProductBornCode.Contains(textBox1.Text.Trim())).ToList();
            }
        }
        private List<C_TurnoverWarehouseProcessing> GetSomething()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            if (comboBox1.Text.Equals("全部"))
            {
                return GetDetail();
            }

            if (comboBox1.Text.Equals("产品名称"))
            {
                return GetByProductName();
            }

            return GetByProductBornCode();
        }
    }
}
