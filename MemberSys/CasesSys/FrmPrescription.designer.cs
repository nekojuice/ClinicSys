namespace ClinicSysMdiParent
{
    partial class FrmPrescription
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
            this.MedicineBox = new System.Windows.Forms.ComboBox();
            this.BTlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tPreCaseIDBox = new ClinicSysMdiParent.TLBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.RDatelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddMed = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDispensing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineBox
            // 
            this.MedicineBox.BackColor = System.Drawing.Color.LightCoral;
            this.MedicineBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MedicineBox.FormattingEnabled = true;
            this.MedicineBox.Location = new System.Drawing.Point(17, 157);
            this.MedicineBox.Name = "MedicineBox";
            this.MedicineBox.Size = new System.Drawing.Size(220, 32);
            this.MedicineBox.TabIndex = 35;
            this.MedicineBox.TextChanged += new System.EventHandler(this.MedicineBox_TextChanged);
            // 
            // BTlabel
            // 
            this.BTlabel.AutoSize = true;
            this.BTlabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTlabel.Location = new System.Drawing.Point(12, 128);
            this.BTlabel.Name = "BTlabel";
            this.BTlabel.Size = new System.Drawing.Size(59, 26);
            this.BTlabel.TabIndex = 48;
            this.BTlabel.Text = "選藥:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(282, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "天數(療程):";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDays.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxDays.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDays.Location = new System.Drawing.Point(287, 156);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(220, 35);
            this.textBoxDays.TabIndex = 53;
            this.textBoxDays.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            // 
            // textBoxTA
            // 
            this.textBoxTA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTA.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxTA.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTA.Location = new System.Drawing.Point(556, 156);
            this.textBoxTA.Name = "textBoxTA";
            this.textBoxTA.Size = new System.Drawing.Size(220, 35);
            this.textBoxTA.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(552, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "總量:";
            // 
            // tPreCaseIDBox
            // 
            this.tPreCaseIDBox.AutoSize = true;
            this.tPreCaseIDBox.BackColor = System.Drawing.Color.LightCoral;
            this.tPreCaseIDBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tPreCaseIDBox.Location = new System.Drawing.Point(0, 0);
            this.tPreCaseIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.tPreCaseIDBox.Name = "tPreCaseIDBox";
            this.tPreCaseIDBox.Ntext = "";
            this.tPreCaseIDBox.Size = new System.Drawing.Size(800, 30);
            this.tPreCaseIDBox.TabIndex = 56;
            this.tPreCaseIDBox.Ttext = "病歷號:";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(122, 63);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(249, 35);
            this.dateTime.TabIndex = 63;
            // 
            // RDatelabel
            // 
            this.RDatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RDatelabel.AutoSize = true;
            this.RDatelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RDatelabel.Location = new System.Drawing.Point(17, 67);
            this.RDatelabel.Name = "RDatelabel";
            this.RDatelabel.Size = new System.Drawing.Size(101, 26);
            this.RDatelabel.TabIndex = 62;
            this.RDatelabel.Text = "開立日期:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 305);
            this.dataGridView1.TabIndex = 64;
            // 
            // buttonAddMed
            // 
            this.buttonAddMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMed.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddMed.Location = new System.Drawing.Point(173, 215);
            this.buttonAddMed.Name = "buttonAddMed";
            this.buttonAddMed.Size = new System.Drawing.Size(121, 32);
            this.buttonAddMed.TabIndex = 65;
            this.buttonAddMed.Text = "+";
            this.buttonAddMed.UseVisualStyleBackColor = true;
            this.buttonAddMed.Click += new System.EventHandler(this.add_Click);
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remove.Location = new System.Drawing.Point(490, 215);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(121, 32);
            this.Remove.TabIndex = 66;
            this.Remove.Text = "-";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(12, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 67;
            this.button3.Text = "儲存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(667, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 32);
            this.button4.TabIndex = 68;
            this.button4.Text = "關閉";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(406, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 69;
            this.label3.Text = "調劑方式:";
            // 
            // textBoxDispensing
            // 
            this.textBoxDispensing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDispensing.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxDispensing.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDispensing.Location = new System.Drawing.Point(514, 63);
            this.textBoxDispensing.Name = "textBoxDispensing";
            this.textBoxDispensing.Size = new System.Drawing.Size(220, 35);
            this.textBoxDispensing.TabIndex = 70;
            // 
            // FrmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.textBoxDispensing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.buttonAddMed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.RDatelabel);
            this.Controls.Add(this.tPreCaseIDBox);
            this.Controls.Add(this.textBoxTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTlabel);
            this.Controls.Add(this.MedicineBox);
            this.Name = "FrmPrescription";
            this.Text = "FrmPrescription";
            this.Load += new System.EventHandler(this.FrmPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MedicineBox;
        private System.Windows.Forms.Label BTlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxTA;
        private System.Windows.Forms.Label label2;
        private TLBox tPreCaseIDBox;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label RDatelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddMed;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDispensing;
    }
}