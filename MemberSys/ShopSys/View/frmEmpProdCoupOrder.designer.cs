namespace ClinicSys
{
    partial class frmEmpProdCoupOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpProdCoupOrder));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBAll = new System.Windows.Forms.ToolStripButton();
            this.TSBCreat = new System.Windows.Forms.ToolStripButton();
            this.TSBDelete = new System.Windows.Forms.ToolStripButton();
            this.TSBUpdate = new System.Windows.Forms.ToolStripButton();
            this.TSBSearch = new System.Windows.Forms.ToolStripButton();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.panelbuttonStripforCRUD = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.panelCoupon = new System.Windows.Forms.Panel();
            this.dataGridViewCoupon = new System.Windows.Forms.DataGridView();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.panel_product_coupon_order = new System.Windows.Forms.Panel();
            this.tabManager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductEditor = new System.Windows.Forms.Button();
            this.panelSideUp = new System.Windows.Forms.Panel();
            this.btnCouponEditor = new System.Windows.Forms.Button();
            this.btnOrderEditor = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelSideMiddle = new System.Windows.Forms.Panel();
            this.panelSideDown = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panelbuttonStripforCRUD.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.panel_product_coupon_order.SuspendLayout();
            this.tabManager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelSideMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBAll,
            this.TSBCreat,
            this.TSBDelete,
            this.TSBUpdate,
            this.TSBSearch,
            this.txtKeyword});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1302, 60);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBAll
            // 
            this.TSBAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBAll.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSBAll.Image = ((System.Drawing.Image)(resources.GetObject("TSBAll.Image")));
            this.TSBAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAll.Name = "TSBAll";
            this.TSBAll.Size = new System.Drawing.Size(113, 57);
            this.TSBAll.Text = "顯示全部";
            this.TSBAll.ToolTipText = "顯示全部";
            this.TSBAll.Click += new System.EventHandler(this.TSBAll_Click);
            // 
            // TSBCreat
            // 
            this.TSBCreat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBCreat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSBCreat.Image = ((System.Drawing.Image)(resources.GetObject("TSBCreat.Image")));
            this.TSBCreat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCreat.Name = "TSBCreat";
            this.TSBCreat.Size = new System.Drawing.Size(83, 57);
            this.TSBCreat.Text = "+新增";
            this.TSBCreat.Click += new System.EventHandler(this.TSBCreate_Click);
            // 
            // TSBDelete
            // 
            this.TSBDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSBDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelete.Image")));
            this.TSBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelete.Name = "TSBDelete";
            this.TSBDelete.Size = new System.Drawing.Size(75, 57);
            this.TSBDelete.Text = "-刪除";
            this.TSBDelete.Click += new System.EventHandler(this.TSBDelete_Click);
            // 
            // TSBUpdate
            // 
            this.TSBUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSBUpdate.Image = ((System.Drawing.Image)(resources.GetObject("TSBUpdate.Image")));
            this.TSBUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUpdate.Name = "TSBUpdate";
            this.TSBUpdate.Size = new System.Drawing.Size(65, 57);
            this.TSBUpdate.Text = "修改";
            this.TSBUpdate.Click += new System.EventHandler(this.TSBUpdate_Click);
            // 
            // TSBSearch
            // 
            this.TSBSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSBSearch.Image = ((System.Drawing.Image)(resources.GetObject("TSBSearch.Image")));
            this.TSBSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSearch.Name = "TSBSearch";
            this.TSBSearch.Size = new System.Drawing.Size(65, 57);
            this.TSBSearch.Text = "搜尋";
            this.TSBSearch.ToolTipText = "搜尋";
            this.TSBSearch.Click += new System.EventHandler(this.TSBSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(233, 60);
            // 
            // panelbuttonStripforCRUD
            // 
            this.panelbuttonStripforCRUD.Controls.Add(this.toolStrip1);
            this.panelbuttonStripforCRUD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbuttonStripforCRUD.Location = new System.Drawing.Point(0, 939);
            this.panelbuttonStripforCRUD.Margin = new System.Windows.Forms.Padding(4);
            this.panelbuttonStripforCRUD.Name = "panelbuttonStripforCRUD";
            this.panelbuttonStripforCRUD.Size = new System.Drawing.Size(1302, 60);
            this.panelbuttonStripforCRUD.TabIndex = 5;
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.dataGridViewProduct);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(4, 4);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1286, 922);
            this.panelProduct.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1286, 922);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewProduct_DataBindingComplete);
            // 
            // panelCoupon
            // 
            this.panelCoupon.Controls.Add(this.dataGridViewCoupon);
            this.panelCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoupon.Location = new System.Drawing.Point(4, 4);
            this.panelCoupon.Margin = new System.Windows.Forms.Padding(4);
            this.panelCoupon.Name = "panelCoupon";
            this.panelCoupon.Size = new System.Drawing.Size(1286, 922);
            this.panelCoupon.TabIndex = 0;
            // 
            // dataGridViewCoupon
            // 
            this.dataGridViewCoupon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCoupon.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCoupon.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCoupon.Name = "dataGridViewCoupon";
            this.dataGridViewCoupon.RowHeadersWidth = 60;
            this.dataGridViewCoupon.RowTemplate.Height = 24;
            this.dataGridViewCoupon.Size = new System.Drawing.Size(1286, 922);
            this.dataGridViewCoupon.TabIndex = 0;
            this.dataGridViewCoupon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCoupon_DataBindingComplete);
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.dataGridViewOrder);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(4, 4);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1286, 922);
            this.panelOrder.TabIndex = 2;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 60;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(1286, 922);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            this.dataGridViewOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewOrder_DataBindingComplete);
            // 
            // panel_product_coupon_order
            // 
            this.panel_product_coupon_order.Controls.Add(this.tabManager);
            this.panel_product_coupon_order.Controls.Add(this.panelbuttonStripforCRUD);
            this.panel_product_coupon_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_product_coupon_order.Location = new System.Drawing.Point(290, 0);
            this.panel_product_coupon_order.Margin = new System.Windows.Forms.Padding(4);
            this.panel_product_coupon_order.Name = "panel_product_coupon_order";
            this.panel_product_coupon_order.Size = new System.Drawing.Size(1302, 999);
            this.panel_product_coupon_order.TabIndex = 3;
            // 
            // tabManager
            // 
            this.tabManager.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabManager.Controls.Add(this.tabPage1);
            this.tabManager.Controls.Add(this.tabPage2);
            this.tabManager.Controls.Add(this.tabPage3);
            this.tabManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManager.ItemSize = new System.Drawing.Size(0, 1);
            this.tabManager.Location = new System.Drawing.Point(0, 0);
            this.tabManager.Margin = new System.Windows.Forms.Padding(4);
            this.tabManager.Name = "tabManager";
            this.tabManager.SelectedIndex = 0;
            this.tabManager.Size = new System.Drawing.Size(1302, 939);
            this.tabManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabManager.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1294, 930);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelCoupon);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1294, 930);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelOrder);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1294, 930);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "商城後台管理";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProductEditor
            // 
            this.btnProductEditor.BackColor = System.Drawing.Color.LightCoral;
            this.btnProductEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductEditor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductEditor.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductEditor.Location = new System.Drawing.Point(0, 0);
            this.btnProductEditor.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductEditor.Name = "btnProductEditor";
            this.btnProductEditor.Size = new System.Drawing.Size(290, 111);
            this.btnProductEditor.TabIndex = 3;
            this.btnProductEditor.Text = "產品管理";
            this.btnProductEditor.UseVisualStyleBackColor = false;
            this.btnProductEditor.Click += new System.EventHandler(this.btnProductEditor_Click);
            // 
            // panelSideUp
            // 
            this.panelSideUp.BackColor = System.Drawing.Color.Snow;
            this.panelSideUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideUp.Location = new System.Drawing.Point(0, 47);
            this.panelSideUp.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideUp.Name = "panelSideUp";
            this.panelSideUp.Size = new System.Drawing.Size(290, 20);
            this.panelSideUp.TabIndex = 2;
            // 
            // btnCouponEditor
            // 
            this.btnCouponEditor.BackColor = System.Drawing.Color.LightCoral;
            this.btnCouponEditor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCouponEditor.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCouponEditor.Location = new System.Drawing.Point(0, 111);
            this.btnCouponEditor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCouponEditor.Name = "btnCouponEditor";
            this.btnCouponEditor.Size = new System.Drawing.Size(290, 111);
            this.btnCouponEditor.TabIndex = 4;
            this.btnCouponEditor.Text = "優惠券管理";
            this.btnCouponEditor.UseVisualStyleBackColor = false;
            this.btnCouponEditor.Click += new System.EventHandler(this.btnCouponEditor_Click);
            // 
            // btnOrderEditor
            // 
            this.btnOrderEditor.BackColor = System.Drawing.Color.LightCoral;
            this.btnOrderEditor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderEditor.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderEditor.Location = new System.Drawing.Point(0, 222);
            this.btnOrderEditor.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderEditor.Name = "btnOrderEditor";
            this.btnOrderEditor.Size = new System.Drawing.Size(290, 111);
            this.btnOrderEditor.TabIndex = 5;
            this.btnOrderEditor.Text = "訂單管理";
            this.btnOrderEditor.UseVisualStyleBackColor = false;
            this.btnOrderEditor.Click += new System.EventHandler(this.btnOrderEditor_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Snow;
            this.panelSide.Controls.Add(this.panelSideMiddle);
            this.panelSide.Controls.Add(this.panelSideDown);
            this.panelSide.Controls.Add(this.panelSideUp);
            this.panelSide.Controls.Add(this.label2);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(290, 999);
            this.panelSide.TabIndex = 1;
            // 
            // panelSideMiddle
            // 
            this.panelSideMiddle.Controls.Add(this.btnOrderEditor);
            this.panelSideMiddle.Controls.Add(this.btnProductEditor);
            this.panelSideMiddle.Controls.Add(this.btnCouponEditor);
            this.panelSideMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideMiddle.Location = new System.Drawing.Point(0, 67);
            this.panelSideMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMiddle.Name = "panelSideMiddle";
            this.panelSideMiddle.Size = new System.Drawing.Size(290, 536);
            this.panelSideMiddle.TabIndex = 4;
            // 
            // panelSideDown
            // 
            this.panelSideDown.BackColor = System.Drawing.Color.Snow;
            this.panelSideDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSideDown.Location = new System.Drawing.Point(0, 603);
            this.panelSideDown.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideDown.Name = "panelSideDown";
            this.panelSideDown.Size = new System.Drawing.Size(290, 396);
            this.panelSideDown.TabIndex = 3;
            // 
            // frmEmpProdCoupOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1592, 999);
            this.Controls.Add(this.panel_product_coupon_order);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpProdCoupOrder";
            this.Text = "frmManager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelbuttonStripforCRUD.ResumeLayout(false);
            this.panelbuttonStripforCRUD.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelCoupon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).EndInit();
            this.panelOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.panel_product_coupon_order.ResumeLayout(false);
            this.tabManager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelSideMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBCreat;
        private System.Windows.Forms.ToolStripButton TSBUpdate;
        private System.Windows.Forms.ToolStripButton TSBDelete;
        private System.Windows.Forms.ToolStripButton TSBSearch;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.Panel panelbuttonStripforCRUD;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Panel panelCoupon;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panel_product_coupon_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductEditor;
        private System.Windows.Forms.Panel panelSideUp;
        private System.Windows.Forms.Button btnCouponEditor;
        private System.Windows.Forms.Button btnOrderEditor;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelSideDown;
        private System.Windows.Forms.Panel panelSideMiddle;
        private System.Windows.Forms.TabControl tabManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewCoupon;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.ToolStripButton TSBAll;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
    }
}