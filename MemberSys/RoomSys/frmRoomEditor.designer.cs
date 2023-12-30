namespace prjRoom
{
    partial class frmRoomEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fbName = new prjComponentDemo.FieldBox();
            this.fbId = new prjComponentDemo.FieldBox();
            this.roomTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeListBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeListBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fbRoomtype = new prjComponentDemo.FieldBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2315, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4905, 2);
            this.label2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(9, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 16;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(147, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbName
            // 
            this.fbName.fieldName = "房間名稱";
            this.fbName.fieldRequired = false;
            this.fbName.fieldValue = "";
            this.fbName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbName.Location = new System.Drawing.Point(9, 146);
            this.fbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbName.Name = "fbName";
            this.fbName.passwordMask = '\0';
            this.fbName.Size = new System.Drawing.Size(199, 116);
            this.fbName.TabIndex = 0;
            // 
            // fbId
            // 
            this.fbId.fieldName = "房間編號";
            this.fbId.fieldRequired = false;
            this.fbId.fieldValue = "";
            this.fbId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbId.Location = new System.Drawing.Point(15, 27);
            this.fbId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbId.Name = "fbId";
            this.fbId.passwordMask = '\0';
            this.fbId.Size = new System.Drawing.Size(205, 116);
            this.fbId.TabIndex = 17;
            // 
            // roomTypeListBindingSource
            // 
            this.roomTypeListBindingSource.DataMember = "RoomTypeList";
            // 
            // roomTypeListBindingSource4
            // 
            this.roomTypeListBindingSource4.DataMember = "RoomTypeList";
            // 
            // fbRoomtype
            // 
            this.fbRoomtype.fieldName = "房型編號";
            this.fbRoomtype.fieldRequired = false;
            this.fbRoomtype.fieldValue = "";
            this.fbRoomtype.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRoomtype.Location = new System.Drawing.Point(9, 263);
            this.fbRoomtype.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fbRoomtype.Name = "fbRoomtype";
            this.fbRoomtype.passwordMask = '\0';
            this.fbRoomtype.Size = new System.Drawing.Size(199, 116);
            this.fbRoomtype.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(121, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "*勿填";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(98, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // frmRoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fbId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fbRoomtype);
            this.Controls.Add(this.fbName);
            this.Name = "frmRoomEditor";
            this.Text = "FrmRoomEditor";
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeListBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private prjComponentDemo.FieldBox fbName;
        private prjComponentDemo.FieldBox fbId;
        
        private System.Windows.Forms.BindingSource roomTypeListBindingSource;
      
        private System.Windows.Forms.BindingSource roomTypeListBindingSource1;
        
        private System.Windows.Forms.BindingSource roomTypeListBindingSource2;
        private System.Windows.Forms.BindingSource roomTypeListBindingSource3;
        private System.Windows.Forms.BindingSource roomTypeListBindingSource4;
        private prjComponentDemo.FieldBox fbRoomtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}