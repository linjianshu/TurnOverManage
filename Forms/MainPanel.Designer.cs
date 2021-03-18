
namespace TurnOverManage.Forms
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.TrademarkLbl = new System.Windows.Forms.Label();
            this.MachiningCenterLbl = new System.Windows.Forms.Label();
            this.graphicalOverlayComponent1 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.FirstTitlePanel = new System.Windows.Forms.Panel();
            this.graphicalOverlayComponent2 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.SecondTitlePanel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.PersonnelInfoLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MachiningCenterStateLbl = new System.Windows.Forms.Label();
            this.ucSignalLamp2 = new HZH_Controls.Controls.UCSignalLamp();
            this.ServerStateLbl = new System.Windows.Forms.Label();
            this.ucSignalLamp1 = new HZH_Controls.Controls.UCSignalLamp();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.ucDataGridView1 = new HZH_Controls.Controls.UCDataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstTitlePanel.SuspendLayout();
            this.SecondTitlePanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrademarkLbl
            // 
            this.TrademarkLbl.AutoSize = true;
            this.TrademarkLbl.BackColor = System.Drawing.Color.Transparent;
            this.TrademarkLbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.TrademarkLbl.ForeColor = System.Drawing.Color.White;
            this.TrademarkLbl.Location = new System.Drawing.Point(34, 6);
            this.TrademarkLbl.Name = "TrademarkLbl";
            this.TrademarkLbl.Size = new System.Drawing.Size(161, 40);
            this.TrademarkLbl.TabIndex = 1;
            this.TrademarkLbl.Text = "SHINDEN";
            // 
            // MachiningCenterLbl
            // 
            this.MachiningCenterLbl.AutoSize = true;
            this.MachiningCenterLbl.BackColor = System.Drawing.Color.Transparent;
            this.MachiningCenterLbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.MachiningCenterLbl.ForeColor = System.Drawing.Color.White;
            this.MachiningCenterLbl.Location = new System.Drawing.Point(189, 20);
            this.MachiningCenterLbl.Name = "MachiningCenterLbl";
            this.MachiningCenterLbl.Size = new System.Drawing.Size(167, 40);
            this.MachiningCenterLbl.TabIndex = 1;
            this.MachiningCenterLbl.Text = "周转库管理";
            // 
            // graphicalOverlayComponent1
            // 
            this.graphicalOverlayComponent1.Owner = null;
            // 
            // FirstTitlePanel
            // 
            this.FirstTitlePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.FirstTitlePanel.Controls.Add(this.TrademarkLbl);
            this.FirstTitlePanel.Controls.Add(this.MachiningCenterLbl);
            this.FirstTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.FirstTitlePanel.Name = "FirstTitlePanel";
            this.FirstTitlePanel.Size = new System.Drawing.Size(1094, 63);
            this.FirstTitlePanel.TabIndex = 3;
            // 
            // graphicalOverlayComponent2
            // 
            this.graphicalOverlayComponent2.Owner = null;
            // 
            // SecondTitlePanel1
            // 
            this.SecondTitlePanel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SecondTitlePanel1.Controls.Add(this.textBox1);
            this.SecondTitlePanel1.Controls.Add(this.comboBox1);
            this.SecondTitlePanel1.Controls.Add(this.ucBtnExt1);
            this.SecondTitlePanel1.Controls.Add(this.PersonnelInfoLbl);
            this.SecondTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondTitlePanel1.Location = new System.Drawing.Point(0, 63);
            this.SecondTitlePanel1.Name = "SecondTitlePanel1";
            this.SecondTitlePanel1.Size = new System.Drawing.Size(1094, 65);
            this.SecondTitlePanel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 27);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "产品名称",
            "产品出生证"});
            this.comboBox1.Location = new System.Drawing.Point(210, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "全部";
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "查   询";
            this.ucBtnExt1.ConerRadius = 10;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(732, 14);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.White;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(145, 42);
            this.ucBtnExt1.TabIndex = 3;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // PersonnelInfoLbl
            // 
            this.PersonnelInfoLbl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PersonnelInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonnelInfoLbl.ForeColor = System.Drawing.Color.White;
            this.PersonnelInfoLbl.Location = new System.Drawing.Point(82, 18);
            this.PersonnelInfoLbl.Name = "PersonnelInfoLbl";
            this.PersonnelInfoLbl.Size = new System.Drawing.Size(133, 29);
            this.PersonnelInfoLbl.TabIndex = 1;
            this.PersonnelInfoLbl.Text = "检索条件:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucBtnExt2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1094, 45);
            this.panel4.TabIndex = 7;
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.CornflowerBlue;
            this.ucBtnExt2.BtnText = "产品信息";
            this.ucBtnExt2.ConerRadius = 13;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.White;
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(11, 8);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.Black;
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(145, 42);
            this.ucBtnExt2.TabIndex = 3;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.MachiningCenterStateLbl);
            this.panel3.Controls.Add(this.ucSignalLamp2);
            this.panel3.Controls.Add(this.ServerStateLbl);
            this.panel3.Controls.Add(this.ucSignalLamp1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 661);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 31);
            this.panel3.TabIndex = 9;
            // 
            // MachiningCenterStateLbl
            // 
            this.MachiningCenterStateLbl.AutoSize = true;
            this.MachiningCenterStateLbl.ForeColor = System.Drawing.Color.White;
            this.MachiningCenterStateLbl.Location = new System.Drawing.Point(206, 3);
            this.MachiningCenterStateLbl.Name = "MachiningCenterStateLbl";
            this.MachiningCenterStateLbl.Size = new System.Drawing.Size(69, 20);
            this.MachiningCenterStateLbl.TabIndex = 11;
            this.MachiningCenterStateLbl.Text = "加工中心";
            // 
            // ucSignalLamp2
            // 
            this.ucSignalLamp2.IsHighlight = true;
            this.ucSignalLamp2.IsShowBorder = false;
            this.ucSignalLamp2.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.ucSignalLamp2.Location = new System.Drawing.Point(177, 2);
            this.ucSignalLamp2.Name = "ucSignalLamp2";
            this.ucSignalLamp2.Size = new System.Drawing.Size(18, 18);
            this.ucSignalLamp2.TabIndex = 10;
            this.ucSignalLamp2.TwinkleSpeed = 0;
            // 
            // ServerStateLbl
            // 
            this.ServerStateLbl.AutoSize = true;
            this.ServerStateLbl.ForeColor = System.Drawing.Color.White;
            this.ServerStateLbl.Location = new System.Drawing.Point(69, 3);
            this.ServerStateLbl.Name = "ServerStateLbl";
            this.ServerStateLbl.Size = new System.Drawing.Size(54, 20);
            this.ServerStateLbl.TabIndex = 11;
            this.ServerStateLbl.Text = "服务器";
            // 
            // ucSignalLamp1
            // 
            this.ucSignalLamp1.IsHighlight = true;
            this.ucSignalLamp1.IsShowBorder = false;
            this.ucSignalLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.ucSignalLamp1.Location = new System.Drawing.Point(40, 2);
            this.ucSignalLamp1.Name = "ucSignalLamp1";
            this.ucSignalLamp1.Size = new System.Drawing.Size(18, 18);
            this.ucSignalLamp1.TabIndex = 10;
            this.ucSignalLamp1.TwinkleSpeed = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.ucDataGridView1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 173);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1094, 448);
            this.panel10.TabIndex = 11;
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1.BackColor = System.Drawing.Color.White;
            this.ucDataGridView1.Columns = null;
            this.ucDataGridView1.DataSource = null;
            this.ucDataGridView1.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucDataGridView1.HeadHeight = 40;
            this.ucDataGridView1.HeadPadingLeft = 0;
            this.ucDataGridView1.HeadTextColor = System.Drawing.Color.Black;
            this.ucDataGridView1.IsShowCheckBox = false;
            this.ucDataGridView1.IsShowHead = true;
            this.ucDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ucDataGridView1.RowHeight = 40;
            this.ucDataGridView1.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.ucDataGridView1.Size = new System.Drawing.Size(1092, 465);
            this.ucDataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 40);
            this.panel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1094, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SecondTitlePanel1);
            this.Controls.Add(this.FirstTitlePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsFullSize = false;
            this.Name = "MainPanel";
            this.Text = "机加过程管控";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.FirstTitlePanel.ResumeLayout(false);
            this.FirstTitlePanel.PerformLayout();
            this.SecondTitlePanel1.ResumeLayout(false);
            this.SecondTitlePanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TrademarkLbl;
        private System.Windows.Forms.Label MachiningCenterLbl;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent1;
        private System.Windows.Forms.Panel FirstTitlePanel;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent2;
        private System.Windows.Forms.Panel SecondTitlePanel1;
        private System.Windows.Forms.Label PersonnelInfoLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        public HZH_Controls.Controls.UCSignalLamp ucSignalLamp1;
        private System.Windows.Forms.Label ServerStateLbl;
        private System.Windows.Forms.Label MachiningCenterStateLbl;
        public HZH_Controls.Controls.UCSignalLamp ucSignalLamp2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel10;
        private HZH_Controls.Controls.UCDataGridView ucDataGridView1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private System.Windows.Forms.ComboBox comboBox1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}