using ClinicSys;
using ClinicSys.View;
using ClinicSys.ViewModel;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinicsys
{
    public partial class frmMbrOrder : Form
    {
        public frmMbrOrder()
        {
            InitializeComponent();
            setDataGridViewMemberOrder();
        }

        List<CMbrOrderViewModel> memberOrderViewModels;
        private void setDataGridViewMemberOrder()
        {
            dataGridViewMemberOrder.Columns.Clear();
            List<tOrder> orders = new COrderModel().getOrdersbyMemberId(FrmParent._MEMBER.Member_ID);
            memberOrderViewModels = new CMbrOrderViewModel().getCMemberOrderViews(orders);
            dataGridViewMemberOrder.DataSource = null;
            dataGridViewMemberOrder.DataSource = memberOrderViewModels;
            DataGridViewButtonColumn gcDetail = new DataGridViewButtonColumn();
            gcDetail.Text = "訂單詳細";
            gcDetail.UseColumnTextForButtonValue = true;
            dataGridViewMemberOrder.Columns.Add(gcDetail);
            DataGridViewButtonColumn gcPay = new DataGridViewButtonColumn();
            gcPay.Text = "付款資訊";
            gcPay.UseColumnTextForButtonValue = true;
            dataGridViewMemberOrder.Columns.Add(gcPay);
            DataGridViewButtonColumn gcReceiver = new DataGridViewButtonColumn();
            gcReceiver.Width = 150;
            gcReceiver.Text = "收貨";
            gcReceiver.UseColumnTextForButtonValue = true;
            dataGridViewMemberOrder.Columns.Add(gcReceiver);
        }

        private void dataGridViewMemberOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            //訂單詳細
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "訂單詳細" && e.RowIndex >= 0)
            {
                List<tOrderDetail> orderDetails = memberOrderViewModels[e.RowIndex].orderDetails;
                frmMsg frm = new frmMsg();
                frm.title = "訂單詳細";
                frm.msg = new CMbrBillViewModel().getBillDetailView(orderDetails);
                frm.ShowDialog();
            }
            //付款資訊
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "付款資訊" && e.RowIndex >= 0)
            {
                frmMsg frm = new frmMsg();
                frm.title = "付款資訊";
                frm.msg = new CMbrBillViewModel().getBillPayInfoView();
                frm.ShowDialog();
            }
            //收貨
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "收貨" && e.RowIndex >= 0)
            {
                string orderId = dataGridViewMemberOrder.Rows[e.RowIndex].Cells["訂單編號"].Value.ToString();
                if (new COrderModel().getShipDatebyOrderId(orderId)!=null && new COrderModel().updateGetDatebyOrderId(orderId))
                    MessageBox.Show("已收貨");
                else
                    MessageBox.Show("尚未出貨");
            }
            setDataGridViewMemberOrder();
        }

        private void dataGridViewMemberOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewMemberOrder, 14, 50);
            CStyle.setDataGridViewHieghtLightStyle(dataGridViewMemberOrder, "待收帳");
            CStyle.setDataGridViewHieghtLightStyle(dataGridViewMemberOrder, "配送中");
            CStyle.setDataGridViewHieghtLightStyle(dataGridViewMemberOrder, "待出貨");
        }
    }
}

