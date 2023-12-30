using MemberSys.Frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys.EmployeeModels
{
    public class CEmpStyle
    {
        public static void AddBtn(DataGridView grd)
        {

            if (grd.Columns.Contains("empEdit"))
                return;

            // 編輯按鈕
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = "編輯";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Name = "empEdit";
            btnEdit.HeaderText = "         ";
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            grd.Columns.Add(btnEdit);
        }

        //員工頁面上的刪除 選到唯一的員工編號 不是員工ID
        public void delete(DataGridView d,string empid)
        {
            if (d.CurrentRow == null)
                return;
             empid = d.CurrentRow.Cells["員工編號"].Value.ToString();
            if (string.IsNullOrEmpty(empid))
                return;

            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int Staff_Number = Convert.ToInt32(empid);
            ClinicSysEntities db = new ClinicSysEntities();
            Member_EmployeeList emp = db.Member_EmployeeList.FirstOrDefault(p => p.Staff_Number == Staff_Number);
            if (emp == null)
                return;
            db.Member_EmployeeList.Remove(emp);
            db.SaveChanges();

         
        }

    }
}
