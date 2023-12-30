using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSysMdiParent.View
{
    public class CDrugViewModel
    {
        private Pharmacy_tMedicinesList _drug;
       // private Pharmacy_tTypeDetails _drugTypeDetails;
        public CDrugViewModel(Pharmacy_tMedicinesList drug)
        {
            _drug = drug;
            //_drugTypeDetails = drugTypeDetails;
        }
       
        
        public string 藥品代碼 { get { return _drug.fDrugCode; } }
        public string 學名 { get { return _drug.fGenericName; } }
        public string 商品名 { get { return _drug.fTradeName; } }
        public string 中文名 { get { return _drug.fDrugName; } }
        //public string 劑型 { get { return _drugTypeDetails.Pharmacy_tTpyeList.fType; } }
        public string 常用劑量 { get { return _drug.fDosage; } }
        
        public string 最大劑量 { get { return _drug.fMaxDose; } }
        public string 懷孕藥品分級 { get { return _drug.fPregnancyCategory; } }
        //public string 副作用 { get { return _drug.fTradeName; } }
        public string 注意事項 { get { return _drug.fPrecautions; } }
        public string 禁忌 { get { return _drug.fWarnings; } }
        public string 儲存方法 { get { return _drug.fStorage; } }
        public string 藥商 { get { return _drug.fSupplier; } }
        public string 廠牌 { get { return _drug.fBrand; } }
    }
}
