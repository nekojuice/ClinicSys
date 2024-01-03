using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys
{
    public class CBillModel
    {
        public int getShipDiscount(int cartsPrice, tCoupon coupon)
        {
            if (coupon != null)
                return (int)(cartsPrice * (coupon.fValue / 100));
            return 0;
        }

        public int getCashDiscount(int cartsPrice, tCoupon coupon)
        {
            if (coupon != null)
            {
                if (coupon.fCategory == "打折卷")
                    return (int)((cartsPrice * ((100 - coupon.fValue)) / 100));
                else
                    return coupon.fValue;
            }
            return 0;
        }

        public int getCartPrice(tOrder order)
        {
            int cartPrice = 0;
            foreach (tOrderDetail d in order.tOrderDetail)
            {
                cartPrice += d.tProduct.fPrice * d.fAmount;
            }
            return cartPrice;
        }

        public int getDiscountPricebyMemberIdandCouponId(int memberId, int couponId)
        {
            tOrder order = new ClinicSysEntities().tOrder.FirstOrDefault(o => o.fMemberId == memberId
                                                && (o.fCouponIdforAmount == couponId ||
                                                    o.fCouponIdforPercent == couponId ||
                                                    o.fCouponIdforShip == couponId));
            int cartPrice = getCartPrice(order);
            string couponCategory = new CCouponModel().getCategorybyId(couponId);


            if (couponCategory == "現金折價卷")
                return new CCouponModel().getCouponbyId(order.fCouponIdforAmount.Value).fValue;
            else if (couponCategory == "打折卷")
                return getCashDiscount(cartPrice, new CCouponModel().getCouponbyId(order.fCouponIdforPercent.Value));
            else
                return 120;
        }

    }
}
