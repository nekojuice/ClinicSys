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
    
    public partial class Attendance_tLeave
    {
        public int fLeaveID { get; set; }
        public int fEmployeeID { get; set; }
        public int fLeaveTypeID { get; set; }
        public Nullable<System.DateTime> fStartDate { get; set; }
        public Nullable<System.DateTime> fEndDate { get; set; }
        public string fSubstitute { get; set; }
        public string fLeaveStatus { get; set; }
        public string fLeaveDescription { get; set; }
    
        public virtual Member_EmployeeList Member_EmployeeList { get; set; }
        public virtual Attendance_tLeaveTypes Attendance_tLeaveTypes { get; set; }
    }
}