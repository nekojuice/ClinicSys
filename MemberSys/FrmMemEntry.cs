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
    public partial class FrmMemEntry : Form
    {
        public FrmMemEntry()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FrmMember m = new FrmMember();
            m.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee f = new FrmEmployee();
            f.Show();
        }

        private void btnCareRecord_Click(object sender, EventArgs e)
        {
            FrmCare c = new FrmCare();
            c.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMember m = new FrmMember();
            m.Show();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            FrmMemEntry m = new FrmMemEntry();


            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            FrmEmployeeEditor m = new FrmEmployeeEditor();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMemEntry_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Add("11201","蔡文綺","女","B","A123456789","台北","同上","26666666","2000/10/22");
            dataGridView1.Rows.Add("11202", "王天真", "女", "B", "A123456789", "台南", "同上", "26666666", "1998/12/22");
            dataGridView1.Rows.Add("11203", "田曦葳", "女", "B", "A123456789", "台北", "同上", "26666666", "2000/10/22");
            dataGridView1.Rows.Add("11204", "白鹿", "女", "B", "A123456789", "台北", "同上", "26666666", "2000/10/22");
            dataGridView1.Rows.Add("11205", "王鶴棣", "男", "B", "A123456789", "台北", "同上", "26666666", "2000/10/22");
            dataGridView1.Rows.Add("11206", "吳磊", "男", "B", "A123456789", "台北", "同上", "26666666", "2000/10/22");
            dataGridView1.Rows.Add("11207", "迪麗熱巴", "女", "B", "A123456789", "台北", "同上", "26666666", "2000/10/22");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmFeed d = new FrmFeed();
            d.ShowDialog();
        }
    }
}
