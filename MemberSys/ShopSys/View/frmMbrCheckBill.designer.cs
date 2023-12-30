using System.Collections.Generic;

namespace ClinicSys
{
    partial class frmMbrCheckBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMbrCheckBill));
            this.dataGridViewCheckBill = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinialPrice = new System.Windows.Forms.Label();
            this.userControlTextAccountFriveNumber = new ClinicSys.userControlText();
            this.userControlComboBoxPayType = new ClinicSys.userControlComboBox();
            this.userControlTextMemo = new ClinicSys.userControlText();
            this.userControlComboShipType = new ClinicSys.userControlComboBox();
            this.userControlTextAddress = new ClinicSys.userControlText();
            this.userControlTextPhone = new ClinicSys.userControlText();
            this.userControlTextName = new ClinicSys.userControlText();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCheckBill
            // 
            this.dataGridViewCheckBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCheckBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckBill.Location = new System.Drawing.Point(81, 96);
            this.dataGridViewCheckBill.Name = "dataGridViewCheckBill";
            this.dataGridViewCheckBill.RowTemplate.Height = 24;
            this.dataGridViewCheckBill.Size = new System.Drawing.Size(442, 250);
            this.dataGridViewCheckBill.TabIndex = 7;
            this.dataGridViewCheckBill.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCheckBill_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(48, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 1);
            this.label2.TabIndex = 22;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccept.Location = new System.Drawing.Point(895, 582);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 49);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "結帳";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1099, 49);
            this.label4.TabIndex = 24;
            this.label4.Text = "結帳";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(791, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "總付款金額";
            // 
            // lblFinialPrice
            // 
            this.lblFinialPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFinialPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFinialPrice.Location = new System.Drawing.Point(791, 607);
            this.lblFinialPrice.Name = "lblFinialPrice";
            this.lblFinialPrice.Size = new System.Drawing.Size(89, 20);
            this.lblFinialPrice.TabIndex = 26;
            this.lblFinialPrice.Text = "$ 0";
            this.lblFinialPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userControlTextAccountFriveNumber
            // 
            this.userControlTextAccountFriveNumber.AutoScroll = true;
            this.userControlTextAccountFriveNumber.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextAccountFriveNumber.Location = new System.Drawing.Point(81, 474);
            this.userControlTextAccountFriveNumber.mutiline = false;
            this.userControlTextAccountFriveNumber.Name = "userControlTextAccountFriveNumber";
            this.userControlTextAccountFriveNumber.showStar = false;
            this.userControlTextAccountFriveNumber.Size = new System.Drawing.Size(442, 64);
            this.userControlTextAccountFriveNumber.TabIndex = 27;
            this.userControlTextAccountFriveNumber.title = "轉帳賬號末5碼";
            this.userControlTextAccountFriveNumber.value = "";
            this.userControlTextAccountFriveNumber.valueReadOnly = false;
            // 
            // userControlComboBoxPayType
            // 
            this.userControlComboBoxPayType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControlComboBoxPayType.items = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlComboBoxPayType.items")));
            this.userControlComboBoxPayType.Location = new System.Drawing.Point(81, 380);
            this.userControlComboBoxPayType.Margin = new System.Windows.Forms.Padding(4);
            this.userControlComboBoxPayType.Name = "userControlComboBoxPayType";
            this.userControlComboBoxPayType.showStar = true;
            this.userControlComboBoxPayType.Size = new System.Drawing.Size(442, 59);
            this.userControlComboBoxPayType.TabIndex = 6;
            this.userControlComboBoxPayType.title = "付款方式";
            this.userControlComboBoxPayType.value = "";
            // 
            // userControlTextMemo
            // 
            this.userControlTextMemo.AutoScroll = true;
            this.userControlTextMemo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextMemo.Location = new System.Drawing.Point(570, 475);
            this.userControlTextMemo.mutiline = false;
            this.userControlTextMemo.Name = "userControlTextMemo";
            this.userControlTextMemo.showStar = false;
            this.userControlTextMemo.Size = new System.Drawing.Size(442, 64);
            this.userControlTextMemo.TabIndex = 5;
            this.userControlTextMemo.title = "備註";
            this.userControlTextMemo.value = "";
            this.userControlTextMemo.valueReadOnly = false;
            // 
            // userControlComboShipType
            // 
            this.userControlComboShipType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControlComboShipType.items = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlComboShipType.items")));
            this.userControlComboShipType.Location = new System.Drawing.Point(570, 96);
            this.userControlComboShipType.Margin = new System.Windows.Forms.Padding(4);
            this.userControlComboShipType.Name = "userControlComboShipType";
            this.userControlComboShipType.showStar = true;
            this.userControlComboShipType.Size = new System.Drawing.Size(442, 59);
            this.userControlComboShipType.TabIndex = 4;
            this.userControlComboShipType.title = "寄送方式";
            this.userControlComboShipType.value = "";
            // 
            // userControlTextAddress
            // 
            this.userControlTextAddress.AutoScroll = true;
            this.userControlTextAddress.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextAddress.Location = new System.Drawing.Point(570, 196);
            this.userControlTextAddress.mutiline = false;
            this.userControlTextAddress.Name = "userControlTextAddress";
            this.userControlTextAddress.showStar = true;
            this.userControlTextAddress.Size = new System.Drawing.Size(442, 64);
            this.userControlTextAddress.TabIndex = 2;
            this.userControlTextAddress.title = "收件地址";
            this.userControlTextAddress.value = "";
            this.userControlTextAddress.valueReadOnly = false;
            // 
            // userControlTextPhone
            // 
            this.userControlTextPhone.AutoScroll = true;
            this.userControlTextPhone.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextPhone.Location = new System.Drawing.Point(570, 382);
            this.userControlTextPhone.mutiline = false;
            this.userControlTextPhone.Name = "userControlTextPhone";
            this.userControlTextPhone.showStar = true;
            this.userControlTextPhone.Size = new System.Drawing.Size(442, 64);
            this.userControlTextPhone.TabIndex = 1;
            this.userControlTextPhone.title = "收件人手機";
            this.userControlTextPhone.value = "";
            this.userControlTextPhone.valueReadOnly = false;
            // 
            // userControlTextName
            // 
            this.userControlTextName.AutoScroll = true;
            this.userControlTextName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControlTextName.Location = new System.Drawing.Point(570, 289);
            this.userControlTextName.mutiline = false;
            this.userControlTextName.Name = "userControlTextName";
            this.userControlTextName.showStar = true;
            this.userControlTextName.Size = new System.Drawing.Size(442, 64);
            this.userControlTextName.TabIndex = 0;
            this.userControlTextName.title = "收件人姓名";
            this.userControlTextName.value = "";
            this.userControlTextName.valueReadOnly = false;
            // 
            // frmMbrCheckBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 657);
            this.Controls.Add(this.userControlTextAccountFriveNumber);
            this.Controls.Add(this.lblFinialPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCheckBill);
            this.Controls.Add(this.userControlComboBoxPayType);
            this.Controls.Add(this.userControlTextMemo);
            this.Controls.Add(this.userControlComboShipType);
            this.Controls.Add(this.userControlTextAddress);
            this.Controls.Add(this.userControlTextPhone);
            this.Controls.Add(this.userControlTextName);
            this.Name = "frmMbrCheckBill";
            this.Text = "frmCheckBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControlText userControlTextName;
        private userControlText userControlTextPhone;
        private userControlText userControlTextAddress;
        private userControlComboBox userControlComboShipType;
        private userControlText userControlTextMemo;
        private userControlComboBox userControlComboBoxPayType;
        private System.Windows.Forms.DataGridView dataGridViewCheckBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinialPrice;
        private userControlText userControlTextAccountFriveNumber;
    }
}