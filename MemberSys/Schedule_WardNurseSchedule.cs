//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemberSys
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule_WardNurseSchedule
    {
        public int WardNurseSchedule_ID { get; set; }
        public int Emp_ID { get; set; }
        public int WardRoom_ID { get; set; }
        public int WardShiftsTime_ID { get; set; }
        public string date { get; set; }
        public int LeaveStatus { get; set; }
    
        public virtual Member_EmployeeList Member_EmployeeList { get; set; }
        public virtual RoomList RoomList { get; set; }
        public virtual Schedule_WardShiftsTime Schedule_WardShiftsTime { get; set; }
    }
}
