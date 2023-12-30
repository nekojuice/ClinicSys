using MemberSys;
using MSIT155_E_MID.ApptSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT155_E_MID.ApptSystem.Model
{
    public class CApptCallingUnit_Model
    {
        ClinicSysEntities db = new ClinicSysEntities();
        public (IQueryable, IQueryable) GetTodayPatientList(int docID, string today, string timeShift)
        {
            var result = from t in db.Schedule_ClinicInfo
                         join time in db.Schedule_ClinicTime on t.ClinicTime_ID equals time.ClinicTime_ID
                         join appt in db.Appt_ClinicList on t.ClinicInfo_ID equals appt.Clinic_ID
                         join state in db.Appt_PatientState_Ref on appt.PatientState_ID equals state.PatientState_ID
                         join member in db.Member_MemberList on appt.Member_ID equals member.Member_ID
                         where t.date == today
                         && t.doctor_ID == docID
                         && time.ClinicShifts == timeShift
                         orderby appt.PatientState_ID, appt.ClinicNumber
                         select new EntityCallingUnitDataType
                         {
                             patientStateId = appt.PatientState_ID,
                             patientClinicNumber = appt.ClinicNumber,
                             patientName = member.Name,
                             patientGender = member.Gender ? "男" : "女",
                             patientNationalID = member.National_ID,
                             patientState = state.PatientState_Name,
                             patientBirth = member.Birth_Date
                         };
            return (result.Where(x => x.patientStateId != 4 && x.patientStateId != 2), result.Where(x => x.patientStateId == 4 || x.patientStateId == 2));
        }
        public (int, int) GetClinitState(int docID, string today, string timeShift)
        {
            var result = from t in db.Schedule_ClinicInfo
                         join time in db.Schedule_ClinicTime on t.ClinicTime_ID equals time.ClinicTime_ID
                         where t.doctor_ID == docID
                         && t.date == today
                         && time.ClinicShifts == timeShift
                         select t;
            int tes = result.Count();
            if (result.Count() > 0)
            {
                return ((int)result.First().ClinicInfo_ID, (int)result.First().JumpStatus);
            }
            else
                return (0, 0);
        }
        public EntityCallingUnit_ClinicInfoType GetClinitInfo(int docID, string today)
        {
            var result1 = from t in db.Schedule_ClinicInfo
                          join time in db.Schedule_ClinicTime on t.ClinicTime_ID equals time.ClinicTime_ID
                          join room in db.RoomList on t.ClincRoom_ID equals room.Room_ID
                          where t.doctor_ID == docID
                          && t.date == today
                          select new EntityCallingUnit_ClinicInfoType
                          {
                              date = t.date,
                              docID = docID,
                              docName = t.Member_EmployeeList.Name,
                              roomName = room.Name,
                              deptName = t.Member_EmployeeList.Department
                          };
            var result2 = from t in db.Schedule_ClinicInfo
                          join time in db.Schedule_ClinicTime on t.ClinicTime_ID equals time.ClinicTime_ID
                          join room in db.RoomList on t.ClincRoom_ID equals room.Room_ID
                          join nurse in db.Schedule_NurseSchedule on t.ClinicInfo_ID equals nurse.Clinic_ID
                          where t.doctor_ID == docID
                          && t.date == today
                          select new EntityCallingUnit_ClinicInfoType
                          {
                              nurseID = nurse.Emp_ID,
                              nurseName = nurse.Member_EmployeeList.Name
                          };
            EntityCallingUnit_ClinicInfoType ans = new EntityCallingUnit_ClinicInfoType();
            if (result1.Count() > 0)
            { ans = result1.FirstOrDefault(); }
            if (result2.Count() > 0)
            {
                ans.nurseID = result2.FirstOrDefault().nurseID;
                ans.nurseName = result2.FirstOrDefault().nurseName;
            }

            return ans;
        }
        public void UpdatePatientState(int docID, string today, string timeshift, string patientNationalID, int state)
        {
            var target = from t in db.Appt_ClinicList
                         join clinic in db.Schedule_ClinicInfo on t.Clinic_ID equals clinic.ClinicInfo_ID
                         join time in db.Schedule_ClinicTime on clinic.ClinicTime_ID equals time.ClinicTime_ID
                         join member in db.Member_MemberList on t.Member_ID equals member.Member_ID
                         where clinic.doctor_ID == docID
                         && clinic.date == today
                         && time.ClinicShifts == timeshift
                         && member.National_ID == patientNationalID
                         select new
                         {
                             clinicID = t.Clinic_ID,
                             memberID = member.Member_ID
                         };
            if (target.Count() <= 0)
            { return; }
            int clinicID = target.FirstOrDefault().clinicID;
            int memberID = target.FirstOrDefault().memberID;
            if (clinicID == 0 || memberID == 0)
            {
                System.Windows.Forms.MessageBox.Show("錯誤!");
                return;
            }
            Appt_ClinicList x = db.Appt_ClinicList.FirstOrDefault(
                a => a.Clinic_ID == clinicID
                && a.Member_ID == memberID
                );
            x.PatientState_ID = state;
            db.SaveChanges();
        }

        public int currentNumber(int ClinicID)  //目前看診號
        {
            var target = from t in db.Appt_ClinicList
                         where t.Clinic_ID == ClinicID
                         orderby t.PatientState_ID, t.ClinicNumber
                         select t;
            return target.FirstOrDefault().ClinicNumber;
        }

        public int getDocIdByNurseId(int nurseID)
        {
            var target = from t in db.Schedule_ClinicInfo
                         join nurse in db.Schedule_NurseSchedule on t.ClinicInfo_ID equals nurse.Clinic_ID
                         where nurse.Emp_ID == nurseID
                         select t.doctor_ID;
            return target.FirstOrDefault();
        }
    }

}
