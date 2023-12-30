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
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmMemberEditor f = new FrmMemberEditor();
            f.Show();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var members = from m in db.Member_MemberList
                          select m;
            dataGridView1.DataSource = members.ToList();
        }
    }
}
