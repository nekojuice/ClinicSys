namespace prjRoom
{
    partial class frmRoomList
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
            this.RoomListdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RoomListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomListdataGridView
            // 
            this.RoomListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomListdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomListdataGridView.Location = new System.Drawing.Point(0, 0);
            this.RoomListdataGridView.Name = "RoomListdataGridView";
            this.RoomListdataGridView.RowTemplate.Height = 24;
            this.RoomListdataGridView.Size = new System.Drawing.Size(800, 450);
            this.RoomListdataGridView.TabIndex = 0;
            // 
            // frmRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomListdataGridView);
            this.Name = "frmRoomList";
            this.Text = "FrmRoomList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmRoomList_Load);
            this.Load += new System.EventHandler(this.frmRoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomListdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomListdataGridView;
    }
}