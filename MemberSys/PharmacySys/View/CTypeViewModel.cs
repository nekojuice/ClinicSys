using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSysMdiParent.View
{
    public class CTypeViewModel
    {
        private Pharmacy_tTypeList _tpyelist;
        public CTypeViewModel (Pharmacy_tTypeList tpyelist)
        {
            _tpyelist = tpyelist;
        }
        //public int fId { get { return _tpyelist.fId_Type; } }
        public string 代碼 { get { return _tpyelist.fTypeCode; } }
        public string 劑型 { get { return _tpyelist.fType; } }
    }
}
