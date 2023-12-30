using Clinicsys;
using ClinicSys;
using ClinicSys.View;
using ClinicSys.ViewModel;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class frmMbrCoupon : Form
    {
        public frmMbrCoupon()
        {
            InitializeComponent();
        }

        List<CMbrCouponGetViewModel> mbrCouponViews;
        private void frmCoupon_Load(object sender, EventArgs e)
        {
            resetDataGridView_get();
            resetDataGridView_history();
        }

        private void resetDataGridView_history()
        {
            dataGridView_history.DataSource = null;
            List<CMbrCouponHistoryViewModel> mbrCouponHistoryViews = loadUsedandExpiredCoupons();
            dataGridView_history.DataSource = mbrCouponHistoryViews;
            label11.Text = "本期共使用：" + mbrCouponHistoryViews.Count() + " 張優惠券";
            int count = 0;
            foreach (CMbrCouponHistoryViewModel v in mbrCouponHistoryViews)
            {
                string discountPrice= v.訂單折扣金額.Substring(2);
                count += Convert.ToInt32(discountPrice);
            }
            label8.Text = "本期累計折抵 $ " + count.ToString() + " 元";
        }

        private List<tCoupon> _expiredorUsedCoupons;
        private List<CMbrCouponHistoryViewModel> loadUsedandExpiredCoupons()
        {
            _expiredorUsedCoupons = new CCouponModel().getExpiredorUsedCouponsbyMemberId(FrmMain._MEMBER.Member_ID);
            List<CMbrCouponHistoryViewModel> mbrCouponHistoryViews = new List<CMbrCouponHistoryViewModel>();
            _expiredorUsedCoupons.ForEach(c => mbrCouponHistoryViews.Add(new CMbrCouponHistoryViewModel(c)));
            return mbrCouponHistoryViews;
        }

        private void resetDataGridView_get()
        {
            dataGridView_get.Columns.Clear();
            dataGridView_get.DataSource = null;
            dataGridView_get.DataSource = loadNonTakedCoupons();
            DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
            bc.Text = "領取";
            bc.UseColumnTextForButtonValue = true;
            dataGridView_get.Columns.Add(bc);
        }

        private List<tCoupon> _unTakeCoupons;
        private List<CMbrCouponGetViewModel> loadNonTakedCoupons()
        {
            _unTakeCoupons = new CCouponModel().getNonTakedCoupons(FrmMain._MEMBER.Member_ID);
            List<CMbrCouponGetViewModel> mbrCouponGetViews = new List<CMbrCouponGetViewModel>();
            _unTakeCoupons.ForEach(c => mbrCouponGetViews.Add(new CMbrCouponGetViewModel(c)));
            return mbrCouponGetViews;
        }

        private void dataGridView_get_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "領取" && e.RowIndex >= 0)
            {
                //測試
                //MessageBox.Show("點擊" + "c:" + e.ColumnIndex + "r:" + e.RowIndex);
                int selectedCouponId = _unTakeCoupons[e.RowIndex].Id;
                new CCouponWalletModel().createCouponWalletbyCouponId(selectedCouponId);
                resetDataGridView_get();
            }

            if (dataGridView_get.Rows.Count == 0)
                MessageBox.Show("已全數領取完畢！");
        }

        private void dataGridView_get_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridView_get, 16,80);
        }

        private void dataGridView_history_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridView_history, 16,80);
        }
    }
}
