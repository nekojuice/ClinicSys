using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys
{
    public partial class FrmCare : Form
    {
        public FrmCare()
        {
            InitializeComponent();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            FrmFeed feed = new FrmFeed();
            feed.ShowDialog();
        }



        private void btnPoo_Click(object sender, EventArgs e)
        {
            FrmPoo p = new FrmPoo();
            p.ShowDialog();
            Member_MemberList m = new Member_MemberList();
        }
    }
}
