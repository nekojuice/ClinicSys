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
        private DataGridView dataGridView;
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
        public DateTime 上架日期 { get { return _product.fStartDate; } }
        public DateTime 下架日期 { get { return _product.fEndDate; } }
        public string 商品描述 { get { return _product.fDescription; } }

        public void ShowAll()
        {
            reloadProductViewModels();
            resetDateGridView();
        }

        public void Create()
        {
            _prodcutModel.create();
            ShowAll();
        }

        public void Delete()
        {
            int productId = _productIds[dataGridView.CurrentRow.Index];
            _prodcutModel.deletebyProductId(productId);
            ShowAll();
        }


        public void Update()
        {
            int currentProductId = _productIds[dataGridView.CurrentRow.Index];
            _prodcutModel.updatebyProductId(currentProductId);
            ShowAll();
        }

        public void Search(string keyword)
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
            dataGridView = grd;
            ShowAll();
        }

        private void resetDateGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _productViewModels;
        }
    }
}
