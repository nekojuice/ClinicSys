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
    
    public partial class tCoupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tCoupon()
        {
            this.tOrder = new HashSet<tOrder>();
            this.tOrder1 = new HashSet<tOrder>();
            this.tOrder2 = new HashSet<tOrder>();
            this.tCouponWallet = new HashSet<tCouponWallet>();
        }
    
        public int Id { get; set; }
        public string fName { get; set; }
        public string fCategory { get; set; }
        public byte[] fPicture { get; set; }
        public int fValue { get; set; }
        public int fCriteria { get; set; }
        public string fDescription { get; set; }
        public System.DateTime fStartDate { get; set; }
        public System.DateTime fEndDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrder> tOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrder> tOrder1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrder> tOrder2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCouponWallet> tCouponWallet { get; set; }
    }
}