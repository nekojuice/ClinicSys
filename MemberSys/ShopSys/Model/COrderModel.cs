﻿using MemberSys;
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
        public void create(tOrder order, int orderPrice, int memberId, tCoupon shipCoupon, tCoupon discountCoupon)
        {
            //create order
            tOrder o = new tOrder();
            o.fOrderId = "TW-" + Guid.NewGuid().ToString().ToUpper().Substring(0, 6).Replace("-", "") + DateTime.Now.ToShortDateString().Replace("/", "");
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
            o.fMemberId = memberId;
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

            //create orderDetail
            int orderId = new COrderModel().getLastOrderIdbyMemberId(memberId);
            List<tCart> carts = new CCartModel().getCartsbyMemberId(memberId).ToList();
            List<tOrderDetail> orderDetails = new List<tOrderDetail>();
            foreach (tCart cart in carts)
            {
                tOrderDetail orderDetail = new tOrderDetail();
                orderDetail.fAmount = cart.fAmount;
                orderDetail.fOrderId = orderId;
                orderDetail.fProductId = cart.fProductId;
                orderDetails.Add(orderDetail);
            }
            db.tOrderDetail.AddRange(orderDetails);

            //delete cart
            db.tCart.RemoveRange(db.tCart.Where(c => c.fMemberId == memberId));
            db.SaveChanges();

            //update couponWallet's fUsed from false to true
            if (shipCoupon != null)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmParent._MEMBER.Member_ID, shipCoupon.Id);
                new CCouponWalletModel().useCoupon(couponWallet.Id);
            }
            if (discountCoupon != null)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmParent._MEMBER.Member_ID, discountCoupon.Id);
                new CCouponWalletModel().useCoupon(couponWallet.Id);
            }
        }

        public int getLastOrderIdbyMemberId(int memberId)
        {
            tOrder lastOrder = db.tOrder.Where(o => o.fMemberId == memberId).FirstOrDefault();
            return lastOrder.Id;
        }

        public List<tOrder> getOrdersbyMemberId(int memberId)
        {
            return db.tOrder.Where(o => o.fMemberId == memberId).OrderByDescending(o => o.Id).ToList();
        }

        public List<tOrder> getOrders()
        {
            return db.tOrder.OrderByDescending(o=>o.Id).ToList();
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

        public void deletebyId(int orderId)
        {
            tOrder order = db.tOrder.Where(o => o.Id == orderId).FirstOrDefault();
            int couponId_amount = (order.fCouponIdforAmount != null) ? Convert.ToInt32(order.fCouponIdforAmount) : -1;
            int couponId_percent = (order.fCouponIdforPercent != null) ? Convert.ToInt32(order.fCouponIdforPercent) : -1;
            int couponId_ship = (order.fCouponIdforShip != null) ? Convert.ToInt32(order.fCouponIdforShip) : -1;

            //delete orderDetail ;
            db.tOrderDetail.RemoveRange(order.tOrderDetail.ToList());
            db.SaveChanges();

            //delete order
            db.tOrder.Remove(order);
            db.SaveChanges();

            //update couponWallet's fUsed from ture to fasle
            if (couponId_amount != -1)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmParent._MEMBER.Member_ID, couponId_amount);
                new CCouponWalletModel().reliveCoupon(couponWallet.Id);
            }
            if (couponId_percent != -1)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmParent._MEMBER.Member_ID, couponId_percent);
                new CCouponWalletModel().reliveCoupon(couponWallet.Id);
            }
            if (couponId_ship != -1)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmParent._MEMBER.Member_ID, couponId_ship);
                new CCouponWalletModel().reliveCoupon(couponWallet.Id);
            }
        }

        public List<tOrder> getOrdersbyKeyword(string keyword)
        {
            return db.tOrder.Where(o => o.fOrderId.ToUpper().Contains(keyword.ToUpper())).ToList();
        }

        public DateTime? getShipDatebyOrderId(string orderId)
        {
            return db.tOrder.Where(o => o.fOrderId == orderId).FirstOrDefault().fShipDate;
        }
    }
}
