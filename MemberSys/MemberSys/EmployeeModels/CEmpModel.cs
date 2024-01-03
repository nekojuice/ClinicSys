using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys.EmployeeModels
{
    public class CEmpModel
    {

        //新增一個含有全部員工(來自資料庫)的MODEL
        ClinicSysEntities db = new ClinicSysEntities();


        //進資料庫看有沒有這筆員工編號
        //count==1代表他在資料庫中找到一筆 員工編號只有唯一值 並且傳回真
        public bool isValidedEmpNumber(int empNumber)
        {
            int count = db.Member_EmployeeList.Where(e => e.Staff_Number == empNumber).Count();
            return (count==1)? true : false;
        }

        public Member_EmployeeList getEmpbyNumber(int employeeNumber)
        {
            return new ClinicSysEntities().Member_EmployeeList.FirstOrDefault(x => x.Staff_Number == employeeNumber);
        }
   
        //找到全部的員工
        public List<Member_EmployeeList>  getEmps()
        {
            var emplist = from p in db.Member_EmployeeList
                          orderby p.Staff_Number
                          select p;
            
            return emplist.ToList(); 
        }
        //搜尋功能
        public List<Member_EmployeeList> getEmpsbyKeyword(string keyword)
        {
            return db.Member_EmployeeList.Where(e=>e.Contact_Address.ToUpper().Contains(keyword)).ToList();
        }

        //員工編號是先去算出目前最大員工號碼 然後1000+號碼+1
        public int getNewStaffNumber()
        {
            return db.Member_EmployeeList.Count() + 1;
        }

        //在編輯畫面上直接用CEmpModel.create();把填好的資料塞進去資料庫
        public void create(Member_EmployeeList emp)
        {
            db.Member_EmployeeList.Add(emp);
            db.SaveChanges();
        }
    }
}
