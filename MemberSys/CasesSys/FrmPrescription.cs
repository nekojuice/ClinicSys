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
    public partial class FrmPrescription : Form
    {
        List<Cases_Prescriptionlist> _CP = new List<Cases_Prescriptionlist>();
        public bool mode = false;
        public IDDataStructure _X = new IDDataStructure();
        public int _PR { get; set; }
        public FrmPrescription()
        {
            InitializeComponent();
        }

        private void FrmPrescription_Load(object sender, EventArgs e)
        {
            PrescriptionSet PS = new PrescriptionSet();
            List<Pharmacy_tMedicinesList> data = PS.medicineListAdd();
            foreach (Pharmacy_tMedicinesList a in data)
            {
                string Name = a.fDrugName;
                string code = a.fDrugCode;
                string day = a.fDay.ToString();
                string eachtime = a.fEachTime.ToString();
                string durationdays = a.fDurationDays.ToString();
                string MDL = Name + "/" + code + "/" + day + "/" + eachtime + "/" + durationdays;
                MedicineBox.Items.Add(MDL);
            }
            tPreCaseIDBox.Ntext = _X.CaseID.ToString();
            if (mode == false)
            {
                PS._PR = _PR;
                tPreCaseIDBox.Ntext =_X.CaseID.ToString();
                Cases_Prescription CP =  PS.PrescriptionDataSet();
                dateTime.Text = CP.Prescription_Date.ToString();
                if (!string.IsNullOrEmpty(CP.Dispensing))
                {
                    textBoxDispensing.Text = CP.Dispensing.ToString();
                }
                ClinicSysEntities CSTE = new ClinicSysEntities();
                var dt = from x in CSTE.Cases_Prescriptionlist
                           where x.Prescription_ID == _PR
                           select new { 處方ID = x.Prescription_ID, 藥品ID = x.Drug_ID, 品名 = x.Pharmacy_tMedicinesList.fDrugName, 一日服用次數 = x.Pharmacy_tMedicinesList.fDay, 服用天數 = x.Days, 總量 = x.Total_Amount };
                dataGridView1.DataSource = dt.ToList();
                CCstyle.DataGridViewDesign(dataGridView1);
            }
            if (mode == true)
            {
                PS._PR= _PR;
            }

        }

        private void MedicineBox_TextChanged(object sender, EventArgs e)
        {
            string[] med = MedicineBox.Text.Split('/');
            textBoxDays.Text = med[4];
            textBoxTA.Text = (Convert.ToInt32(med[2]) * Convert.ToInt32(med[3]) * Convert.ToInt32(med[4])).ToString();
        }

        private void textBoxDays_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDays.Text))
            {
                try { Convert.ToInt32(textBoxDays.Text); }
                catch { MessageBox.Show("請輸入數字"); }
                finally
                {
                    string[] med = MedicineBox.Text.Split('/');
                    textBoxTA.Text = (Convert.ToInt32(med[2]) * Convert.ToInt32(med[3]) * Convert.ToInt32(textBoxDays.Text)).ToString();
                }
            }
            else
            {
                textBoxTA.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mode == true)
            {
                PrescriptionSet PS = new PrescriptionSet();
                PS._PR = _PR;
                PS.PrescriptionDelete();
            }
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MedicineBox.Text))
            {
                return;
            }
            ClinicSysEntities CSTE = new ClinicSysEntities();
            string[] med = MedicineBox.Text.Split('/');
            string go = med[1];
            Pharmacy_tMedicinesList x = CSTE.Pharmacy_tMedicinesList.FirstOrDefault(P => P.fDrugCode == go);
            Cases_Prescriptionlist cp = new Cases_Prescriptionlist();
            if (x != null) 
            {
                    cp.Prescription_ID = _PR;
                    cp.Drug_ID = x.fId_Drug;
                    cp.Days = Convert.ToInt32(textBoxDays.Text);
                    cp.Total_Amount = Convert.ToInt32(textBoxTA.Text);
                    try
                    {
                        CSTE.Cases_Prescriptionlist.Add(cp);
                        CSTE.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("藥品重複選用");
                    }
                    finally 
                    {
                        //MessageBox.Show("儲存成功");
                        PrescriptionSet PS = new PrescriptionSet();
                        PS._PR = _PR;
                        var data = from d in CSTE.Cases_Prescriptionlist
                               where d.Prescription_ID == _PR
                               select new { 處方ID = d.Prescription_ID, 藥品ID = d.Drug_ID, 品名 = d.Pharmacy_tMedicinesList.fDrugName, 一日服用次數 = d.Pharmacy_tMedicinesList.fDay, 服用天數 = d.Days, 總量 = d.Total_Amount };
                        dataGridView1.DataSource = data.ToList();
                        CCstyle.DataGridViewDesign(dataGridView1);
                    }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {

                ClinicSysEntities CSTE = new ClinicSysEntities();
                if (dataGridView1.SelectedRows[0].Index >= 0)
                {
                    int i = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    int j = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                    Cases_Prescriptionlist x = CSTE.Cases_Prescriptionlist.FirstOrDefault(P => P.Prescription_ID == i && P.Drug_ID == j);
                    CSTE.Cases_Prescriptionlist.Remove(x);
                    CSTE.SaveChanges();
                }
                //MessageBox.Show("刪除成功");
                PrescriptionSet PS = new PrescriptionSet();
                PS._PR = _PR;
                var data = from x in CSTE.Cases_Prescriptionlist
                       where x.Prescription_ID == _PR
                       select new { 處方ID = x.Prescription_ID, 藥品ID = x.Drug_ID, 品名 = x.Pharmacy_tMedicinesList.fDrugName, 一日服用次數 = x.Pharmacy_tMedicinesList.fDay, 服用天數 = x.Days, 總量 = x.Total_Amount };
            dataGridView1.DataSource=data.ToList();
                CCstyle.DataGridViewDesign(dataGridView1);
            
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
                ClinicSysEntities CSTE = new ClinicSysEntities();
                Cases_Prescription p = CSTE.Cases_Prescription.FirstOrDefault(X => X.Prescription_ID == _PR);
                if (p != null) 
                {
                    p.Prescription_Date = Convert.ToDateTime(dateTime.Text);
                    p.Dispensing =textBoxDispensing.Text;
                    CSTE.SaveChanges();
                    MessageBox.Show("儲存成功");
                    this.Close();
                }
        }


    }
}
