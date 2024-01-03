using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ClinicSysMdiParent.Method;
using MemberSys;

namespace ClinicSysMdiParent
{

    public class CCasesSystem
    {
        public IDDataStructure _X = new IDDataStructure();
        public int _MR { get; set; }
        public void memberDataGridViewSet(DataGridView dataGridView1)
        {
            ClinicSysEntities H = new ClinicSysEntities();
            var data = from x in H.Member_MemberList
                       select new { 姓名 = x.Name, 性別 = x.Gender, 血型 = x.Blood_Type, 身分證號 = x.National_ID, 生日 = x.Birth_Date };
            dataGridView1.DataSource = data.ToList();
        }
        public List<Cases_MainCase> MainDataGridViewSet(DataGridView dataGridView)
        {
            ClinicSysEntities H = new ClinicSysEntities();
            var memdata = from x in H.Member_MemberList
                          select x;
            string NID = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Member_MemberList m = memdata.FirstOrDefault(P => P.National_ID == NID);
            _X.ID = m.Member_ID;
            var casedata = from x in H.Cases_MainCase
                           where x.Member_ID == _X.ID
                           select x;
            if (casedata.ToList().Count != 0)
            {
                var cedt = casedata.ToList();
                return cedt;
            }
            else 
                return null;
        }

        public void searchMember(DataGridView dataGridView1, string str)
        {
            ClinicSysEntities H = new ClinicSysEntities();
            var data = from x in H.Member_MemberList
                       where x.Name.Contains(str) || x.National_ID.Contains(str)
                       select new { 姓名 = x.Name, 性別 = x.Gender, 血型 = x.Blood_Type, 身分證號 = x.National_ID, 生日 = x.Birth_Date };
            dataGridView1.DataSource = data.ToList();
        }

        public void saveCaseInformation (string pasthistory,string allergyrecord,string imagepath)
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_MainCase save = CSTE.Cases_MainCase.FirstOrDefault(P => P.Case_ID == _X.CaseID);
            save.PastHistory = pasthistory;
            save.AllergyRecord = allergyrecord;
            if (!string.IsNullOrEmpty(imagepath))
            {
                string photo = Guid.NewGuid().ToString() + ".jpg";
                save.Attachment = photo;
                File.Copy(imagepath, Application.StartupPath + photo);
            }
            CSTE.SaveChanges();
            MessageBox.Show("已儲存");
        }



