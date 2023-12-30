namespace ClinicSysMdiParent
{
    partial class FrmType
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fbType = new ClinicSysMdiParent.View.FieldBox();
            this.fbTypeCode = new ClinicSysMdiParent.View.FieldBox();
            this.fbIdType = new ClinicSysMdiParent.View.FieldBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 61);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "劑型基本資訊";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fbType
            // 
            this.fbType.fieldName = "劑型種類";
            this.fbType.fieldValue = "";
            this.fbType.Location = new System.Drawing.Point(12, 260);
            this.fbType.Name = "fbType";
            this.fbType.Size = new System.Drawing.Size(594, 64);
            this.fbType.TabIndex = 21;
            // 
            // fbTypeCode
            // 
            this.fbTypeCode.fieldName = "劑型代碼";
            this.fbTypeCode.fieldValue = "";
            this.fbTypeCode.Location = new System.Drawing.Point(12, 181);
            this.fbTypeCode.Name = "fbTypeCode";
            this.fbTypeCode.Size = new System.Drawing.Size(594, 64);
            this.fbTypeCode.TabIndex = 20;
            // 
            // fbIdType
            // 
            this.fbIdType.fieldName = "fId";
            this.fbIdType.fieldValue = "";
            this.fbIdType.Location = new System.Drawing.Point(12, 96);
            this.fbIdType.Name = "fbIdType";
            this.fbIdType.Size = new System.Drawing.Size(594, 64);
            this.fbIdType.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(496, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 56);
            this.button1.TabIndex = 22;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(376, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 56);
            this.button2.TabIndex = 23;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbType);
            this.Controls.Add(this.fbTypeCode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fbIdType);
            this.Name = "FrmType";
            this.Text = "FrmType";
            this.Load += new System.EventHandler(this.FrmType_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private View.FieldBox fbIdType;
        private View.FieldBox fbType;
        private View.FieldBox fbTypeCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}