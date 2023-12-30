namespace Clinicsys
{
    partial class userControlDateTimePicker
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStar = new System.Windows.Forms.Label();
            this.lalTitle = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.lblStar);
            this.panel2.Controls.Add(this.lalTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 28);
            this.panel2.TabIndex = 2;
            // 
            // lblStar
            // 
            this.lblStar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStar.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStar.ForeColor = System.Drawing.Color.White;
            this.lblStar.Location = new System.Drawing.Point(91, 0);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(26, 28);
            this.lblStar.TabIndex = 1;
            this.lblStar.Text = "*";
            this.lblStar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalTitle
            // 
            this.lalTitle.AutoSize = true;
            this.lalTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lalTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lalTitle.ForeColor = System.Drawing.Color.White;
            this.lalTitle.Location = new System.Drawing.Point(0, 0);
            this.lalTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lalTitle.Name = "lalTitle";
            this.lalTitle.Size = new System.Drawing.Size(91, 30);
            this.lalTitle.TabIndex = 0;
            this.lalTitle.Text = "txtTitle";
            this.lalTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(442, 36);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 29, 0, 0, 0, 0);
            // 
            // userControlDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Name = "userControlDateTimePicker";
            this.Size = new System.Drawing.Size(442, 63);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lalTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
