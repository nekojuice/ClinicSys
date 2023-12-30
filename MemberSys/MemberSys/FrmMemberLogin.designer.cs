namespace MemberSys
{
    partial class FrmMemberLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fbMemPassword = new MemberSys.FieldBox();
            this.fbMemEmail = new MemberSys.FieldBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 488);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 2);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 108);
            this.label1.TabIndex = 11;
            this.label1.Text = "會員登入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(520, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMemLogin_Click);
            // 
            // fbMemPassword
            // 
            this.fbMemPassword.fieldName = "請輸入密碼";
            this.fbMemPassword.fieldRequired = false;
            this.fbMemPassword.fieldValue = "pass1234";
            this.fbMemPassword.Location = new System.Drawing.Point(125, 287);
            this.fbMemPassword.Margin = new System.Windows.Forms.Padding(4);
            this.fbMemPassword.Name = "fbMemPassword";
            this.fbMemPassword.passwordMask = '*';
            this.fbMemPassword.Size = new System.Drawing.Size(499, 88);
            this.fbMemPassword.TabIndex = 13;
            // 
            // fbMemEmail
            // 
            this.fbMemEmail.fieldName = "請輸入帳號";
            this.fbMemEmail.fieldRequired = false;
            this.fbMemEmail.fieldValue = "jiaxin.li@example.com";
            this.fbMemEmail.Location = new System.Drawing.Point(125, 172);
            this.fbMemEmail.Margin = new System.Windows.Forms.Padding(4);
            this.fbMemEmail.Name = "fbMemEmail";
            this.fbMemEmail.passwordMask = '\0';
            this.fbMemEmail.Size = new System.Drawing.Size(499, 88);
            this.fbMemEmail.TabIndex = 12;
            // 
            // FrmMemberLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 535);
            this.Controls.Add(this.fbMemPassword);
            this.Controls.Add(this.fbMemEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmMemberLogin";
            this.Text = "FrmMemberLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMemberLogin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private FieldBox fbMemPassword;
        private FieldBox fbMemEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}