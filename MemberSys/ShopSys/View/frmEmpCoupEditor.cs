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
    public partial class frmEmpCoupEditor : Form
    {
        private tCoupon _coupon;
        public tCoupon coupon
        {
            get
            {
                if (_coupon == null)
                    _coupon = new tCoupon();
                _coupon.fName = this.userControlName.value;
                _coupon.fCategory = this.userControlComboBoxCatagory.value;
                _coupon.fValue = Convert.ToInt32(this.userControlTextValue.value);
                _coupon.fCriteria = Convert.ToInt32(this.userControlTextCriteria.value);
                _coupon.fStartDate = this.userControlDateTimePickerStartDate.value;
                _coupon.fEndDate = this.userControlDateTimePickerEndDate.value;
                _coupon.fDescription = this.userControlTextDescription.value;
                _coupon.fPicture = CUtility.getBytesbyPicture(this.pictureBox1);
                return _coupon;
            }
            set
            {
                _coupon = value;
                userControlName.value = value.fName;
                this.userControlComboBoxCatagory.value = value.fCategory;
                this.userControlTextValue.value = value.fValue.ToString();
                this.userControlTextCriteria.value = value.fCriteria.ToString();
                this.userControlDateTimePickerStartDate.value = value.fStartDate;
                this.userControlDateTimePickerEndDate.value = value.fEndDate;
                this.userControlTextDescription.value = value.fDescription;
                this.pictureBox1.Image = CUtility.getImagebyBytes(value.fPicture); 
            }
        }

        public frmEmpCoupEditor()
        {
            InitializeComponent();
            this.userControlComboBoxCatagory.items = new List<string>() { "免運券", "打折卷", "現金折價卷" };
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
            if (string.IsNullOrEmpty(userControlName.value))
                ErrorMsg += "(必填)優惠券名稱 \r\n";
            if (string.IsNullOrEmpty(userControlComboBoxCatagory.value))
                ErrorMsg += "(必選)優惠券種類 \r\n";
            if (!(int.TryParse(userControlTextValue.value, out i) && i > 0))
                ErrorMsg += "(必填)優惠值 [格式:正整數] \r\n";
            if (!(int.TryParse(userControlTextCriteria.value, out i) && i > 0))
                ErrorMsg += "(必填)需滿額值 [格式:正整數] \r\n";
            if (startDateTime > endDateTime)
                ErrorMsg += "(格式異常)生效日期晚於失效日期 \r\n";
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
