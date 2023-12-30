using ClinicSysMdiParent.Model;
using MemberSys;
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


namespace ClinicSysMdiParent.View
{
    public partial class FrmClinicScheduleEditor : Form
    {
        private DialogResult _isOK;
        public DialogResult confirm
        {
            get { return _isOK; }
        }

        CComboFactory x = new CComboFactory();
        List<int> _listforDoctorId = new List<int>();
        List<int> _listforRoomId = new List<int>();

        ClinicSysEntities db = new ClinicSysEntities();

        public FrmClinicScheduleEditor()
        {
            InitializeComponent();
        }


        private Schedule_ClinicSchedule _schedule = new Schedule_ClinicSchedule();
        public Schedule_ClinicSchedule schedule
        {
            get
            {
                if (_schedule == null)
                    schedule = new Schedule_ClinicSchedule();
                _schedule.Doctor_ID = Convert.ToInt32(combName.SelectedValue);  //GetSelectedDoctorId(combName.SelectedItem.ToString());
                _schedule.time_ID = Convert.ToInt32(combShifts.SelectedValue);
                _schedule.week = combweekday.SelectedIndex + 1;
                _schedule.Room_ID = Convert.ToInt32(combClinicroom.SelectedValue);

                return _schedule;
            }
            set
            {
                _schedule = value;
                combName.SelectedValue = _schedule.Doctor_ID;
                combShifts.SelectedValue = _schedule.time_ID;
                combweekday.SelectedIndex = _schedule.week + 1;
                combClinicroom.SelectedValue = _schedule.Room_ID;
                
            }
        }

        private int GetSelectedDoctorId(string selectedDoctorName)
        {
            var selectedDoctorList = x.FindDoctorname().Cast<CDoctorname>().ToList();
            var selectedDoctor = selectedDoctorList.FirstOrDefault(d => d.Dr姓名 == selectedDoctorName);

            if (selectedDoctor != null)
                return selectedDoctor.Drid;
            
            return 0;
        }

        private void FrmClinicScheduleEditor_Load(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;

            var doctors = x.FindDoctorname().ToList();
            doctors.Insert(0, new CDoctorname { Drid = 0, Dr姓名 = "" });
            combName.DataSource = doctors;
            combName.DisplayMember = "Dr姓名";
            combName.ValueMember = "DrId";

            var rooms = x.FindRoomNumber().ToList();
            rooms.Insert(0, new CRoomName { Roomid = 0, Room名 = "" });
            combClinicroom.DataSource = rooms;
            combClinicroom.DisplayMember = "Room名";
            combClinicroom.ValueMember = "Roomid";

            var shifts = x.FindShifts().ToList();
            shifts.Insert(0, new CClinicTime { ShiftID = 0, Shifts = "" });
            combShifts.DataSource = shifts;
            combShifts.DisplayMember = "Shifts";
            combShifts.ValueMember = "ShiftID";

        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();
        }

        private void btn確定_Click(object sender, EventArgs e)
        {
            if (!isUiValidated())
                return;

           
            if (IsDuplicateSchedule(schedule)) // 檢查是否已經存在相同排診
            {
                MessageBox.Show("該醫師在該時段已經有排診，不可重複排診。");
                return;
            }
            
            
            if (IsRoomOccupied(schedule))// 檢查是否有其他醫師在同一時段使用相同診間
            {
                MessageBox.Show("該時段的診間已經被其他醫師使用，請選擇其他診間。");
                return;
            }

            //todo: insert to db
            db.Schedule_ClinicSchedule.Add(schedule);
            db.SaveChanges();

           
            //_isOK = DialogResult.OK;
            this.Close();
        }


        private bool isUiValidated()//都有選取才能新增
        {
            string msg = "";
            if (combName.SelectedIndex == -1)
                msg += "\r\n必須選擇醫生";
            if (combweekday.SelectedIndex == -1)
                msg += "\r\n必須選擇星期";
            if (combShifts.SelectedIndex == -1)
                msg += "\r\n必須選擇時段";
            if (combClinicroom.SelectedIndex == -1)
                msg += "\r\n必須選擇診間";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }
        private bool IsDuplicateSchedule(Schedule_ClinicSchedule schedule)
        {
            // 在資料庫中檢查是否已經存在相同排診
            return db.Schedule_ClinicSchedule.Any(
                s => s.Doctor_ID == schedule.Doctor_ID &&
                     s.week == schedule.week &&
                     s.time_ID == schedule.time_ID &&
                     s.Room_ID == schedule.Room_ID);
        }

        private bool IsRoomOccupied(Schedule_ClinicSchedule schedule)
        {
            // 檢查是否有其他醫師在同一時段使用相同診間
            return db.Schedule_ClinicSchedule.Any(
                s => s.week == schedule.week &&
                     s.time_ID == schedule.time_ID &&
                     s.Room_ID == schedule.Room_ID &&
                     s.Doctor_ID != schedule.Doctor_ID);
        }


    }


}
