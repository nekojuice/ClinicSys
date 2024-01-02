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
        public void create(tProduct product)
        { 
            db.tProduct.Add(product);
            db.SaveChanges();
        }

        public void deletebyId(int productId)
        {
            tProduct prod = db.tProduct.Where(p => p.Id == productId).FirstOrDefault();
            db.tProduct.Remove(prod);
            db.SaveChanges();
        }

        public void update(tProduct product)
        {
            tProduct prod = new tProduct();
            prod = db.tProduct.Where(p => p.Id == product.Id).FirstOrDefault();
            prod.fName = product.fName;
            prod.fCategory = product.fCategory;
            prod.fPrice = product.fPrice;
            prod.fStartDate = product.fStartDate;
            prod.fEndDate = product.fEndDate;
            prod.fDescription = product.fDescription;
            prod.fPicture = product.fPicture;
            db.SaveChanges();
        }

        public List<tProduct> getProducts()
        {
            return db.tProduct.Where(x => (x.fEndDate > DateTime.Now) && (x.fStartDate <= DateTime.Now)).OrderByDescending(x=>x.Id).ToList();
        }

        public List<tProduct> getProductsbyKeyword(string keyword)
        {
            List<CEmpProductViewModel> lstCoupon = new List<CEmpProductViewModel>();
            return db.tProduct.Where(p => p.fName.ToUpper().Contains(keyword.ToUpper()) || p.fDescription.ToUpper().Contains(keyword.ToUpper())).ToList();
        }

        public tProduct getproductbyId(int ProductId)
        {
            return db.tProduct.FirstOrDefault(p => p.Id == ProductId);
        }
    }
}
