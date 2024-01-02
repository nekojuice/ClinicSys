using MemberSys;
using MSIT155_E_MID.ApptSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT155_E_MID.ApptSystem.Model
{
    public class CApptManager_Model
    {
        ClinicSysEntities db = new ClinicSysEntities();

        public IQueryable GetScheduleYM()   //回傳有排班的年/月
        {
            var result = from tSchedule in db.Schedule_ClinicInfo select tSchedule.date.Substring(0, 7);
            return result.Distinct();
        }
        public IQueryable GetDocName(string dept)   //(依科別)回傳所有醫生名
        {

            if (dept != "全部")
            {
                return from tEmpList in db.Member_EmployeeList
                       where tEmpList.Emp_Type == "醫生" && tEmpList.Department == dept
                       select tEmpList.Name;
            }
            return from tEmpList in db.Member_EmployeeList
                   where tEmpList.Emp_Type == "醫生"
                   select tEmpList.Name;
        }

        public IQueryable GetClinicSchedule(string start, string end, string dept, string docName)   //依月份/科別/醫生名顯示門診
        {
            var result = from Schedule_ClinicInfo in db.Schedule_ClinicInfo
                         join tClinicTime in db.Schedule_ClinicTime on Schedule_ClinicInfo.ClinicTime_ID equals tClinicTime.ClinicTime_ID
                         join tMember_EmployeeList in db.Member_EmployeeList on Schedule_ClinicInfo.doctor_ID equals tMember_EmployeeList.Emp_ID
                         where tMember_EmployeeList.Emp_Type == "醫生"
                         && Schedule_ClinicInfo.date.CompareTo(start) >= 0
                         && Schedule_ClinicInfo.date.CompareTo(end) <= 0
                         orderby Schedule_ClinicInfo.date, tClinicTime.ClinicTime_ID
                         select new EntityApptLINQDataType
                         {
                             clinic_ID = Schedule_ClinicInfo.ClinicInfo_ID,
                             date = Schedule_ClinicInfo.date,
                             clinicShifts = tClinicTime.ClinicShifts,
                             department = tMember_EmployeeList.Department,
                             docname = tMember_EmployeeList.Name,
                             registrationLimit = (int)Schedule_ClinicInfo.RegistrationLimit
                         };

            if (dept != "全部" && docName != "全部")    //兩個都有指定
            {
                return result.Where(x => x.department == dept && x.docname == docName);
            }
            if (dept != "全部")   //科別指定
            {
                return result.Where(x => x.department == dept);
            }
            if (docName != "全部")    //醫生指定
            {
                return result.Where(x => x.docname == docName);
            }

            return result;  //都沒有指定(都是全部)


        }

        public int GetApptPatientCount(int clinicID)
        {
            var result = from tClinicList in db.Appt_ClinicList
                         join tAppt_PatientState_Ref in db.Appt_PatientState_Ref on tClinicList.PatientState_ID equals tAppt_PatientState_Ref.PatientState_ID
                         where tClinicList.Clinic_ID == clinicID
                         select tClinicList;
            return result.Count();
        }
        public EntityApptLINQDataType GetClinicInfo(int clinicID)
        {
            var result = from tClinicList in db.Appt_ClinicList
                         join tSchedule_ClinicInfo in db.Schedule_ClinicInfo on tClinicList.Clinic_ID equals tSchedule_ClinicInfo.ClinicInfo_ID
                         join tAppt_PatientState_Ref in db.Appt_PatientState_Ref on tClinicList.PatientState_ID equals tAppt_PatientState_Ref.PatientState_ID
                         join tClinicTime in db.Schedule_ClinicTime on tSchedule_ClinicInfo.ClinicTime_ID equals tClinicTime.ClinicTime_ID
                         join tEmployeeList in db.Member_EmployeeList on tSchedule_ClinicInfo.doctor_ID equals tEmployeeList.Emp_ID
                         join tMemberList in db.Member_MemberList on tClinicList.Member_ID equals tMemberList.Member_ID
                         where tClinicList.Clinic_ID == clinicID
                         orderby tClinicList.ClinicNumber
                         select new EntityApptLINQDataType
                         {
                             clinic_ID = tClinicList.Clinic_ID,
                             date =tSchedule_ClinicInfo.date,
                             clinicShifts = tClinicTime.ClinicShifts,
                             department = tEmployeeList.Department,
                             docname = tEmployeeList.Name,
                             registrationLimit = (int)tSchedule_ClinicInfo.RegistrationLimit,
                         };
            try
            {
                return result.First();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public IQueryable GetClinicData(int clinicID)
        {
            var result = from tClinicList in db.Appt_ClinicList
                         join Schedule_ClinicInfo in db.Schedule_ClinicInfo on tClinicList.Clinic_ID equals Schedule_ClinicInfo.ClinicInfo_ID
                         join tAppt_PatientState_Ref in db.Appt_PatientState_Ref on tClinicList.PatientState_ID equals tAppt_PatientState_Ref.PatientState_ID
                         join tClinicTime in db.Schedule_ClinicTime on Schedule_ClinicInfo.ClinicTime_ID equals tClinicTime.ClinicTime_ID
                         join tEmployeeList in db.Member_EmployeeList on Schedule_ClinicInfo.doctor_ID equals tEmployeeList.Emp_ID
                         join tMemberList in db.Member_MemberList on tClinicList.Member_ID equals tMemberList.Member_ID
                         where tClinicList.Clinic_ID == clinicID
                         orderby tClinicList.ClinicNumber
                         select new EntityApptLINQDataType
                         {
                             clinic_ID = tClinicList.Clinic_ID,
                             date = Schedule_ClinicInfo.date,
                             clinicShifts = tClinicTime.ClinicShifts,
                             department = tEmployeeList.Department,
                             docname = tEmployeeList.Name,
                             registrationLimit = (int)Schedule_ClinicInfo.RegistrationLimit,

                             member_ID = tMemberList.Member_ID,
                             member_name = tMemberList.Name,
                             member_birth = tMemberList.Birth_Date,
                             member_gender = tMemberList.Gender,
                             member_National_ID = tMemberList.National_ID,
                             patientClinicNumber = tClinicList.ClinicNumber,
                             patientState_ID = tClinicList.PatientState_ID,
                             patientState_Name = tAppt_PatientState_Ref.PatientState_Name,
                             patient_isCancelled = tClinicList.IsCancelled,
                             isVIP = tClinicList.IsVIP
                         };
            return result;
        }

        public IQueryable GetPatientInfo(string keyWord)
        {
            var result = from tMemberList in db.Member_MemberList
                         where tMemberList.National_ID.Contains(keyWord)
                         || tMemberList.Name.Contains(keyWord)
                         select new EntityApptLINQDataType
                         {
                             member_name = tMemberList.Name,
                             member_gender = tMemberList.Gender,
                             member_National_ID = tMemberList.National_ID,
                             member_birth = tMemberList.Birth_Date,
                             member_ID = tMemberList.Member_ID
                         };
            return result;
        }
        //已棄用
        /*public void AddNewAppt(int clinic_ID, string member_NationalID, bool isVIP)
        {
            var result = db.Member_MemberList.Where(tMemberList => tMemberList.National_ID == member_NationalID);
            int member_ID = result.First().Member_ID;

            try
            {
                db.Appt_ClinicList.Add(new Appt_ClinicList()
                {
                    Clinic_ID = clinic_ID,
                    Member_ID = member_ID,
                    PatientState_ID = 1,
                    IsCancelled = false,
                    IsVIP = isVIP,
                });
                db.SaveChanges();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("新增掛號失敗，可能原因如下:\r\n" +
                    " 1. 此病患沒有加入會員(沒有建檔)\r\n" +
                    " 2. 其他錯誤發生");
                throw;
            }
        }*/
        public void AddNewAppt2(int clinic_ID, string member_NationalID, bool isVIP)
        {
            //依身分證撈出會員ID
            var result1 = db.Member_MemberList.Where(tMemberList => tMemberList.National_ID == member_NationalID);
            int member_ID = result1.First().Member_ID;
            //撈出最大診號
            var result2 = from tClinicList in db.Appt_ClinicList
                          join tMemberList in db.Member_MemberList on tClinicList.Member_ID equals tMemberList.Member_ID
                          where tClinicList.Clinic_ID == clinic_ID
                          && tClinicList.IsVIP == isVIP
                          select tClinicList;

            int maxClinicNumber = isVIP ? -1 : 0;
            try
            { maxClinicNumber = result2.Max(x => x.ClinicNumber); }
            catch (Exception)
            { }

            try
            {
                db.Appt_ClinicList.Add(new Appt_ClinicList()
                {
                    Clinic_ID = clinic_ID,
                    Member_ID = member_ID,
                    ClinicNumber = maxClinicNumber + 2,
                    PatientState_ID = 8,
                    IsCancelled = false,
                    IsVIP = isVIP,
                });
                db.SaveChanges();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("新增掛號失敗，可能原因如下:\r\n" +
                    " 1. 此病患沒有加入會員(沒有建檔)\r\n" +
                    " 2. 其他錯誤發生");
                throw;
            }
        }



        public bool IsRegularNewAppt(int clinic_ID, string member_NationalID)  //查詢病患是否重複掛號當診
        {
            var result = from tClinicList in db.Appt_ClinicList
                         join tMemberList in db.Member_MemberList on tClinicList.Member_ID equals tMemberList.Member_ID
                         where tClinicList.Clinic_ID == clinic_ID
                         && tMemberList.National_ID == member_NationalID
                         && tClinicList.IsCancelled == false
                         select tClinicList;
            if (result.Count() > 0)
                return true;
            else
                return false;
        }

        public EntityApptLINQDataType GetClinicOneAppt(int clinic_ID, string member_NationalID)
        {
            var result = from tClinicList in db.Appt_ClinicList
                         join tMemberList in db.Member_MemberList on tClinicList.Member_ID equals tMemberList.Member_ID
                         join tPatientState_Ref in db.Appt_PatientState_Ref on tClinicList.PatientState_ID equals tPatientState_Ref.PatientState_ID
                         where tClinicList.Clinic_ID == clinic_ID
                         && tMemberList.National_ID == member_NationalID
                         select new EntityApptLINQDataType()
                         {
                             member_name = tMemberList.Name,
                             member_gender = tMemberList.Gender,
                             member_National_ID = tMemberList.National_ID,
                             member_birth = tMemberList.Birth_Date,

                             patient_isCancelled = tClinicList.IsCancelled,
                             patientState_Name = tPatientState_Ref.PatientState_Name,
                             isVIP = tClinicList.IsVIP
                         };
            try
            {
                return result.First();
            }
            catch (Exception)
            {
                MessageBox.Show("資料已變動，請重新整理");

                return null;
            }

        }

        public void DeleteAppt(int Clinic_ID, string member_NationalID)
        {
            var result1 = db.Member_MemberList.Where(tMemberList => tMemberList.National_ID == member_NationalID);
            int member_ID = result1.First().Member_ID;

            Appt_ClinicList result2 = db.Appt_ClinicList.Where(
                x => x.Clinic_ID == Clinic_ID && x.Member_ID == member_ID).First();

            db.Appt_ClinicList.Remove(result2);
            db.SaveChanges();
        }
        public void ModifyAppt(int Clinic_ID, string member_NationalID, bool isCanceled, string state)
        {
            var result1 = db.Member_MemberList.Where(tMemberList => tMemberList.National_ID == member_NationalID);
            int member_ID = result1.First().Member_ID;

            var result2 = db.Appt_PatientState_Ref.Where(t => t.PatientState_Name == state);
            int state_ID = result2.First().PatientState_ID;

            var result3 = db.Appt_ClinicList.Where(t => t.Clinic_ID == Clinic_ID && t.Member_ID == member_ID);
            Appt_ClinicList target = result3.First();
            if (target != null)
            {
                target.IsCancelled = isCanceled;
                target.PatientState_ID = state_ID;
                db.SaveChanges();
            }
        }

        public int GetClinicApptLimit(int Clinic_ID)
        {
            var result = db.Schedule_ClinicInfo.Where(x => x.ClinicInfo_ID == Clinic_ID);
            return (int)result.First().RegistrationLimit;
        }
        public void ModifyApptLimit(int Clinic_ID, int limit)
        {
            var target = db.Schedule_ClinicInfo.Where(x => x.ClinicInfo_ID == Clinic_ID);
            target.First().RegistrationLimit = limit;
            db.SaveChanges();
        }
        public IQueryable GetPatientAllAppt(string member_NationalID, string selectedYM)
        {
            var result1 = from tAppt_ClinicList in db.Appt_ClinicList
                          join tSchedule_ClinicInfo in db.Schedule_ClinicInfo on tAppt_ClinicList.Clinic_ID equals tSchedule_ClinicInfo.ClinicInfo_ID
                          join tMember_MemberList in db.Member_MemberList on tAppt_ClinicList.Member_ID equals tMember_MemberList.Member_ID
                          join tSchedule_ClinicSchedule in db.Schedule_ClinicInfo on tAppt_ClinicList.Clinic_ID equals tSchedule_ClinicSchedule.ClinicInfo_ID
                          join tMember_EmployeeList in db.Member_EmployeeList on tSchedule_ClinicInfo.doctor_ID equals tMember_EmployeeList.Emp_ID
                          join tAppt_PatientState_Ref in db.Appt_PatientState_Ref on tAppt_ClinicList.PatientState_ID equals tAppt_PatientState_Ref.PatientState_ID
                          join tSchedule_ClinicTime in db.Schedule_ClinicTime on tSchedule_ClinicSchedule.ClinicTime_ID equals tSchedule_ClinicTime.ClinicTime_ID
                          where tMember_MemberList.National_ID == member_NationalID
                          && tSchedule_ClinicInfo.date.StartsWith(selectedYM)
                          orderby tSchedule_ClinicInfo.date, tSchedule_ClinicTime.ClinicTime_ID
                          select new EntityApptLINQDataType
                          {
                              //member_name = tMember_MemberList.Name,    //患者姓名
                              //member_National_ID = member_NationalID,   //患者身分證
                              //member_gender = tMember_MemberList.Gender,    //患者性別
                              //member_birth = tMember_MemberList.Birth_Date, //患者生日

                              clinic_ID = tAppt_ClinicList.Clinic_ID,
                              date = tSchedule_ClinicSchedule.date, //門診日期
                              clinicShifts = tSchedule_ClinicTime.ClinicShifts, //門診時段
                              department = tMember_EmployeeList.Department, //科別
                              docname = tMember_EmployeeList.Name,  //醫生
                              patientClinicNumber = tAppt_ClinicList.ClinicNumber,  //診號
                              patient_isCancelled = tAppt_ClinicList.IsCancelled,   //是否退掛
                              isVIP = tAppt_ClinicList.IsVIP    //是否VIP
                          };
            return result1;
        }

        public IQueryable GetPatientTodayAppt(string member_NationalID, string today)
        {
            var result = from tAppt_ClinicList in db.Appt_ClinicList
                         join tSchedule_ClinicInfo in db.Schedule_ClinicInfo on tAppt_ClinicList.Clinic_ID equals tSchedule_ClinicInfo.ClinicInfo_ID
                         join tMember_EmployeeList in db.Member_EmployeeList on tSchedule_ClinicInfo.doctor_ID equals tMember_EmployeeList.Emp_ID
                         join tMember_MemberList in db.Member_MemberList on tAppt_ClinicList.Member_ID equals tMember_MemberList.Member_ID
                         join tSchedule_ClinicSchedule in db.Schedule_ClinicInfo on tAppt_ClinicList.Clinic_ID equals tSchedule_ClinicSchedule.ClinicInfo_ID
                         join tSchedule_ClinicTime in db.Schedule_ClinicTime on tSchedule_ClinicInfo.ClinicTime_ID equals tSchedule_ClinicTime.ClinicTime_ID
                         where tMember_MemberList.National_ID == member_NationalID
                         && tSchedule_ClinicInfo.date == today
                         orderby tSchedule_ClinicTime.ClinicTime_ID
                         select new EntityApptLINQDataType
                         {
                             department = tMember_EmployeeList.Department,
                             clinic_ID = tAppt_ClinicList.Clinic_ID,
                             member_name = tMember_MemberList.Name,
                             docname = tMember_EmployeeList.Name,
                             clinicShifts = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                             patientClinicNumber = tAppt_ClinicList.ClinicNumber,
                             patientState_Name = tAppt_ClinicList.Appt_PatientState_Ref.PatientState_Name
                         };
            return result;
        }

        public int GetEmpID(string empName) 
        {
            var result = from t in db.Member_EmployeeList
                         where t.Name == empName
                         select t.Emp_ID;
            return result.FirstOrDefault();
        }
    }

}
