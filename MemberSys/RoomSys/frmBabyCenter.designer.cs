namespace prjRoom
{
    partial class frmBabyCenter
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
            this.RoomListdataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RoomListdataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomListdataGridView2
            // 
            this.RoomListdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomListdataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomListdataGridView2.Location = new System.Drawing.Point(0, 0);
            this.RoomListdataGridView2.Name = "RoomListdataGridView2";
            this.RoomListdataGridView2.RowTemplate.Height = 24;
            this.RoomListdataGridView2.Size = new System.Drawing.Size(800, 450);
            this.RoomListdataGridView2.TabIndex = 0;
            // 
            // frmBabyCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomListdataGridView2);
            this.Name = "frmBabyCenter";
            this.Text = "frmBabyCenter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmBabyCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomListdataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomListdataGridView2;
    }
}