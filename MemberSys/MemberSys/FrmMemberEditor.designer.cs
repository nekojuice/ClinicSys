namespace MemberSys
{
    partial class FrmMemberEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtPickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fbPassword = new MemberSys.FieldBoxss();
            this.fbEmail = new MemberSys.FieldBoxss();
            this.CboGender = new MemberSys.UserCombo();
            this.fbMember_Num = new MemberSys.FieldBoxss();
            this.fbICEPhone = new MemberSys.FieldBoxss();
            this.fbICE = new MemberSys.FieldBoxss();
            this.fbNID = new MemberSys.FieldBoxss();
            this.fbPhone = new MemberSys.FieldBoxss();
            this.fbCAddress = new MemberSys.FieldBoxss();
            this.fbAddress = new MemberSys.FieldBoxss();
            this.fbBlood = new MemberSys.FieldBoxss();
            this.fbName = new MemberSys.FieldBoxss();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(753, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "取消變更";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(599, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "保存變更";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1002, 47);
            this.label1.TabIndex = 26;
            this.label1.Text = "會員資料編輯";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 65);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 454);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.fbPassword);
            this.panel3.Controls.Add(this.fbEmail);
            this.panel3.Controls.Add(this.CboGender);
            this.panel3.Controls.Add(this.fbMember_Num);
            this.panel3.Controls.Add(this.fbICEPhone);
            this.panel3.Controls.Add(this.fbICE);
            this.panel3.Controls.Add(this.fbNID);
            this.panel3.Controls.Add(this.fbPhone);
            this.panel3.Controls.Add(this.fbCAddress);
            this.panel3.Controls.Add(this.fbAddress);
            this.panel3.Controls.Add(this.fbBlood);
            this.panel3.Controls.Add(this.fbName);
            this.panel3.Location = new System.Drawing.Point(9, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 438);
            this.panel3.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(434, 235);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 55);
            this.panel4.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dtPickerBirth);
            this.panel5.Location = new System.Drawing.Point(140, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 38);
            this.panel5.TabIndex = 66;
            // 
            // dtPickerBirth
            // 
            this.dtPickerBirth.CustomFormat = "yyyy-MM-dd";
            this.dtPickerBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPickerBirth.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtPickerBirth.Location = new System.Drawing.Point(0, 0);
            this.dtPickerBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerBirth.Name = "dtPickerBirth";
            this.dtPickerBirth.Size = new System.Drawing.Size(215, 32);
            this.dtPickerBirth.TabIndex = 65;
            this.dtPickerBirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "生日";
            // 
            // fbPassword
            // 
            this.fbPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbPassword.fieldName = "會員密碼";
            this.fbPassword.fieldValue = "0369888";
            this.fbPassword.Location = new System.Drawing.Point(434, 45);
            this.fbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.fbPassword.Name = "fbPassword";
            this.fbPassword.Size = new System.Drawing.Size(368, 55);
            this.fbPassword.TabIndex = 64;
            // 
            // fbEmail
            // 
            this.fbEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbEmail.fieldName = "信箱";
            this.fbEmail.fieldValue = "0369888";
            this.fbEmail.Location = new System.Drawing.Point(434, 108);
            this.fbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.Size = new System.Drawing.Size(368, 55);
            this.fbEmail.TabIndex = 63;
            // 
            // CboGender
            // 
            this.CboGender.BackColor = System.Drawing.SystemColors.Control;
            this.CboGender.fieldName = "生理性別";
            this.CboGender.fieldValue = "";
            this.CboGender.Location = new System.Drawing.Point(28, 127);
            this.CboGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboGender.Name = "CboGender";
            this.CboGender.Size = new System.Drawing.Size(373, 46);
            this.CboGender.TabIndex = 62;
            // 
            // fbMember_Num
            // 
            this.fbMember_Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbMember_Num.fieldName = "會員編號";
            this.fbMember_Num.fieldValue = "11011";
            this.fbMember_Num.Location = new System.Drawing.Point(28, 9);
            this.fbMember_Num.Margin = new System.Windows.Forms.Padding(4);
            this.fbMember_Num.Name = "fbMember_Num";
            this.fbMember_Num.Size = new System.Drawing.Size(373, 50);
            this.fbMember_Num.TabIndex = 61;
            // 
            // fbICEPhone
            // 
            this.fbICEPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbICEPhone.fieldName = "緊急聯絡人電話";
            this.fbICEPhone.fieldValue = "036888";
            this.fbICEPhone.Location = new System.Drawing.Point(434, 368);
            this.fbICEPhone.Margin = new System.Windows.Forms.Padding(4);
            this.fbICEPhone.Name = "fbICEPhone";
            this.fbICEPhone.Size = new System.Drawing.Size(368, 50);
            this.fbICEPhone.TabIndex = 60;
            // 
            // fbICE
            // 
            this.fbICE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbICE.fieldName = "緊急聯絡人姓名";
            this.fbICE.fieldValue = "我";
            this.fbICE.Location = new System.Drawing.Point(434, 305);
            this.fbICE.Margin = new System.Windows.Forms.Padding(4);
            this.fbICE.Name = "fbICE";
            this.fbICE.Size = new System.Drawing.Size(368, 55);
            this.fbICE.TabIndex = 59;
            // 
            // fbNID
            // 
            this.fbNID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbNID.fieldName = "身分證字號";
            this.fbNID.fieldValue = "a1255555";
            this.fbNID.Location = new System.Drawing.Point(28, 242);
            this.fbNID.Margin = new System.Windows.Forms.Padding(4);
            this.fbNID.Name = "fbNID";
            this.fbNID.Size = new System.Drawing.Size(373, 55);
            this.fbNID.TabIndex = 58;
            // 
            // fbPhone
            // 
            this.fbPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbPhone.fieldName = "電話";
            this.fbPhone.fieldValue = "0369888";
            this.fbPhone.Location = new System.Drawing.Point(434, 171);
            this.fbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.fbPhone.Name = "fbPhone";
            this.fbPhone.Size = new System.Drawing.Size(368, 55);
            this.fbPhone.TabIndex = 56;
            // 
            // fbCAddress
            // 
            this.fbCAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbCAddress.fieldName = "聯絡地址";
            this.fbCAddress.fieldValue = "台北";
            this.fbCAddress.Location = new System.Drawing.Point(28, 366);
            this.fbCAddress.Margin = new System.Windows.Forms.Padding(4);
            this.fbCAddress.Name = "fbCAddress";
            this.fbCAddress.Size = new System.Drawing.Size(373, 55);
            this.fbCAddress.TabIndex = 55;
            // 
            // fbAddress
            // 
            this.fbAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbAddress.fieldName = "戶籍地址";
            this.fbAddress.fieldValue = "台北";
            this.fbAddress.Location = new System.Drawing.Point(28, 306);
            this.fbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.fbAddress.Name = "fbAddress";
            this.fbAddress.Size = new System.Drawing.Size(373, 55);
            this.fbAddress.TabIndex = 54;
            // 
            // fbBlood
            // 
            this.fbBlood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbBlood.fieldName = "血型";
            this.fbBlood.fieldValue = "b";
            this.fbBlood.Location = new System.Drawing.Point(28, 179);
            this.fbBlood.Margin = new System.Windows.Forms.Padding(4);
            this.fbBlood.Name = "fbBlood";
            this.fbBlood.Size = new System.Drawing.Size(373, 55);
            this.fbBlood.TabIndex = 53;
            // 
            // fbName
            // 
            this.fbName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbName.fieldName = "姓名";
            this.fbName.fieldValue = "蔡文綺";
            this.fbName.Location = new System.Drawing.Point(28, 66);
            this.fbName.Margin = new System.Windows.Forms.Padding(4);
            this.fbName.Name = "fbName";
            this.fbName.Size = new System.Drawing.Size(373, 55);
            this.fbName.TabIndex = 52;
            // 
            // FrmMemberEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMemberEditor";
            this.Text = "FrmMemberEditor";
            this.Load += new System.EventHandler(this.FrmMemberEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UserCombo CboGender;
        private FieldBoxss fbMember_Num;
        private FieldBoxss fbICEPhone;
        private FieldBoxss fbICE;
        private FieldBoxss fbNID;
        private FieldBoxss fbPhone;
        private FieldBoxss fbCAddress;
        private FieldBoxss fbAddress;
        private FieldBoxss fbBlood;
        private FieldBoxss fbName;
        private FieldBoxss fbPassword;
        private FieldBoxss fbEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerBirth;
    }
}