namespace Clinicsys
{
    partial class frmMbrOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMbrOrder));
            this.dataGridViewMemberOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMemberOrder
            // 
            this.dataGridViewMemberOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMemberOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMemberOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMemberOrder.Name = "dataGridViewMemberOrder";
            this.dataGridViewMemberOrder.RowTemplate.Height = 24;
            this.dataGridViewMemberOrder.Size = new System.Drawing.Size(1370, 797);
            this.dataGridViewMemberOrder.TabIndex = 0;
            this.dataGridViewMemberOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMemberOrder_CellContentClick);
            this.dataGridViewMemberOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewMemberOrder_DataBindingComplete);
            // 
            // frmMbrOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 797);
            this.Controls.Add(this.dataGridViewMemberOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMbrOrder";
            this.Text = "購買清單";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMemberOrder;
    }
}