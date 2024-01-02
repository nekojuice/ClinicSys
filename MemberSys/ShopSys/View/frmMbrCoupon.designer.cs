namespace ClinicSys
{
    partial class frmMbrCoupon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_history = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelGet = new System.Windows.Forms.Panel();
            this.lblGetTitle = new System.Windows.Forms.Label();
            this.dataGridView_get = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panelGet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_get)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1173, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "歷史紀錄";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.Snow;
            this.panelHistory.Controls.Add(this.label11);
            this.panelHistory.Controls.Add(this.label8);
            this.panelHistory.Controls.Add(this.dataGridView_history);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(3, 3);
            this.panelHistory.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(1167, 642);
            this.panelHistory.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(32, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 30);
            this.label11.TabIndex = 19;
            this.label11.Text = "本期累計使用7張優惠券";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(31, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "本期累計折抵 $ 800 元";
            // 
            // dataGridView_history
            // 
            this.dataGridView_history.AllowUserToAddRows = false;
            this.dataGridView_history.AllowUserToDeleteRows = false;
            this.dataGridView_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_history.Location = new System.Drawing.Point(0, 3);
            this.dataGridView_history.Name = "dataGridView_history";
            this.dataGridView_history.ReadOnly = true;
            this.dataGridView_history.RowTemplate.Height = 24;
            this.dataGridView_history.Size = new System.Drawing.Size(1167, 528);
            this.dataGridView_history.TabIndex = 13;
            this.dataGridView_history.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_history_DataBindingComplete);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelGet);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "領取優惠券";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelGet
            // 
            this.panelGet.BackColor = System.Drawing.Color.Snow;
            this.panelGet.Controls.Add(this.lblGetTitle);
            this.panelGet.Controls.Add(this.dataGridView_get);
            this.panelGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGet.Location = new System.Drawing.Point(3, 3);
            this.panelGet.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelGet.Name = "panelGet";
            this.panelGet.Size = new System.Drawing.Size(1167, 642);
            this.panelGet.TabIndex = 2;
            // 
            // lblGetTitle
            // 
            this.lblGetTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGetTitle.AutoSize = true;
            this.lblGetTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGetTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGetTitle.Location = new System.Drawing.Point(437, 49);
            this.lblGetTitle.Name = "lblGetTitle";
            this.lblGetTitle.Size = new System.Drawing.Size(292, 40);
            this.lblGetTitle.TabIndex = 11;
            this.lblGetTitle.Text = "1月會員獨享優惠券";
            // 
            // dataGridView_get
            // 
            this.dataGridView_get.AllowUserToAddRows = false;
            this.dataGridView_get.AllowUserToDeleteRows = false;
            this.dataGridView_get.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_get.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_get.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_get.Location = new System.Drawing.Point(133, 110);
            this.dataGridView_get.Name = "dataGridView_get";
            this.dataGridView_get.ReadOnly = true;
            this.dataGridView_get.RowTemplate.Height = 24;
            this.dataGridView_get.Size = new System.Drawing.Size(908, 480);
            this.dataGridView_get.TabIndex = 7;
            this.dataGridView_get.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_get_CellClick);
            this.dataGridView_get.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_get_DataBindingComplete);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // frmMbrCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 691);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMbrCoupon";
            this.Text = "frmCoupon";
            this.Load += new System.EventHandler(this.frmCoupon_Load);
            this.tabPage3.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panelGet.ResumeLayout(false);
            this.panelGet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_get)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelGet;
        private System.Windows.Forms.Label lblGetTitle;
        private System.Windows.Forms.DataGridView dataGridView_get;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView_history;
    }
}