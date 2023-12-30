using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSysMdiParent.View
{
    public class CSideEffectViewModel
    {
        private Pharmacy_tSideEffectList _sideEffectList;
        public CSideEffectViewModel(Pharmacy_tSideEffectList sideEffectList) 
        {
            _sideEffectList = sideEffectList;
        }
        public string 代碼 { get { return _sideEffectList.fSideEffectCode; } }
        public string 副作用 { get { return _sideEffectList.fSideEffect; } }
    }
}
