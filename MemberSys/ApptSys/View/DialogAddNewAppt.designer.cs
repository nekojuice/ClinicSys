namespace MSIT155_E_MID.ApptSystem.View
{
    partial class DialogAddNewAppt
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
            this.cbIsNormal = new System.Windows.Forms.CheckBox();
            this.cbIsVip = new System.Windows.Forms.CheckBox();
            this.patientInfo1 = new MSIT155_E_MID.PatientInfo();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTimeShift = new System.Windows.Forms.Label();
            this.lbDept = new System.Windows.Forms.Label();
            this.lbDocName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbLimitPatient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbIsNormal
            // 
            this.cbIsNormal.AutoSize = true;
            this.cbIsNormal.Checked = true;
            this.cbIsNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsNormal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbIsNormal.Location = new System.Drawing.Point(38, 268);
            this.cbIsNormal.Name = "cbIsNormal";
            this.cbIsNormal.Size = new System.Drawing.Size(115, 31);
            this.cbIsNormal.TabIndex = 0;
            this.cbIsNormal.Text = "普通掛號";
            this.cbIsNormal.UseVisualStyleBackColor = true;
            this.cbIsNormal.Click += new System.EventHandler(this.cbIsNormal_CheckedChanged);
            // 
            // cbIsVip
            // 
            this.cbIsVip.AutoSize = true;
            this.cbIsVip.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbIsVip.Location = new System.Drawing.Point(38, 305);
            this.cbIsVip.Name = "cbIsVip";
            this.cbIsVip.Size = new System.Drawing.Size(106, 31);
            this.cbIsVip.TabIndex = 1;
            this.cbIsVip.Text = "VIP插號";
            this.cbIsVip.UseVisualStyleBackColor = true;
            this.cbIsVip.Click += new System.EventHandler(this.cbIsVip_CheckedChanged);
            // 
            // patientInfo1
            // 
            this.patientInfo1.BackColor = System.Drawing.Color.MistyRose;
            this.patientInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientInfo1.info = null;
            this.patientInfo1.Location = new System.Drawing.Point(12, 12);
            this.patientInfo1.Name = "patientInfo1";
            this.patientInfo1.Size = new System.Drawing.Size(210, 232);
            this.patientInfo1.TabIndex = 2;
            this.patientInfo1.txtBirth = "";
            this.patientInfo1.txtGender = "";
            this.patientInfo1.txtID = "";
            this.patientInfo1.txtName = "";
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDate.Location = new System.Drawing.Point(306, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(371, 50);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "日期: ";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTimeShift
            // 
            this.lbTimeShift.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTimeShift.Location = new System.Drawing.Point(306, 62);
            this.lbTimeShift.Name = "lbTimeShift";
            this.lbTimeShift.Size = new System.Drawing.Size(371, 50);
            this.lbTimeShift.TabIndex = 4;
            this.lbTimeShift.Text = "時段: ";
            this.lbTimeShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDept
            // 
            this.lbDept.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDept.Location = new System.Drawing.Point(306, 112);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(371, 50);
            this.lbDept.TabIndex = 5;
            this.lbDept.Text = "科別: ";
            this.lbDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDocName
            // 
            this.lbDocName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDocName.Location = new System.Drawing.Point(306, 162);
            this.lbDocName.Name = "lbDocName";
            this.lbDocName.Size = new System.Drawing.Size(371, 50);
            this.lbDocName.TabIndex = 6;
            this.lbDocName.Text = "醫師: ";
            this.lbDocName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(243, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = ">>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.AutoSize = true;
            this.btnYes.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnYes.Location = new System.Drawing.Point(437, 299);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(102, 37);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "確認";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(575, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbLimitPatient
            // 
            this.lbLimitPatient.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLimitPatient.Location = new System.Drawing.Point(306, 212);
            this.lbLimitPatient.Name = "lbLimitPatient";
            this.lbLimitPatient.Size = new System.Drawing.Size(287, 50);
            this.lbLimitPatient.TabIndex = 9;
            this.lbLimitPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(308, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "*如果超出原訂負荷人數，請先和醫師確認";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DialogAddNewAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLimitPatient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbDocName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.lbTimeShift);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.patientInfo1);
            this.Controls.Add(this.cbIsVip);
            this.Controls.Add(this.cbIsNormal);
            this.Name = "DialogAddNewAppt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogAddNewAppt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsNormal;
        private System.Windows.Forms.CheckBox cbIsVip;
        private PatientInfo patientInfo1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTimeShift;
        private System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.Label lbDocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbLimitPatient;
        private System.Windows.Forms.Label label2;
    }
}