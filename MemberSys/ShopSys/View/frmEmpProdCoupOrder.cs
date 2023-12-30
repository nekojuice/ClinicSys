using ClinicSys.View;
using ClinicSys.ViewModel;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class frmEmpProdCoupOrder : Form
    {
        ICRUD _managerforActiveTabpage;
        public frmEmpProdCoupOrder()
        {
            InitializeComponent();
            _managerforActiveTabpage = new CEmpProductViewModel();
            _managerforActiveTabpage.mountDateGridView(dataGridViewProduct);
        }

        private void TSBAll_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage.ShowAll();
        }
        private void TSBCreate_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage.Create();
        }

        private void TSBDelete_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage.Delete();
        }

        private void TSBUpdate_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage.Update();
        }

        private void TSBSearch_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage.Search(this.txtKeyword.Text);
        }

        private void btnProductEditor_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage = new CEmpProductViewModel();
            _managerforActiveTabpage.mountDateGridView(dataGridViewProduct);
            tabManager.SelectedIndex = 0;
        }

        private void btnCouponEditor_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage = new CEmpCouponViewModel();
            _managerforActiveTabpage.mountDateGridView(dataGridViewCoupon);
            tabManager.SelectedIndex = 1;
        }

        private void btnOrderEditor_Click(object sender, EventArgs e)
        {
            _managerforActiveTabpage = new CEmpOrderViewModel();
            _managerforActiveTabpage.mountDateGridView(dataGridViewOrder);
            tabManager.SelectedIndex = 2;
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string orderId = senderGrid.CurrentRow.Cells["訂單編號"].Value.ToString();

            //收件資訊
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "收件資訊" && e.RowIndex >= 0)
            {
                tOrder order = new COrderModel().getOrderbyOrderId(orderId);
                frmMsg frm = new frmMsg();
                frm.title = "收件資訊";
                string receiverMsg = new CEmpOrderViewModel().getFrmMagforReceiverInfoView(order);
                frm.msg = receiverMsg;
                frm.ShowDialog();
            }
            //收款
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "收帳" && e.RowIndex >= 0)
            {
                new COrderModel().updateCheckPayDatebyOrderId(orderId);
                MessageBox.Show("已收帳");
                _managerforActiveTabpage = new CEmpOrderViewModel();
                _managerforActiveTabpage.mountDateGridView(dataGridViewOrder);
                tabManager.SelectedIndex = 2;
            }
            //出貨
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "出貨" && e.RowIndex >= 0)
            {
                if (new COrderModel().updateShipDatebyOrderId(orderId))
                {
                    MessageBox.Show("已出貨");
                    _managerforActiveTabpage = new CEmpOrderViewModel();
                    _managerforActiveTabpage.mountDateGridView(dataGridViewOrder);
                    tabManager.SelectedIndex = 2;
                }
                else
                    MessageBox.Show("尚未收帳");
            }
        }


        private void dataGridViewProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewProduct, 14, 90);
        }

        private void dataGridViewCoupon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewCoupon, 14, 90);
        }

        private void dataGridViewOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewOrder, 12, 55);
            CStyle.setDataGridViewHieghtLightStyle(dataGridViewOrder, "未收帳");
            CStyle.setDataGridViewHieghtLightStyle(dataGridViewOrder, "未出貨");
            CStyle.setDataGridViewHieghtLightStyle(dataGridViewOrder, "配送中");
        }
    }
}
