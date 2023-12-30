using MemberSys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Media.Animation;

namespace ClinicSys
{
    public class CCouponWalletModel
    {
        ClinicSysEntities db = new ClinicSysEntities();

        public List<tCouponWallet> getActivatedCouponWalletsbyUserId(int userId)
        {
            return db.tCouponWallet.Where(c => c.fMemberId == userId
                                            && c.tCoupon.fStartDate <= DateTime.Now
                                            && c.tCoupon.fEndDate > DateTime.Now).ToList(); ;
        }

        public List<tCouponWallet> getActivatedandNonUsedCouponWalletsbyUserId(int userId)
        {
            return db.tCouponWallet.Where(c => c.fMemberId == userId
                                            && c.fUsed == false
                                            && c.tCoupon.fStartDate <= DateTime.Now
                                            && c.tCoupon.fEndDate > DateTime.Now).ToList(); ;
        }

        public List<tCouponWallet> getCouponWalletsbymemberId(int memberId)
        {
            return db.tCouponWallet.Where(w => w.fMemberId == memberId).ToList();
        }
        public List<tCouponWallet> getActivatedandNonUsedShipCouponWalletsbyMemberId(int memberId)
        {
            return db.tCouponWallet.Where(w => w.fMemberId == memberId && w.tCoupon.fCategory == "免運券"
                                            && w.fUsed == false
                                            && w.tCoupon.fEndDate > DateTime.Now
                                            && w.tCoupon.fStartDate <= DateTime.Now).ToList();
        }
        public List<tCouponWallet> getActivatedandNonUsedDiscountCouponWalletsbyMemberId(int memberId)
        {
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            return db.tCouponWallet.Where(w => w.fMemberId == memberId && w.tCoupon.fCategory != "免運券"
                                            && w.fUsed == false
                                            && w.tCoupon.fEndDate > DateTime.Now
                                            && w.tCoupon.fStartDate <= DateTime.Now).ToList();
        }

        public List<tCouponWallet> getExpiredorUsedCouponwalletsbyMemberId(int memberId)
        {
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            return db.tCouponWallet.Where(w => w.fMemberId == memberId 
                                            && (w.tCoupon.fEndDate < DateTime.Now || w.fUsed==true)).ToList();
        }


        public void useCoupon(int couponWalletId)
        {
            tCouponWallet couponWallet = db.tCouponWallet.Where(w => w.Id == couponWalletId).FirstOrDefault();
            couponWallet.fUsed = true;
            db.SaveChanges();
        }
        public void create(tCouponWallet couponWallet)
        {
            db.tCouponWallet.Add(couponWallet);
            db.SaveChanges();
        }

        public tCouponWallet getCouponWalletbyMemberIdandCouponId(int memberId, int couponId)
        {
            return db.tCouponWallet.Where(w => w.fMemberId == memberId && w.fCouponId == couponId).FirstOrDefault();
        }

        public void createCouponWalletbyCouponId(int selectedCouponId)
        {
            db.tCouponWallet.Add(new tCouponWallet { fCouponId = selectedCouponId , fUsed = false, fMemberId = FrmMain._MEMBER.Member_ID});
            db.SaveChanges();
        }


    }
}
