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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicSysMdiParent
{
    public partial class FrmReport : Form
    {
        public bool mode = false;
        public IDDataStructure _X = new IDDataStructure();
        public List<Cases_TestReport> _data = new List<Cases_TestReport>();
        public int _TR;

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            if (mode == false)
            {
                ReportSet X = new ReportSet();
                X._TR = _TR;
                _data = X.ReportDataSet();
                tReCaseIDBox.Ntext = _X.CaseID.ToString();
                TdateTime.Text = _data[0].Test_Date.ToString("d");
                textBoxTestName.Text = _data[0].Test_Name.ToString();
                RedateTime.Text = _data[0].Report_Date.ToString();
                textBoxResult.Text = _data[0].Result;
                _data.Clear();
            }
            if (mode == true)
            {
                tReCaseIDBox.Ntext = _X.CaseID.ToString();
                _data.Clear();
            }
        }

        private void save(object sender, EventArgs e)
        {
            if (mode == false)
            {
                ClinicSysEntities CSTE = new ClinicSysEntities();
                var x = CSTE.Cases_TestReport.FirstOrDefault(p => p.Report_ID == _TR);
                if (x != null)
                {
                    x.Test_Date = Convert.ToDateTime(TdateTime.Text);
                    x.Report_Date = Convert.ToDateTime(RedateTime.Text);
                    x.Test_Name = textBoxTestName.Text;
                    x.Result = textBoxResult.Text;
                    CSTE.SaveChanges();
                }
                MessageBox.Show("修改資料成功");
                this.Close();
            }
            if (mode == true)
            {
                ClinicSysEntities CSTE = new ClinicSysEntities();
                Cases_TestReport x = new Cases_TestReport();
                x.Case_ID = _X.CaseID;
                x.Test_Date = Convert.ToDateTime(TdateTime.Text);
                x.Report_Date = Convert.ToDateTime(RedateTime.Text);
                x.Test_Name = textBoxTestName.Text;
                x.Result = textBoxResult.Text;
                CSTE.Cases_TestReport.Add(x);
                CSTE.SaveChanges();
                MessageBox.Show("新增資料成功");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
