using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys
{
    public class COrderDetailModel
    {
        ClinicSysEntities db = new ClinicSysEntities();

        public List<tOrderDetail> GetOrderDetailsbyOrderId(int orderId)
        {
           return db.tOrderDetail.Where(d=>d.fOrderId== orderId).ToList();
        }
    }
}
