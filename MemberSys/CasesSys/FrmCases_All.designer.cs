namespace ClinicSysMdiParent
{
    partial class FrmCases_All
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCases_All));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.memsave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMR = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AllegeryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SwitchBox = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tCustomerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCaseIDBox = new ClinicSysMdiParent.TLBox();
            this.tWeightBox = new ClinicSysMdiParent.TLBox();
            this.tHeightBox = new ClinicSysMdiParent.TLBox();
            this.tBirthDayBox = new ClinicSysMdiParent.TLBox();
            this.tNationalIDBox = new ClinicSysMdiParent.TLBox();
            this.tBloodTypeBox = new ClinicSysMdiParent.TLBox();
            this.tGenderBox = new ClinicSysMdiParent.TLBox();
            this.tNameBox = new ClinicSysMdiParent.TLBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCustomerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "查";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Mem_Search);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(63, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 34);
            this.textBox1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(198, 517);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel10);
            this.splitContainer1.Size = new System.Drawing.Size(995, 559);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 43;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 42);
            this.flowLayoutPanel1.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.tCaseIDBox);
            this.panel1.Controls.Add(this.tWeightBox);
            this.panel1.Controls.Add(this.tHeightBox);
            this.panel1.Controls.Add(this.tBirthDayBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 28);
            this.panel1.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.memsave);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.dataGridViewMR);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.HistoryBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.AllegeryBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.SwitchBox);
            this.panel5.Controls.Add(this.textBoxSearch);
            this.panel5.Location = new System.Drawing.Point(0, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(795, 494);
            this.panel5.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(130, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 32);
            this.button4.TabIndex = 48;
            this.button4.Text = "新生兒資料登錄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.new_Born_Add);
            // 
            // memsave
            // 
            this.memsave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memsave.Location = new System.Drawing.Point(8, 180);
            this.memsave.Name = "memsave";
            this.memsave.Size = new System.Drawing.Size(121, 32);
            this.memsave.TabIndex = 47;
            this.memsave.Text = "儲存修改";
            this.memsave.UseVisualStyleBackColor = true;
            this.memsave.Click += new System.EventHandler(this.memsave_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(254, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 32);
            this.button5.TabIndex = 46;
            this.button5.Text = "查詢";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.searchClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Font = new System.Drawing.Font("細明體-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 216);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 30);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // dataGridViewMR
            // 
            this.dataGridViewMR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMR.Location = new System.Drawing.Point(6, 293);
            this.dataGridViewMR.Name = "dataGridViewMR";
            this.dataGridViewMR.RowHeadersWidth = 51;
            this.dataGridViewMR.RowTemplate.Height = 24;
            this.dataGridViewMR.Size = new System.Drawing.Size(784, 204);
            this.dataGridViewMR.TabIndex = 5;
            this.dataGridViewMR.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMR_RowHeaderMouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(130, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 41;
            this.button3.Text = "刪除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 171);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(8, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 40;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NewClick);
            // 
            // HistoryBox
            // 
            this.HistoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HistoryBox.Location = new System.Drawing.Point(113, 6);
            this.HistoryBox.Multiline = true;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(499, 71);
            this.HistoryBox.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "過去病史:";
            // 
            // AllegeryBox
            // 
            this.AllegeryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllegeryBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AllegeryBox.Location = new System.Drawing.Point(3, 109);
            this.AllegeryBox.Multiline = true;
            this.AllegeryBox.Name = "AllegeryBox";
            this.AllegeryBox.Size = new System.Drawing.Size(609, 65);
            this.AllegeryBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(0, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "過敏記錄:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchBox
            // 
            this.SwitchBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SwitchBox.FormattingEnabled = true;
            this.SwitchBox.Items.AddRange(new object[] {
            "看診紀錄",
            "檢查報告",
            "處方籤",
            "新生兒"});
            this.SwitchBox.Location = new System.Drawing.Point(8, 254);
            this.SwitchBox.Name = "SwitchBox";
            this.SwitchBox.Size = new System.Drawing.Size(243, 32);
            this.SwitchBox.TabIndex = 34;
            this.SwitchBox.Text = "選取需要查看的資料";
            this.SwitchBox.SelectedIndexChanged += new System.EventHandler(this.Switch);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxSearch.Location = new System.Drawing.Point(539, 215);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(246, 33);
            this.textBoxSearch.TabIndex = 33;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightCoral;
            this.panel10.Controls.Add(this.tNationalIDBox);
            this.panel10.Controls.Add(this.tBloodTypeBox);
            this.panel10.Controls.Add(this.tGenderBox);
            this.panel10.Controls.Add(this.tNameBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(794, 28);
            this.panel10.TabIndex = 28;
            // 
            // tCustomerDataBindingSource
            // 
            this.tCustomerDataBindingSource.DataMember = "tCustomerData";
            // 
            // tCaseIDBox
            // 
            this.tCaseIDBox.AutoSize = true;
            this.tCaseIDBox.BackColor = System.Drawing.Color.LightCoral;
            this.tCaseIDBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCaseIDBox.Location = new System.Drawing.Point(546, 0);
            this.tCaseIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.tCaseIDBox.Name = "tCaseIDBox";
            this.tCaseIDBox.Ntext = "";
            this.tCaseIDBox.Size = new System.Drawing.Size(248, 28);
            this.tCaseIDBox.TabIndex = 20;
            this.tCaseIDBox.Ttext = "病歷號:";
            // 
            // tWeightBox
            // 
            this.tWeightBox.AutoSize = true;
            this.tWeightBox.BackColor = System.Drawing.Color.LightCoral;
            this.tWeightBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tWeightBox.Location = new System.Drawing.Point(388, 0);
            this.tWeightBox.Margin = new System.Windows.Forms.Padding(4);
            this.tWeightBox.Name = "tWeightBox";
            this.tWeightBox.Ntext = "";
            this.tWeightBox.Size = new System.Drawing.Size(158, 28);
            this.tWeightBox.TabIndex = 48;
            this.tWeightBox.Ttext = "體重:";
            // 
            // tHeightBox
            // 
            this.tHeightBox.AutoSize = true;
            this.tHeightBox.BackColor = System.Drawing.Color.LightCoral;
            this.tHeightBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tHeightBox.Location = new System.Drawing.Point(229, 0);
            this.tHeightBox.Margin = new System.Windows.Forms.Padding(4);
            this.tHeightBox.Name = "tHeightBox";
            this.tHeightBox.Ntext = "";
            this.tHeightBox.Size = new System.Drawing.Size(159, 28);
            this.tHeightBox.TabIndex = 0;
            this.tHeightBox.Ttext = "身高:";
            // 
            // tBirthDayBox
            // 
            this.tBirthDayBox.AutoSize = true;
            this.tBirthDayBox.BackColor = System.Drawing.Color.LightCoral;
            this.tBirthDayBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tBirthDayBox.Location = new System.Drawing.Point(0, 0);
            this.tBirthDayBox.Margin = new System.Windows.Forms.Padding(4);
            this.tBirthDayBox.Name = "tBirthDayBox";
            this.tBirthDayBox.Ntext = "";
            this.tBirthDayBox.Size = new System.Drawing.Size(229, 28);
            this.tBirthDayBox.TabIndex = 8;
            this.tBirthDayBox.Ttext = "生日:";
            // 
            // tNationalIDBox
            // 
            this.tNationalIDBox.AutoSize = true;
            this.tNationalIDBox.BackColor = System.Drawing.Color.LightCoral;
            this.tNationalIDBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tNationalIDBox.Location = new System.Drawing.Point(564, 0);
            this.tNationalIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.tNationalIDBox.Name = "tNationalIDBox";
            this.tNationalIDBox.Ntext = "";
            this.tNationalIDBox.Size = new System.Drawing.Size(230, 28);
            this.tNationalIDBox.TabIndex = 20;
            this.tNationalIDBox.Ttext = "證號:";
            // 
            // tBloodTypeBox
            // 
            this.tBloodTypeBox.AutoSize = true;
            this.tBloodTypeBox.BackColor = System.Drawing.Color.LightCoral;
            this.tBloodTypeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tBloodTypeBox.Location = new System.Drawing.Point(388, 0);
            this.tBloodTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.tBloodTypeBox.Name = "tBloodTypeBox";
            this.tBloodTypeBox.Ntext = "";
            this.tBloodTypeBox.Size = new System.Drawing.Size(176, 28);
            this.tBloodTypeBox.TabIndex = 48;
            this.tBloodTypeBox.Ttext = "血型:";
            // 
            // tGenderBox
            // 
            this.tGenderBox.AutoSize = true;
            this.tGenderBox.BackColor = System.Drawing.Color.LightCoral;
            this.tGenderBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tGenderBox.Location = new System.Drawing.Point(229, 0);
            this.tGenderBox.Margin = new System.Windows.Forms.Padding(4);
            this.tGenderBox.Name = "tGenderBox";
            this.tGenderBox.Ntext = "";
            this.tGenderBox.Size = new System.Drawing.Size(159, 28);
            this.tGenderBox.TabIndex = 0;
            this.tGenderBox.Ttext = "性別:";
            // 
            // tNameBox
            // 
            this.tNameBox.AutoSize = true;
            this.tNameBox.BackColor = System.Drawing.Color.LightCoral;
            this.tNameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tNameBox.Location = new System.Drawing.Point(0, 0);
            this.tNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.tNameBox.Name = "tNameBox";
            this.tNameBox.Ntext = "";
            this.tNameBox.Size = new System.Drawing.Size(229, 28);
            this.tNameBox.TabIndex = 8;
            this.tNameBox.Ttext = "姓名:";
            // 
            // FrmCases_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(995, 559);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCases_All";
            this.Text = "FrmCases_All";
            this.Activated += new System.EventHandler(this.FrmCases_All_Activated);
            this.Load += new System.EventHandler(this.FrmCases_All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCustomerDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tCustomerDataBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewMR;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox HistoryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AllegeryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SwitchBox;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel10;
        private TLBox tNationalIDBox;
        private TLBox tGenderBox;
        private TLBox tNameBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button memsave;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TLBox tBloodTypeBox;
        private System.Windows.Forms.Panel panel1;
        private TLBox tCaseIDBox;
        private TLBox tWeightBox;
        private TLBox tHeightBox;
        private TLBox tBirthDayBox;
        private System.Windows.Forms.Button button4;
    }
}