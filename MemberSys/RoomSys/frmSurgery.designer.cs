namespace prjRoom
{
    partial class frmSurgery
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
            this.RoomListdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RoomListdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomListdataGridView1
            // 
            this.RoomListdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomListdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomListdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.RoomListdataGridView1.Name = "RoomListdataGridView1";
            this.RoomListdataGridView1.RowTemplate.Height = 24;
            this.RoomListdataGridView1.Size = new System.Drawing.Size(800, 450);
            this.RoomListdataGridView1.TabIndex = 0;
            // 
            // frmSurgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomListdataGridView1);
            this.Name = "frmSurgery";
            this.Text = "frmSurgery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmSurgery_Load);
            this.Load += new System.EventHandler(this.frmSurgery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomListdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomListdataGridView1;
    }
}