namespace MSIT155_E_MID.ApptSystem.View
{
    partial class DialogModifyAppt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientClinicNumber = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.txtIsCancelled = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsVIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.cbxIsCancelled = new System.Windows.Forms.ComboBox();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.cbxIsVIP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.patientInfo1 = new MSIT155_E_MID.PatientInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(285, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "診號";
            // 
            // txtPatientClinicNumber
            // 
            this.txtPatientClinicNumber.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPatientClinicNumber.Location = new System.Drawing.Point(345, 163);
            this.txtPatientClinicNumber.Name = "txtPatientClinicNumber";
            this.txtPatientClinicNumber.ReadOnly = true;
            this.txtPatientClinicNumber.Size = new System.Drawing.Size(151, 35);
            this.txtPatientClinicNumber.TabIndex = 2;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInfo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInfo.Location = new System.Drawing.Point(0, 41);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(748, 72);
            this.lbInfo.TabIndex = 22;
            this.lbInfo.Text = "門診掛號資訊";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIsCancelled
            // 
            this.txtIsCancelled.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIsCancelled.Location = new System.Drawing.Point(345, 220);
            this.txtIsCancelled.Name = "txtIsCancelled";
            this.txtIsCancelled.ReadOnly = true;
            this.txtIsCancelled.Size = new System.Drawing.Size(151, 35);
            this.txtIsCancelled.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(285, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "退掛";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtState.Location = new System.Drawing.Point(345, 277);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(151, 35);
            this.txtState.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(285, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "狀態";
            // 
            // txtIsVIP
            // 
            this.txtIsVIP.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIsVIP.Location = new System.Drawing.Point(345, 334);
            this.txtIsVIP.Name = "txtIsVIP";
            this.txtIsVIP.ReadOnly = true;
            this.txtIsVIP.Size = new System.Drawing.Size(151, 35);
            this.txtIsVIP.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(285, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "VIP";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(633, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 37);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.AutoSize = true;
            this.btnYes.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnYes.Location = new System.Drawing.Point(495, 458);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(102, 37);
            this.btnYes.TabIndex = 29;
            this.btnYes.Text = "確認";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // cbxIsCancelled
            // 
            this.cbxIsCancelled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIsCancelled.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxIsCancelled.FormattingEnabled = true;
            this.cbxIsCancelled.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbxIsCancelled.Location = new System.Drawing.Point(563, 220);
            this.cbxIsCancelled.Name = "cbxIsCancelled";
            this.cbxIsCancelled.Size = new System.Drawing.Size(143, 35);
            this.cbxIsCancelled.TabIndex = 31;
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "未報到",
            "已報到",
            "過號 已報到",
            "覆診 已報到",
            "看診中",
            "離場 檢查中 ",
            "離場 叫號未到",
            "已結束"});
            this.cbxState.Location = new System.Drawing.Point(563, 277);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(143, 35);
            this.cbxState.TabIndex = 32;
            // 
            // cbxIsVIP
            // 
            this.cbxIsVIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIsVIP.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxIsVIP.FormattingEnabled = true;
            this.cbxIsVIP.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbxIsVIP.Location = new System.Drawing.Point(563, 334);
            this.cbxIsVIP.Name = "cbxIsVIP";
            this.cbxIsVIP.Size = new System.Drawing.Size(143, 35);
            this.cbxIsVIP.TabIndex = 33;
            this.cbxIsVIP.SelectedIndexChanged += new System.EventHandler(this.cbxIsVIP_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(502, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 34);
            this.label5.TabIndex = 34;
            this.label5.Text = ">>";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(341, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "*更改VIP欄位，將會刪除並重新預約此掛號";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(12, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 37);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(748, 41);
            this.label7.TabIndex = 38;
            this.label7.Text = "管理掛號紀錄";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // patientInfo1
            // 
            this.patientInfo1.BackColor = System.Drawing.Color.MistyRose;
            this.patientInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientInfo1.info = null;
            this.patientInfo1.Location = new System.Drawing.Point(60, 166);
            this.patientInfo1.Name = "patientInfo1";
            this.patientInfo1.Size = new System.Drawing.Size(210, 232);
            this.patientInfo1.TabIndex = 0;
            this.patientInfo1.txtBirth = "";
            this.patientInfo1.txtGender = "";
            this.patientInfo1.txtID = "";
            this.patientInfo1.txtName = "";
            // 
            // DialogModifyAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 507);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxIsVIP);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.cbxIsCancelled);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtIsVIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsCancelled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientClinicNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientInfo1);
            this.Name = "DialogModifyAppt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogModifyAppt";
            this.Load += new System.EventHandler(this.DialogModifyAppt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PatientInfo patientInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientClinicNumber;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox txtIsCancelled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsVIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.ComboBox cbxIsCancelled;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.ComboBox cbxIsVIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
    }
}