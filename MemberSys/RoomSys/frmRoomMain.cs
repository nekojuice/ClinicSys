using prjCustomerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRoom
{
    public partial class frmRoomMain : Form
    {
        public frmRoomMain()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmSurgery f = new frmSurgery();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmRoomList f=new frmRoomList();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmBabyCenter f = new frmBabyCenter();
            f.MdiParent = this;
            f.Show();
        }

       

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            IOperation f = this.ActiveMdiChild as IOperation;
            if (f != null)
                f.create();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            IOperation f = this.ActiveMdiChild as IOperation;
            f.delete();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            IOperation f = this.ActiveMdiChild as IOperation;
            f.update();
        }
    }
}
