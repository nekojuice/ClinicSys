using ClinicSysMdiParent.Method;
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

namespace ClinicSysMdiParent
{
    public partial class FrmNewBornData : Form
    {
        public IDDataStructure _ID = new IDDataStructure();
        public FrmNewBornData()
        {
            InitializeComponent();
        }

        private void FrmNewBornData_Load(object sender, EventArgs e)
        {
            memIDBox.Ntext =_ID.ID.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ClinicSysEntities CSTE =new ClinicSysEntities();
            Cases_NewBornList CNBL = new Cases_NewBornList();
            CNBL.Member_ID = Convert.ToInt32(memIDBox.Ntext);
            CNBL.Name = textBoxBName.Text;
            CNBL.Birth_Date = Convert.ToDateTime(Birthday.Text);
            if (Gender.Text == "男")
            {
                CNBL.Gender = false;
            }
            if (Gender.Text == "女")
            {
                CNBL.Gender = true;
            }
            CNBL.Blood_Type = BT.Text;
            CNBL.ICE_Name = ICENAME.Text;
            CNBL.ICE_Number =ICENUMBER.Text;
            CSTE.Cases_NewBornList.Add(CNBL);
            CSTE.SaveChanges();
            MessageBox.Show("新增成功");
            this.Close();
        }
    }
}
