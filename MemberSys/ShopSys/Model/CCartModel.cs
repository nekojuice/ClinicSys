using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys
{
    public class CCartModel
    {
        ClinicSysEntities db = new ClinicSysEntities();
        public int getAmountfromCartbyProductIdandMemberId(int productid, int memberId)
        {
            int Amount = 0;
            if (db.tCart.Where(c => c.fProductId == productid && c.fMemberId == memberId).Count()>0)
                Amount= db.tCart.Where(c => c.fProductId == productid && c.fMemberId == memberId).FirstOrDefault().fAmount;
            return Amount;
        }

        public List<tCart> getCartsbyMemberId(int memberId)
        {
            return db.tCart.Where(c => c.fMemberId == memberId).ToList();
        }

        public int caculateCartsPrice(int memberId)
        {
            int cartsPrice = 0;
            if (db.tCart.Where(c => c.fMemberId == memberId).Count() > 0)
                cartsPrice = db.tCart.Where(c => c.fMemberId == memberId).Sum(c => c.tProduct.fPrice * c.fAmount);
            return cartsPrice;
        }

        public bool isProductExistinCart(int productId, int memberId)
        {
            if (db.tCart.Count(c => c.fProductId == productId && c.fMemberId == memberId) == 1)
                return true;
            else
                return false;
        }

        public void create(tCart cart)
        {
            db.tCart.Add(cart);
            db.SaveChanges();
        }

        public void updateAmount(int productId, int amount, int memberId)
        {
            tCart cart = db.tCart.Where(c => c.fProductId == productId && c.fMemberId == memberId).FirstOrDefault();
            cart.fAmount = amount;
            db.SaveChanges();
        }

        public void delete(int productId, int memberId)
        {
            tCart cart= db.tCart.Where(c => c.fProductId == productId && c.fMemberId == memberId).FirstOrDefault();
            db.tCart.Remove(cart);
            db.SaveChanges();
        }

        public void deleteCartsbyMemberId(int memberId)
        {
            db.tCart.RemoveRange(db.tCart.Where(c => c.fMemberId == memberId));
            db.SaveChanges();
        }
    }
}
