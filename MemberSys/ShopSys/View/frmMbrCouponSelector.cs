using Clinicsys;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class frmMbrCouponSelector : Form
    {
        public frmMbrCouponSelector()
        {
            InitializeComponent();
        }

        private int _memberId;
        public int memberId
        {
            set
            {
                _memberId = value;
                loadCouponList(_memberId);
            }
        }

        private tCoupon _selectedShipCoupon;
        public tCoupon selectedShipCoupon
        {
            set
            {
                _selectedShipCoupon = value;
                setCheckboxSelectedbyCoupon(_selectedShipCoupon);
            }
        }
        private tCoupon _selectedDiscountCoupon;
        public tCoupon selectedDiscountCoupon
        {
            set
            {
                _selectedDiscountCoupon = value;
                setCheckboxSelectedbyCoupon(_selectedDiscountCoupon);
            }
        }

        private void checkCritiria( userControlCoupon ucsender)
        {
            int cartPrice = new CCartModel().caculateCartsPrice(_memberId);
            if (cartPrice < ucsender.coupon.fCriteria)
            {
                ucsender.isSelected = false;
                MessageBox.Show("未達低消$ "+ ucsender.coupon.fCriteria);
            }
            else
            {
                if (ucsender.coupon.fCategory == "免運券")
                    setAllShipCouponNonSelected();
                else
                    setAllDiscountCouponNonSelected();
                ucsender.isSelected = true;
            }
        }

        private void loadCouponList(int memberId)
        {
            flowLayoutPanel1.Controls.Add(new userControlCategoryHeader("運費抵用券"));
            List<tCouponWallet> couponwallets_ship = new CCouponWalletModel().getActivatedandNonUsedShipCouponWalletsbyMemberId(memberId);
            foreach (tCouponWallet couponwallet in couponwallets_ship)
            {
                userControlCoupon uc = new userControlCoupon(couponwallet.tCoupon, false);
                uc.onCheckboxClick += checkCritiria;
                flowLayoutPanel1.Controls.Add(uc);
            }

            flowLayoutPanel1.Controls.Add(new userControlCategoryHeader("折扣抵用券"));
            List<tCouponWallet> couponwallets_discount = new CCouponWalletModel().getActivatedandNonUsedDiscountCouponWalletsbyMemberId(memberId);
            foreach (tCouponWallet couponwallet in couponwallets_discount)
            {
                userControlCoupon uc = new userControlCoupon(couponwallet.tCoupon, false);
                uc.onCheckboxClick += checkCritiria;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void setCheckboxSelectedbyCoupon(tCoupon coupon)
        {
            if (coupon is null)
                return;
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is userControlCoupon)
                {
                    userControlCoupon uc = control as userControlCoupon;
                    if (uc.coupon.Id == coupon.Id)
                        uc.isSelected = true;
                }
            }
        }

        private void setAllShipCouponNonSelected()
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is userControlCoupon)
                {
                    userControlCoupon uc = control as userControlCoupon;
                    if (uc.coupon.fCategory == "免運券")
                        uc.isSelected = false;
                }
            }
        }

        private void setAllDiscountCouponNonSelected()
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is userControlCoupon)
                {
                    userControlCoupon uc = control as userControlCoupon;
                    if (uc.coupon.fCategory != "免運券")
                        uc.isSelected = false;
                }
            }
        }

        public tCoupon getSelectedShipCoupon()
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is userControlCoupon)
                {
                    userControlCoupon uc = control as userControlCoupon;
                    if ((uc.coupon.fCategory == "免運券") && (uc.isSelected == true))
                    {
                        return uc.coupon;
                    }
                }
            }
            return null;
        }

        public tCoupon getSelectedDiscountCoupon()
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is userControlCoupon)
                {
                    userControlCoupon uc = control as userControlCoupon;
                    if ((uc.coupon.fCategory != "免運券") && (uc.isSelected == true))
                    {
                        return uc.coupon;
                    }
                }
            }
            return null;
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
