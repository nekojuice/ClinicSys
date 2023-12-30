using System;
using System.Collections.Generic;

namespace ClinicSys
{
    partial class frmEmpCoupEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpCoupEditor));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.userControlTextCriteria = new ClinicSys.userControlText();
            this.userControlComboBoxCatagory = new ClinicSys.userControlComboBox();
            this.userControlTextDescription = new ClinicSys.userControlText();
            this.userControlDateTimePickerEndDate = new Clinicsys.userControlDateTimePicker();
            this.userControlDateTimePickerStartDate = new Clinicsys.userControlDateTimePicker();
            this.userControlTextValue = new ClinicSys.userControlText();
            this.userControlName = new ClinicSys.userControlText();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label3.TabIndex = 12;
            this.label3.Text = "優惠券維護";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(784, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(633, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "優惠券照片";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(543, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 3);
            this.label2.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(726, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 49);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccept.Location = new System.Drawing.Point(868, 519);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 49);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.Text = "確定";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // userControlTextCriteria
            // 
            this.userControlTextCriteria.AutoScroll = true;
            this.userControlTextCriteria.AutoSize = true;
            this.userControlTextCriteria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextCriteria.Location = new System.Drawing.Point(543, 155);
            this.userControlTextCriteria.mutiline = false;
            this.userControlTextCriteria.Name = "userControlTextCriteria";
            this.userControlTextCriteria.showStar = true;
            this.userControlTextCriteria.Size = new System.Drawing.Size(442, 64);
            this.userControlTextCriteria.TabIndex = 26;
            this.userControlTextCriteria.title = "需滿額值";
            this.userControlTextCriteria.value = "";
            this.userControlTextCriteria.valueReadOnly = false;
            // 
            // userControlComboBoxCatagory
            // 
            this.userControlComboBoxCatagory.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControlComboBoxCatagory.items = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlComboBoxCatagory.items")));
            this.userControlComboBoxCatagory.Location = new System.Drawing.Point(50, 161);
            this.userControlComboBoxCatagory.Margin = new System.Windows.Forms.Padding(4);
            this.userControlComboBoxCatagory.Name = "userControlComboBoxCatagory";
            this.userControlComboBoxCatagory.showStar = true;
            this.userControlComboBoxCatagory.Size = new System.Drawing.Size(442, 59);
            this.userControlComboBoxCatagory.TabIndex = 25;
            this.userControlComboBoxCatagory.title = "優惠券種類";
            this.userControlComboBoxCatagory.value = "";
            // 
            // userControlTextDescription
            // 
            this.userControlTextDescription.AutoScroll = true;
            this.userControlTextDescription.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextDescription.Location = new System.Drawing.Point(50, 441);
            this.userControlTextDescription.mutiline = true;
            this.userControlTextDescription.Name = "userControlTextDescription";
            this.userControlTextDescription.showStar = false;
            this.userControlTextDescription.Size = new System.Drawing.Size(442, 131);
            this.userControlTextDescription.TabIndex = 21;
            this.userControlTextDescription.title = "使用描述";
            this.userControlTextDescription.value = "";
            this.userControlTextDescription.valueReadOnly = false;
            // 
            // userControlDateTimePickerEndDate
            // 
            this.userControlDateTimePickerEndDate.Location = new System.Drawing.Point(50, 341);
            this.userControlDateTimePickerEndDate.Name = "userControlDateTimePickerEndDate";
            this.userControlDateTimePickerEndDate.showStar = true;
            this.userControlDateTimePickerEndDate.Size = new System.Drawing.Size(442, 75);
            this.userControlDateTimePickerEndDate.TabIndex = 20;
            this.userControlDateTimePickerEndDate.title = "失效日期";
            this.userControlDateTimePickerEndDate.value = new System.DateTime(2023, 12, 28, 18, 3, 37, 163);
            // 
            // userControlDateTimePickerStartDate
            // 
            this.userControlDateTimePickerStartDate.Location = new System.Drawing.Point(50, 245);
            this.userControlDateTimePickerStartDate.Name = "userControlDateTimePickerStartDate";
            this.userControlDateTimePickerStartDate.showStar = true;
            this.userControlDateTimePickerStartDate.Size = new System.Drawing.Size(442, 71);
            this.userControlDateTimePickerStartDate.TabIndex = 19;
            this.userControlDateTimePickerStartDate.title = "生效日期";
            this.userControlDateTimePickerStartDate.value = new System.DateTime(2023, 12, 28, 18, 3, 37, 165);
            // 
            // userControlTextValue
            // 
            this.userControlTextValue.AutoScroll = true;
            this.userControlTextValue.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextValue.Location = new System.Drawing.Point(543, 72);
            this.userControlTextValue.mutiline = false;
            this.userControlTextValue.Name = "userControlTextValue";
            this.userControlTextValue.showStar = true;
            this.userControlTextValue.Size = new System.Drawing.Size(442, 64);
            this.userControlTextValue.TabIndex = 17;
            this.userControlTextValue.title = "優惠值";
            this.userControlTextValue.value = "";
            this.userControlTextValue.valueReadOnly = false;
            // 
            // userControlName
            // 
            this.userControlName.AutoScroll = true;
            this.userControlName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlName.Location = new System.Drawing.Point(50, 72);
            this.userControlName.mutiline = false;
            this.userControlName.Name = "userControlName";
            this.userControlName.showStar = true;
            this.userControlName.Size = new System.Drawing.Size(442, 64);
            this.userControlName.TabIndex = 13;
            this.userControlName.title = "優惠券名稱";
            this.userControlName.value = "";
            this.userControlName.valueReadOnly = false;
            // 
            // frmCouponEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 591);
            this.Controls.Add(this.userControlTextCriteria);
            this.Controls.Add(this.userControlComboBoxCatagory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.userControlTextDescription);
            this.Controls.Add(this.userControlDateTimePickerEndDate);
            this.Controls.Add(this.userControlDateTimePickerStartDate);
            this.Controls.Add(this.userControlTextValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlName);
            this.Controls.Add(this.label3);
            this.Name = "frmCouponEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "優惠券種類";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private userControlText userControlName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private userControlText userControlTextValue;
        private Clinicsys.userControlDateTimePicker userControlDateTimePickerEndDate;
        private Clinicsys.userControlDateTimePicker userControlDateTimePickerStartDate;
        private userControlText userControlTextDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private userControlComboBox userControlComboBoxCatagory;
        private userControlText userControlTextCriteria;
    }
}