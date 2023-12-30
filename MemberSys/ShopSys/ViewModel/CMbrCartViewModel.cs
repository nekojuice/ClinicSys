using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSys
{
    public class CMbrCartViewModel
    {
        [Browsable(false)]
        public tCart cart { get; set; }
        public byte[] 商品照片 { get { return cart.tProduct.fPicture; } }
        public string 商品名稱 { get { return cart.tProduct.fName; } }
        public string 商品價格 { get { return "$ " + cart.tProduct.fPrice.ToString(); } }
        public string 購買數量 { get { return cart.fAmount.ToString(); } }

        public List<CMbrCartViewModel> getCartViewModelsbyMemberId(int memberId)
        {
            List<tCart> carts = new CCartModel().getCartsbyMemberId(memberId);
            List<CMbrCartViewModel> cartViewModels = new List<CMbrCartViewModel>();
            foreach (tCart c in carts)
            {
                CMbrCartViewModel cartViewModel = new CMbrCartViewModel();
                cartViewModel.cart = c;
                cartViewModels.Add(cartViewModel);
            }
            return cartViewModels;
        }
    }


}
