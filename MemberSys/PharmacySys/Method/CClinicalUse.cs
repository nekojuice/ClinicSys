using ClinicSysMdiParent.View;
using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.Method
{
    public class CClinicalUse : IOperation
    {
        private DataGridView _grd;
        public CClinicalUse (DataGridView grd)
        {
            _grd = grd;
            refresh();
        }
        public void create()
        {
            FrmClinicalUse f=new FrmClinicalUse();
            f.ShowDialog();
            
            if(f.confirm==DialogResult.OK)
            {
                ClinicSysEntities db=new ClinicSysEntities();
                db.Pharmacy_tClinicalUseList.Add(f.clinicalUseList);
                db.SaveChanges();
                refresh();
            }
        }

        public void delete()
        {
            if (_grd.CurrentRow == null)
                return;
            string code = _grd.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(code))
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            ClinicSysEntities db = new ClinicSysEntities();
            Pharmacy_tClinicalUseList uses = db.Pharmacy_tClinicalUseList.FirstOrDefault
                (p => p.fClinicalUseCode.ToString() == code);

            if (uses == null)
                return;

            db.Pharmacy_tClinicalUseList.Remove(uses);
            db.SaveChanges();
            refresh();
        }

        public void refresh()
        {
            var all = from t in (new ClinicSysEntities()).Pharmacy_tClinicalUseList
                      select t;
            List<CClinicalUseViewModel> list = new List<CClinicalUseViewModel>();
            foreach (var t in all)
                list.Add(new CClinicalUseViewModel(t));
            _grd.DataSource = list;
            CStyle_Drug.resetGridRowColor(_grd);
            CStyle_Drug.resetGrdWith(_grd);
        }

        public void search(string keyword)
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var uses = db.Pharmacy_tClinicalUseList.Where(p => p.fClinicalUseCode.Contains(keyword) ||
                                                     p.fClinicalUse.Contains(keyword));
            List<CClinicalUseViewModel> list = new List<CClinicalUseViewModel>();
            foreach (var s in uses)
            {
                list.Add(new CClinicalUseViewModel(s));
            }
            _grd.DataSource = list;
            //refresh();  要讓grd只顯示 code & type，不能用refresh會變成重新帶入資料 forecah設定


            CStyle_Drug.resetGridRowColor(_grd);
        }

        public void update()
        {
            if (_grd.CurrentRow == null)
                return;
            string code = _grd.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(code))
                return;           
            ClinicSysEntities db = new ClinicSysEntities();
            Pharmacy_tClinicalUseList uses = db.Pharmacy_tClinicalUseList.FirstOrDefault
                (p => p.fClinicalUseCode.ToString() == code);

            if (uses == null)
                return;
            FrmClinicalUse f =new FrmClinicalUse();
            f.clinicalUseList = uses;   
            f.ShowDialog();

            if (f.confirm == DialogResult.OK)
            {
                uses.fId_ClinicalUse = f.clinicalUseList.fId_ClinicalUse;
                uses.fClinicalUseCode = f.clinicalUseList.fClinicalUseCode;
                uses.fClinicalUse=f.clinicalUseList.fClinicalUse;
                
                db.SaveChanges();
                refresh();
            }

        }
    }
}
