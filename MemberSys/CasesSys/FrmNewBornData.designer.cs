namespace ClinicSysMdiParent
{
    partial class FrmNewBornData
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
            this.ok = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.RDatelabel = new System.Windows.Forms.Label();
            this.memIDBox = new ClinicSysMdiParent.TLBox();
            this.textBoxBName = new System.Windows.Forms.TextBox();
            this.Pulselabel = new System.Windows.Forms.Label();
            this.BT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.ICENAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ICENUMBER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ok.Location = new System.Drawing.Point(12, 660);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(121, 32);
            this.ok.TabIndex = 41;
            this.ok.Text = "新增";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(686, 660);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 32);
            this.exit.TabIndex = 42;
            this.exit.Text = "關閉";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Birthday
            // 
            this.Birthday.CustomFormat = "yyyy-MM-dd";
            this.Birthday.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(320, 158);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(249, 35);
            this.Birthday.TabIndex = 63;
            // 
            // RDatelabel
            // 
            this.RDatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RDatelabel.AutoSize = true;
            this.RDatelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RDatelabel.Location = new System.Drawing.Point(255, 162);
            this.RDatelabel.Name = "RDatelabel";
            this.RDatelabel.Size = new System.Drawing.Size(59, 26);
            this.RDatelabel.TabIndex = 62;
            this.RDatelabel.Text = "生日:";
            // 
            // memIDBox
            // 
            this.memIDBox.AutoSize = true;
            this.memIDBox.BackColor = System.Drawing.Color.LightCoral;
            this.memIDBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.memIDBox.Location = new System.Drawing.Point(0, 0);
            this.memIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.memIDBox.Name = "memIDBox";
            this.memIDBox.Ntext = "";
            this.memIDBox.Size = new System.Drawing.Size(825, 30);
            this.memIDBox.TabIndex = 64;
            this.memIDBox.Ttext = "會員號:";
            // 
            // textBoxBName
            // 
            this.textBoxBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBName.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxBName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxBName.Location = new System.Drawing.Point(320, 68);
            this.textBoxBName.Name = "textBoxBName";
            this.textBoxBName.Size = new System.Drawing.Size(249, 35);
            this.textBoxBName.TabIndex = 66;
            // 
            // Pulselabel
            // 
            this.Pulselabel.AutoSize = true;
            this.Pulselabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pulselabel.Location = new System.Drawing.Point(255, 72);
            this.Pulselabel.Name = "Pulselabel";
            this.Pulselabel.Size = new System.Drawing.Size(59, 26);
            this.Pulselabel.TabIndex = 65;
            this.Pulselabel.Text = "姓名:";
            // 
            // BT
            // 
            this.BT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT.BackColor = System.Drawing.Color.LightCoral;
            this.BT.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BT.Location = new System.Drawing.Point(320, 337);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(249, 35);
            this.BT.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(255, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 67;
            this.label1.Text = "血型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(255, 252);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 69;
            this.label2.Text = "性別:";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Gender.Location = new System.Drawing.Point(320, 248);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(249, 34);
            this.Gender.TabIndex = 70;
            // 
            // ICENAME
            // 
            this.ICENAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICENAME.BackColor = System.Drawing.Color.LightCoral;
            this.ICENAME.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ICENAME.Location = new System.Drawing.Point(320, 427);
            this.ICENAME.Name = "ICENAME";
            this.ICENAME.Size = new System.Drawing.Size(249, 35);
            this.ICENAME.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(150, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 71;
            this.label3.Text = "緊急聯絡人姓名:";
            // 
            // ICENUMBER
            // 
            this.ICENUMBER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICENUMBER.BackColor = System.Drawing.Color.LightCoral;
            this.ICENUMBER.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ICENUMBER.Location = new System.Drawing.Point(320, 517);
            this.ICENUMBER.Name = "ICENUMBER";
            this.ICENUMBER.Size = new System.Drawing.Size(249, 35);
            this.ICENUMBER.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(150, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 73;
            this.label4.Text = "緊急聯絡人電話:";
            // 
            // FrmNewBornData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(825, 704);
            this.Controls.Add(this.ICENUMBER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ICENAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBName);
            this.Controls.Add(this.Pulselabel);
            this.Controls.Add(this.memIDBox);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.RDatelabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ok);
            this.Name = "FrmNewBornData";
            this.Text = "FrmNewBornData";
            this.Load += new System.EventHandler(this.FrmNewBornData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label RDatelabel;
        private TLBox memIDBox;
        private System.Windows.Forms.TextBox textBoxBName;
        private System.Windows.Forms.Label Pulselabel;
        private System.Windows.Forms.TextBox BT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox ICENAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ICENUMBER;
        private System.Windows.Forms.Label label4;
    }
}