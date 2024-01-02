using MemberSys;
using prjCustomerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjRoom
{
    public partial class frmScheduleEditor : Form
    {
        private DialogResult _isOk;

        public DialogResult confirm
        {
            get { return _isOk; }
        }
        private Appointment_Room_Schedule _schedule;
        public Appointment_Room_Schedule schedule
        {

            get
            {
                if (_schedule == null)
                    _schedule = new Appointment_Room_Schedule();
                if (!string.IsNullOrEmpty(fbId.fieldValue))
                _schedule.Appointment_ID = Convert.ToInt32(fbId.fieldValue);
                _schedule.Room_ID = Convert.ToInt32(fbRoomId.fieldValue);
                _schedule.Member_ID= Convert.ToInt32(fbMemberId.fieldValue);
                _schedule.StartDate = fbStartDate.fieldValue;
                _schedule.EndDate = fbEndDate.fieldValue;
                _schedule.Doctor_ID = Convert.ToInt32(fbDoctorId.fieldValue);
                _schedule.Nurse_ID = Convert.ToInt32(fbNurseId.fieldValue);
                
                return _schedule;
            }
            set
            {
                _schedule = value;
                fbId.fieldValue = _schedule.Appointment_ID.ToString();
                fbRoomId.fieldValue = _schedule.Room_ID.ToString();
                fbMemberId.fieldValue = _schedule.Member_ID.ToString();
                fbStartDate.fieldValue = _schedule.StartDate;
                fbEndDate.fieldValue = _schedule.EndDate;
                fbDoctorId.fieldValue = _schedule.Doctor_ID.ToString();
                fbNurseId.fieldValue = _schedule.Nurse_ID.ToString();

            }
        }
        public  string  isUiValidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(fbRoomId.fieldValue))
                msg += "\r\n房間編號是必填欄位不可空白";
            if (string.IsNullOrEmpty(fbMemberId.fieldValue))
                msg += "\r\n患者編號是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbRoomId.fieldValue) )
              
                msg += "\r\n房間編號必須輸入";
            if(!int.TryParse(fbRoomId.fieldValue,out int a))
                msg += "\r\n房間編號必須輸入數字";
            if (!string.IsNullOrEmpty(fbMemberId.fieldValue) &&
             ! CNumberUtility.isNumber(fbMemberId.fieldValue))
                msg += "\r\n患者編號必須輸入數字";
            if (string.IsNullOrEmpty(fbDoctorId.fieldValue))
                msg += "\r\n醫生編號是必填欄位不可空白";
            if (string.IsNullOrEmpty(fbNurseId.fieldValue))
                msg += "\r\n護士編號是必填欄位，不可空白";

          
            return msg;
        }
        public frmScheduleEditor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errormsg = isUiValidated();
            if (!string.IsNullOrEmpty(errormsg))
            {
                MessageBox.Show(errormsg);
                return;
            }
            _isOk = DialogResult.OK;
            this.Close();
        }

      
    }
}
