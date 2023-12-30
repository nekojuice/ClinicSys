using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys
{
    public class CMbrBillViewModel
    {
        CBillModel billModel = new CBillModel();
        public List<object> getFrmShopDataGridViewBillView(int cartsPrice, tCoupon shipCoupon, tCoupon discountCoupon, out int finalPrice)
        {
            List<object> _lstBill = new List<object>();

            int shipPrice = (cartsPrice == 0) ? 0 : 120;
            int shipDiscount = billModel.getShipDiscount(shipPrice, shipCoupon);
            int cashDiscount = billModel.getCashDiscount(cartsPrice, discountCoupon);

            finalPrice = cartsPrice + shipPrice - shipDiscount - cashDiscount;
            if (cartsPrice != 0)
                _lstBill.Add(new { 項目 = "小計", 金額 = "$ " + cartsPrice });
            if (shipPrice != 0)
                _lstBill.Add(new { 項目 = "運費", 金額 = "$ " + shipPrice });
            if (shipDiscount != 0)
                _lstBill.Add(new { 項目 = "運費折扣", 金額 = "-$ " + shipDiscount });
            if (cashDiscount != 0)
                _lstBill.Add(new { 項目 = "現金優惠", 金額 = "-$ " + cashDiscount });
            if (cartsPrice != 0)
            {
                _lstBill.Add(new { 項目 = "==============", 金額 = "" });
                _lstBill.Add(new { 項目 = "訂單金額", 金額 = "$ " + finalPrice });
            }
            return _lstBill;
        }

        public string getBillDetailView(List<tOrderDetail> orderDetails)
        {

            tOrder order = orderDetails[0].tOrder;
            int cartPrice = billModel.getCartPrice(order);
            int shipDiscount = 0;
            if (order.fCouponIdforShip != null)
                shipDiscount = billModel.getShipDiscount(order.fShipPrice, new CCouponModel().getCouponbyId((int)order.fCouponIdforShip));

            int percentDiscount = 0;
            if (order.fCouponIdforPercent != null)
                percentDiscount = billModel.getCashDiscount(cartPrice, new CCouponModel().getCouponbyId((int)order.fCouponIdforPercent));

            int amountDiscount = 0;
            if (order.fCouponIdforAmount != null)
                amountDiscount = billModel.getCashDiscount(cartPrice, new CCouponModel().getCouponbyId((int)order.fCouponIdforAmount));

            string msg = "";
            foreach (var d in orderDetails)
                msg += "商品:" + d.tProduct.fName + "  數量:" + d.fAmount + "\r\n";
            msg += "---------------------------------- \r\n";
            msg += "商品小計: $" + cartPrice + "\r\n";
            msg += "運費: $" + order.fShipPrice + "\r\n";
            if (shipDiscount != 0)
                msg += "免運券折扣: -$" + shipDiscount + "\r\n";
            if (percentDiscount != 0)
                msg += "打折券折扣: -$" + percentDiscount + "\r\n";
            if (amountDiscount != 0)
                msg += "現金券折扣: -$" + amountDiscount + "\r\n";
            msg += "---------------------------------- \r\n";
            msg += "訂單金額: $" + order.fOrderPrice;

            return msg;
        }

        public string getBillPayInfoView()
        {
            string msg = "";
            msg += "【銀行轉帳】 \r\n";
            msg += "戶名：禾芯婦幼照護體系 \r\n";
            msg += "銀行名稱：彰化商業銀行股份有限公司 \r\n";
            msg += "分行名稱：西內湖分行 \r\n";
            msg += "銀行代碼：009  \r\n";
            msg += "銀行帳號：989051-22997-356 \r\n";
            msg += "(商城將於一個工作日內由專人確認收帳) \r\n";

            msg += "---------------------------------- \r\n";
            msg += "【貨到付款】 \r\n";
            msg += "請於物流收貨時付款。 \r\n";
            msg += "物流公司: 嘉里大榮物流股份有限公司" + "\r\n";
            msg += "物流電話: 0800-660-868" + "\r\n";
            return msg;
        }
    }


}
