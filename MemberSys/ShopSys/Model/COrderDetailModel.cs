using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Media.Media3D;

namespace ClinicSys
{
    public class COrderDetailModel
    {
        ClinicSysEntities db = new ClinicSysEntities();
        public void createOrderDetailbyMemberId(int memberId)
        {
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
            db.SaveChanges();
        }

        public List<tOrderDetail> GetOrderDetailsbyOrderId(int orderId)
        {
           return db.tOrderDetail.Where(d=>d.fOrderId== orderId).ToList();
        }
    }
}
