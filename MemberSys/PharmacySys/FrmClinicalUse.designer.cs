namespace ClinicSysMdiParent
{
    partial class FrmClinicalUse
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fbClinicalUse = new ClinicSysMdiParent.View.FieldBox();
            this.fbClinicalUseCode = new ClinicSysMdiParent.View.FieldBox();
            this.fbId_ClinicalUse = new ClinicSysMdiParent.View.FieldBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 61);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "衛生署許可適應症基本資訊";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(415, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 56);
            this.button2.TabIndex = 28;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(535, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 56);
            this.button1.TabIndex = 27;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbClinicalUse
            // 
            this.fbClinicalUse.fieldName = "適應症名稱";
            this.fbClinicalUse.fieldValue = "";
            this.fbClinicalUse.Location = new System.Drawing.Point(12, 245);
            this.fbClinicalUse.Name = "fbClinicalUse";
            this.fbClinicalUse.Size = new System.Drawing.Size(615, 46);
            this.fbClinicalUse.TabIndex = 26;
            // 
            // fbClinicalUseCode
            // 
            this.fbClinicalUseCode.fieldName = "適應症代碼";
            this.fbClinicalUseCode.fieldValue = "";
            this.fbClinicalUseCode.Location = new System.Drawing.Point(12, 166);
            this.fbClinicalUseCode.Name = "fbClinicalUseCode";
            this.fbClinicalUseCode.Size = new System.Drawing.Size(615, 52);
            this.fbClinicalUseCode.TabIndex = 25;
            // 
            // fbId_ClinicalUse
            // 
            this.fbId_ClinicalUse.fieldName = "Id";
            this.fbId_ClinicalUse.fieldValue = "";
            this.fbId_ClinicalUse.Location = new System.Drawing.Point(12, 81);
            this.fbId_ClinicalUse.Name = "fbId_ClinicalUse";
            this.fbId_ClinicalUse.Size = new System.Drawing.Size(615, 46);
            this.fbId_ClinicalUse.TabIndex = 24;
            // 
            // FrmClinicalUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbClinicalUse);
            this.Controls.Add(this.fbClinicalUseCode);
            this.Controls.Add(this.fbId_ClinicalUse);
            this.Controls.Add(this.panel3);
            this.Name = "FrmClinicalUse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClinicalUse";
            this.Load += new System.EventHandler(this.FrmClinicalUse_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private View.FieldBox fbClinicalUse;
        private View.FieldBox fbClinicalUseCode;
        private View.FieldBox fbId_ClinicalUse;
    }
}