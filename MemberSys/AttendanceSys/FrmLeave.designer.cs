namespace ClinicSys
{
    partial class FrmLeave
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
            this.xButton1 = new PowerLib.Winform.Controls.XButton();
            this.xButton2 = new PowerLib.Winform.Controls.XButton();
            this.CBLeaveType = new Sunny.UI.UIComboBox();
            this.lblName = new Sunny.UI.UILabel();
            this.lblJob = new Sunny.UI.UILabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiMarkLabel4 = new Sunny.UI.UIMarkLabel();
            this.txtBDe = new Sunny.UI.UITextBox();
            this.uiMarkLabel5 = new Sunny.UI.UIMarkLabel();
            this.CBOtherP = new Sunny.UI.UIComboBox();
            this.uiMarkLabel6 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel7 = new Sunny.UI.UIMarkLabel();
            this.StarDP = new Sunny.UI.UIDatetimePicker();
            this.EndDP = new Sunny.UI.UIDatetimePicker();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.xButton1.Location = new System.Drawing.Point(653, 607);
            this.xButton1.Name = "xButton1";
            this.xButton1.RoundedRectangleCornerRadius = 20;
            this.xButton1.Size = new System.Drawing.Size(106, 53);
            this.xButton1.StartColor = System.Drawing.Color.LightCoral;
            this.xButton1.TabIndex = 14;
            this.xButton1.Text = "確定";
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
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
            this.xButton2.Location = new System.Drawing.Point(792, 607);
            this.xButton2.Name = "xButton2";
            this.xButton2.RoundedRectangleCornerRadius = 20;
            this.xButton2.Size = new System.Drawing.Size(106, 53);
            this.xButton2.StartColor = System.Drawing.Color.LightCoral;
            this.xButton2.TabIndex = 15;
            this.xButton2.Text = "取消";
            this.xButton2.Click += new System.EventHandler(this.xButton2_Click);
            // 
            // CBLeaveType
            // 
            this.CBLeaveType.DataSource = null;
            this.CBLeaveType.FillColor = System.Drawing.Color.Snow;
            this.CBLeaveType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBLeaveType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CBLeaveType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CBLeaveType.Location = new System.Drawing.Point(98, 214);
            this.CBLeaveType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBLeaveType.MinimumSize = new System.Drawing.Size(63, 0);
            this.CBLeaveType.Name = "CBLeaveType";
            this.CBLeaveType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CBLeaveType.Size = new System.Drawing.Size(150, 29);
            this.CBLeaveType.TabIndex = 23;
            this.CBLeaveType.Text = "假別";
            this.CBLeaveType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CBLeaveType.Watermark = "";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblName.Location = new System.Drawing.Point(108, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 38);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "王小明";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJob
            // 
            this.lblJob.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblJob.Location = new System.Drawing.Point(320, 133);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(126, 38);
            this.lblJob.TabIndex = 26;
            this.lblJob.Text = "預設";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(95, 248);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(138, 39);
            this.uiMarkLabel1.TabIndex = 27;
            this.uiMarkLabel1.Text = "請假起訖時間:";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel2.Location = new System.Drawing.Point(94, 92);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel2.TabIndex = 28;
            this.uiMarkLabel2.Text = "申請人:";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel3.Location = new System.Drawing.Point(307, 92);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel3.TabIndex = 29;
            this.uiMarkLabel3.Text = "職務:";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(108, 283);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(86, 38);
            this.uiLabel1.TabIndex = 30;
            this.uiLabel1.Text = "開始時間:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(108, 326);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(86, 38);
            this.uiLabel2.TabIndex = 31;
            this.uiLabel2.Text = "結束時間:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel4.Location = new System.Drawing.Point(95, 379);
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel4.Size = new System.Drawing.Size(138, 39);
            this.uiMarkLabel4.TabIndex = 32;
            this.uiMarkLabel4.Text = "請假事由:";
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBDe
            // 
            this.txtBDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBDe.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBDe.Location = new System.Drawing.Point(112, 423);
            this.txtBDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBDe.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtBDe.Name = "txtBDe";
            this.txtBDe.Padding = new System.Windows.Forms.Padding(5);
            this.txtBDe.ShowText = false;
            this.txtBDe.Size = new System.Drawing.Size(393, 97);
            this.txtBDe.TabIndex = 33;
            this.txtBDe.Text = "請寫下描述";
            this.txtBDe.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBDe.Watermark = "";
            this.txtBDe.Click += new System.EventHandler(this.txtBDe_Click);
            // 
            // uiMarkLabel5
            // 
            this.uiMarkLabel5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel5.Location = new System.Drawing.Point(94, 525);
            this.uiMarkLabel5.Name = "uiMarkLabel5";
            this.uiMarkLabel5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel5.Size = new System.Drawing.Size(138, 39);
            this.uiMarkLabel5.TabIndex = 34;
            this.uiMarkLabel5.Text = "職務代理人:";
            this.uiMarkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBOtherP
            // 
            this.CBOtherP.DataSource = null;
            this.CBOtherP.FillColor = System.Drawing.Color.Snow;
            this.CBOtherP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBOtherP.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CBOtherP.Items.AddRange(new object[] {
            "王小明",
            "王小美",
            "蔡英文"});
            this.CBOtherP.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CBOtherP.Location = new System.Drawing.Point(112, 569);
            this.CBOtherP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBOtherP.MinimumSize = new System.Drawing.Size(63, 0);
            this.CBOtherP.Name = "CBOtherP";
            this.CBOtherP.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CBOtherP.Size = new System.Drawing.Size(150, 29);
            this.CBOtherP.TabIndex = 24;
            this.CBOtherP.Text = "其他同仁";
            this.CBOtherP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CBOtherP.Watermark = "";
            // 
            // uiMarkLabel6
            // 
            this.uiMarkLabel6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel6.Location = new System.Drawing.Point(95, 168);
            this.uiMarkLabel6.Name = "uiMarkLabel6";
            this.uiMarkLabel6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel6.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel6.TabIndex = 35;
            this.uiMarkLabel6.Text = "假別:";
            this.uiMarkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel7
            // 
            this.uiMarkLabel7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel7.Location = new System.Drawing.Point(81, 23);
            this.uiMarkLabel7.MarkColor = System.Drawing.Color.Thistle;
            this.uiMarkLabel7.Name = "uiMarkLabel7";
            this.uiMarkLabel7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel7.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel7.TabIndex = 36;
            this.uiMarkLabel7.Text = "請假申請";
            this.uiMarkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StarDP
            // 
            this.StarDP.DateFormat = "yyyy-MM-dd HH:mm";
            this.StarDP.FillColor = System.Drawing.Color.White;
            this.StarDP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StarDP.Location = new System.Drawing.Point(201, 292);
            this.StarDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StarDP.MaxLength = 16;
            this.StarDP.MinimumSize = new System.Drawing.Size(63, 0);
            this.StarDP.Name = "StarDP";
            this.StarDP.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.StarDP.Size = new System.Drawing.Size(200, 29);
            this.StarDP.SymbolDropDown = 61555;
            this.StarDP.SymbolNormal = 61555;
            this.StarDP.TabIndex = 38;
            this.StarDP.Text = "2023-12-23 11:29";
            this.StarDP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.StarDP.Value = new System.DateTime(2023, 12, 23, 11, 29, 45, 84);
            this.StarDP.Watermark = "";
            // 
            // EndDP
            // 
            this.EndDP.DateFormat = "yyyy-MM-dd HH:mm";
            this.EndDP.FillColor = System.Drawing.Color.White;
            this.EndDP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndDP.Location = new System.Drawing.Point(201, 331);
            this.EndDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDP.MaxLength = 16;
            this.EndDP.MinimumSize = new System.Drawing.Size(63, 0);
            this.EndDP.Name = "EndDP";
            this.EndDP.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EndDP.Size = new System.Drawing.Size(200, 29);
            this.EndDP.SymbolDropDown = 61555;
            this.EndDP.SymbolNormal = 61555;
            this.EndDP.TabIndex = 39;
            this.EndDP.Text = "2023-12-23 11:29";
            this.EndDP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndDP.Value = new System.DateTime(2023, 12, 23, 11, 29, 45, 84);
            this.EndDP.Watermark = "";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(511, 61);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeId.TabIndex = 53;
            this.txtEmployeeId.Text = "28";
            // 
            // FrmLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(944, 691);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.EndDP);
            this.Controls.Add(this.StarDP);
            this.Controls.Add(this.uiMarkLabel7);
            this.Controls.Add(this.uiMarkLabel6);
            this.Controls.Add(this.CBOtherP);
            this.Controls.Add(this.uiMarkLabel5);
            this.Controls.Add(this.txtBDe);
            this.Controls.Add(this.uiMarkLabel4);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiMarkLabel3);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.CBLeaveType);
            this.Controls.Add(this.xButton2);
            this.Controls.Add(this.xButton1);
            this.Name = "FrmLeave";
            this.Text = "FrmLeave";
            this.Load += new System.EventHandler(this.FrmLeave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowerLib.Winform.Controls.XButton xButton1;
        private PowerLib.Winform.Controls.XButton xButton2;
        private Sunny.UI.UIComboBox CBLeaveType;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UILabel lblJob;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel4;
        private Sunny.UI.UITextBox txtBDe;
        private Sunny.UI.UIMarkLabel uiMarkLabel5;
        private Sunny.UI.UIComboBox CBOtherP;
        private Sunny.UI.UIMarkLabel uiMarkLabel6;
        private Sunny.UI.UIMarkLabel uiMarkLabel7;
        private Sunny.UI.UIDatetimePicker StarDP;
        private Sunny.UI.UIDatetimePicker EndDP;
        private System.Windows.Forms.TextBox txtEmployeeId;
    }
}