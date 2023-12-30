namespace prjRoom
{
    partial class frmScheduleEditor
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fbNurseId = new prjComponentDemo.FieldBox();
            this.fbDoctorId = new prjComponentDemo.FieldBox();
            this.fbEndDate = new prjComponentDemo.FieldBox();
            this.fbStartDate = new prjComponentDemo.FieldBox();
            this.fbMemberId = new prjComponentDemo.FieldBox();
            this.fbRoomId = new prjComponentDemo.FieldBox();
            this.fbId = new prjComponentDemo.FieldBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(207, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(345, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2178, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5000, 2);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "(EX:20240101)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(180, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "(EX:20240101)";
            // 
            // fbNurseId
            // 
            this.fbNurseId.fieldName = "護士編號";
            this.fbNurseId.fieldRequired = false;
            this.fbNurseId.fieldValue = "";
            this.fbNurseId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbNurseId.Location = new System.Drawing.Point(352, 15);
            this.fbNurseId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbNurseId.Name = "fbNurseId";
            this.fbNurseId.passwordMask = '\0';
            this.fbNurseId.Size = new System.Drawing.Size(318, 116);
            this.fbNurseId.TabIndex = 0;
            // 
            // fbDoctorId
            // 
            this.fbDoctorId.fieldName = "醫生編號";
            this.fbDoctorId.fieldRequired = false;
            this.fbDoctorId.fieldValue = "";
            this.fbDoctorId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbDoctorId.Location = new System.Drawing.Point(352, 143);
            this.fbDoctorId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbDoctorId.Name = "fbDoctorId";
            this.fbDoctorId.passwordMask = '\0';
            this.fbDoctorId.Size = new System.Drawing.Size(318, 116);
            this.fbDoctorId.TabIndex = 0;
            // 
            // fbEndDate
            // 
            this.fbEndDate.fieldName = "迄(格式為８ 位數字)";
            this.fbEndDate.fieldRequired = false;
            this.fbEndDate.fieldValue = "";
            this.fbEndDate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbEndDate.Location = new System.Drawing.Point(6, 478);
            this.fbEndDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbEndDate.Name = "fbEndDate";
            this.fbEndDate.passwordMask = '\0';
            this.fbEndDate.Size = new System.Drawing.Size(318, 116);
            this.fbEndDate.TabIndex = 0;
            // 
            // fbStartDate
            // 
            this.fbStartDate.fieldName = "起(格式為8位數字)";
            this.fbStartDate.fieldRequired = false;
            this.fbStartDate.fieldValue = "";
            this.fbStartDate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbStartDate.Location = new System.Drawing.Point(6, 372);
            this.fbStartDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbStartDate.Name = "fbStartDate";
            this.fbStartDate.passwordMask = '\0';
            this.fbStartDate.Size = new System.Drawing.Size(318, 116);
            this.fbStartDate.TabIndex = 0;
            // 
            // fbMemberId
            // 
            this.fbMemberId.fieldName = "患者編號";
            this.fbMemberId.fieldRequired = false;
            this.fbMemberId.fieldValue = "";
            this.fbMemberId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbMemberId.Location = new System.Drawing.Point(6, 244);
            this.fbMemberId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbMemberId.Name = "fbMemberId";
            this.fbMemberId.passwordMask = '\0';
            this.fbMemberId.Size = new System.Drawing.Size(318, 116);
            this.fbMemberId.TabIndex = 0;
            // 
            // fbRoomId
            // 
            this.fbRoomId.fieldName = "房間編號";
            this.fbRoomId.fieldRequired = false;
            this.fbRoomId.fieldValue = "";
            this.fbRoomId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRoomId.Location = new System.Drawing.Point(6, 143);
            this.fbRoomId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbRoomId.Name = "fbRoomId";
            this.fbRoomId.passwordMask = '\0';
            this.fbRoomId.Size = new System.Drawing.Size(318, 116);
            this.fbRoomId.TabIndex = 0;
            // 
            // fbId
            // 
            this.fbId.fieldName = "預約編號";
            this.fbId.fieldRequired = false;
            this.fbId.fieldValue = "";
            this.fbId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbId.Location = new System.Drawing.Point(6, 15);
            this.fbId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbId.Name = "fbId";
            this.fbId.passwordMask = '\0';
            this.fbId.Size = new System.Drawing.Size(318, 116);
            this.fbId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(114, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "*勿填";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(90, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(90, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(443, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(443, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "*";
            // 
            // frmScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 670);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbNurseId);
            this.Controls.Add(this.fbDoctorId);
            this.Controls.Add(this.fbEndDate);
            this.Controls.Add(this.fbStartDate);
            this.Controls.Add(this.fbMemberId);
            this.Controls.Add(this.fbRoomId);
            this.Controls.Add(this.fbId);
            this.Name = "frmScheduleEditor";
            this.Text = "frmScheduleEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prjComponentDemo.FieldBox fbId;
        private prjComponentDemo.FieldBox fbRoomId;
        private prjComponentDemo.FieldBox fbMemberId;
        private prjComponentDemo.FieldBox fbStartDate;
        private prjComponentDemo.FieldBox fbEndDate;
        private prjComponentDemo.FieldBox fbDoctorId;
        private prjComponentDemo.FieldBox fbNurseId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}