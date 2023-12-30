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

namespace ClinicSys
{
    public partial class userControlCategoryHeader : UserControl
    {
        public userControlCategoryHeader(string couponCategoryName)
        {
            InitializeComponent();
            text = couponCategoryName;
        }


        private string _text = "";
        public string text
        {
            set
            {
                _text = value;
                this.lblCouponCategory.Text = _text;
            }
        }
    }
}
