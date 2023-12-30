using Clinicsys;
using ClinicSys;
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
    public partial class FrmMain : Form
    {
        //public static Member_EmployeeList _EMPLOYEE;
        public static Member_MemberList _MEMBER = new Member_MemberList { Member_ID = 6 };
        public FrmMain()
        {
            InitializeComponent();
        }

        public void Activate_fProducts()
        {
            frmMbrShop frm = new frmMbrShop();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void 線上商城ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activate_fProducts();
        }

        private void 優惠券ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMbrCoupon frm = new frmMbrCoupon();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void 購物清單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMbrOrder fOrders = new frmMbrOrder();
            fOrders.MdiParent = this;
            fOrders.WindowState = FormWindowState.Maximized;
            fOrders.Show();
            fOrders.Activate();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmEmpProdCoupOrder frm = new frmEmpProdCoupOrder();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void 測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpCoupEditor frm = new frmEmpCoupEditor();
            frm.ShowDialog();
        }

        private void toolStripDropDownButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
