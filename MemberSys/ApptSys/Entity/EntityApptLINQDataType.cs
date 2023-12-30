using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIT155_E_MID.ApptSystem.Entity
{
    public class EntityApptLINQDataType
    {
        [DisplayName("流水號")]
        public int clinic_ID { get; set; }
        [DisplayName("日期")]
        public string date { get; set; }
        [DisplayName("時段")]
        public string clinicShifts { get; set; }
        [DisplayName("科別")]
        public string department { get; set; }
        [DisplayName("醫師姓名")]
        public string docname { get; set; }
        [DisplayName("上限人數")]
        public int registrationLimit { get; set; }

        [DisplayName("會員編號")]
        public int member_ID { get; set; }
        [DisplayName("病患姓名")]
        public string member_name { get; set; }
        [DisplayName("生日")]
        public DateTime member_birth { get; set; }
        [DisplayName("性別")]
        public bool member_gender { get; set; }
        [DisplayName("身分證字號")]
        public string member_National_ID { get; set; }
        [DisplayName("診號")]
        public int patientClinicNumber { get; set; }
        [DisplayName("看診狀態編號")]
        public int patientState_ID { get; set; }
        [DisplayName("看診狀態")]
        public string patientState_Name { get; set; }
        [DisplayName("是否退掛")]
        public bool patient_isCancelled { get; set; }
        [DisplayName("VIP")]
        public bool isVIP {  get; set; }

    }
}
