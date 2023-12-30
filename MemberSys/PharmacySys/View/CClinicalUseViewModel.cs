using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSysMdiParent.View
{
    public class CClinicalUseViewModel
    {
        private Pharmacy_tClinicalUseList _clinicaluselist;
        public CClinicalUseViewModel(Pharmacy_tClinicalUseList clinicaluselist)
        {
            _clinicaluselist = clinicaluselist;
        }
        public string 代碼 { get { return _clinicaluselist.fClinicalUseCode; } }
        public string 衛生署許可證適應症 { get { return _clinicaluselist.fClinicalUse; } }
         
    }
}
