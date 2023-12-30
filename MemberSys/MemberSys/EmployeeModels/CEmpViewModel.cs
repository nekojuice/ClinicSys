using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MemberSys.EmployeeModels
{
    public class CEmpViewModel
    {
        private Member_EmployeeList _db_emp;

        public CEmpViewModel(Member_EmployeeList db_emp)
        {
            this._db_emp = db_emp;
        }
        public CEmpViewModel() { }

        [Browsable(false)]
        public int 員工ID { get { return _db_emp.Emp_ID; } }
        public int 員工編號 { get { return _db_emp.Staff_Number; } }
        public string 員工姓名 { get { return _db_emp.Name; } }
        public string 生理性別
        {
            get
            {
                //從資料庫來的資料會是真和假，如果是真就是男的
                //寫進資料庫也是如此，我表單上選女，進到資料庫就是假，也就是0
                return _db_emp.Gender == true ? "男" : "女";
            }
            //set { db_member.Gender = (value == "男" ? true : false); }
        }
        public string 血型 { get { return _db_emp.Blood_Type; } }
        public string 身份證字號 { get { return _db_emp.National_ID; } }
        public string 戶籍地址 { get { return _db_emp.Address; } }
        public string 聯絡地址 { get { return _db_emp.Contact_Address; } }
        public string 聯絡電話 { get { return _db_emp.Phone; } }
        public DateTime 生日 { get { return _db_emp.Birth_Date; } }
        public string 員工類型 { get { return _db_emp.Emp_Type; } }

        public string 科別 { get { return _db_emp.Department; } }
        [Browsable(false)]
        public string 員工密碼 { get { return _db_emp.Emp_Password; } }
        [Browsable(false)]
        public  byte [] 員工大頭照 { get { return _db_emp.EmpPhoto; } }

        //用linq把資料庫中每筆資料取出存進listEmp 並且顯示
        public List<CEmpViewModel> GetAllVwEmp()
        {
            var db_emps = new CEmpModel().getEmps();
            List<CEmpViewModel> vwEmpList = new List<CEmpViewModel>();

            foreach (var db_emp in db_emps)
                vwEmpList.Add(new CEmpViewModel(db_emp));

            return vwEmpList;
        }

        //20231226下午 員工的查詢功能
        public Member_EmployeeList queryByEmpNumber(int number)
        {
            ClinicSysEntities db = new ClinicSysEntities();

            Member_EmployeeList employee = db.Member_EmployeeList.FirstOrDefault(emp => emp.Staff_Number == number);

            if (employee == null)
            {
                // 找不到員工編號，顯示錯誤或採取相應的處理
                MessageBox.Show("找不到相應的員工編號！");
            }

            return employee;
        }
    }
}
