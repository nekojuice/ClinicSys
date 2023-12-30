using ClinicSysMdiParent.Model;
using ClinicSysMdiParent.View;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClinicSysMdiParent
{
    public partial class FrmClinicInfoEditor : Form
    {
        private DialogResult _isOK;
        ClinicSysEntities db = new ClinicSysEntities();
        CComboFactory _x = new CComboFactory();

        public FrmClinicInfoEditor()
        {
            InitializeComponent();
        }
        private CClinicInfo _info;
        public CClinicInfo info
        {
            get 
            {
                info.date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                info.name = combName.Text;
                info.shifts = combShifts.Text;
                info.room = combClinicroom.Text;
                info.limit = txtlimit.Text;
                return _info;
            }

            set
            {
                _info = value;
                dateTimePicker1.Value = DateTime.Parse(value.date);
                string a = value.limit.Replace("人", "");
                txtlimit.Text = a;
            }
        }
        private Schedule_ClinicInfo _oldschedule = new Schedule_ClinicInfo();
        private Schedule_ClinicInfo _schedule = new Schedule_ClinicInfo();
        public Schedule_ClinicInfo schedule
        {
            get
            {
                if (_schedule == null)
                    schedule = new Schedule_ClinicInfo();
                _schedule.doctor_ID = Convert.ToInt32(combName.SelectedValue);
                _schedule.ClinicTime_ID = Convert.ToInt32(combShifts.SelectedValue);
                _schedule.date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                _schedule.ClincRoom_ID = Convert.ToInt32(combClinicroom.SelectedValue);
                _schedule.RegistrationLimit = Convert.ToInt32(txtlimit.Text);

                return _schedule;
            }
            set { _schedule = value; }
        }



        private void FrmClinicShedule_Load(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;

            var doctors = _x.FindDoctorname().ToList();
            doctors.Insert(0, new CDoctorname { Drid = 0, Dr姓名 = "" });
            combName.DataSource = doctors;
            combName.DisplayMember = "Dr姓名";
            combName.ValueMember = "DrId";

            var rooms = _x.FindRoomNumber().ToList();
            rooms.Insert(0, new CRoomName { Roomid = 0, Room名 = "" });
            combClinicroom.DataSource = rooms;
            combClinicroom.DisplayMember = "Room名";
            combClinicroom.ValueMember = "Roomid";

            var shifts = _x.FindShifts().ToList();
            shifts.Insert(0, new CClinicTime { ShiftID = 0, Shifts = "" });
            combShifts.DataSource = shifts;
            combShifts.DisplayMember = "Shifts";
            combShifts.ValueMember = "ShiftID";

            //讓combobox出現選中的資料(set)
            combName.SelectedItem = ((List<CDoctorname>)combName.DataSource).
                Where(x => x.Dr姓名 == _info.name).FirstOrDefault();
            combClinicroom.SelectedItem = ((List<CRoomName>)combClinicroom.DataSource).
                Where(x => x.Room名 == _info.room).FirstOrDefault();
            combShifts.SelectedItem=((List<CClinicTime>)combShifts.DataSource).
                Where(x => x.Shifts == _info.shifts).FirstOrDefault();
        }

        private void btn確定_Click(object sender, EventArgs e)
        {
            _oldschedule.date = _info.date;
            _oldschedule.doctor_ID = ((List<CDoctorname>)combName.DataSource).
                Where(x => x.Dr姓名 == _info.name).FirstOrDefault().Drid;
            _oldschedule.ClincRoom_ID = ((List<CRoomName>)combClinicroom.DataSource).
                Where(x => x.Room名 == _info.room).FirstOrDefault().Roomid;
            _oldschedule.ClinicTime_ID = ((List<CClinicTime>)combShifts.DataSource).
                Where(x => x.Shifts == _info.shifts).FirstOrDefault().ShiftID;
            _oldschedule.RegistrationLimit = Convert.ToInt32(_info.limit.Replace("人",""));


            Schedule_ClinicInfo a = db.Schedule_ClinicInfo.FirstOrDefault(x => x.date == _oldschedule.date 
            && x.doctor_ID ==_oldschedule.doctor_ID 
            && x.ClinicTime_ID ==_oldschedule.ClinicTime_ID 
            && x.ClincRoom_ID==_oldschedule.ClincRoom_ID 
            && x.RegistrationLimit == _oldschedule.RegistrationLimit);
            //a.date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            //a.doctor_ID = (int)combName.SelectedValue;
            a.ClinicTime_ID = (int)combShifts.SelectedValue;
            a.ClincRoom_ID = (int)combClinicroom.SelectedValue;
            a.RegistrationLimit = Convert.ToInt32(txtlimit.Text);

            db.SaveChanges();
            this.Close();
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();
        }
    }

} 





    
    

