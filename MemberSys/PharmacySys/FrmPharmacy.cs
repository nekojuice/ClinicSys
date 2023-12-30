using ClinicSysMdiParent.Method;
using ClinicSysMdiParent.View;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent
{
    public partial class FrmPharmacy : Form, IOperation
    {
        public FrmPharmacy()
        {
            InitializeComponent();
        }

        private void FrmPharmacy_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()  //一直有問題
        {
            //ClinicSysEntities db = new ClinicSysEntities();
            //var _medicine= from t in db.Pharmacy_tMedicinesList
            //               select t;
            //dataGridView1.DataSource= _medicine.ToArray();
            //CStyle.resetGridRowColor(dataGridView1);
            /*var all=from t in(new ClinicSysEntities()).Pharmacy_tMedicinesList
                    select t;
            List<CDrugViewModel> list=new List<CDrugViewModel>();
            foreach (var t in all) 
                list.Add(new CDrugViewModel(t));
            dataGridView1.DataSource = list;*/
            ClinicSysEntities db = new ClinicSysEntities();
            var all = from t in db.Pharmacy_tMedicinesList
                      select t;

            dataGridViewDrug.DataSource = all.ToList();


            //可以抓一個主表+一個關聯子表
            //List<string> list = new List<string>();
            /* var _medicine = from t in db.Pharmacy_tClinicalUseDetails
                             select new
                             {
                                 t.fId_Drug,
                                 t.Pharmacy_tMedicinesList.fDrugCode,
                                 t.Pharmacy_tMedicinesList.fGenericName,
                                 t.Pharmacy_tMedicinesList.fTradeName
                             };*/

            //List<string> list = new List<string>();
            //foreach (var t in _medicine)
            //{
            //    list.Add(t);
            //}
            //dataGridView1.DataSource = _medicine.ToList();
            CStyle.resetGridRowColor(dataGridViewDrug);
        }

        private void FrmPharmacy_Activated(object sender, EventArgs e) //版面尚未修改好
        {
            CStyle.resetGridRowColor(dataGridViewDrug);
            dataGridViewDrug.Columns[0].Width = 200;
            dataGridViewDrug.Columns[1].Width = 200;
            dataGridViewDrug.Columns[2].Width = 200;
            dataGridViewDrug.Columns[3].Width = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update();
        }


        public void create()   
        {
            FrmDrugEditor f = new FrmDrugEditor();
            f.WindowState = FormWindowState.Maximized;
            //f.ShowDialog();
           

            if (f.ShowDialog() == DialogResult.OK)
            {
                ClinicSysEntities db = new ClinicSysEntities();
                db.Pharmacy_tMedicinesList.Add(f.medicinesList);

                try { db.SaveChanges(); } //無法存入db會跳出messagebox並表明原因
                catch (DbEntityValidationException ex)
                {
                    foreach (var x in ex.EntityValidationErrors)
                    {
                        foreach (var x1 in x.ValidationErrors)
                        {
                            MessageBox.Show($"Property：{x1.PropertyName}Error:{x1.ErrorMessage}");
                        }
                    }
                }
                db.Pharmacy_tTypeDetails.Add(new Pharmacy_tTypeDetails()
                {
                    fId_Drug = f.medicinesList.fId_Drug,
                    fId_Tpye = Convert.ToInt32(f.劑型)
                });
                //適應症
                for (int i = 0; i < f.適應症.Count; i++)
                {
                    db.Pharmacy_tClinicalUseDetails.Add(new Pharmacy_tClinicalUseDetails()
                    {
                        fId_Drug = f.medicinesList.fId_Drug,
                        fId_ClicicalUse = Convert.ToInt32(f.適應症[i])
                    });
                    db.SaveChanges();
                }
                //副作用
                for (int i = 0; i < f.副作用.Count; i++)
                {
                    db.Pharmacy_tSideEffectDetails.Add(new Pharmacy_tSideEffectDetails()
                    {
                        fId_Drug = f.medicinesList.fId_Drug,
                        fId_SideEffect = Convert.ToInt32(f.副作用[i])
                    });
                    db.SaveChanges();
                }
                refresh();
            }
        }

        public void delete() //已測試副作用明細表+藥品主表可以一起刪除 //若測試新增只有主表的話 在刪除開始時子表沒有內容就會return
        {
            if (dataGridViewDrug == null)
                return;
            string id = dataGridViewDrug.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id)) //如果id是空值return
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int ID = Convert.ToInt32(id);
            ClinicSysEntities db = new ClinicSysEntities();
            Pharmacy_tMedicinesList m = db.Pharmacy_tMedicinesList.FirstOrDefault(p => p.fId_Drug == ID);
            if (m == null)
                return;
            //劑型刪除
            var CUdetails = db.Pharmacy_tClinicalUseDetails.Where(p => p.fId_Drug == ID);//.ToList();
            if (CUdetails == null)
                return;
            foreach (var c in CUdetails)
            {
                db.Pharmacy_tClinicalUseDetails.Remove(c);

            }
            db.SaveChanges();

            Pharmacy_tTypeDetails t = db.Pharmacy_tTypeDetails.FirstOrDefault(p => p.fId_Drug == ID);
            if (t == null)
                return;
            db.Pharmacy_tTypeDetails.Remove(t);
            db.SaveChanges();

            //適應症刪除
           
            //副作用刪除
            var SEdetails = db.Pharmacy_tSideEffectDetails.Where(p => p.fId_Drug == ID).ToList();
            if (SEdetails == null)
                return;
            foreach (Pharmacy_tSideEffectDetails d in SEdetails)
            {
                db.Pharmacy_tSideEffectDetails.Remove(d);
                
            }
            db.SaveChanges();
            //主表刪除
            //Pharmacy_tMedicinesList m = db.Pharmacy_tMedicinesList.FirstOrDefault(p => p.fId_Drug == ID);
            //if (m == null)
            //    return;
            db.Pharmacy_tMedicinesList.Remove(m);

            db.SaveChanges();
            refresh();
        }
        
        public void update()   //適應症更新結合 create及delete
        {
            if (dataGridViewDrug == null)
                return;
            string id = dataGridViewDrug.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int ID = Convert.ToInt32(id);
            ClinicSysEntities db = new ClinicSysEntities();
            Pharmacy_tMedicinesList m = db.Pharmacy_tMedicinesList.FirstOrDefault(p => p.fId_Drug == ID);
            if (m == null) return;
            Pharmacy_tTypeDetails t = db.Pharmacy_tTypeDetails.FirstOrDefault(p => p.fId_Drug == ID);
            //if (t == null) return;
            //可以只找第一筆嗎？不行！
            //----
            var a1 = from t1 in db.Pharmacy_tClinicalUseDetails 
                     where t1.fId_Drug == ID
                     select t1;
            var a2 = from t2 in db.Pharmacy_tSideEffectDetails
                     where t2.fId_Drug == ID
                     select t2;            
            List<Pharmacy_tClinicalUseDetails> c = a1.ToList();
            List<Pharmacy_tSideEffectDetails> s = a2.ToList();
            //----
            
            FrmDrugEditor f = new FrmDrugEditor();
            f.medicinesList = m; //還要加上其他表跳入Editor時就要帶入資料
            f.Tdatails = t;
            f.CUdetails = c;
            f.SEdetails = s;
            
            
            f.WindowState = FormWindowState.Maximized;
            //f.ShowDialog();
            if (f.ShowDialog()== DialogResult.OK)  //  if (f.confirm== DialogResult.OK)會存不回資料庫if=false
            {
                m.fId_Drug = f.medicinesList.fId_Drug;
                m.fDrugCode = f.medicinesList.fDrugCode;
                m.fGenericName = f.medicinesList.fGenericName;
                m.fTradeName=f.medicinesList.fTradeName;
                m.fDrugName = f.medicinesList.fDrugName;
                m.fDrugDose = f.medicinesList.fDrugDose;
                m.fMaxDose = f.medicinesList.fMaxDose;
                m.fPrecautions = f.medicinesList.fPrecautions;
                m.fWarnings = f.medicinesList.fWarnings;
                m.fPregnancyCategory = f.medicinesList.fPregnancyCategory;
                m.fApperance = f.medicinesList.fApperance;
                m.fImages = f.medicinesList.fImages;
                m.fStorage = f.medicinesList.fStorage;
                m.fSupplier = f.medicinesList.fSupplier;
                m.fBrand = f.medicinesList.fBrand;
                m.fDay = f.medicinesList.fDay;
                m.fEachTime = f.medicinesList.fEachTime;
                m.fDurationDays = f.medicinesList.fDurationDays;
                m.fQty = f.medicinesList.fQty;
                t.fId_Tpye=f.Tdatails.fId_Tpye;
                db.SaveChanges();
                refresh();
                //適應症
                foreach (var c1 in c)
                {
                    db.Pharmacy_tClinicalUseDetails.Remove(c1);
                    db.SaveChanges();
                }                
                for (int i = 0; i < f.適應症.Count; i++)
                {
                    db.Pharmacy_tClinicalUseDetails.Add(new Pharmacy_tClinicalUseDetails()
                    {
                        fId_Drug = f.medicinesList.fId_Drug,
                        fId_ClicicalUse = Convert.ToInt32(f.適應症[i])
                    });
                    db.SaveChanges();
                }
                ////副作用               ;
                foreach (Pharmacy_tSideEffectDetails s1 in s)
                {
                    db.Pharmacy_tSideEffectDetails.Remove(s1);
                    db.SaveChanges();
                }
                for (int i = 0; i < f.副作用.Count; i++)
                {
                    db.Pharmacy_tSideEffectDetails.Add(new Pharmacy_tSideEffectDetails()
                    {
                        fId_Drug = f.medicinesList.fId_Drug,
                        fId_SideEffect = Convert.ToInt32(f.副作用[i])
                    });
                    db.SaveChanges();
                }
            }
        }

        public void search(string keyword)
        {
            ClinicSysEntities db=new ClinicSysEntities();
            var Medicine=db.Pharmacy_tMedicinesList.
                Where(k=>k.fDrugCode.Contains(keyword)||
                     k.fGenericName.Contains(keyword)||
                     k.fTradeName.Contains(keyword)||
                     k.fDrugName.Contains(keyword)||
                     k.fStorage.Contains(keyword)||
                     k.fSupplier.Contains(keyword)||
                     k.fBrand.Contains(keyword));                
            dataGridViewDrug.DataSource = Medicine.ToList();
            CStyle.resetGridRowColor(dataGridViewDrug);                  
        }                
        private void button5_Click(object sender, EventArgs e)
        {
            search(txtKeyword.Text);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            var CUdetails = new ClinicSysEntities().Pharmacy_tClinicalUseDetails.Where(p => p.fId_Drug == 18);
            MessageBox.Show(CUdetails.Count().ToString());
            */
        }
        
    }
}
