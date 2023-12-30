namespace ClinicSysMdiParent
{
    partial class FrmRecords
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
            this.RDatelabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pulselabel = new System.Windows.Forms.Label();
            this.BTlabel = new System.Windows.Forms.Label();
            this.textBoxPulse = new System.Windows.Forms.TextBox();
            this.textBoxBT = new System.Windows.Forms.TextBox();
            this.textBoxBP = new System.Windows.Forms.TextBox();
            this.BPlabel = new System.Windows.Forms.Label();
            this.CClabel = new System.Windows.Forms.Label();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxDisposal = new System.Windows.Forms.TextBox();
            this.Disposallabel = new System.Windows.Forms.Label();
            this.textBoxPreScribe = new System.Windows.Forms.TextBox();
            this.Prescribelabel = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.tDocNameBox = new ClinicSysMdiParent.TLBox();
            this.tRCaseIDBox = new ClinicSysMdiParent.TLBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RDatelabel
            // 
            this.RDatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RDatelabel.AutoSize = true;
            this.RDatelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RDatelabel.Location = new System.Drawing.Point(0, 71);
            this.RDatelabel.Name = "RDatelabel";
            this.RDatelabel.Size = new System.Drawing.Size(59, 26);
            this.RDatelabel.TabIndex = 0;
            this.RDatelabel.Text = "日期:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(5, 644);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 41;
            this.button2.Text = "儲存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(540, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "關閉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.tRCaseIDBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 28);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.tDocNameBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 28);
            this.panel2.TabIndex = 44;
            // 
            // Pulselabel
            // 
            this.Pulselabel.AutoSize = true;
            this.Pulselabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pulselabel.Location = new System.Drawing.Point(348, 71);
            this.Pulselabel.Name = "Pulselabel";
            this.Pulselabel.Size = new System.Drawing.Size(59, 26);
            this.Pulselabel.TabIndex = 45;
            this.Pulselabel.Text = "脈搏:";
            // 
            // BTlabel
            // 
            this.BTlabel.AutoSize = true;
            this.BTlabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTlabel.Location = new System.Drawing.Point(0, 135);
            this.BTlabel.Name = "BTlabel";
            this.BTlabel.Size = new System.Drawing.Size(59, 26);
            this.BTlabel.TabIndex = 47;
            this.BTlabel.Text = "體溫:";
            // 
            // textBoxPulse
            // 
            this.textBoxPulse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPulse.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxPulse.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPulse.Location = new System.Drawing.Point(413, 67);
            this.textBoxPulse.Name = "textBoxPulse";
            this.textBoxPulse.Size = new System.Drawing.Size(249, 35);
            this.textBoxPulse.TabIndex = 51;
            // 
            // textBoxBT
            // 
            this.textBoxBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBT.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxBT.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxBT.Location = new System.Drawing.Point(65, 131);
            this.textBoxBT.Name = "textBoxBT";
            this.textBoxBT.Size = new System.Drawing.Size(249, 35);
            this.textBoxBT.TabIndex = 52;
            // 
            // textBoxBP
            // 
            this.textBoxBP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBP.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxBP.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxBP.Location = new System.Drawing.Point(412, 131);
            this.textBoxBP.Name = "textBoxBP";
            this.textBoxBP.Size = new System.Drawing.Size(249, 35);
            this.textBoxBP.TabIndex = 54;
            // 
            // BPlabel
            // 
            this.BPlabel.AutoSize = true;
            this.BPlabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPlabel.Location = new System.Drawing.Point(348, 135);
            this.BPlabel.Name = "BPlabel";
            this.BPlabel.Size = new System.Drawing.Size(59, 26);
            this.BPlabel.TabIndex = 53;
            this.BPlabel.Text = "血壓:";
            // 
            // CClabel
            // 
            this.CClabel.AutoSize = true;
            this.CClabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CClabel.Location = new System.Drawing.Point(0, 194);
            this.CClabel.Name = "CClabel";
            this.CClabel.Size = new System.Drawing.Size(101, 26);
            this.CClabel.TabIndex = 55;
            this.CClabel.Text = "主述症狀:";
            // 
            // textBoxCC
            // 
            this.textBoxCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCC.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCC.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCC.Location = new System.Drawing.Point(5, 223);
            this.textBoxCC.Multiline = true;
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(656, 115);
            this.textBoxCC.TabIndex = 56;
            // 
            // textBoxDisposal
            // 
            this.textBoxDisposal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDisposal.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxDisposal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDisposal.Location = new System.Drawing.Point(6, 370);
            this.textBoxDisposal.Multiline = true;
            this.textBoxDisposal.Name = "textBoxDisposal";
            this.textBoxDisposal.Size = new System.Drawing.Size(656, 115);
            this.textBoxDisposal.TabIndex = 58;
            // 
            // Disposallabel
            // 
            this.Disposallabel.AutoSize = true;
            this.Disposallabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Disposallabel.Location = new System.Drawing.Point(1, 341);
            this.Disposallabel.Name = "Disposallabel";
            this.Disposallabel.Size = new System.Drawing.Size(59, 26);
            this.Disposallabel.TabIndex = 57;
            this.Disposallabel.Text = "處置:";
            // 
            // textBoxPreScribe
            // 
            this.textBoxPreScribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreScribe.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxPreScribe.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPreScribe.Location = new System.Drawing.Point(6, 518);
            this.textBoxPreScribe.Multiline = true;
            this.textBoxPreScribe.Name = "textBoxPreScribe";
            this.textBoxPreScribe.Size = new System.Drawing.Size(656, 115);
            this.textBoxPreScribe.TabIndex = 60;
            // 
            // Prescribelabel
            // 
            this.Prescribelabel.AutoSize = true;
            this.Prescribelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Prescribelabel.Location = new System.Drawing.Point(1, 489);
            this.Prescribelabel.Name = "Prescribelabel";
            this.Prescribelabel.Size = new System.Drawing.Size(59, 26);
            this.Prescribelabel.TabIndex = 59;
            this.Prescribelabel.Text = "醫囑:";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(65, 67);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(249, 35);
            this.dateTime.TabIndex = 61;
            // 
            // tDocNameBox
            // 
            this.tDocNameBox.AutoSize = true;
            this.tDocNameBox.BackColor = System.Drawing.Color.LightCoral;
            this.tDocNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDocNameBox.Location = new System.Drawing.Point(0, 0);
            this.tDocNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.tDocNameBox.Name = "tDocNameBox";
            this.tDocNameBox.Ntext = "";
            this.tDocNameBox.Size = new System.Drawing.Size(683, 28);
            this.tDocNameBox.TabIndex = 21;
            this.tDocNameBox.Ttext = "診號:";
            // 
            // tRCaseIDBox
            // 
            this.tRCaseIDBox.AutoSize = true;
            this.tRCaseIDBox.BackColor = System.Drawing.Color.LightCoral;
            this.tRCaseIDBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRCaseIDBox.Location = new System.Drawing.Point(0, 0);
            this.tRCaseIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.tRCaseIDBox.Name = "tRCaseIDBox";
            this.tRCaseIDBox.Ntext = "";
            this.tRCaseIDBox.Size = new System.Drawing.Size(683, 28);
            this.tRCaseIDBox.TabIndex = 21;
            this.tRCaseIDBox.Ttext = "病歷號:";
            // 
            // FrmRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(683, 688);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.textBoxPreScribe);
            this.Controls.Add(this.Prescribelabel);
            this.Controls.Add(this.textBoxDisposal);
            this.Controls.Add(this.Disposallabel);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.CClabel);
            this.Controls.Add(this.textBoxBP);
            this.Controls.Add(this.BPlabel);
            this.Controls.Add(this.textBoxBT);
            this.Controls.Add(this.textBoxPulse);
            this.Controls.Add(this.BTlabel);
            this.Controls.Add(this.Pulselabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RDatelabel);
            this.Name = "FrmRecords";
            this.Text = "FrmRecords";
            this.Load += new System.EventHandler(this.FrmRecords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RDatelabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private TLBox tRCaseIDBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private TLBox tDocNameBox;
        private System.Windows.Forms.Label Pulselabel;
        private System.Windows.Forms.Label BTlabel;
        private System.Windows.Forms.TextBox textBoxPulse;
        private System.Windows.Forms.TextBox textBoxBT;
        private System.Windows.Forms.TextBox textBoxBP;
        private System.Windows.Forms.Label BPlabel;
        private System.Windows.Forms.Label CClabel;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.TextBox textBoxDisposal;
        private System.Windows.Forms.Label Disposallabel;
        private System.Windows.Forms.TextBox textBoxPreScribe;
        private System.Windows.Forms.Label Prescribelabel;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}