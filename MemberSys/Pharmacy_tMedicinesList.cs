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
    
    public partial class Pharmacy_tMedicinesList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pharmacy_tMedicinesList()
        {
            this.Cases_Prescriptionlist = new HashSet<Cases_Prescriptionlist>();
            this.Pharmacy_tClinicalUseDetails = new HashSet<Pharmacy_tClinicalUseDetails>();
            this.Pharmacy_tTypeDetails = new HashSet<Pharmacy_tTypeDetails>();
            this.Pharmacy_tSideEffectDetails = new HashSet<Pharmacy_tSideEffectDetails>();
        }
    
        public int fId_Drug { get; set; }
        public string fDrugCode { get; set; }
        public string fGenericName { get; set; }
        public string fTradeName { get; set; }
        public string fDrugName { get; set; }
        public string fDrugDose { get; set; }
        public string fMaxDose { get; set; }
        public string fPrecautions { get; set; }
        public string fWarnings { get; set; }
        public string fPregnancyCategory { get; set; }
        public string fApperance { get; set; }
        public string fImages { get; set; }
        public string fStorage { get; set; }
        public string fSupplier { get; set; }
        public string fBrand { get; set; }
        public string fDosage { get; set; }
        public Nullable<int> fDay { get; set; }
        public Nullable<int> fEachTime { get; set; }
        public Nullable<int> fDurationDays { get; set; }
        public Nullable<int> fQty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cases_Prescriptionlist> Cases_Prescriptionlist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pharmacy_tClinicalUseDetails> Pharmacy_tClinicalUseDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pharmacy_tTypeDetails> Pharmacy_tTypeDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pharmacy_tSideEffectDetails> Pharmacy_tSideEffectDetails { get; set; }
    }
}
