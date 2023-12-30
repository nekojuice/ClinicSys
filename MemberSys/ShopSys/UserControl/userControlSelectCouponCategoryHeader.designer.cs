namespace ClinicSys
{
    partial class userControlCategoryHeader
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCouponCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCouponCategory
            // 
            this.lblCouponCategory.BackColor = System.Drawing.Color.MistyRose;
            this.lblCouponCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCouponCategory.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCouponCategory.Location = new System.Drawing.Point(0, 0);
            this.lblCouponCategory.Name = "lblCouponCategory";
            this.lblCouponCategory.Size = new System.Drawing.Size(878, 50);
            this.lblCouponCategory.TabIndex = 0;
            this.lblCouponCategory.Text = "categoryName";
            this.lblCouponCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlSelectCouponCategoryHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCouponCategory);
            this.Name = "UserControlSelectCouponCategoryHeader";
            this.Size = new System.Drawing.Size(878, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCouponCategory;
    }
}
