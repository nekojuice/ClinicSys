using Clinicsys;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class userControlCoupon : UserControl
    {
        public userControlCoupon(tCoupon coupon, bool isSelected)
        {
            InitializeComponent();
            this.coupon = coupon;
            this.isSelected = isSelected;
        }

        private tCoupon _coupon;
        public tCoupon coupon
        {
            get
            {
                return _coupon;
            }
            set
            {
                _coupon = value;
                pictureBox1.Image = CUtility.getImagebyBytes(_coupon.fPicture); ;
                lblName.Text = _coupon.fName;
                lblDescription.Text = _coupon.fDescription;
                lblDate.Text = _coupon.fEndDate.ToString("yyyy/MM/dd");
            }
        }

        private bool _isSelected;
        public bool isSelected
        {
            get
            {
                _isSelected = checkBox1.Checked;
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                checkBox1.Checked = _isSelected;
            }
        }

        public delegate void checkboxClickEventHandler(userControlCoupon ucsender);
        public event checkboxClickEventHandler onCheckboxClick;

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            onCheckboxClick(this as userControlCoupon);
        }
    }
}
