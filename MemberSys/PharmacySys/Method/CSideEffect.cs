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
    public class CSideEffect : IOperation
    {
        private DataGridView _grd;
        public CSideEffect( DataGridView grd )
        {
            _grd = grd;
            refresh();
        }
        public void create()
        {           
            FrmSideEffect f=new FrmSideEffect();
            f.ShowDialog();
            
            if(f.confirm==DialogResult.OK)
            {

                ClinicSysEntities db = new ClinicSysEntities();
                db.Pharmacy_tSideEffectList.Add(f.sideEffectList);
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
            Pharmacy_tSideEffectList s = db.Pharmacy_tSideEffectList.FirstOrDefault
                (p => p.fSideEffectCode.ToString() == code);

            if (s == null)
                return;

            db.Pharmacy_tSideEffectList.Remove(s);
            db.SaveChanges();
            refresh();
        }

        public void refresh() 
        {
            var all = from t in (new ClinicSysEntities()).Pharmacy_tSideEffectList
                      select t;
            List<CSideEffectViewModel> list = new List<CSideEffectViewModel>();
            foreach (var t in all)
                list.Add(new CSideEffectViewModel(t));
            _grd.DataSource = list;
            CStyle.resetGridRowColor(_grd);
            CStyle.resetGrdWith(_grd);

        }

        public void search(string keyword)
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var s = db.Pharmacy_tSideEffectList.Where(p => p.fSideEffectCode.Contains(keyword) ||
                                                     p.fSideEffect.Contains(keyword));
            List<CSideEffectViewModel> list = new List<CSideEffectViewModel>();
            foreach (var key in s)
            {
                list.Add(new CSideEffectViewModel(key));
            }
            _grd.DataSource = list;
            //refresh();  要讓grd只顯示 code & type，不能用refresh會變成重新帶入資料 forecah設定


            CStyle.resetGridRowColor(_grd);
        }

        public void update()
        {
            if (_grd.CurrentRow == null)
                return;
            string code = _grd.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(code))
                return;
            ClinicSysEntities db = new ClinicSysEntities();
            Pharmacy_tSideEffectList effect = db.Pharmacy_tSideEffectList.FirstOrDefault
               (p => p.fSideEffectCode.ToString() == code);

            if (effect == null)
                return;
            FrmSideEffect f= new FrmSideEffect();
            f.sideEffectList = effect;
            f.ShowDialog();

            if (f.confirm == DialogResult.OK)
            {

                effect.fId_SideEffect = f.sideEffectList.fId_SideEffect;
                effect.fSideEffectCode = f.sideEffectList.fSideEffectCode;
                effect.fSideEffect = f.sideEffectList.fSideEffect;
                db.SaveChanges();
                refresh();
            }
        }
    }
}
