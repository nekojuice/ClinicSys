namespace MSIT155_E_MID.ApptSystem.View
{
    partial class FrmCallingUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCallingUnit));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cbxSelectTimeShift = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentName = new System.Windows.Forms.TextBox();
            this.txtCurrentNum = new System.Windows.Forms.TextBox();
            this.btnState1 = new System.Windows.Forms.Button();
            this.btnState5 = new System.Windows.Forms.Button();
            this.btnState7 = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnState6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(391, 878);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInfo.Location = new System.Drawing.Point(0, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(391, 55);
            this.lbInfo.TabIndex = 22;
            this.lbInfo.Text = "門診資訊";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "當前";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cbxSelectTimeShift,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 55);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(391, 28);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MemberSys.Properties.Resources.refresh_16px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 25);
            this.toolStripButton1.Text = "重新整理";
            this.toolStripButton1.Click += new System.EventHandler(this.cbxSelectTimeShift_SelectedIndexChanged);
            // 
            // cbxSelectTimeShift
            // 
            this.cbxSelectTimeShift.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbxSelectTimeShift.AutoSize = false;
            this.cbxSelectTimeShift.BackColor = System.Drawing.Color.MistyRose;
            this.cbxSelectTimeShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectTimeShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSelectTimeShift.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxSelectTimeShift.Items.AddRange(new object[] {
            "選擇時段",
            "早診",
            "午診",
            "晚診"});
            this.cbxSelectTimeShift.Name = "cbxSelectTimeShift";
            this.cbxSelectTimeShift.Size = new System.Drawing.Size(90, 28);
            this.cbxSelectTimeShift.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTimeShift_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 25);
            this.toolStripLabel1.Text = "時段: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCurrentName);
            this.panel1.Controls.Add(this.txtCurrentNum);
            this.panel1.Controls.Add(this.btnState1);
            this.panel1.Controls.Add(this.btnState5);
            this.panel1.Controls.Add(this.btnState7);
            this.panel1.Controls.Add(this.btnCall);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnState6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 802);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 159);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(95, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "姓名";
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentName.Location = new System.Drawing.Point(95, 28);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(164, 46);
            this.txtCurrentName.TabIndex = 32;
            // 
            // txtCurrentNum
            // 
            this.txtCurrentNum.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentNum.Location = new System.Drawing.Point(7, 28);
            this.txtCurrentNum.Name = "txtCurrentNum";
            this.txtCurrentNum.Size = new System.Drawing.Size(82, 46);
            this.txtCurrentNum.TabIndex = 31;
            // 
            // btnState1
            // 
            this.btnState1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnState1.Enabled = false;
            this.btnState1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnState1.Image = ((System.Drawing.Image)(resources.GetObject("btnState1.Image")));
            this.btnState1.Location = new System.Drawing.Point(134, 80);
            this.btnState1.Name = "btnState1";
            this.btnState1.Size = new System.Drawing.Size(125, 76);
            this.btnState1.TabIndex = 24;
            this.btnState1.Text = "看診中";
            this.btnState1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnState1.UseVisualStyleBackColor = true;
            this.btnState1.Click += new System.EventHandler(this.btnState1_Click);
            // 
            // btnState5
            // 
            this.btnState5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnState5.Enabled = false;
            this.btnState5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnState5.Image = ((System.Drawing.Image)(resources.GetObject("btnState5.Image")));
            this.btnState5.Location = new System.Drawing.Point(265, 56);
            this.btnState5.Name = "btnState5";
            this.btnState5.Size = new System.Drawing.Size(108, 47);
            this.btnState5.TabIndex = 25;
            this.btnState5.Text = "檢查";
            this.btnState5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnState5.UseVisualStyleBackColor = true;
            this.btnState5.Click += new System.EventHandler(this.btnState5_Click);
            // 
            // btnState7
            // 
            this.btnState7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnState7.Enabled = false;
            this.btnState7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnState7.Image = ((System.Drawing.Image)(resources.GetObject("btnState7.Image")));
            this.btnState7.Location = new System.Drawing.Point(265, 109);
            this.btnState7.Name = "btnState7";
            this.btnState7.Size = new System.Drawing.Size(108, 47);
            this.btnState7.TabIndex = 26;
            this.btnState7.Text = "完診";
            this.btnState7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnState7.UseVisualStyleBackColor = true;
            this.btnState7.Click += new System.EventHandler(this.btnState7_Click);
            // 
            // btnCall
            // 
            this.btnCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCall.Enabled = false;
            this.btnCall.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCall.Image = ((System.Drawing.Image)(resources.GetObject("btnCall.Image")));
            this.btnCall.Location = new System.Drawing.Point(4, 80);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(126, 76);
            this.btnCall.TabIndex = 27;
            this.btnCall.Text = "叫號";
            this.btnCall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnState6
            // 
            this.btnState6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnState6.Enabled = false;
            this.btnState6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnState6.Image = ((System.Drawing.Image)(resources.GetObject("btnState6.Image")));
            this.btnState6.Location = new System.Drawing.Point(265, 3);
            this.btnState6.Name = "btnState6";
            this.btnState6.Size = new System.Drawing.Size(108, 47);
            this.btnState6.TabIndex = 28;
            this.btnState6.Text = "未到";
            this.btnState6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnState6.UseVisualStyleBackColor = true;
            this.btnState6.Click += new System.EventHandler(this.btnState6_Click);
            // 
            // FrmCallingUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(391, 961);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbInfo);
            this.Name = "FrmCallingUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "叫號機";
            this.Load += new System.EventHandler(this.FrmCallingUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnState1;
        private System.Windows.Forms.Button btnState5;
        private System.Windows.Forms.Button btnState7;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnState6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentName;
        private System.Windows.Forms.TextBox txtCurrentNum;
        private System.Windows.Forms.ToolStripComboBox cbxSelectTimeShift;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}