        public void NewBornDataSet(DataGridView dataGridView1)
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            var NB = from a in CSTE.Cases_NewBornList
                     where (a.Member_ID == _X.ID)
                     select new { 新生兒ID = a.NewBorn_ID, 新生兒姓名 = a.Name, 緊急連絡人姓名 = a.ICE_Name, 緊急連絡人電話 = a.ICE_Number };
            dataGridView1.DataSource= NB.ToList();
        }

    }



        public class RecordSet
        {
            public IDDataStructure _X = new IDDataStructure();
            public int _MR { get; set; }
            public List<Cases_Medical_Records> RecordDataSet()
            {

                ClinicSysEntities H = new ClinicSysEntities();
                var data = from x in H.Cases_Medical_Records
                           where x.MR_Id == _MR
                           select x;
                return data.ToList();

            }
            public void RecordDataSearch(DataGridView dataGridView1, string keyword)
            {

                ClinicSysEntities H = new ClinicSysEntities();

                var data = from x in H.Cases_Medical_Records
                           where x.CC.Contains(keyword) && x.Case_ID == _X.CaseID
                           select new { 病歷號 = x.Case_ID, 記錄號 = x.MR_Id, 主述 = x.CC };
                dataGridView1.DataSource = data.ToList();
            }

            public void RecordDataGridViewSet(DataGridView dataGridView1)
            {

                ClinicSysEntities H = new ClinicSysEntities();
                var data = from x in H.Cases_Medical_Records
                           where x.Case_ID == _X.CaseID
                           select new { 記錄號 = x.MR_Id, 病歷號 = x.Case_ID, 主述 = x.CC };
                dataGridView1.DataSource = data.ToList();
            }

        public void RecordsDelete()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_Medical_Records x = CSTE.Cases_Medical_Records.FirstOrDefault(p => p.MR_Id ==(_MR));
            if (x != null)
            {
                CSTE.Cases_Medical_Records.Remove(x);
                CSTE.SaveChanges();
            }
            MessageBox.Show("刪除資料成功");
        }
        }


        public class ReportSet
        {
            public IDDataStructure _X = new IDDataStructure();
            public int _TR { get; set; }

        public void ReportDataGridViewSet(DataGridView dataGridView1)
        {
            ClinicSysEntities H = new ClinicSysEntities();
            var data = from x in H.Cases_TestReport
                       where x.Case_ID == _X.CaseID
                       select new { 檢查單號 = x.Report_ID, 檢查日期 = x.Test_Date, 檢查項目 = x.Test_Name };
            dataGridView1.DataSource = data.ToList();
        }

        public List<Cases_TestReport> ReportDataSet()
        {

            ClinicSysEntities H = new ClinicSysEntities();
            var data = from x in H.Cases_TestReport
                       where x.Report_ID == _TR
                       select x;
            return data.ToList();

        }

        public void ReportDelete()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_TestReport x = CSTE.Cases_TestReport.FirstOrDefault(p => p.Report_ID == (_TR));
            if (x != null)
            {
                CSTE.Cases_TestReport.Remove(x);
                CSTE.SaveChanges();
            }
            MessageBox.Show("刪除資料成功");
        }

        public void ReportDataSearch(DataGridView dataGridView1,string keyword,DateTime date)
        {

            ClinicSysEntities H = new ClinicSysEntities();
            var data = from x in H.Cases_TestReport
                       where x.Case_ID == _X.CaseID && (x.Test_Date ==date || x.Test_Name == keyword)
                       select new { 檢查單號 = x.Report_ID, 檢查日期 = x.Test_Date, 檢查項目 = x.Test_Name };
            dataGridView1.DataSource = data.ToList();
        }
    }

       public class PrescriptionSet 
       {
        public IDDataStructure _X = new IDDataStructure();
        public int _PR { get; set; }
        public void PreDataGridViewSet(DataGridView dataGridView1)
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            var data = from x in CSTE.Cases_Prescription where x.Case_ID == _X.CaseID
                       select new { 處方籤號碼 = x.Prescription_ID, 開立日期 = x.Prescription_Date };
            dataGridView1.DataSource = data.ToList();
        }
        public List<Pharmacy_tMedicinesList> medicineListAdd()
        {
            ClinicSysEntities CSTE =new ClinicSysEntities();
            var data = from x in CSTE.Pharmacy_tMedicinesList
                       select x;
            List<Pharmacy_tMedicinesList> medicinesLists = data.ToList();
            return medicinesLists;
        }
        public Cases_Prescription PrescriptionDataSet()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_Prescription data = CSTE.Cases_Prescription.FirstOrDefault(p => p.Prescription_ID == (_PR));
            Cases_Prescription prescriptions = data;
            return prescriptions;
        }

        public Cases_Prescriptionlist PrescriptionListDataSet()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_Prescriptionlist data = CSTE.Cases_Prescriptionlist.FirstOrDefault(p => p.Prescription_ID == (_PR));
            Cases_Prescriptionlist prescriptionslist = data;
            return prescriptionslist;
        }
        //public List<Cases_Prescription> ListPrescriptionListDataSet()
        //{
        //    ClinicSysEntities CSTE = new ClinicSysEntities();
        //    var data = from x in CSTE.Cases_Prescriptionlist
        //               where x.Prescription_ID == _PR
        //               select new { 處方ID = x.Prescription_ID, 藥品ID = x.Drug_ID, 品名 = x.Pharmacy_tMedicinesList.fDrugName, 一日服用次數 = x.Pharmacy_tMedicinesList.fDay, 服用天數 = x.Days, 總量 = x.Total_Amount };
        //    var list = data.ToList();
        //    return list;
        //}

        public void PrescriptionListDelete()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_Prescription x = CSTE.Cases_Prescription.FirstOrDefault(p => p.Prescription_ID == (_PR));
            List<Cases_Prescriptionlist> y = CSTE.Cases_Prescriptionlist.Where(P => P.Prescription_ID == (_PR)).ToList();
            if (x != null)
            {
                CSTE.Cases_Prescription.Remove(x);
                foreach (Cases_Prescriptionlist z in y)
                {
                    CSTE.Cases_Prescriptionlist.Remove(z);
                }
                CSTE.SaveChanges();
            }
            MessageBox.Show("刪除資料成功");
        }
        public void PrescriptionSearch(DataGridView dataGridView1, string keyword, DateTime date)
        {

            ClinicSysEntities H = new ClinicSysEntities();
            var data = from x in H.Cases_Prescription
                       where x.Case_ID == _X.CaseID && (x.Prescription_Date == date )
                       select new  { 處方籤號碼 = x.Prescription_ID, 開立日期 = x.Prescription_Date };
       
            dataGridView1.DataSource = data.ToList();
        }
        public int PrescriptionCreate()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_Prescription CP = new Cases_Prescription();
            CP.Case_ID = _X.CaseID;
            CP.Prescription_Date = DateTime.Now.Date;
            CSTE.Cases_Prescription.Add(CP);
            CSTE.SaveChanges();
            int count = CSTE.Cases_Prescription.Count();
            var PID = from x in CSTE.Cases_Prescription
                      where x.Case_ID == _X.CaseID
                      select x.Prescription_ID;
            List<int> LCP = PID.ToList();
            int ID = LCP.Last();
            return ID;
        }

        public void PrescriptionDelete()
        {
            ClinicSysEntities CSTE = new ClinicSysEntities();
            Cases_Prescription x = CSTE.Cases_Prescription.FirstOrDefault(p => p.Prescription_ID == (_PR));
            if (x != null)
            {
                CSTE.Cases_Prescription.Remove(x);
                CSTE.SaveChanges();
            }
            MessageBox.Show("刪除資料成功");
        }
    }
}
