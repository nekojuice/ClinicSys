using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIT155_E_MID.ApptSystem.Entity
{
    public class EntitySmartCardInfoType
    {
        public EntitySmartCardInfoType() { }
        public EntitySmartCardInfoType(EntitySmartCardInfoType x) 
        {
            cCardNumber = x.cCardNumber;
            cName =x.cName;
            cID=x.cID;
            cBirthday = x.cBirthday;
            cGender=x.cGender;
            cCardPublish=x.cCardPublish;
        }
        public string cCardNumber {  get; set; }
        public string cName { get; set;}
        public string cID { get; set;}
        public string cBirthday {  get; set;}
        public string cGender { get; set;}
        public string cCardPublish { get; set;}
    }
}
