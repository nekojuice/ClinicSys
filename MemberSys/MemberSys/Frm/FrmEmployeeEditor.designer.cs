using MemberSys;

namespace MemberSys
{
    partial class FrmEmployeeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeEditor));
            this.btnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEmp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboEmpType = new System.Windows.Forms.ComboBox();
            this.lblEmptype = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtPickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxEmp = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fbEmpPassword = new MemberSys.FieldBoxss();
            this.fbNID = new MemberSys.FieldBoxss();
            this.fbBirth = new MemberSys.FieldBoxss();
            this.fbEmpNum = new MemberSys.FieldBoxss();
            this.cboGender = new MemberSys.UserCombo();
            this.fbPhone = new MemberSys.FieldBoxss();
            this.fbCAddress = new MemberSys.FieldBoxss();
            this.fbAddress = new MemberSys.FieldBoxss();
            this.fbBlood = new MemberSys.FieldBoxss();
            this.fbName = new MemberSys.FieldBoxss();
            this.panelEmp.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOk.Location = new System.Drawing.Point(657, 417);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 34);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(814, 417);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEmpCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "新增員工資料";
            // 
            // panelEmp
            // 
            this.panelEmp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEmp.Controls.Add(this.label2);
            this.panelEmp.Controls.Add(this.cboDepartment);
            this.panelEmp.Controls.Add(this.lblDepartment);
            this.panelEmp.Controls.Add(this.cboEmpType);
            this.panelEmp.Controls.Add(this.lblEmptype);
            this.panelEmp.Location = new System.Drawing.Point(424, 302);
            this.panelEmp.Margin = new System.Windows.Forms.Padding(2);
            this.panelEmp.Name = "panelEmp";
            this.panelEmp.Size = new System.Drawing.Size(372, 52);
            this.panelEmp.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "員工細項";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(288, 4);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(71, 28);
            this.cboDepartment.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDepartment.Location = new System.Drawing.Point(244, 4);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 20);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "科別";
            // 
            // cboEmpType
            // 
            this.cboEmpType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboEmpType.FormattingEnabled = true;
            this.cboEmpType.Location = new System.Drawing.Point(152, 3);
            this.cboEmpType.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpType.Name = "cboEmpType";
            this.cboEmpType.Size = new System.Drawing.Size(71, 28);
            this.cboEmpType.TabIndex = 1;
            this.cboEmpType.SelectedIndexChanged += new System.EventHandler(this.cboEmpType_SelectedIndexChanged);
            // 
            // lblEmptype
            // 
            this.lblEmptype.AutoSize = true;
            this.lblEmptype.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmptype.Location = new System.Drawing.Point(110, 4);
            this.lblEmptype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmptype.Name = "lblEmptype";
            this.lblEmptype.Size = new System.Drawing.Size(41, 20);
            this.lblEmptype.TabIndex = 0;
            this.lblEmptype.Text = "類型";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(424, 124);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 55);
            this.panel4.TabIndex = 67;
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
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "生日";
            // 
            // pictureBoxEmp
            // 
            this.pictureBoxEmp.BackColor = System.Drawing.Color.White;
            this.pictureBoxEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmp.BackgroundImage")));
            this.pictureBoxEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEmp.Location = new System.Drawing.Point(814, 62);
            this.pictureBoxEmp.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEmp.Name = "pictureBoxEmp";
            this.pictureBoxEmp.Size = new System.Drawing.Size(118, 160);
            this.pictureBoxEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmp.TabIndex = 68;
            this.pictureBoxEmp.TabStop = false;
            this.pictureBoxEmp.Click += new System.EventHandler(this.pictureBoxEmp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fbEmpPassword
            // 
            this.fbEmpPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbEmpPassword.fieldName = "員工密碼";
            this.fbEmpPassword.fieldValue = "123";
            this.fbEmpPassword.Location = new System.Drawing.Point(424, 244);
            this.fbEmpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.fbEmpPassword.Name = "fbEmpPassword";
            this.fbEmpPassword.Size = new System.Drawing.Size(372, 52);
            this.fbEmpPassword.TabIndex = 18;
            // 
            // fbNID
            // 
            this.fbNID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbNID.fieldName = "身分證字號";
            this.fbNID.fieldValue = "123";
            this.fbNID.Location = new System.Drawing.Point(424, 184);
            this.fbNID.Margin = new System.Windows.Forms.Padding(4);
            this.fbNID.Name = "fbNID";
            this.fbNID.Size = new System.Drawing.Size(372, 52);
            this.fbNID.TabIndex = 17;
            // 
            // fbBirth
            // 
            this.fbBirth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbBirth.fieldName = "生日";
            this.fbBirth.fieldValue = "2000/10/22";
            this.fbBirth.Location = new System.Drawing.Point(424, 124);
            this.fbBirth.Margin = new System.Windows.Forms.Padding(4);
            this.fbBirth.Name = "fbBirth";
            this.fbBirth.Size = new System.Drawing.Size(372, 52);
            this.fbBirth.TabIndex = 16;
            // 
            // fbEmpNum
            // 
            this.fbEmpNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbEmpNum.fieldName = "員工編號";
            this.fbEmpNum.fieldValue = "1001";
            this.fbEmpNum.Location = new System.Drawing.Point(424, 62);
            this.fbEmpNum.Margin = new System.Windows.Forms.Padding(4);
            this.fbEmpNum.Name = "fbEmpNum";
            this.fbEmpNum.Size = new System.Drawing.Size(372, 52);
            this.fbEmpNum.TabIndex = 15;
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.SystemColors.Control;
            this.cboGender.fieldName = "生理性別";
            this.cboGender.fieldValue = "";
            this.cboGender.Location = new System.Drawing.Point(10, 124);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(372, 48);
            this.cboGender.TabIndex = 14;
            // 
            // fbPhone
            // 
            this.fbPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbPhone.fieldName = "電話";
            this.fbPhone.fieldValue = "09635555";
            this.fbPhone.Location = new System.Drawing.Point(10, 365);
            this.fbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.fbPhone.Name = "fbPhone";
            this.fbPhone.Size = new System.Drawing.Size(372, 51);
            this.fbPhone.TabIndex = 5;
            // 
            // fbCAddress
            // 
            this.fbCAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbCAddress.fieldName = "聯絡地址";
            this.fbCAddress.fieldValue = "台北";
            this.fbCAddress.Location = new System.Drawing.Point(10, 301);
            this.fbCAddress.Margin = new System.Windows.Forms.Padding(4);
            this.fbCAddress.Name = "fbCAddress";
            this.fbCAddress.Size = new System.Drawing.Size(372, 52);
            this.fbCAddress.TabIndex = 4;
            // 
            // fbAddress
            // 
            this.fbAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbAddress.fieldName = "戶籍地址";
            this.fbAddress.fieldValue = "台北";
            this.fbAddress.Location = new System.Drawing.Point(10, 241);
            this.fbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.fbAddress.Name = "fbAddress";
            this.fbAddress.Size = new System.Drawing.Size(372, 52);
            this.fbAddress.TabIndex = 3;
            // 
            // fbBlood
            // 
            this.fbBlood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbBlood.fieldName = "血型";
            this.fbBlood.fieldValue = "B型";
            this.fbBlood.Location = new System.Drawing.Point(10, 181);
            this.fbBlood.Margin = new System.Windows.Forms.Padding(4);
            this.fbBlood.Name = "fbBlood";
            this.fbBlood.Size = new System.Drawing.Size(372, 52);
            this.fbBlood.TabIndex = 2;
            // 
            // fbName
            // 
            this.fbName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fbName.fieldName = "姓名";
            this.fbName.fieldValue = "蔡文綺";
            this.fbName.Location = new System.Drawing.Point(10, 62);
            this.fbName.Margin = new System.Windows.Forms.Padding(4);
            this.fbName.Name = "fbName";
            this.fbName.Size = new System.Drawing.Size(372, 52);
            this.fbName.TabIndex = 0;
            // 
            // FrmEmployeeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 467);
            this.Controls.Add(this.pictureBoxEmp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelEmp);
            this.Controls.Add(this.fbEmpPassword);
            this.Controls.Add(this.fbNID);
            this.Controls.Add(this.fbBirth);
            this.Controls.Add(this.fbEmpNum);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.fbPhone);
            this.Controls.Add(this.fbCAddress);
            this.Controls.Add(this.fbAddress);
            this.Controls.Add(this.fbBlood);
            this.Controls.Add(this.fbName);
            this.Name = "FrmEmployeeEditor";
            this.Text = "FrmEmployeeEditor";
            this.Load += new System.EventHandler(this.FrmEmployeeEditor_Load);
            this.panelEmp.ResumeLayout(false);
            this.panelEmp.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FieldBoxss fbName;
        private FieldBoxss fbBlood;
        private FieldBoxss fbAddress;
        private FieldBoxss fbCAddress;
        private FieldBoxss fbPhone;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private UserCombo cboGender;
        private FieldBoxss fbEmpNum;
        private FieldBoxss fbBirth;
        private FieldBoxss fbNID;
        private FieldBoxss fbEmpPassword;
        private System.Windows.Forms.Panel panelEmp;
        private System.Windows.Forms.Label lblEmptype;
        private System.Windows.Forms.ComboBox cboEmpType;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtPickerBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxEmp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}