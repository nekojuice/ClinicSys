namespace ClinicSys
{
    partial class FrmLeaveSearch
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
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.CBLeaveType = new Sunny.UI.UIComboBox();
            this.uiMarkLabel7 = new Sunny.UI.UIMarkLabel();
            this.xButton1 = new PowerLib.Winform.Controls.XButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xButton2 = new PowerLib.Winform.Controls.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDatePicker1.FillColor = System.Drawing.Color.Snow;
            this.uiDatePicker1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDatePicker1.Location = new System.Drawing.Point(352, 102);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(150, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 62;
            this.uiDatePicker1.Text = "2023-12-21";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2023, 12, 21, 11, 15, 44, 930);
            this.uiDatePicker1.Watermark = "";
            // 
            // CBLeaveType
            // 
            this.CBLeaveType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBLeaveType.DataSource = null;
            this.CBLeaveType.FillColor = System.Drawing.Color.Snow;
            this.CBLeaveType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBLeaveType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CBLeaveType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CBLeaveType.Location = new System.Drawing.Point(510, 102);
            this.CBLeaveType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBLeaveType.MinimumSize = new System.Drawing.Size(63, 0);
            this.CBLeaveType.Name = "CBLeaveType";
            this.CBLeaveType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CBLeaveType.Size = new System.Drawing.Size(101, 29);
            this.CBLeaveType.TabIndex = 60;
            this.CBLeaveType.Text = "公假";
            this.CBLeaveType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CBLeaveType.Watermark = "";
            // 
            // uiMarkLabel7
            // 
            this.uiMarkLabel7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMarkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel7.Location = new System.Drawing.Point(53, 37);
            this.uiMarkLabel7.MarkColor = System.Drawing.Color.Thistle;
            this.uiMarkLabel7.Name = "uiMarkLabel7";
            this.uiMarkLabel7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel7.Size = new System.Drawing.Size(139, 41);
            this.uiMarkLabel7.TabIndex = 61;
            this.uiMarkLabel7.Text = "請假查詢";
            this.uiMarkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xButton1
            // 
            this.xButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xButton1.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton1.CheckedForeColor = System.Drawing.Color.White;
            this.xButton1.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton1.DefaultButtonBorderWidth = 2;
            this.xButton1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.xButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.xButton1.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton1.HoldingForeColor = System.Drawing.Color.White;
            this.xButton1.HoldingImage = null;
            this.xButton1.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton1.Image = null;
            this.xButton1.Location = new System.Drawing.Point(641, 89);
            this.xButton1.Name = "xButton1";
            this.xButton1.RoundedRectangleCornerRadius = 20;
            this.xButton1.Size = new System.Drawing.Size(106, 53);
            this.xButton1.StartColor = System.Drawing.Color.LightCoral;
            this.xButton1.TabIndex = 59;
            this.xButton1.Text = "搜尋";
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 231);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.Location = new System.Drawing.Point(219, 109);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeId.TabIndex = 63;
            this.txtEmployeeId.Text = "28";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-7, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(833, 10);
            this.label3.TabIndex = 64;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // xButton2
            // 
            this.xButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xButton2.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton2.CheckedForeColor = System.Drawing.Color.White;
            this.xButton2.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton2.DefaultButtonBorderWidth = 2;
            this.xButton2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.xButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.xButton2.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xButton2.HoldingForeColor = System.Drawing.Color.White;
            this.xButton2.HoldingImage = null;
            this.xButton2.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xButton2.Image = null;
            this.xButton2.Location = new System.Drawing.Point(86, 89);
            this.xButton2.Name = "xButton2";
            this.xButton2.RoundedRectangleCornerRadius = 20;
            this.xButton2.Size = new System.Drawing.Size(106, 53);
            this.xButton2.StartColor = System.Drawing.Color.LightCoral;
            this.xButton2.TabIndex = 65;
            this.xButton2.Text = "新增申請";
            this.xButton2.Click += new System.EventHandler(this.xButton2_Click);
            // 
            // FrmLeaveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(818, 501);
            this.Controls.Add(this.xButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.uiDatePicker1);
            this.Controls.Add(this.CBLeaveType);
            this.Controls.Add(this.uiMarkLabel7);
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLeaveSearch";
            this.Text = "FrmLeaveSearch";
            this.Activated += new System.EventHandler(this.FrmLeaveSearch_Activated);
            this.Load += new System.EventHandler(this.FrmLeaveSearch_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmLeaveSearch_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIComboBox CBLeaveType;
        private Sunny.UI.UIMarkLabel uiMarkLabel7;
        private PowerLib.Winform.Controls.XButton xButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label3;
        private PowerLib.Winform.Controls.XButton xButton2;
    }
}