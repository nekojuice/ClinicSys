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
using static ClinicSysMdiParent.CCasesSystem;

namespace ClinicSysMdiParent
{
    public partial class FrmRecords : Form
    {
        public bool mode = false;

        public IDDataStructure _X = new IDDataStructure();

        public List<Cases_Medical_Records> _data = new List<Cases_Medical_Records>();
        public int _MR { get; set; }
        public FrmRecords()
        {
            InitializeComponent();
        }

   

        private void FrmRecords_Load(object sender, EventArgs e)
        {
            if (mode == false)
            {
                RecordSet X = new RecordSet();
                X._MR = _MR;
                _data = X.RecordDataSet();
                tRCaseIDBox.Ntext = _X.CaseID.ToString();
                dateTime.Text = _data[0].Schedule_ClinicInfo.date.ToString();
                tDocNameBox.Ntext = _data[0].Clinic_ID.ToString();
                textBoxPulse.Text = _data[0].Pulse.ToString();
                textBoxBP.Text = _data[0].BP.ToString();
                textBoxBT.Text = _data[0].BT.ToString();
                textBoxCC.Text = _data[0].CC.ToString();
                textBoxDisposal.Text = _data[0].Disposal.ToString();
                textBoxPreScribe.Text = _data[0].Prescribe.ToString();
                _data.Clear();
            }
            if (mode == true)
            {
                tRCaseIDBox.Ntext = _X.CaseID.ToString();
                tDocNameBox.Ntext = 335.ToString(); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                UPDATE();
            }
            if (mode == true)
            {
                Create();
            }
        }

        private void Create()
        {
            ClinicSysEntities db = new ClinicSysEntities();
            Cases_Medical_Records x = new Cases_Medical_Records();
            if (x != null)
            {
                x.Case_ID = Convert.ToInt32(tRCaseIDBox.Ntext);
                x.Clinic_ID = Convert.ToInt32(tDocNameBox.Ntext);
                x.Pulse = Convert.ToInt32(textBoxPulse.Text);
                x.BP = textBoxBP.Text;
                x.BT = Convert.ToDouble(textBoxBT.Text);
                x.CC = textBoxCC.Text;
                x.Disposal = textBoxDisposal.Text;
                x.Prescribe = textBoxPreScribe.Text;
                db.Cases_Medical_Records.Add(x);
                db.SaveChanges();
            }
            MessageBox.Show("新增資料成功");
            this.Close();
        }

        private void UPDATE()
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var x = db.Cases_Medical_Records.FirstOrDefault(p => p.MR_Id == _MR);
            if (x != null)
            {
                x.Pulse = Convert.ToInt32(textBoxPulse.Text);
                x.BP = textBoxBP.Text;
                x.BT = Convert.ToDouble(textBoxBT.Text);
                x.CC = textBoxCC.Text;
                x.Disposal = textBoxDisposal.Text;
                x.Prescribe = textBoxPreScribe.Text;
                db.SaveChanges();
            }
            MessageBox.Show("修改資料成功");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
