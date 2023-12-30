using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Clinicsys
{
    public partial class userControlAddDecrease : UserControl
    {
        private string _value;
        private string _text;

        public int value
        {
            get
            {
                _value = txtValue.Text;
                return Convert.ToInt32( _value);
            }
            set
            {
                _value = value.ToString();
                txtValue.Text = _value;
            }
        }

        public string text
        {
            get 
            {
                return _text;
            }
            set
            {
                _text = value;
                lblTitle.Text = _text;
            }
        }

        public userControlAddDecrease()
        {
            InitializeComponent();
            value = 1; 
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (value > 1)
                --value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ++value;
        }
    }
}
