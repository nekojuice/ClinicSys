using ClinicSys;
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
    public partial class FrmCases_All : Form
    {
        IDDataStructure _mID = new IDDataStructure();

        private string _imagepath = null;
        public FrmCases_All()
        {
            InitializeComponent();
        }

        private void FrmCases_All_Load(object sender, EventArgs e)
        {
            (new CCasesSystem()).memberDataGridViewSet(dataGridView1);
            CCstyle.DataGridViewDesign(dataGridView1);
            CCstyle.DataGridViewDesign(dataGridViewMR);
        }

        private void FrmCases_All_Activated(object sender, EventArgs e)
        {
            (new CCasesSystem()).memberDataGridViewSet(dataGridView1);
            this.WindowState = FormWindowState.Maximized;
            CCstyle.DataGridViewDesign(dataGridView1);
            CCstyle.DataGridViewDesign(dataGridViewMR);
        }

        private void Mem_Search(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                (new CCasesSystem()).searchMember(dataGridView1, textBox1.Text);
                CCstyle.DataGridViewDesign(dataGridView1);
            }
            else
                (new CCasesSystem()).memberDataGridViewSet(dataGridView1);
            CCstyle.DataGridViewDesign(dataGridView1);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NightMare();
            DataGridViewRefresh();
        }


        private void Delete(object sender, EventArgs e)
        {
            if (SwitchBox.Text == "看診紀錄")
            {
                if ((int)dataGridViewMR.SelectedRows[0].Cells[0].Value > 0 && MessageBox.Show("確定刪除?", "刪除", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    RecordSet rs =new RecordSet();
                    rs._MR = (int)dataGridViewMR.SelectedRows[0].Cells[0].Value;
                    rs.RecordsDelete();
                    RDGVS();
                }
            }
            if (SwitchBox.Text == "檢查報告")
            {
                if ((int)dataGridViewMR.SelectedRows[0].Cells[0].Value > 0 && MessageBox.Show("確定刪除?", "刪除", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ReportSet rs = new ReportSet();
                    rs._TR = (int)dataGridViewMR.SelectedRows[0].Cells[0].Value;
                    rs.ReportDelete();
                    ReDGVS();
                }
            }
                if (SwitchBox.Text == "處方籤")
                {
                    if ((int)dataGridViewMR.SelectedRows[0].Cells[0].Value > 0 && MessageBox.Show("確定刪除?", "刪除", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        PrescriptionSet rs = new PrescriptionSet();
                        rs._PR = (int)dataGridViewMR.SelectedRows[0].Cells[0].Value;
                        rs.PrescriptionDelete();
                        PDGVS();
                    }
                }
        }



        private void Switch(object sender, EventArgs e)
        {
            DataGridViewRefresh();
        }


        private void searchClick(object sender, EventArgs e)
        {
            if (SwitchBox.Text == "看診紀錄")
            {
                RecordSet c = new RecordSet();
                c._X = _mID;
                c.RecordDataSearch(dataGridViewMR,textBoxSearch.Text);
                CCstyle.DataGridViewDesign(dataGridViewMR);
            }
            if (SwitchBox.Text == "檢查報告")
            {
                ReportSet c = new ReportSet();
                c._X = _mID;
                c.ReportDataSearch(dataGridViewMR, textBoxSearch.Text,Convert.ToDateTime(dateTimePicker1.Text));
                CCstyle.DataGridViewDesign(dataGridViewMR);
            }
            if (SwitchBox.Text == "處方籤")
            {
                PrescriptionSet c = new PrescriptionSet();
                c._X = _mID;
                c.PrescriptionSearch(dataGridViewMR, textBoxSearch.Text, Convert.ToDateTime(dateTimePicker1.Text));
                CCstyle.DataGridViewDesign(dataGridViewMR);
            }
        }

        private void NewClick(object sender, EventArgs e)
        {
            if (SwitchBox.Text == "看診紀錄")
            {
                FrmRecords FR = new FrmRecords();
                FR.mode = true;
                FR._X = _mID;
                FR.ShowDialog();
                RecordSet c = new RecordSet();
                c._X = _mID;
                c.RecordDataSearch(dataGridViewMR, textBoxSearch.Text);
                CCstyle.DataGridViewDesign(dataGridViewMR);
            }
            if (SwitchBox.Text == "檢查報告")
            {
                FrmReport FR = new FrmReport();
                FR.mode = true;
                FR._X = _mID;
                FR.ShowDialog();
                ReportSet c = new ReportSet();
                c._X = _mID;
                c.ReportDataGridViewSet(dataGridViewMR);
                CCstyle.DataGridViewDesign(dataGridViewMR);
            }
            if (SwitchBox.Text == "處方籤")
            {
                PrescriptionSet c = new PrescriptionSet();
                c._X = _mID;
                int NPID =c.PrescriptionCreate();
                c.PreDataGridViewSet(dataGridViewMR);
                CCstyle.DataGridViewDesign(dataGridViewMR);
                FrmPrescription FP = new FrmPrescription();
                FP.mode = true;
                FP._X = _mID;
                FP._PR = NPID;
                FP.ShowDialog();
            }
        }

        private void dataGridViewMR_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (SwitchBox.Text == "看診紀錄")
            {
                FrmRecords FR = new FrmRecords();
                FR._X = _mID;
                FR._MR = (int)dataGridViewMR.SelectedRows[0].Cells[0].Value;
                FR.ShowDialog();
            }
            if (SwitchBox.Text == "檢查報告")
            {
                FrmReport FR = new FrmReport();
                FR._X = _mID;
                FR._TR = (int)dataGridViewMR.SelectedRows[0].Cells[0].Value;
                FR.ShowDialog();
            }
            if (SwitchBox.Text == "處方籤")
            {
                FrmPrescription FR = new FrmPrescription();
                FR._X = _mID;
                FR._PR = (int)dataGridViewMR.SelectedRows[0].Cells[0].Value;
                FR.ShowDialog();
            }
        }


        private void RDGVS()
        {
            RecordSet c = new RecordSet();
            c._X = _mID;
            c.RecordDataGridViewSet(dataGridViewMR);
            CCstyle.DataGridViewDesign(dataGridViewMR);
        }

        private void ReDGVS()
        {
            ReportSet c = new ReportSet();
            c._X = _mID;
            c.ReportDataGridViewSet(dataGridViewMR);
            CCstyle.DataGridViewDesign(dataGridViewMR);
        }
        private void PDGVS()
        {
            PrescriptionSet c = new PrescriptionSet();
            c._X = _mID;
            c.PreDataGridViewSet(dataGridViewMR);
            CCstyle.DataGridViewDesign(dataGridViewMR);
        }

        private void NightMare()
        {
            string[] a = new string[5];
            tNameBox.Ntext = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            bool gender = (bool)dataGridView1.SelectedRows[0].Cells[1].Value;
            if (!gender)
            {
                tGenderBox.Ntext = "女";
            }
            else
            {
                tGenderBox.Ntext = "男";
            }
            DateTime birthday = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
            tBloodTypeBox.Ntext = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tNationalIDBox.Ntext = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tBirthDayBox.Ntext = birthday.ToString("yyyy-MM-dd");
            List<Cases_MainCase> cedt = (new CCasesSystem()).MainDataGridViewSet(dataGridView1);
            tHeightBox.Ntext = cedt[0].Height.ToString() + " cm";
            tWeightBox.Ntext = cedt[0].Weight.ToString() + " kg";
            _mID.ID = cedt[0].Member_ID;
            _mID.CaseID = cedt[0].Case_ID;
            tCaseIDBox.Ntext = _mID.CaseID.ToString();
            HistoryBox.Text = cedt[0].PastHistory.ToString();
            AllegeryBox.Text = cedt[0].AllergyRecord.ToString();
            //try
            //{
            //    cedt[0].Attachment.ToString();
            //}
            //catch(NullReferenceException ex) { return; }
            //finally { pictureBox1.Image = new Bitmap(cedt[0].Attachment.ToString()); }
        }

        private void DataGridViewRefresh()
        {
            if (SwitchBox.Text == "看診紀錄")
            {
                RDGVS();
            }
            if (SwitchBox.Text == "檢查報告")
            {
                ReDGVS();
            }
            if (SwitchBox.Text == "處方籤")
            {
                PDGVS();
            }
            if (SwitchBox.Text == "新生兒")
            {
                CCasesSystem c = new CCasesSystem();
                c._X = _mID;
                c.NewBornDataSet(dataGridViewMR);
                CCstyle.DataGridViewDesign(dataGridViewMR);
            }
        }

        private void memsave_Click(object sender, EventArgs e)
        {
            CCasesSystem memsave = new CCasesSystem();
            memsave._X = _mID;
            memsave.saveCaseInformation(HistoryBox.Text, AllegeryBox.Text,_imagepath);
        }

        private void new_Born_Add(object sender, EventArgs e)
        {
            FrmNewBornData FNBD = new FrmNewBornData();
            FNBD._ID = _mID;
            FNBD.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            pictureBox1.Image = new Bitmap(open.FileName);
            _imagepath = open.FileName;

        }
    }
}
