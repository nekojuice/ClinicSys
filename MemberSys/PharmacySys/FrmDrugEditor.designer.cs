namespace ClinicSysMdiParent
{
    partial class FrmDrugEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.comboBoxPC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lbSEdetails = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lbCUdetails = new System.Windows.Forms.ListBox();
            this.lblfImages = new System.Windows.Forms.Label();
            this.picfImages = new System.Windows.Forms.PictureBox();
            this.lblfApperance = new System.Windows.Forms.Label();
            this.picfApperance = new System.Windows.Forms.PictureBox();
            this.fbStorage = new ClinicSysMdiParent.View.FieldBox();
            this.fbBrand = new ClinicSysMdiParent.View.FieldBox();
            this.fbId_Drug = new ClinicSysMdiParent.View.FieldBox();
            this.fbSupplier = new ClinicSysMdiParent.View.FieldBox();
            this.fbMaxDose = new ClinicSysMdiParent.View.FieldBox();
            this.fbPrecautions = new ClinicSysMdiParent.View.FieldBox();
            this.fbWarnings = new ClinicSysMdiParent.View.FieldBox();
            this.fbGenericName = new ClinicSysMdiParent.View.FieldBox();
            this.fbTradeName = new ClinicSysMdiParent.View.FieldBox();
            this.fbDrugCode = new ClinicSysMdiParent.View.FieldBox();
            this.fbDrugDose = new ClinicSysMdiParent.View.FieldBox();
            this.fbDrugName = new ClinicSysMdiParent.View.FieldBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfApperance)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1784, 1061);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1780, 73);
            this.label1.TabIndex = 15;
            this.label1.Text = "藥品基本資訊";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxPC);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxType);
            this.splitContainer2.Panel1.Controls.Add(this.lblType);
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.lblfImages);
            this.splitContainer2.Panel1.Controls.Add(this.picfImages);
            this.splitContainer2.Panel1.Controls.Add(this.lblfApperance);
            this.splitContainer2.Panel1.Controls.Add(this.picfApperance);
            this.splitContainer2.Panel1.Controls.Add(this.fbStorage);
            this.splitContainer2.Panel1.Controls.Add(this.fbBrand);
            this.splitContainer2.Panel1.Controls.Add(this.fbId_Drug);
            this.splitContainer2.Panel1.Controls.Add(this.fbSupplier);
            this.splitContainer2.Panel1.Controls.Add(this.fbMaxDose);
            this.splitContainer2.Panel1.Controls.Add(this.fbPrecautions);
            this.splitContainer2.Panel1.Controls.Add(this.fbWarnings);
            this.splitContainer2.Panel1.Controls.Add(this.fbGenericName);
            this.splitContainer2.Panel1.Controls.Add(this.fbTradeName);
            this.splitContainer2.Panel1.Controls.Add(this.fbDrugCode);
            this.splitContainer2.Panel1.Controls.Add(this.fbDrugDose);
            this.splitContainer2.Panel1.Controls.Add(this.fbDrugName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(1780, 971);
            this.splitContainer2.SplitterDistance = 875;
            this.splitContainer2.TabIndex = 0;
            // 
            // comboBoxPC
            // 
            this.comboBoxPC.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxPC.FormattingEnabled = true;
            this.comboBoxPC.Location = new System.Drawing.Point(141, 452);
            this.comboBoxPC.Name = "comboBoxPC";
            this.comboBoxPC.Size = new System.Drawing.Size(724, 32);
            this.comboBoxPC.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 32);
            this.label2.TabIndex = 122;
            this.label2.Text = "懷孕藥品分級";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(146, 286);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(719, 32);
            this.comboBoxType.TabIndex = 121;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblType.Location = new System.Drawing.Point(25, 286);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(239, 32);
            this.lblType.TabIndex = 121;
            this.lblType.Text = "劑型";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.lbSEdetails);
            this.panel2.Location = new System.Drawing.Point(915, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 393);
            this.panel2.TabIndex = 53;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(22, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(561, 57);
            this.button4.TabIndex = 15;
            this.button4.Text = "副作用";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbSEdetails
            // 
            this.lbSEdetails.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSEdetails.FormattingEnabled = true;
            this.lbSEdetails.ItemHeight = 24;
            this.lbSEdetails.Location = new System.Drawing.Point(22, 110);
            this.lbSEdetails.Name = "lbSEdetails";
            this.lbSEdetails.Size = new System.Drawing.Size(561, 244);
            this.lbSEdetails.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lbCUdetails);
            this.panel1.Location = new System.Drawing.Point(915, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 393);
            this.panel1.TabIndex = 52;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(22, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(561, 57);
            this.button3.TabIndex = 14;
            this.button3.Text = "適應症";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbCUdetails
            // 
            this.lbCUdetails.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCUdetails.FormattingEnabled = true;
            this.lbCUdetails.ItemHeight = 24;
            this.lbCUdetails.Location = new System.Drawing.Point(22, 110);
            this.lbCUdetails.Name = "lbCUdetails";
            this.lbCUdetails.Size = new System.Drawing.Size(561, 244);
            this.lbCUdetails.TabIndex = 50;
            // 
            // lblfImages
            // 
            this.lblfImages.AutoSize = true;
            this.lblfImages.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblfImages.Location = new System.Drawing.Point(1552, 637);
            this.lblfImages.Name = "lblfImages";
            this.lblfImages.Size = new System.Drawing.Size(143, 20);
            this.lblfImages.TabIndex = 49;
            this.lblfImages.Text = "藥品包裝(允許null)";
            // 
            // picfImages
            // 
            this.picfImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picfImages.Location = new System.Drawing.Point(1525, 377);
            this.picfImages.Name = "picfImages";
            this.picfImages.Size = new System.Drawing.Size(246, 215);
            this.picfImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picfImages.TabIndex = 48;
            this.picfImages.TabStop = false;
            this.picfImages.Click += new System.EventHandler(this.picfImages_Click);
            // 
            // lblfApperance
            // 
            this.lblfApperance.AutoSize = true;
            this.lblfApperance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblfApperance.Location = new System.Drawing.Point(1552, 307);
            this.lblfApperance.Name = "lblfApperance";
            this.lblfApperance.Size = new System.Drawing.Size(159, 20);
            this.lblfApperance.TabIndex = 47;
            this.lblfApperance.Text = "藥品外觀(不允許null)";
            // 
            // picfApperance
            // 
            this.picfApperance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picfApperance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picfApperance.Location = new System.Drawing.Point(1525, 52);
            this.picfApperance.Name = "picfApperance";
            this.picfApperance.Size = new System.Drawing.Size(246, 215);
            this.picfApperance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picfApperance.TabIndex = 46;
            this.picfApperance.TabStop = false;
            this.picfApperance.Click += new System.EventHandler(this.picfApperance_Click);
            // 
            // fbStorage
            // 
            this.fbStorage.AutoSize = true;
            this.fbStorage.fieldName = "儲存方法";
            this.fbStorage.fieldValue = "";
            this.fbStorage.Location = new System.Drawing.Point(22, 611);
            this.fbStorage.Name = "fbStorage";
            this.fbStorage.Size = new System.Drawing.Size(843, 32);
            this.fbStorage.TabIndex = 11;
            // 
            // fbBrand
            // 
            this.fbBrand.AutoSize = true;
            this.fbBrand.fieldName = "廠牌";
            this.fbBrand.fieldValue = "";
            this.fbBrand.Location = new System.Drawing.Point(22, 713);
            this.fbBrand.Name = "fbBrand";
            this.fbBrand.Size = new System.Drawing.Size(843, 32);
            this.fbBrand.TabIndex = 13;
            // 
            // fbId_Drug
            // 
            this.fbId_Drug.fieldName = "fId";
            this.fbId_Drug.fieldValue = "";
            this.fbId_Drug.Location = new System.Drawing.Point(22, 49);
            this.fbId_Drug.Name = "fbId_Drug";
            this.fbId_Drug.Size = new System.Drawing.Size(843, 32);
            this.fbId_Drug.TabIndex = 1;
            // 
            // fbSupplier
            // 
            this.fbSupplier.AutoSize = true;
            this.fbSupplier.fieldName = "藥商";
            this.fbSupplier.fieldValue = "";
            this.fbSupplier.Location = new System.Drawing.Point(22, 662);
            this.fbSupplier.Name = "fbSupplier";
            this.fbSupplier.Size = new System.Drawing.Size(843, 32);
            this.fbSupplier.TabIndex = 12;
            // 
            // fbMaxDose
            // 
            this.fbMaxDose.fieldName = "最大劑量";
            this.fbMaxDose.fieldValue = "";
            this.fbMaxDose.Location = new System.Drawing.Point(22, 396);
            this.fbMaxDose.Name = "fbMaxDose";
            this.fbMaxDose.Size = new System.Drawing.Size(843, 32);
            this.fbMaxDose.TabIndex = 7;
            // 
            // fbPrecautions
            // 
            this.fbPrecautions.fieldName = "注意事項";
            this.fbPrecautions.fieldValue = "";
            this.fbPrecautions.Location = new System.Drawing.Point(22, 509);
            this.fbPrecautions.Name = "fbPrecautions";
            this.fbPrecautions.Size = new System.Drawing.Size(843, 32);
            this.fbPrecautions.TabIndex = 9;
            // 
            // fbWarnings
            // 
            this.fbWarnings.AutoSize = true;
            this.fbWarnings.fieldName = "禁忌";
            this.fbWarnings.fieldValue = "";
            this.fbWarnings.Location = new System.Drawing.Point(22, 560);
            this.fbWarnings.Name = "fbWarnings";
            this.fbWarnings.Size = new System.Drawing.Size(843, 32);
            this.fbWarnings.TabIndex = 10;
            // 
            // fbGenericName
            // 
            this.fbGenericName.fieldName = "學名";
            this.fbGenericName.fieldValue = "";
            this.fbGenericName.Location = new System.Drawing.Point(22, 145);
            this.fbGenericName.Name = "fbGenericName";
            this.fbGenericName.Size = new System.Drawing.Size(843, 32);
            this.fbGenericName.TabIndex = 3;
            // 
            // fbTradeName
            // 
            this.fbTradeName.fieldName = "商品名";
            this.fbTradeName.fieldValue = "";
            this.fbTradeName.Location = new System.Drawing.Point(22, 193);
            this.fbTradeName.Name = "fbTradeName";
            this.fbTradeName.Size = new System.Drawing.Size(843, 32);
            this.fbTradeName.TabIndex = 4;
            // 
            // fbDrugCode
            // 
            this.fbDrugCode.fieldName = "藥品代碼";
            this.fbDrugCode.fieldValue = "";
            this.fbDrugCode.Location = new System.Drawing.Point(22, 97);
            this.fbDrugCode.Name = "fbDrugCode";
            this.fbDrugCode.Size = new System.Drawing.Size(843, 32);
            this.fbDrugCode.TabIndex = 2;
            // 
            // fbDrugDose
            // 
            this.fbDrugDose.AutoSize = true;
            this.fbDrugDose.fieldName = "常用劑量";
            this.fbDrugDose.fieldValue = "";
            this.fbDrugDose.Location = new System.Drawing.Point(22, 339);
            this.fbDrugDose.Name = "fbDrugDose";
            this.fbDrugDose.Size = new System.Drawing.Size(843, 32);
            this.fbDrugDose.TabIndex = 6;
            // 
            // fbDrugName
            // 
            this.fbDrugName.fieldName = "中文名";
            this.fbDrugName.fieldValue = "";
            this.fbDrugName.Location = new System.Drawing.Point(22, 239);
            this.fbDrugName.Name = "fbDrugName";
            this.fbDrugName.Size = new System.Drawing.Size(843, 32);
            this.fbDrugName.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(1483, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(1628, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // FrmDrugEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1784, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDrugEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDrugEditor";
            this.Load += new System.EventHandler(this.FrmDrugEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picfImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfApperance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private View.FieldBox fbId_Drug;
        private View.FieldBox fbMaxDose;
        private View.FieldBox fbGenericName;
        private View.FieldBox fbTradeName;
        private View.FieldBox fbDrugCode;
        private View.FieldBox fbDrugDose;
        private View.FieldBox fbDrugName;
        private View.FieldBox fbStorage;
        private View.FieldBox fbBrand;
        private View.FieldBox fbSupplier;
        private View.FieldBox fbPrecautions;
        private View.FieldBox fbWarnings;
        private System.Windows.Forms.Label lblfImages;
        private System.Windows.Forms.PictureBox picfImages;
        private System.Windows.Forms.Label lblfApperance;
        private System.Windows.Forms.PictureBox picfApperance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbCUdetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbSEdetails;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}