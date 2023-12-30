using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class frmEmpProdEditor : Form
    {
        private tProduct _product;
        public tProduct product
        {
            get
            {
                if (_product == null)
                    _product = new tProduct();
                _product.fName = this.userControlTextName.value;
                _product.fCategory = this.userControlComboBoxCategory.value;
                _product.fPrice = Convert.ToInt32(this.userControlTextPrice.value);
                _product.fStartDate = this.userControlDateTimePickerStartDate.value;
                _product.fEndDate = this.userControlDateTimePickerEndDate.value;
                _product.fDescription = this.userControlTextDescription.value;
                _product.fPicture = CUtility.getBytesbyPicture(this.pictureBox1);
                return _product;
            }
            set
            {
                _product = value;
                userControlTextName.value = value.fName;
                this.userControlComboBoxCategory.value = value.fCategory;
                this.userControlTextPrice.value = value.fPrice.ToString();
                this.userControlDateTimePickerStartDate.value = value.fStartDate;
                this.userControlDateTimePickerEndDate.value = value.fEndDate;
                this.userControlTextDescription.value = value.fDescription;
                this.pictureBox1.Image = CUtility.getImagebyBytes (value.fPicture);
            }
        }


        public frmEmpProdEditor()
        {
            InitializeComponent();
            userControlComboBoxCategory.items = new List<string>() { "月子餐", "營養補給", "嬰兒早教", "美妝保養品" };
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string ErrorMsg = verifyForm();

            if (!string.IsNullOrEmpty(ErrorMsg))
            {
                MessageBox.Show(ErrorMsg);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private string verifyForm()
        {
            DateTime startDateTime = userControlDateTimePickerStartDate.value;
            DateTime endDateTime = userControlDateTimePickerEndDate.value;
            int i;

            string ErrorMsg = "";
            if (string.IsNullOrEmpty(userControlTextName.value))
                ErrorMsg += "(必填)商品名稱 \r\n";
            if (string.IsNullOrEmpty(userControlComboBoxCategory.value))
                ErrorMsg += "(必選)商品種類 \r\n";
            if (!(int.TryParse(userControlTextPrice.value, out i) && i > 0))
                ErrorMsg += "(必填)商品價格 [格式:正整數] \r\n";
            if (startDateTime > endDateTime)
                ErrorMsg += "(格式異常)上架日期晚於下架日期 \r\n";
            return ErrorMsg;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "新增商品圖片";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
