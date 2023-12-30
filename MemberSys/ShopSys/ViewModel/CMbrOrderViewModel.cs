using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;

namespace ClinicSys.ViewModel
{
    public class CMbrOrderViewModel
    {
        public string 訂單編號 { get; set; }
        public string 訂單金額 { get; set; }
        public string 付款方式 { get; set; }
        public string 購買時間 { get; set; }
        public string 收帳時間 { get; set; }
        public string 出貨時間 { get; set; }
        public string 收貨時間 { get; set; }

        [Browsable(false)]
        public List<tOrderDetail> orderDetails { get; set; }

        public List<CMbrOrderViewModel> getCMemberOrderViews(List<tOrder> orders)
        {
            List<CMbrOrderViewModel> memberOrderViewModels = new List<CMbrOrderViewModel>();
            foreach (tOrder order in orders)
            {
                CMbrOrderViewModel viewModel = new CMbrOrderViewModel();
                viewModel.訂單編號 = order.fOrderId;
                viewModel.訂單金額 = "$ " + order.fOrderPrice;
                viewModel.付款方式 = order.fPayType;
                viewModel.購買時間 = order.fOrderDate.ToString();
                string checkPayDate = order.fCheckPayDate.ToString();
                string shipDate = order.fShipDate.ToString();
                viewModel.收帳時間 = (string.IsNullOrEmpty(checkPayDate)) ? "待收帳" : order.fCheckPayDate.ToString();
                if (!string.IsNullOrEmpty(checkPayDate))
                {
                    viewModel.出貨時間 = (string.IsNullOrEmpty(order.fShipDate.ToString())) ? "待出貨" : order.fShipDate.ToString();
                    if (!string.IsNullOrEmpty(shipDate))
                    {
                        viewModel.收貨時間 = (string.IsNullOrEmpty(order.fGetDate.ToString()) ? "配送中" : order.fGetDate.ToString());
                    }
                }
                viewModel.orderDetails = new COrderDetailModel().GetOrderDetailsbyOrderId(order.Id);
                memberOrderViewModels.Add(viewModel);
            }
            return memberOrderViewModels;
        }
    }
}
