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
    public partial class ccuserControlProduct : UserControl
    {
        public ccuserControlProduct(tProduct p)
        {
            InitializeComponent();
            product = p;
        }

        private tProduct _product { get; set; }
        public tProduct product
        {
            get { return _product; }
            set
            {
                _product = value;
                this.pictureBox1.Image = CUtility.getImagebyBytes(_product.fPicture);
                this.lblName.Text = _product.fName;
                this.lblPrice.Text = "$ " + _product.fPrice.ToString();
            }
        }

        public delegate void btnAddCartClickEvent(tProduct product);
        public event btnAddCartClickEvent onbtnClick_AddProdcuttoCart;

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            onbtnClick_AddProdcuttoCart(product);
        }
    }
}
