using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public class CProductModel
    {
        ClinicSysEntities db= new ClinicSysEntities();
        public void create()
        {
            frmEmpProdEditor frm = new frmEmpProdEditor();
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;

            tProduct p = new tProduct();
            p.fName = frm.product.fName;
            p.fCategory = frm.product.fCategory;
            p.fPrice = frm.product.fPrice;
            p.fStartDate = frm.product.fStartDate;
            p.fEndDate = frm.product.fEndDate;
            p.fDescription = frm.product.fDescription;
            p.fPicture = frm.product.fPicture;

            db.tProduct.Add(p);
            db.SaveChanges();
        }

        public void deletebyProductId(int productId)
        {
            tProduct prod = db.tProduct.Where(p => p.Id == productId).FirstOrDefault();
            db.tProduct.Remove(prod);
            db.SaveChanges();
        }

        public void updatebyProductId(int productId)
        {
            tProduct prod = new tProduct();
            prod = db.tProduct.Where(p => p.Id == productId).FirstOrDefault();
            frmEmpProdEditor frm = new frmEmpProdEditor();
            frm.product = prod;
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;
            prod.fName = frm.product.fName;
            prod.fCategory = frm.product.fCategory;
            prod.fPrice = frm.product.fPrice;
            prod.fStartDate = frm.product.fStartDate;
            prod.fEndDate = frm.product.fEndDate;
            prod.fDescription = frm.product.fDescription;
            prod.fPicture = frm.product.fPicture;
            db.SaveChanges();
        }

        public List<tProduct> getProducts()
        {
            return db.tProduct.Where(x => (x.fEndDate > DateTime.Now) && (x.fStartDate <= DateTime.Now)).ToList();
        }

        public List<tProduct> getProductsbyKeyword(string keyword)
        {
            List<CEmpProductViewModel> lstCoupon = new List<CEmpProductViewModel>();
            return db.tProduct.Where(p => p.fName.ToUpper().Contains(keyword.ToUpper()) || p.fDescription.ToUpper().Contains(keyword.ToUpper())).ToList();
        }
    }
}
