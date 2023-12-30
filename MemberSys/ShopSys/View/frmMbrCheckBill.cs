using Clinicsys;
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

namespace ClinicSys
{
    public partial class frmMbrCheckBill : Form
    {
        private tOrder _order;
        public tOrder order
        {
            get
            {
                if (_order == null)
                    _order = new tOrder();
                _order.fReceiverName = this.userControlTextName.value;
                _order.fReceiverPhone = this.userControlTextPhone.value;
                _order.fReceiverAddress = this.userControlTextAddress.value;
                _order.fMemo = this.userControlTextMemo.value;
                _order.fPayType = this.userControlComboBoxPayType.value;
                _order.fAccountFiveNumber = this.userControlTextAccountFriveNumber.value;
                _order.fShipType = this.userControlComboShipType.value;
                _order.fOrderPrice = Convert.ToInt32( this.lblFinialPrice.Text);
                _order.fShipPrice = 120;
                return _order;
            }
        }

        public int finalPrice { set { lblFinialPrice.Text = value.ToString(); } }
        private List<object> _billViewModels;
        public List<object> billViewModels
        {
            get { return _billViewModels; }
            set
            {
                _billViewModels = value;
                dataGridViewCheckBill.DataSource = _billViewModels;
            }
        }

        public frmMbrCheckBill()
        {
            InitializeComponent();
            userControlComboShipType.items = new List<string>() { "賣家宅配" };
            userControlComboBoxPayType.items = new List<string>() { "貨到付款", "銀行轉帳" };
            userControlComboBoxPayType.onSelectedChange += setStarStatus;
        }

        private void setStarStatus()
        {
            if (this.userControlComboBoxPayType.value == "銀行轉帳")
            {
                this.userControlTextAccountFriveNumber.showStar = true;
                this.userControlTextAccountFriveNumber.Enabled = true;
            }
            else
            {
                this.userControlTextAccountFriveNumber.showStar = false;
                this.userControlTextAccountFriveNumber.Enabled = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridViewCheckBill_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewCheckBill, 14, 35);
        }
    }
}
