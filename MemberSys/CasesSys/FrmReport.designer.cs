namespace ClinicSysMdiParent
{
    partial class FrmReport
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
            this.tReCaseIDBox = new ClinicSysMdiParent.TLBox();
            this.TdateTime = new System.Windows.Forms.DateTimePicker();
            this.TDatelabel = new System.Windows.Forms.Label();
            this.RedateTime = new System.Windows.Forms.DateTimePicker();
            this.ReDatelabel = new System.Windows.Forms.Label();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.BPlabel = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AttachmentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tReCaseIDBox
            // 
            this.tReCaseIDBox.AutoSize = true;
            this.tReCaseIDBox.BackColor = System.Drawing.Color.LightCoral;
            this.tReCaseIDBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tReCaseIDBox.Location = new System.Drawing.Point(0, 0);
            this.tReCaseIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.tReCaseIDBox.Name = "tReCaseIDBox";
            this.tReCaseIDBox.Ntext = "";
            this.tReCaseIDBox.Size = new System.Drawing.Size(752, 30);
            this.tReCaseIDBox.TabIndex = 22;
            this.tReCaseIDBox.Ttext = "病歷號:";
            // 
            // TdateTime
            // 
            this.TdateTime.CustomFormat = "yyyy-MM-dd";
            this.TdateTime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TdateTime.Location = new System.Drawing.Point(305, 59);
            this.TdateTime.Name = "TdateTime";
            this.TdateTime.Size = new System.Drawing.Size(249, 35);
            this.TdateTime.TabIndex = 63;
            // 
            // TDatelabel
            // 
            this.TDatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TDatelabel.AutoSize = true;
            this.TDatelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TDatelabel.Location = new System.Drawing.Point(198, 65);
            this.TDatelabel.Name = "TDatelabel";
            this.TDatelabel.Size = new System.Drawing.Size(101, 26);
            this.TDatelabel.TabIndex = 62;
            this.TDatelabel.Text = "檢查日期:";
            // 
            // RedateTime
            // 
            this.RedateTime.CustomFormat = "yyyy-MM-dd";
            this.RedateTime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RedateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RedateTime.Location = new System.Drawing.Point(305, 183);
            this.RedateTime.Name = "RedateTime";
            this.RedateTime.Size = new System.Drawing.Size(249, 35);
            this.RedateTime.TabIndex = 65;
            // 
            // ReDatelabel
            // 
            this.ReDatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReDatelabel.AutoSize = true;
            this.ReDatelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReDatelabel.Location = new System.Drawing.Point(198, 189);
            this.ReDatelabel.Name = "ReDatelabel";
            this.ReDatelabel.Size = new System.Drawing.Size(101, 26);
            this.ReDatelabel.TabIndex = 64;
            this.ReDatelabel.Text = "報告日期:";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestName.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxTestName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTestName.Location = new System.Drawing.Point(305, 121);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(249, 35);
            this.textBoxTestName.TabIndex = 67;
            // 
            // BPlabel
            // 
            this.BPlabel.AutoSize = true;
            this.BPlabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPlabel.Location = new System.Drawing.Point(198, 127);
            this.BPlabel.Name = "BPlabel";
            this.BPlabel.Size = new System.Drawing.Size(101, 26);
            this.BPlabel.TabIndex = 66;
            this.BPlabel.Text = "檢查名稱:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxResult.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxResult.Location = new System.Drawing.Point(77, 271);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(663, 99);
            this.textBoxResult.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "結果:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 70;
            this.label2.Text = "附件:";
            // 
            // AttachmentPanel
            // 
            this.AttachmentPanel.Location = new System.Drawing.Point(17, 410);
            this.AttachmentPanel.Name = "AttachmentPanel";
            this.AttachmentPanel.Size = new System.Drawing.Size(723, 157);
            this.AttachmentPanel.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(619, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 72;
            this.button1.Text = "關閉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveButton.Location = new System.Drawing.Point(17, 605);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 32);
            this.SaveButton.TabIndex = 73;
            this.SaveButton.Text = "儲存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.save);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(752, 640);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AttachmentPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTestName);
            this.Controls.Add(this.BPlabel);
            this.Controls.Add(this.RedateTime);
            this.Controls.Add(this.ReDatelabel);
            this.Controls.Add(this.TdateTime);
            this.Controls.Add(this.TDatelabel);
            this.Controls.Add(this.tReCaseIDBox);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TLBox tReCaseIDBox;
        private System.Windows.Forms.DateTimePicker TdateTime;
        private System.Windows.Forms.Label TDatelabel;
        private System.Windows.Forms.DateTimePicker RedateTime;
        private System.Windows.Forms.Label ReDatelabel;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Label BPlabel;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel AttachmentPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
    }
}