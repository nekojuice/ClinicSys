using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media.TextFormatting;

namespace ClinicSys.ViewModel
{
    public class CEmpOrderViewModel : ICRUD
    {
        private tOrder _order;
        private DataGridView dataGridView;
        private COrderModel _orderModel = new COrderModel();
        private List<int> _orderIds = new List<int>();
        private List<CEmpOrderViewModel> _employeeOrderViewModels = new List<CEmpOrderViewModel>();

        public CEmpOrderViewModel(tOrder order)
        {
            this._order = order;
        }

        public CEmpOrderViewModel() { }

        [Browsable(false)]
        public tOrder order { get; set; }
        public string 訂單編號 { get { return _order.fOrderId; } }
        public string 金額 { get { return "$" + _order.fOrderPrice; } }
        public string 購買時間 { get { return _order.fOrderDate.ToString(); } }
        public string 付款方式 { get { return _order.fPayType; } }
        public string 末5碼 { get { return _order.fAccountFiveNumber; } }

        public string 收賬時間
        {
            get
            {
                if (string.IsNullOrEmpty(_order.fCheckPayDate.ToString()))
                    return "未收帳";
                else return _order.fCheckPayDate.ToString();
            }
        }
        public string 出貨時間
        {
            get
            {
                if (string .IsNullOrEmpty(_order.fCheckPayDate.ToString()))
                    return "";
                else if (string.IsNullOrEmpty(_order.fShipDate.ToString()))
                    return "未出貨";
                else return _order.fShipDate.ToString();
            }
        }
        public string 收貨時間
        {
            get
            {
                if (_order.fGetDate> DateTime.Now)
                    return "配送中";
                else return _order.fGetDate.ToString();
            }
        }


        public void Create()
        {
            MessageBox.Show("使用Admin帳號，由會員介面下訂。");
        }

        public void Delete()
        {
            int orderId = _orderIds[dataGridView.CurrentRow.Index];
            _orderModel.deletebyOrderId(orderId);
            ShowAll();
        }

        public void Search(string keyword)
        {
            reloadEmployeeOrderViewModelsbyKeyword(keyword);
            resetDateGridView();
        }

        public void ShowAll()
        {
            reloadEmployeeOrderViewModels();
            resetDateGridView();
        }

        public void Update()
        {
            MessageBox.Show("無法編輯已成立訂單，請刪除後重新下訂。");
        }
        public void mountDateGridView(DataGridView grd)
        {
            dataGridView = grd;
            ShowAll();
        }

        private void reloadEmployeeOrderViewModelsbyKeyword(string keyword)
        {
            _employeeOrderViewModels.Clear();
            _orderIds.Clear();
            List<tOrder> orders = _orderModel.getOrdersbyKeyword(keyword);
            orders.ForEach(o => { _employeeOrderViewModels.Add(new CEmpOrderViewModel(o)); _orderIds.Add(o.Id); });
        }


        private void reloadEmployeeOrderViewModels()
        {
            _employeeOrderViewModels.Clear();
            _orderIds.Clear();
            List<tOrder> orders = _orderModel.getOrders();
            orders.ForEach(o => { _employeeOrderViewModels.Add(new CEmpOrderViewModel(o)); _orderIds.Add(o.Id); });
        }

        private void resetDateGridView()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;
            dataGridView.DataSource = _employeeOrderViewModels;
            DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
            bc.Text = "收件資訊";
            bc.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(bc);
            bc=new DataGridViewButtonColumn();
            bc.Text = "收帳";
            bc.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(bc);
            bc = new DataGridViewButtonColumn();
            bc.Text = "出貨";
            bc.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(bc);
        }

        public string getFrmMagforReceiverInfoView(tOrder order)
        {
            string msg = "";
            msg += "收件人姓名: " + order.fReceiverName + "\r\n";
            msg += "收件人手機: " + order.fReceiverPhone + "\r\n";
            msg += "收件地址: " + order.fReceiverAddress + "\r\n";
            msg += "---------------------------------- \r\n";
            msg += "物流公司: 嘉里大榮物流股份有限公司" + "\r\n";
            msg += "物流電話: 0800-660-868" + "\r\n";
            msg += "---------------------------------- \r\n";
            ClinicSysEntities db = new ClinicSysEntities();
            Member_MemberList member = db.Member_MemberList.FirstOrDefault(m => m.Member_ID == order.fMemberId);
            msg += "訂購人姓名: " + member.Name + "\r\n";
            msg += "訂購人手機: " + member.Phone + "\r\n";
            return msg;
        }
    }
}
