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
    public partial class FrmCUList : Form
    {
       

        public string Id { set { lblDrug.Text = "Id：" + value + "\r\n"; } }  //DrugID從Editor中取出
        public string 學名 { set { lblDrug.Text += "學名：" + value; } } //學名從Editor中取出

        //----修改時可以抓取原本存的CUList
        private List<Pharmacy_tClinicalUseDetails> _CUdetailsSelected;
        public List<Pharmacy_tClinicalUseDetails> CUdetailsSelected
        {
            get
            {
                return _CUdetailsSelected;
            }
            set
            {
                _CUdetailsSelected = value;
                lbCUList.DataSource = _CUdetailsSelected;                
                lbCUList.ValueMember = "fId_ClicicalUse";
            }
        }
        public FrmCUList()
        {
            InitializeComponent();
        }

        private void FrmCUList_Load(object sender, EventArgs e)
        {
            loadCUList();
        }

        private void loadCUList()  
        {            
            ClinicSysEntities db = new ClinicSysEntities();
            var q = from t in db.Pharmacy_tClinicalUseList
                    select t.fId_ClinicalUse + ". " + t.fClinicalUse;

            foreach (var q1 in q)
            {                
                clbCUList.Items.Add(q1.ToString());
            }                            
        }


        public List<string> _culist { get; set; }
        private void button1_Click(object sender, EventArgs e) //確認
        {
           if (_culist == null)
                _culist= new List<string>();
            foreach(var q in lbCUList.Items)
            {
                _culist.Add(q.ToString());
            }
            if (lbCUList.Items.Count <= 0) 
            { MessageBox.Show("請選取一個以上的適應症"); }
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e) //加入
        {
            lbCUList.DataSource = null;
            //lbCUList.Items.Clear();
            for (int i = 0; i < clbCUList.CheckedItems.Count; i++)
            {
                lbCUList.Items.Add((string)clbCUList.CheckedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e) //清空
        {
            lbCUList.DataSource = null;
            //lbCUList.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e) //取消
        {
            this.Close();
        }
    }
}
