using MemberSys;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ClinicSys
{
    public class CMbrCouponHistoryViewModel
    {
        private tCoupon _coupon;

        [Browsable(false)]
        public tCoupon coupon
        {
            set
            {
                _coupon = value;
                照片 = _coupon.fPicture;
                分類 = _coupon.fCategory;
                說明 = _coupon.fDescription;
                狀態 = (new CCouponWalletModel().getCouponWalletsbymemberId(FrmMain._MEMBER.Member_ID).FirstOrDefault(w => w.fCouponId == _coupon.Id).fUsed) ? "已使用" : "已過期";
                訂單折扣金額 = (狀態 == "已過期") ? "0" : new CBillModel().getDiscountPricebyMemberIdandCouponId(FrmMain._MEMBER.Member_ID,_coupon.Id).ToString();
            }
            get
            {
                return _coupon;
            }
        }

        public CMbrCouponHistoryViewModel(tCoupon coupon)
        {
            this.coupon = coupon;
        }

        [Browsable(false)]
        public List<tCoupon> coupons { get; set; }

        public byte[] 照片 { get; set; }
        public string 分類 { get; set; }
        public string 說明 { get; set; }
        public string 狀態 { get; set; }

        private string _訂單折扣金額;
        public string 訂單折扣金額
        {
            get
            { 
                return "$ " + _訂單折扣金額;
            }
            set
            {
                _訂單折扣金額 = value;
            }
        }
    }
}