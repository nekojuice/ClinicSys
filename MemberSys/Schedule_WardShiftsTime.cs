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
    
    public partial class Schedule_WardShiftsTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule_WardShiftsTime()
        {
            this.Schedule_WardNurseSchedule = new HashSet<Schedule_WardNurseSchedule>();
        }
    
        public int WardShiftsTime_ID { get; set; }
        public string Shifts { get; set; }
        public string ShiftsTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule_WardNurseSchedule> Schedule_WardNurseSchedule { get; set; }
    }
}
