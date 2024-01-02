using ClinicSysMdiParent.Method;
using ClinicSysMdiParent.View;
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
    public partial class FrmPharmacyDetail : Form
    {
        // IOperation 可以抓到目前的tabPage

        IOperation _ActiveTabPage;
        public FrmPharmacyDetail()  //這裡讀取資料
        {
            InitializeComponent();
            _ActiveTabPage = new CType(dataGridView1);            
        }

        private void FrmPharmacyDetail_Activated(object sender, EventArgs e)
        {
            _ActiveTabPage.refresh(); //一開始進畫面的顏色字型修改在CType.cs中
            
            dataGridView1.Columns[1].Width = 800;
        }

       
        private void toolStripButton1_Click(object sender, EventArgs e) 
        {
            _ActiveTabPage.create();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) 
        {
            _ActiveTabPage.delete();           
        }

        private void toolStripButton3_Click(object sender, EventArgs e) 
        {
            _ActiveTabPage.update();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            _ActiveTabPage.search(txtKeyword.Text);
        }
        //tabControl1.SelectedIndex可以抓到目前的，當轉換時會同時配對datagridview與新增種類畫面
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                _ActiveTabPage = new CType(dataGridView1);
                dataGridView1.Columns[1].Width = 800;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                _ActiveTabPage = new CClinicalUse(dataGridView2);
                dataGridView2.Columns[0].Width = 100;
                dataGridView2.Columns[1].Width = 800;
            }
            else
            {
                _ActiveTabPage = new CSideEffect(dataGridView3);
                dataGridView3.Columns[1].Width = 800;
            }
        }
    }
}
