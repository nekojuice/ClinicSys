using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSysMdiParent.Model
{
   
    public  class CComboFactory
         
    {
        ClinicSysEntities db = new ClinicSysEntities();
        public IEnumerable<CDoctorname> FindDoctorname()
        //  public IQueryable FindDoctorname()
        {
            var DCnameid = from x in db.Member_EmployeeList
                           where x.Emp_Type == "醫師"
                           select new CDoctorname//匿名類別
                           {
                               Dr姓名 = x.Name,
                               Drid = x.Emp_ID
                           };
            return DCnameid;
        }
        public IEnumerable<CRoomName> FindRoomNumber()//撈出診間名和ID
        {
            var Roomnumberid = from x in db.RoomList
                               where x.Type_ID == 3
                               select new CRoomName
                               {
                                   Room名 = x.Name,
                                   Roomid = x.Room_ID
                               };
            return Roomnumberid;
        }
        public IEnumerable<CClinicTime> FindShifts()
        {
            var Shiftsid = from x in db.Schedule_ClinicTime
                           select new CClinicTime
                           {
                               ShiftID = x.ClinicTime_ID,
                               Shifts = x.ClinicShifts
                           };
            return Shiftsid;
        }

        public IEnumerable<CNurseName> FindNurseName()//撈出診間名和ID
        {
            var NurseName = from x in db.Member_EmployeeList
                            where x.Department == "門診"
                            select new CNurseName
                            {
                                Nurseid = x.Emp_ID,
                                NurseName = x.Name
                            };
            return NurseName;
        }
    }
}
