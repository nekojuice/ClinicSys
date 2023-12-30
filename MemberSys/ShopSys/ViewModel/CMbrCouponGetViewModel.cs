using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys.ViewModel
{
    public class CMbrCouponGetViewModel
    {
        [Browsable(false)]
        public tCoupon coupon
        {
            set
            {
                照片 = value.fPicture;
                分類 = value.fCategory;
                說明 = value.fDescription;
            }
        }

        [Browsable(false)]
        public List<tCoupon> coupons { get; set; }

        public CMbrCouponGetViewModel(tCoupon coupon)
        {
            this.coupon = coupon;
        }

        public byte[] 照片 { get; set; }
        public string 分類 { get; set; }
        public string 說明 { get; set; }

    }
}
