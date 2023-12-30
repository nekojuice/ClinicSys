using System;

namespace ClinicSys
{
    partial class frmEmpProdEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpProdEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControlTextPrice = new ClinicSys.userControlText();
            this.userControlTextName = new ClinicSys.userControlText();
            this.userControlTextDescription = new ClinicSys.userControlText();
            this.userControlDateTimePickerEndDate = new Clinicsys.userControlDateTimePicker();
            this.userControlDateTimePickerStartDate = new Clinicsys.userControlDateTimePicker();
            this.userControlComboBoxCategory = new ClinicSys.userControlComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(654, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品照片";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(778, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccept.Location = new System.Drawing.Point(861, 464);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 49);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "確定";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(713, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 49);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(536, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 3);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1039, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "商品維護";
            // 
            // userControlTextPrice
            // 
            this.userControlTextPrice.AutoScroll = true;
            this.userControlTextPrice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextPrice.Location = new System.Drawing.Point(537, 82);
            this.userControlTextPrice.mutiline = false;
            this.userControlTextPrice.Name = "userControlTextPrice";
            this.userControlTextPrice.showStar = true;
            this.userControlTextPrice.Size = new System.Drawing.Size(442, 64);
            this.userControlTextPrice.TabIndex = 13;
            this.userControlTextPrice.title = "商品價格";
            this.userControlTextPrice.value = "";
            this.userControlTextPrice.valueReadOnly = false;
            // 
            // userControlTextName
            // 
            this.userControlTextName.AutoScroll = true;
            this.userControlTextName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextName.Location = new System.Drawing.Point(45, 82);
            this.userControlTextName.mutiline = false;
            this.userControlTextName.Name = "userControlTextName";
            this.userControlTextName.showStar = true;
            this.userControlTextName.Size = new System.Drawing.Size(442, 64);
            this.userControlTextName.TabIndex = 12;
            this.userControlTextName.title = "商品名稱";
            this.userControlTextName.value = "";
            this.userControlTextName.valueReadOnly = false;
            // 
            // userControlTextDescription
            // 
            this.userControlTextDescription.AutoScroll = true;
            this.userControlTextDescription.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextDescription.Location = new System.Drawing.Point(45, 395);
            this.userControlTextDescription.mutiline = true;
            this.userControlTextDescription.Name = "userControlTextDescription";
            this.userControlTextDescription.showStar = false;
            this.userControlTextDescription.Size = new System.Drawing.Size(442, 118);
            this.userControlTextDescription.TabIndex = 5;
            this.userControlTextDescription.title = "商品描述";
            this.userControlTextDescription.value = "";
            this.userControlTextDescription.valueReadOnly = false;
            // 
            // userControlDateTimePickerEndDate
            // 
            this.userControlDateTimePickerEndDate.Location = new System.Drawing.Point(45, 312);
            this.userControlDateTimePickerEndDate.Name = "userControlDateTimePickerEndDate";
            this.userControlDateTimePickerEndDate.showStar = true;
            this.userControlDateTimePickerEndDate.Size = new System.Drawing.Size(442, 75);
            this.userControlDateTimePickerEndDate.TabIndex = 4;
            this.userControlDateTimePickerEndDate.title = "下架日期";
            this.userControlDateTimePickerEndDate.value = new System.DateTime(2023, 12, 28, 15, 48, 13, 316);
            // 
            // userControlDateTimePickerStartDate
            // 
            this.userControlDateTimePickerStartDate.Location = new System.Drawing.Point(45, 233);
            this.userControlDateTimePickerStartDate.Name = "userControlDateTimePickerStartDate";
            this.userControlDateTimePickerStartDate.showStar = true;
            this.userControlDateTimePickerStartDate.Size = new System.Drawing.Size(442, 71);
            this.userControlDateTimePickerStartDate.TabIndex = 3;
            this.userControlDateTimePickerStartDate.title = "上架日期";
            this.userControlDateTimePickerStartDate.value = new System.DateTime(2023, 12, 28, 15, 48, 13, 319);
            // 
            // userControlComboBoxCategory
            // 
            this.userControlComboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControlComboBoxCategory.items = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlComboBoxCategory.items")));
            this.userControlComboBoxCategory.Location = new System.Drawing.Point(45, 159);
            this.userControlComboBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.userControlComboBoxCategory.Name = "userControlComboBoxCategory";
            this.userControlComboBoxCategory.showStar = true;
            this.userControlComboBoxCategory.Size = new System.Drawing.Size(442, 71);
            this.userControlComboBoxCategory.TabIndex = 0;
            this.userControlComboBoxCategory.title = "商品種類";
            this.userControlComboBoxCategory.value = "";
            // 
            // frmProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 539);
            this.Controls.Add(this.userControlTextPrice);
            this.Controls.Add(this.userControlTextName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlTextDescription);
            this.Controls.Add(this.userControlDateTimePickerEndDate);
            this.Controls.Add(this.userControlDateTimePickerStartDate);
            this.Controls.Add(this.userControlComboBoxCategory);
            this.Name = "frmProductEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdcutEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControlComboBox userControlComboBoxCategory;
        private Clinicsys.userControlDateTimePicker userControlDateTimePickerStartDate;
        private Clinicsys.userControlDateTimePicker userControlDateTimePickerEndDate;
        private userControlText userControlTextDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private userControlText userControlTextName;
        private userControlText userControlTextPrice;
    }
}