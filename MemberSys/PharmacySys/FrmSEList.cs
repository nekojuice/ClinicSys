using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent
{
    public partial class FrmSEList : Form
    {
        public string Id { set { lblDrug.Text = "Id：" + value + "\r\n"; } }  
        public string 學名 { set { lblDrug.Text += "學名：" + value; } }     
        
        //----修改時可以抓取原本存的SEList
        private List<Pharmacy_tSideEffectDetails> _SEdetailsSelected;
        public List<Pharmacy_tSideEffectDetails> SEdetailsSelected
        {
            get
            {
                return _SEdetailsSelected;
            }
            set
            {
                _SEdetailsSelected = value;                
                lbSEList.DataSource =_SEdetailsSelected;
                lbSEList.ValueMember = "fId_SideEffect";                
            }
        }
        public FrmSEList()
        {
            InitializeComponent();
        }

        private void FrmSEList_Load(object sender, EventArgs e)
        {
            laodSEList();
        }

        private void laodSEList()
        {
            ClinicSysEntities db= new ClinicSysEntities();
            var q = from t in db.Pharmacy_tSideEffectList
                    select t.fId_SideEffect+ ".  " +t.fSideEffect;
            foreach ( var t in q )
            {
         
                clbSEList.Items.Add( t );
            }
        }


        private bool isFirstEdiotr = true;
        private void button2_Click(object sender, EventArgs e)   //加入
        {
            if (isFirstEdiotr)
            {
                lbSEList.DataSource = null;
                isFirstEdiotr = false;
            }
            
            lbSEList.Items.Clear();
            for( int i = 0; i < clbSEList.CheckedItems.Count; i++)
            {
                lbSEList.Items.Add(clbSEList.CheckedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e) //清空
        {
            lbSEList.DataSource = null;
            lbSEList.Items.Clear() ;
            
        }

        private void button4_Click(object sender, EventArgs e) //取消
        {
            this.Close();
        }

        public List<string> _selist {  get; set; }
        private void button1_Click(object sender, EventArgs e) //確認
        {
            if( _selist == null )
                _selist=new List<string>();
            foreach(var t in lbSEList.Items)
            {
                _selist.Add(t.ToString());
            }
            if (lbSEList.Items.Count <= 0)
            {
                MessageBox.Show("請選取一個以上的副作用");
                return;
            }
            this.Close();
        }
    }
}
