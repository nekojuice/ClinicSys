namespace ClinicSys
{
    partial class Frmexpen
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
            this.uiMarkLabel6 = new Sunny.UI.UIMarkLabel();
            this.txtDes = new Sunny.UI.UITextBox();
            this.uiMarkLabel4 = new Sunny.UI.UIMarkLabel();
            this.DPuse = new Sunny.UI.UIDatePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.lblJob = new Sunny.UI.UILabel();
            this.lblName = new Sunny.UI.UILabel();
            this.CBex = new Sunny.UI.UIComboBox();
            this.DPapply = new Sunny.UI.UIDatePicker();
            this.xButton2 = new PowerLib.Winform.Controls.XButton();
            this.xButton1 = new PowerLib.Winform.Controls.XButton();
            this.uiMarkLabel7 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel5 = new Sunny.UI.UIMarkLabel();
            this.txtAmount = new Sunny.UI.UITextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiMarkLabel6
            // 
            this.uiMarkLabel6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel6.Location = new System.Drawing.Point(68, 180);
            this.uiMarkLabel6.Name = "uiMarkLabel6";
            this.uiMarkLabel6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel6.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel6.TabIndex = 54;
            this.uiMarkLabel6.Text = "申請項目:";
            this.uiMarkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDes
            // 
            this.txtDes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDes.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDes.Location = new System.Drawing.Point(85, 435);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDes.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDes.Name = "txtDes";
            this.txtDes.Padding = new System.Windows.Forms.Padding(5);
            this.txtDes.ShowText = false;
            this.txtDes.Size = new System.Drawing.Size(393, 97);
            this.txtDes.TabIndex = 52;
            this.txtDes.Text = "請寫下描述";
            this.txtDes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDes.Watermark = "";
            this.txtDes.Click += new System.EventHandler(this.txtDes_Click);
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel4.Location = new System.Drawing.Point(68, 391);
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel4.Size = new System.Drawing.Size(138, 39);
            this.uiMarkLabel4.TabIndex = 51;
            this.uiMarkLabel4.Text = "申請事由:";
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DPuse
            // 
            this.DPuse.FillColor = System.Drawing.Color.Snow;
            this.DPuse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DPuse.Location = new System.Drawing.Point(174, 347);
            this.DPuse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPuse.MaxLength = 10;
            this.DPuse.MinimumSize = new System.Drawing.Size(63, 0);
            this.DPuse.Name = "DPuse";
            this.DPuse.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DPuse.ShowToday = true;
            this.DPuse.Size = new System.Drawing.Size(150, 29);
            this.DPuse.SymbolDropDown = 61555;
            this.DPuse.SymbolNormal = 61555;
            this.DPuse.TabIndex = 39;
            this.DPuse.Text = "2023-12-21";
            this.DPuse.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DPuse.Value = new System.DateTime(2023, 12, 21, 11, 15, 44, 930);
            this.DPuse.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(81, 338);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(86, 38);
            this.uiLabel2.TabIndex = 50;
            this.uiLabel2.Text = "使用日期:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(81, 295);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(86, 38);
            this.uiLabel1.TabIndex = 49;
            this.uiLabel1.Text = "申請日期:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel3.Location = new System.Drawing.Point(280, 90);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel3.TabIndex = 48;
            this.uiMarkLabel3.Text = "職務:";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel2.Location = new System.Drawing.Point(68, 90);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel2.TabIndex = 47;
            this.uiMarkLabel2.Text = "申請人:";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(68, 260);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(138, 39);
            this.uiMarkLabel1.TabIndex = 46;
            this.uiMarkLabel1.Text = "申請與時間:";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJob
            // 
            this.lblJob.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblJob.Location = new System.Drawing.Point(293, 131);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(126, 38);
            this.lblJob.TabIndex = 45;
            this.lblJob.Text = "醫生";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblName.Location = new System.Drawing.Point(68, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 38);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "王小明";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBex
            // 
            this.CBex.DataSource = null;
            this.CBex.FillColor = System.Drawing.Color.Snow;
            this.CBex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBex.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CBex.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CBex.Location = new System.Drawing.Point(85, 226);
            this.CBex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBex.MinimumSize = new System.Drawing.Size(63, 0);
            this.CBex.Name = "CBex";
            this.CBex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CBex.Size = new System.Drawing.Size(150, 29);
            this.CBex.TabIndex = 40;
            this.CBex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CBex.Watermark = "";
            // 
            // DPapply
            // 
            this.DPapply.FillColor = System.Drawing.Color.Snow;
            this.DPapply.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DPapply.Location = new System.Drawing.Point(174, 304);
            this.DPapply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPapply.MaxLength = 10;
            this.DPapply.MinimumSize = new System.Drawing.Size(63, 0);
            this.DPapply.Name = "DPapply";
            this.DPapply.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DPapply.ShowToday = true;
            this.DPapply.Size = new System.Drawing.Size(150, 29);
            this.DPapply.SymbolDropDown = 61555;
            this.DPapply.SymbolNormal = 61555;
            this.DPapply.TabIndex = 38;
            this.DPapply.Text = "2023-12-21";
            this.DPapply.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DPapply.Value = new System.DateTime(2023, 12, 21, 11, 15, 44, 930);
            this.DPapply.Watermark = "";
            // 
            // xButton2
            // 
            this.xButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xButton2.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton2.CheckedForeColor = System.Drawing.Color.White;
            this.xButton2.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton2.DefaultButtonBorderWidth = 2;
            this.xButton2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.xButton2.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.xButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.xButton2.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton2.HoldingForeColor = System.Drawing.Color.White;
            this.xButton2.HoldingImage = null;
            this.xButton2.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton2.Image = null;
            this.xButton2.Location = new System.Drawing.Point(666, 516);
            this.xButton2.Name = "xButton2";
            this.xButton2.RoundedRectangleCornerRadius = 20;
            this.xButton2.Size = new System.Drawing.Size(106, 53);
            this.xButton2.StartColor = System.Drawing.Color.LightCoral;
            this.xButton2.TabIndex = 37;
            this.xButton2.Text = "取消";
            this.xButton2.Click += new System.EventHandler(this.xButton2_Click);
            // 
            // xButton1
            // 
            this.xButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xButton1.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton1.CheckedForeColor = System.Drawing.Color.White;
            this.xButton1.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton1.DefaultButtonBorderWidth = 2;
            this.xButton1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.xButton1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.xButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.xButton1.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton1.HoldingForeColor = System.Drawing.Color.White;
            this.xButton1.HoldingImage = null;
            this.xButton1.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton1.Image = null;
            this.xButton1.Location = new System.Drawing.Point(523, 516);
            this.xButton1.Name = "xButton1";
            this.xButton1.RoundedRectangleCornerRadius = 20;
            this.xButton1.Size = new System.Drawing.Size(106, 53);
            this.xButton1.StartColor = System.Drawing.Color.LightCoral;
            this.xButton1.TabIndex = 36;
            this.xButton1.Text = "確定";
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // uiMarkLabel7
            // 
            this.uiMarkLabel7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel7.Location = new System.Drawing.Point(66, 18);
            this.uiMarkLabel7.MarkColor = System.Drawing.Color.Thistle;
            this.uiMarkLabel7.Name = "uiMarkLabel7";
            this.uiMarkLabel7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel7.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel7.TabIndex = 55;
            this.uiMarkLabel7.Text = "費用申請";
            this.uiMarkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel5
            // 
            this.uiMarkLabel5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel5.Location = new System.Drawing.Point(280, 180);
            this.uiMarkLabel5.Name = "uiMarkLabel5";
            this.uiMarkLabel5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel5.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel5.TabIndex = 56;
            this.uiMarkLabel5.Text = "申請費用";
            this.uiMarkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(297, 226);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAmount.ShowText = false;
            this.txtAmount.Size = new System.Drawing.Size(122, 30);
            this.txtAmount.TabIndex = 53;
            this.txtAmount.Text = "請寫下金額";
            this.txtAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAmount.Watermark = "";
            this.txtAmount.Click += new System.EventHandler(this.txtAmount_Click);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(425, 75);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeId.TabIndex = 57;
            this.txtEmployeeId.Text = "28";
            // 
            // Frmexpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.uiMarkLabel5);
            this.Controls.Add(this.uiMarkLabel7);
            this.Controls.Add(this.uiMarkLabel6);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.uiMarkLabel4);
            this.Controls.Add(this.DPuse);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiMarkLabel3);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.CBex);
            this.Controls.Add(this.DPapply);
            this.Controls.Add(this.xButton2);
            this.Controls.Add(this.xButton1);
            this.Name = "Frmexpen";
            this.Text = "Frmexpen";
            this.Load += new System.EventHandler(this.Frmexpen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frmexpen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIMarkLabel uiMarkLabel6;
        private Sunny.UI.UITextBox txtDes;
        private Sunny.UI.UIMarkLabel uiMarkLabel4;
        private Sunny.UI.UIDatePicker DPuse;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UILabel lblJob;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UIComboBox CBex;
        private Sunny.UI.UIDatePicker DPapply;
        private PowerLib.Winform.Controls.XButton xButton2;
        private PowerLib.Winform.Controls.XButton xButton1;
        private Sunny.UI.UIMarkLabel uiMarkLabel7;
        private Sunny.UI.UIMarkLabel uiMarkLabel5;
        private Sunny.UI.UITextBox txtAmount;
        private System.Windows.Forms.TextBox txtEmployeeId;
    }
}