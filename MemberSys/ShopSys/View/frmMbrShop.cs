using ClinicSys;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinicsys
{
    public partial class frmMbrShop : Form
    {
        private List<tProduct> _products;
        private tCoupon _selectedShipCoupon;
        private tCoupon _selectedDiscountCoupon;
        private int _finalPrice;

        public frmMbrShop()
        {
            _products = new CProductModel().getProducts();
            InitializeComponent();
            loadProducts();
            resetDataGridViewCart();
            resetDataGridViewBill();
        }

        private void loadProducts()
        {
            List<ccuserControlProduct> userControlProducts = new List<ccuserControlProduct>();

            foreach (tProduct product in _products)
            {
                ccuserControlProduct uc = new ccuserControlProduct(product);
                uc.onbtnClick_AddProdcuttoCart += showFrmCartEditor;
                userControlProducts.Add(uc);
            }
            flowLayoutPanel1.Controls.AddRange(userControlProducts.ToArray());
        }

        private void resetDataGridViewBill()
        {
            dataGridViewBill.DataSource = null;
            int cartsPrice = new CCartModel().caculateCartsPrice(FrmMain._MEMBER.Member_ID);
            dataGridViewBill.DataSource = new CMbrBillViewModel().getFrmShopDataGridViewBillView(cartsPrice,_selectedShipCoupon,_selectedDiscountCoupon, out _finalPrice);
        }

        private void resetDataGridViewCart()
        {
            List<CMbrCartViewModel> cartViewModels = new CMbrCartViewModel().getCartViewModelsbyMemberId(FrmMain._MEMBER.Member_ID);
            this.dataGridViewCart.DataSource = cartViewModels;
        }

        private void removeSelectedCoupons()
        {
            if (_selectedShipCoupon != null)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmMain._MEMBER.Member_ID, _selectedShipCoupon.Id);
                new CCouponWalletModel().useCoupon(couponWallet.Id);
                _selectedShipCoupon = null;
            }
            if (_selectedDiscountCoupon != null)
            {
                tCouponWallet couponWallet = new CCouponWalletModel().getCouponWalletbyMemberIdandCouponId(FrmMain._MEMBER.Member_ID, _selectedDiscountCoupon.Id);
                new CCouponWalletModel().useCoupon(couponWallet.Id);
                _selectedDiscountCoupon = null;
            }
        }

        private void showFrmCartEditor(tProduct product)
        {
            frmMbrCartEditor frm = new frmMbrCartEditor();
            int Amount = new CCartModel().getAmountfromCartbyProductIdandMemberId(product.Id, FrmMain._MEMBER.Member_ID);
            frm.count = (Amount == 0) ? "1" : Amount.ToString();
            frm.product = product;
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                int count = Convert.ToInt32(frm.count);
                if (new CCartModel().isProductExistinCart(product.Id, FrmMain._MEMBER.Member_ID))
                    new CCartModel().updateAmount(product.Id, count, FrmMain._MEMBER.Member_ID);
                else
                    new CCartModel().create(new tCart { fProductId = product.Id, fAmount = count, fMemberId = FrmMain._MEMBER.Member_ID });
            }
            if (dialogResult == DialogResult.No)
                new CCartModel().delete(product.Id, FrmMain._MEMBER.Member_ID);

            reset_selectedShipCoupon_selectedDiscountCoupon();
            resetDataGridViewCart();
            resetDataGridViewBill();
        }

        private void reset_selectedShipCoupon_selectedDiscountCoupon()
        {
            int cartsPrice = new CCartModel().caculateCartsPrice(FrmMain._MEMBER.Member_ID);
            if (_selectedShipCoupon != null && cartsPrice < _selectedShipCoupon.fCriteria)
                _selectedShipCoupon = null;
            if (_selectedDiscountCoupon != null && cartsPrice < _selectedDiscountCoupon.fCriteria)
                _selectedDiscountCoupon = null;
        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CMbrCartViewModel> cartViewModels = dataGridViewCart.DataSource as List<CMbrCartViewModel>;
            tProduct product = cartViewModels[e.RowIndex].cart.tProduct;
            showFrmCartEditor(product);
        }

        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            List<object> billViewModels = dataGridViewBill.DataSource as List<object>;
            frmMbrCheckBill frm = new frmMbrCheckBill();
            frm.billViewModels = billViewModels;
            frm.finalPrice = _finalPrice;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            new COrderModel().create(frm.order,_finalPrice, FrmMain._MEMBER.Member_ID, _selectedShipCoupon, _selectedDiscountCoupon);
            new COrderDetailModel().createOrderDetailbyMemberId(FrmMain._MEMBER.Member_ID);
            new CCartModel().deleteCartsbyMemberId(FrmMain._MEMBER.Member_ID);
            removeSelectedCoupons();
            resetDataGridViewCart();
            resetDataGridViewBill();
            if (frm.order.fPayType == "銀行轉帳")
                MessageBox.Show("已完成訂購，請於2日內完成轉帳付款。");
            else
                MessageBox.Show("已完成訂購，經盡快替您寄出。");
        }

        private void btnSelectCoupon_Click(object sender, EventArgs e)
        {
            frmMbrCouponSelector frm = new frmMbrCouponSelector();
            frm.memberId = FrmMain._MEMBER.Member_ID;
            frm.selectedShipCoupon = _selectedShipCoupon;
            frm.selectedDiscountCoupon = _selectedDiscountCoupon;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _selectedShipCoupon = frm.getSelectedShipCoupon();
                _selectedDiscountCoupon = frm.getSelectedDiscountCoupon();
            }
            resetDataGridViewBill();
        }

        private void dataGridViewCart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewCart,14, 55);
        }

        private void dataGridViewBill_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.SetDataGridViewRowStyle(dataGridViewBill, 14, 30);
        }
    }
}
