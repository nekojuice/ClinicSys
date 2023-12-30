using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media.Animation;

namespace ClinicSys
{
    public class CCouponModel
    {

        ClinicSysEntities db = new ClinicSysEntities();
        public tCoupon selectedShipCoupon { get; set; }
        public tCoupon selectedDiscountCoupon { get; set; }

        public void create()
        {
            frmEmpCoupEditor frm = new frmEmpCoupEditor();
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;

            tCoupon c = new tCoupon();
            c.fName = frm.coupon.fName;
            c.fCategory = frm.coupon.fCategory;
            c.fValue = frm.coupon.fValue;
            c.fCriteria = frm.coupon.fCriteria;
            c.fStartDate = frm.coupon.fStartDate;
            c.fEndDate = frm.coupon.fEndDate;
            c.fDescription = frm.coupon.fDescription;
            c.fPicture = frm.coupon.fPicture;

            db.tCoupon.Add(c);
            db.SaveChanges();
        }

        public void deletebyCouponId(int couponId)
        {
            tCoupon coup = db.tCoupon.Where(c => c.Id == couponId).FirstOrDefault();
            db.tCoupon.Remove(coup);
            db.SaveChanges();
        }

        public void updatebyCouponId(int couponId)
        {
            tCoupon coup = new tCoupon();
            coup = db.tCoupon.Where(c => c.Id == couponId).FirstOrDefault();

            frmEmpCoupEditor frm = new frmEmpCoupEditor();
            frm.coupon = coup;
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;
            coup.fName = frm.coupon.fName;
            coup.fCategory = frm.coupon.fCategory;
            coup.fValue = frm.coupon.fValue;
            coup.fCriteria = frm.coupon.fCriteria;
            coup.fStartDate = frm.coupon.fStartDate;
            coup.fEndDate = frm.coupon.fEndDate;
            coup.fDescription = frm.coupon.fDescription;
            coup.fPicture = frm.coupon.fPicture;
            db.SaveChanges();
        }

        public tCoupon getCouponbyId(int couponId)
        {
            tCoupon c =db.tCoupon.FirstOrDefault(x => x.Id == couponId);
            return c;
        }

        public List<tCoupon> getCoupons()
        {
            return db.tCoupon.ToList();
        }

        public List<tCoupon> getCouponsbyKeyword(string keyword)
        {
            List<CEmpCouponViewModel> lstCoupon = new List<CEmpCouponViewModel>();
            return db.tCoupon.Where(c => c.fName.ToUpper().Contains(keyword.ToUpper()) || c.fValue.ToString().Contains(keyword.ToUpper()) || c.fDescription.ToUpper().Contains(keyword.ToUpper())).ToList();
        }


        public List<tCoupon> getActivatedCoupons()
        {
            return db.tCoupon.Where(x => (x.fEndDate > DateTime.Now) && (x.fStartDate <= DateTime.Now)).ToList();
        }

        public List<tCoupon> getExpiredorUsedCouponsbyMemberId(int memberId)
        {
            List<tCouponWallet> couponWallets = new CCouponWalletModel().getExpiredorUsedCouponwalletsbyMemberId(memberId);
            List<tCoupon> coupons = new List<tCoupon>();
            couponWallets.ForEach(w=>coupons.Add(w.tCoupon));
            return coupons;
        }

        public List<tCoupon> getNonTakedCoupons(int memberId)
        {
            List<tCoupon> coupons = new CCouponModel().getActivatedCoupons();
            List<tCouponWallet> mbrCouponWallets = new CCouponWalletModel().getActivatedCouponWalletsbyUserId(memberId);
            List<tCoupon> mbrCoupons = new List<tCoupon>();
            mbrCouponWallets.ForEach(w => mbrCoupons.Add(new CCouponModel().getCouponbyId(w.fCouponId)));
            foreach (tCoupon coupon in mbrCoupons)
                coupons.Remove(coupons.FirstOrDefault(c => c.Id == coupon.Id));
            return coupons;
        }


    }
}
