using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys.View
{
    public partial class frmMsg : Form
    {
        public frmMsg()
        {
            InitializeComponent();
        }
        public string msg
        {
            set
            {
                lblMsg.Text = value;
            }
        }

        public string title
        {
            set { lblMsg.Text = value; }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
