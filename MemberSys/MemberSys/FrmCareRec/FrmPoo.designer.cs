namespace MemberSys
{
    partial class FrmPoo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPoo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPoo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPooColor = new System.Windows.Forms.ComboBox();
            this.cboPooType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPooAmount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 33);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lblPoo
            // 
            this.lblPoo.CausesValidation = false;
            this.lblPoo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPoo.Location = new System.Drawing.Point(77, 27);
            this.lblPoo.Name = "lblPoo";
            this.lblPoo.Size = new System.Drawing.Size(457, 29);
            this.lblPoo.TabIndex = 21;
            this.lblPoo.Text = "顯示選到的小孩姓名以及生日";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(415, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "儲存紀錄";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPoo
            // 
            this.labelPoo.AutoSize = true;
            this.labelPoo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPoo.Location = new System.Drawing.Point(49, 337);
            this.labelPoo.Name = "labelPoo";
            this.labelPoo.Size = new System.Drawing.Size(143, 24);
            this.labelPoo.TabIndex = 27;
            this.labelPoo.Text = "顯示剛剛的紀錄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(256, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "顏色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(92, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "狀態";
            // 
            // cboPooColor
            // 
            this.cboPooColor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboPooColor.FormattingEnabled = true;
            this.cboPooColor.Location = new System.Drawing.Point(220, 216);
            this.cboPooColor.Name = "cboPooColor";
            this.cboPooColor.Size = new System.Drawing.Size(121, 32);
            this.cboPooColor.TabIndex = 30;
            this.cboPooColor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboPooType
            // 
            this.cboPooType.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboPooType.FormattingEnabled = true;
            this.cboPooType.Location = new System.Drawing.Point(53, 216);
            this.cboPooType.Name = "cboPooType";
            this.cboPooType.Size = new System.Drawing.Size(121, 32);
            this.cboPooType.TabIndex = 29;
            this.cboPooType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(433, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "份量";
            // 
            // cboPooAmount
            // 
            this.cboPooAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboPooAmount.FormattingEnabled = true;
            this.cboPooAmount.Location = new System.Drawing.Point(400, 216);
            this.cboPooAmount.Name = "cboPooAmount";
            this.cboPooAmount.Size = new System.Drawing.Size(121, 32);
            this.cboPooAmount.TabIndex = 33;
            this.cboPooAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // FrmPoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 426);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPooAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPooColor);
            this.Controls.Add(this.cboPooType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPoo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPoo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPoo";
            this.Text = "FrmPoo";
            this.Load += new System.EventHandler(this.FrmPoo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPoo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPoo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPooColor;
        private System.Windows.Forms.ComboBox cboPooType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPooAmount;
    }
}