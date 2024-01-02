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
    public class CType : IOperation
    {
        private DataGridView _grd;
        public CType(DataGridView grd)
        {
            _grd = grd;
            refresh();
        }
        public void refresh()
        {
            var all = from t in (new ClinicSysEntities()).Pharmacy_tTypeList                      
                      select t;
            List<CTypeViewModel> list = new List<CTypeViewModel>();
            foreach (var t in all)
                list.Add(new CTypeViewModel(t));
            _grd.DataSource = list;
            CStyle_Drug.resetGridRowColor(_grd);
            CStyle_Drug.resetGrdWith(_grd);
        }
        public void create()
        {
            FrmType f = new FrmType();
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                ClinicSysEntities db = new ClinicSysEntities();
                db.Pharmacy_tTypeList.Add(f.typelist);
                db.SaveChanges();
                refresh();
            }
        }

        public void delete()
        {
            if (_grd.CurrentRow == null)
                return;
            string id = _grd.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            
            ClinicSysEntities db = new ClinicSysEntities();
            Pharmacy_tTypeList type =db.Pharmacy_tTypeList.FirstOrDefault(p => p.fTypeCode.ToString() == id);
          
            if (type == null)
                return;

            db.Pharmacy_tTypeList.Remove(type);
            db.SaveChanges();
            refresh();
            //20231219已測試3次Text =>最終可刪除，Lamda寫錯是用Code去比對，不然type=null，會直接結束
        }
        public void update()//20231219測試不成功，從第一次開始 開啟變更頁面會跳不出所選取的資料，為空白頁面，修改後都會改成typecode 劑型不變

        {
            if (_grd.CurrentRow == null)
                return;
            string id = _grd.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            //int fID=Convert.ToInt32(id);
            ClinicSysEntities db=new ClinicSysEntities();
            Pharmacy_tTypeList t = db.Pharmacy_tTypeList.FirstOrDefault(p => p.fTypeCode == id);
            if (t == null)
                return;
            FrmType f = new FrmType();
            f.typelist = t;     //要填資料進去，不然會是空白頁面
            f.ShowDialog();
           
            if (f.confirm == DialogResult.OK) 
            {
                t.fTypeCode = f.typelist.fTypeCode;
                t.fType = f.typelist.fType;
                db.SaveChanges();
                refresh();
            }


        }
        public void search(string keyword) //查詢後畫面會停留，要不要補上tabpg2>tabpg1後pg1重新長
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var types=db.Pharmacy_tTypeList.Where(p=>p.fType.Contains(keyword) || 
                                                     p.fTypeCode.Contains(keyword));
            List<CTypeViewModel> list = new List<CTypeViewModel>();
            foreach (var type in types)
            {
                list.Add(new CTypeViewModel(type)); 
            }
            _grd.DataSource = list;
            //refresh();  要讓grd只顯示 code & type
       
           
            CStyle_Drug.resetGridRowColor(_grd);
        }

       
    }
}
