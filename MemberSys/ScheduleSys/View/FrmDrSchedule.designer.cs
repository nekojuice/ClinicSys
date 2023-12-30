namespace ClinicSysMdiParent.View
{
    partial class FrmDrSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.combClinicroom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combShifts = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combodepartment = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSecheduling = new System.Windows.Forms.Button();
            this.DTPickerSecheduling = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1584, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "醫師班表";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 678);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(1197, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "診間";
            // 
            // combClinicroom
            // 
            this.combClinicroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combClinicroom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combClinicroom.ForeColor = System.Drawing.Color.Brown;
            this.combClinicroom.FormattingEnabled = true;
            this.combClinicroom.Location = new System.Drawing.Point(1260, 304);
            this.combClinicroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combClinicroom.Name = "combClinicroom";
            this.combClinicroom.Size = new System.Drawing.Size(140, 33);
            this.combClinicroom.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(1197, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "時段";
            // 
            // combShifts
            // 
            this.combShifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combShifts.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combShifts.ForeColor = System.Drawing.Color.Brown;
            this.combShifts.FormattingEnabled = true;
            this.combShifts.Location = new System.Drawing.Point(1260, 364);
            this.combShifts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combShifts.Name = "combShifts";
            this.combShifts.Size = new System.Drawing.Size(140, 33);
            this.combShifts.TabIndex = 18;
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerSearch.Location = new System.Drawing.Point(99, 70);
            this.dateTimePickerSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(211, 34);
            this.dateTimePickerSearch.TabIndex = 21;
            this.dateTimePickerSearch.ValueChanged += new System.EventHandler(this.dateTimePickerSearch_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(37, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(1197, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "醫師";
            // 
            // combName
            // 
            this.combName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combName.ForeColor = System.Drawing.Color.Brown;
            this.combName.FormattingEnabled = true;
            this.combName.Location = new System.Drawing.Point(1260, 184);
            this.combName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combName.Name = "combName";
            this.combName.Size = new System.Drawing.Size(140, 33);
            this.combName.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(1197, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "科別";
            // 
            // combodepartment
            // 
            this.combodepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodepartment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combodepartment.ForeColor = System.Drawing.Color.Brown;
            this.combodepartment.FormattingEnabled = true;
            this.combodepartment.Items.AddRange(new object[] {
            "",
            "婦產科",
            "小兒科"});
            this.combodepartment.Location = new System.Drawing.Point(1260, 244);
            this.combodepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combodepartment.Name = "combodepartment";
            this.combodepartment.Size = new System.Drawing.Size(140, 33);
            this.combodepartment.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(1409, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(111, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "查詢";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(40, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 682);
            this.panel1.TabIndex = 33;
            // 
            // btnSecheduling
            // 
            this.btnSecheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecheduling.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSecheduling.ForeColor = System.Drawing.Color.Brown;
            this.btnSecheduling.Location = new System.Drawing.Point(1409, 121);
            this.btnSecheduling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSecheduling.Name = "btnSecheduling";
            this.btnSecheduling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSecheduling.Size = new System.Drawing.Size(111, 42);
            this.btnSecheduling.TabIndex = 34;
            this.btnSecheduling.Text = "每月排班";
            this.btnSecheduling.UseVisualStyleBackColor = true;
            this.btnSecheduling.Click += new System.EventHandler(this.btnSecheduling_Click);
            // 
            // DTPickerSecheduling
            // 
            this.DTPickerSecheduling.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTPickerSecheduling.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTPickerSecheduling.Location = new System.Drawing.Point(1260, 122);
            this.DTPickerSecheduling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPickerSecheduling.Name = "DTPickerSecheduling";
            this.DTPickerSecheduling.Size = new System.Drawing.Size(140, 34);
            this.DTPickerSecheduling.TabIndex = 35;
            this.DTPickerSecheduling.ValueChanged += new System.EventHandler(this.DTPickerSecheduling_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(1197, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "月份";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(1291, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 39;
            this.button1.Text = "編輯";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn編輯_Click);
            // 
            // FrmDrSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1584, 868);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPickerSecheduling);
            this.Controls.Add(this.btnSecheduling);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combodepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combShifts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combClinicroom);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDrSchedule";
            this.Text = "FrmDrSchedule";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combClinicroom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combShifts;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combodepartment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSecheduling;
        private System.Windows.Forms.DateTimePicker DTPickerSecheduling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}