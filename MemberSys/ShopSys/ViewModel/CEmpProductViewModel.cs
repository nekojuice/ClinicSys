using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public class CEmpProductViewModel : ICRUD
    {
        private tProduct _product;
        private DataGridView _dataGridView;
        private CProductModel _prodcutModel = new CProductModel();
        private List<int> _productIds = new List<int>();
        private List<CEmpProductViewModel> _productViewModels = new List<CEmpProductViewModel>();

        public CEmpProductViewModel(tProduct p)
        {
            _product = p;
        }

        public CEmpProductViewModel() { }

        public byte[] 商品照片 { get { return _product.fPicture; } }
        public string 商品名稱 { get { return _product.fName; } }
        public string 商品分類 { get { return _product.fCategory; } }
        public string 商品價格 { get { return "$ " + _product.fPrice.ToString(); } }
        public string 上架日期 { get { return _product.fStartDate.ToShortDateString(); } }
        public string 下架日期 { get { return _product.fEndDate.ToShortDateString(); } }
        public string 商品描述 { get { return _product.fDescription; } }

        public void showAll()
        {
            reloadProductViewModels();
            resetDateGridView();
        }

        public void create()
        {
            frmEmpProdEditor frm = new frmEmpProdEditor();
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;

            tProduct product = new tProduct();
            product.fName = frm.product.fName;
            product.fCategory = frm.product.fCategory;
            product.fPrice = frm.product.fPrice;
            product.fStartDate = frm.product.fStartDate;
            product.fEndDate = frm.product.fEndDate;
            product.fDescription = frm.product.fDescription;
            product.fPicture = frm.product.fPicture;
            _prodcutModel.create(product);
            showAll();
            
        }

        public void delete()
        {
            int productId = _productIds[_dataGridView.CurrentRow.Index];
            _prodcutModel.deletebyId(productId);
            showAll();
        }

        public void update()
        {
            int currentProductId = _productIds[_dataGridView.CurrentRow.Index];
            frmEmpProdEditor frm = new frmEmpProdEditor();
            frm.product = new CProductModel().getproductbyId(currentProductId);
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;
            _prodcutModel.update(frm.product);
            showAll();
        }

        public void search(string keyword)
        {
            reloadProductViewModelsbyKeyword(keyword);
            resetDateGridView();
        }

        private void reloadProductViewModels()
        {
            _productViewModels.Clear();
            _productIds.Clear();
            List<tProduct> products = _prodcutModel.getProducts();
            products.ForEach(p => { _productViewModels.Add(new CEmpProductViewModel(p)); _productIds.Add(p.Id); });
        }

        private void reloadProductViewModelsbyKeyword(string keyword)
        {
            _productViewModels.Clear();
            _productIds.Clear();
            List<tProduct> products = _prodcutModel.getProductsbyKeyword(keyword);
            products.ForEach(p => { _productViewModels.Add(new CEmpProductViewModel(p)); _productIds.Add(p.Id); });
        }

        public void mountDateGridView(DataGridView grd)
        {
            _dataGridView = grd;
            showAll();
        }

        private void resetDateGridView()
        {
            _dataGridView.DataSource = null;
            _dataGridView.DataSource = _productViewModels;
        }

    }
}
