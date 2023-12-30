using MemberSys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys
{
    public class COrderModel
    {
        ClinicSysEntities db = new ClinicSysEntities();
        public void create(tOrder order, int orderPrice, int userId, tCoupon shipCoupon, tCoupon discountCoupon)
        {
            tOrder o = new tOrder();
            o.fOrderId = "TW" + Guid.NewGuid().ToString().ToUpper().Substring(0, 13).Replace("-", "") + DateTime.Now.ToShortDateString().Replace("/", "");
            o.fOrderDate = DateTime.Now;
            o.fCheckPayDate = order.fCheckPayDate;
            o.fShipDate = order.fShipDate;
            o.fOrderPrice = order.fOrderPrice;
            o.fShipPrice = 120;
            o.fReceiverName = order.fReceiverName;
            o.fReceiverPhone = order.fReceiverPhone;
            o.fReceiverAddress = order.fReceiverAddress;
            o.fMemo = order.fMemo;
            o.fAccountFiveNumber = order.fAccountFiveNumber;
            o.fPayType = order.fPayType;
            o.fShipType = order.fShipType;
            o.fMemberId = userId;
            if (shipCoupon != null)
                o.fCouponIdforShip = shipCoupon.Id;
            if (discountCoupon != null)
            {
                if (discountCoupon.fCategory == "打折卷")
                    o.fCouponIdforPercent = discountCoupon.Id;
                else
                    o.fCouponIdforAmount = discountCoupon.Id;
            }
            db.tOrder.Add(o);
            db.SaveChanges();
        }

        public int getLastOrderIdbyMemberId(int memberId)
        {
            tOrder lastOrder = db.tOrder.Where(o => o.fMemberId == memberId).OrderByDescending(o => o.Id).FirstOrDefault();
            return lastOrder.Id;
        }

        public List<tOrder> getOrdersbyMemberId(int memberId)
        {
            return db.tOrder.Where(o => o.fMemberId == memberId).ToList();
        }

        public List<tOrder> getOrders()
        {
            return db.tOrder.ToList();
        }

        public tOrder getOrderbyOrderId(string orderId)
        {
            return db.tOrder.FirstOrDefault(o => o.fOrderId == orderId);
        }

        public void updateCheckPayDatebyOrderId(string orderId)
        {
            tOrder order = db.tOrder.FirstOrDefault(o => o.fOrderId == orderId);
            order.fCheckPayDate = DateTime.Now;
            db.SaveChanges();
        }

        public bool updateGetDatebyOrderId(string orderId)
        {
            tOrder order = db.tOrder.FirstOrDefault(o => o.fOrderId == orderId);
            if (order.fShipDate == null)
                return false;
            else
            {
                order.fGetDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }

        }

        public bool updateShipDatebyOrderId(string orderId)
        {
            tOrder order = db.tOrder.FirstOrDefault(o => o.fOrderId == orderId);
            if (order.fCheckPayDate == null)
                return false;
            else
            {
                order.fShipDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }
        }

        public void deletebyOrderId(int orderId)
        {
            tOrder order = db.tOrder.Where(o => o.Id == orderId).FirstOrDefault();
            List<tOrderDetail> orderDetails = order.tOrderDetail.ToList();
            db.tOrderDetail.RemoveRange(orderDetails);
            db.SaveChanges();
            db.tOrder.Remove(order);
            db.SaveChanges();
        }

        public List<tOrder> getOrdersbyKeyword(string keyword)
        {
            return db.tOrder.Where(o => o.fOrderId.ToUpper().Contains(keyword.ToUpper())).ToList();
        }

        public DateTime? getShipDatebyOrderId(string orderId)
        {
            return db.tOrder.Where(o=>o.fOrderId==orderId).FirstOrDefault().fShipDate;
        }
    }
}
