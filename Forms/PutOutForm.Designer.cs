
namespace TurnOverManage
{
    partial class PutOutForm
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
            this.ProductType = new System.Windows.Forms.Label();
            this.BadReasonLbl = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductBornCodeTxt = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BadReasonLbl);
            this.panel3.Controls.Add(this.ProductType);
            this.panel3.Controls.Add(this.ProductBornCodeTxt);
            this.panel3.Controls.Add(this.ProductNameTxt);
            this.panel3.Size = new System.Drawing.Size(453, 213);
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductType.Location = new System.Drawing.Point(104, 70);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(93, 26);
            this.ProductType.TabIndex = 8;
            this.ProductType.Text = "产品名称:";
            // 
            // BadReasonLbl
            // 
            this.BadReasonLbl.AutoSize = true;
            this.BadReasonLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BadReasonLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BadReasonLbl.Location = new System.Drawing.Point(104, 143);
            this.BadReasonLbl.Name = "BadReasonLbl";
            this.BadReasonLbl.Size = new System.Drawing.Size(112, 26);
            this.BadReasonLbl.TabIndex = 8;
            this.BadReasonLbl.Text = "产品出生证:";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.BackColor = System.Drawing.Color.White;
            this.ProductNameTxt.Location = new System.Drawing.Point(220, 67);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(143, 32);
            this.ProductNameTxt.TabIndex = 6;
            // 
            // ProductBornCodeTxt
            // 
            this.ProductBornCodeTxt.BackColor = System.Drawing.Color.White;
            this.ProductBornCodeTxt.Location = new System.Drawing.Point(220, 140);
            this.ProductBornCodeTxt.Name = "ProductBornCodeTxt";
            this.ProductBornCodeTxt.Size = new System.Drawing.Size(143, 32);
            this.ProductBornCodeTxt.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // PutOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(453, 337);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PutOutForm";
            this.Text = "ScanOfflineForm";
            this.Title = "出库管理";
            this.Load += new System.EventHandler(this.ScanOfflineForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.Label BadReasonLbl;
        private System.Windows.Forms.TextBox ProductBornCodeTxt;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.IO.Ports.SerialPort serialPort1;
    }
}