namespace ClinicSysMdiParent
{
    partial class FrmSideEffect
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fbSideEffect = new ClinicSysMdiParent.View.FieldBox();
            this.fbSideEffectCode = new ClinicSysMdiParent.View.FieldBox();
            this.fbId_SideEffect = new ClinicSysMdiParent.View.FieldBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "副作用基本資訊";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(424, 365);
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
            this.button1.Location = new System.Drawing.Point(544, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 56);
            this.button1.TabIndex = 27;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbSideEffect
            // 
            this.fbSideEffect.fieldName = "副作用名稱";
            this.fbSideEffect.fieldValue = "";
            this.fbSideEffect.Location = new System.Drawing.Point(12, 233);
            this.fbSideEffect.Name = "fbSideEffect";
            this.fbSideEffect.Size = new System.Drawing.Size(624, 64);
            this.fbSideEffect.TabIndex = 26;
            // 
            // fbSideEffectCode
            // 
            this.fbSideEffectCode.fieldName = "副作用代碼";
            this.fbSideEffectCode.fieldValue = "";
            this.fbSideEffectCode.Location = new System.Drawing.Point(12, 154);
            this.fbSideEffectCode.Name = "fbSideEffectCode";
            this.fbSideEffectCode.Size = new System.Drawing.Size(624, 64);
            this.fbSideEffectCode.TabIndex = 25;
            // 
            // fbId_SideEffect
            // 
            this.fbId_SideEffect.fieldName = "fId";
            this.fbId_SideEffect.fieldValue = "";
            this.fbId_SideEffect.Location = new System.Drawing.Point(12, 69);
            this.fbId_SideEffect.Name = "fbId_SideEffect";
            this.fbId_SideEffect.Size = new System.Drawing.Size(624, 64);
            this.fbId_SideEffect.TabIndex = 24;
            // 
            // FrmSideEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbSideEffect);
            this.Controls.Add(this.fbSideEffectCode);
            this.Controls.Add(this.fbId_SideEffect);
            this.Controls.Add(this.label1);
            this.Name = "FrmSideEffect";
            this.Text = "FrmSideEffect";
            this.Activated += new System.EventHandler(this.FrmSideEffect_Activated);
            this.Load += new System.EventHandler(this.FrmSideEffect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private View.FieldBox fbSideEffect;
        private View.FieldBox fbSideEffectCode;
        private View.FieldBox fbId_SideEffect;
    }
}