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
    
    public partial class Cases_Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cases_Prescription()
        {
            this.Cases_Prescriptionlist = new HashSet<Cases_Prescriptionlist>();
        }
    
        public int Case_ID { get; set; }
        public int Prescription_ID { get; set; }
        public System.DateTime Prescription_Date { get; set; }
        public string Dispensing { get; set; }
    
        public virtual Cases_MainCase Cases_MainCase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cases_Prescriptionlist> Cases_Prescriptionlist { get; set; }
    }
}
