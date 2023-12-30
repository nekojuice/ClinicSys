using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIT155_E_MID.ApptSystem.Entity
{
    public class EntityCallingUnitDataType
    {
        public int patientClinicNumber { get; set; }
        public string patientName { get; set; }
        public string patientGender { get; set; }
        public string patientNationalID { get; set; }
        public string patientState { get; set; }
        public int patientStateId { get; set; }
        public DateTime patientBirth {  get; set; }
    }

    public class EntityCallingUnit_ClinicInfoType
    {
        public int docID { get; set; }
        public string date { get; set; }
        public string docName { get; set; }
        public string roomName { get; set; }
        public int clinicID { get; set; }
        public string deptName {  get; set; }

        public int nurseID {  get; set; }

        public string nurseName { get; set;}
    }
}
