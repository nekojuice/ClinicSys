using ClinicSys;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinicsys
{
    public partial class frmMbrCartEditor : Form
    {

        private tProduct _product;
        public tProduct product
        {
            set
            {
                _product = value;
                pictureBox1.Image = CUtility.getImagebyBytes(_product.fPicture);
                lblName.Text = _product.fName;
                lbl_price.Text = "現時促銷價\r\n $" + _product.fPrice;
                txtDescription.Text = _product.fDescription;
            }
        }

        private string _count;
        public string count
        {
            get
            {
                _count = userControlAddDecrease1.value.ToString();
                return _count;
            }
            set
            {
                _count = value;
                userControlAddDecrease1.value = Convert.ToInt32(_count);
            }
        }

        public frmMbrCartEditor()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            count = "1";
        }


        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRemovefromCart_Click(object sender, EventArgs e)
        {
            DialogResult =DialogResult.No;
            this.Close(); 
        }
    }
}
