using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public class CCouponModel
    {

        ClinicSysEntities db = new ClinicSysEntities();

        public void create(tCoupon coupon)
        {        
            db.tCoupon.Add(coupon);
            db.SaveChanges();
        }

        public void update(tCoupon coupon)
        {
            tCoupon coup = new tCoupon();
            coup = db.tCoupon.Where(c => c.Id == coupon.Id).FirstOrDefault();
            coup.fName = coupon.fName;
            coup.fCategory = coupon.fCategory;
            coup.fValue = coupon.fValue;
            coup.fCriteria = coupon.fCriteria;
            coup.fStartDate = coupon.fStartDate;
            coup.fEndDate = coupon.fEndDate;
            coup.fDescription = coupon.fDescription;
            coup.fPicture = coupon.fPicture;
            db.SaveChanges();
        }
        public void deletebyId(int couponId)
        {
            tCoupon coup = db.tCoupon.Where(c => c.Id == couponId).FirstOrDefault();
            db.tCoupon.Remove(coup);
            db.SaveChanges();
        }

        public List<tCoupon> getCoupons()
        {
            return db.tCoupon.OrderByDescending(x=>x.Id).ToList();
        }

        public tCoupon getCouponbyId(int couponId)
        {
            tCoupon c =db.tCoupon.FirstOrDefault(x => x.Id == couponId);
            return c;
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

        public List<tCoupon> getExpiredorUsedCouponsbyMemberId(int memberId)
        {
            List<tCouponWallet> couponWallets = new CCouponWalletModel().getExpiredorUsedCouponwalletsbyMemberId(memberId);
            List<tCoupon> coupons = new List<tCoupon>();
            couponWallets.ForEach(w=>coupons.Add(w.tCoupon));
            return coupons;
        }

        public string getCategorybyId(int couponId)
        {
            return db.tCoupon.FirstOrDefault(c => c.Id == couponId).fCategory;
        }

    }
}
