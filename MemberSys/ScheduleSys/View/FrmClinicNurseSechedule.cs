using ClinicSysMdiParent.Model;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.View
{
    public partial class FrmClinicNurseSechedule : Form
    {
        ClinicSysEntities db = new ClinicSysEntities();
        CComboFactory x = new CComboFactory();
        public FrmClinicNurseSechedule()
        {
            InitializeComponent();
        }

        private void FrmClinicNurseSechedule_Activated(object sender, EventArgs e)
        {
            CStyle3.DataGridViewDesignForNurse(dataGridView1);
        }

        private void FrmClinicNurseSechedule_Load(object sender, EventArgs e)
        {
            PutDrNameInCombobox(comboDrName);
            PutNurseNameInCombobox(combNurseName);
            PutClinicRoomInCombobox(combClinicroom);
            PutClinicShiftInCombobox(combShifts);

            string r = DateTime.Now.ToString("yyyy/MM");

            var result = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                         where tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7) == r
                         orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                         tSchedule_NurseSchedule.Schedule_ClinicInfo.ClinicTime_ID
                         select new
                         {
                             跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                             醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                             科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                             診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                             時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                             時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                             日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                             人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                         };

            dataGridView1.DataSource = result.ToList();
        }


        private void btn查詢_Click(object sender, EventArgs e)
        {
            if (combodepartment.SelectedIndex != 0)
            {
                string t = (dateTimePickerSearch.Value).ToString("yyyy/MM");
                string d = combodepartment.Text;
                var schedules = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                       where tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department == d
                                        && (t == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                       tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                       select new
                                       {
                                           跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                           醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                           人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                dataGridView1.DataSource = schedules.ToList();
                CStyle3.DataGridViewDesignForNurse(dataGridView1);
                combodepartment.SelectedIndex = 0;
            }

            if(comboDrName.SelectedIndex != 0)
            {
                string t = (dateTimePickerSearch.Value).ToString("yyyy/MM");
                var schedules = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                       where tSchedule_NurseSchedule.Schedule_ClinicInfo.doctor_ID == (int)comboDrName.SelectedValue
                                        && (t == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                       tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                       select new
                                       {
                                           跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                           醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                           人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                dataGridView1.DataSource = schedules.ToList();
                CStyle3.DataGridViewDesignForNurse(dataGridView1);
                comboDrName.SelectedIndex = 0;
            }

            if(combNurseName.SelectedIndex != 0)
            {
                string t = (dateTimePickerSearch.Value).ToString("yyyy/MM");
                var schedules = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                       where tSchedule_NurseSchedule.Emp_ID == (int)combNurseName.SelectedValue
                                        && (t == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                       tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                       select new
                                       {
                                           跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                           醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                           人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                dataGridView1.DataSource = schedules.ToList();
                CStyle3.DataGridViewDesignForNurse(dataGridView1);
                combNurseName.SelectedIndex = 0;
            }


            if (combClinicroom.SelectedIndex != 0)
            {
                string t = (dateTimePickerSearch.Value).ToString("yyyy/MM");
                string d = combodepartment.Text;
                var schedules = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                       where tSchedule_NurseSchedule.Schedule_ClinicInfo.ClincRoom_ID == (int)combClinicroom.SelectedValue
                                        && (t == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                       tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                       select new
                                       {
                                           跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                           醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                           人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                dataGridView1.DataSource = schedules.ToList();
                CStyle3.DataGridViewDesignForNurse(dataGridView1);
                combClinicroom.SelectedIndex = 0;
            }

            if (combShifts.SelectedIndex != 0)
            {
                string t = (dateTimePickerSearch.Value).ToString("yyyy/MM");
                string d = combodepartment.Text;
                var schedules = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                       where tSchedule_NurseSchedule.Schedule_ClinicInfo.ClinicTime_ID == (int)combShifts.SelectedValue
                                        && (t == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                       tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                       select new
                                       {
                                           跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                           醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                           人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                dataGridView1.DataSource = schedules.ToList();
                CStyle3.DataGridViewDesignForNurse(dataGridView1);
                combShifts.SelectedIndex = 0;
            }
        }

        private void btnScheduling_Click(object sender, EventArgs e)
        {
            var HaveSchedules = db.Schedule_ClinicInfo.AsEnumerable()
                .Where(s => DateTime.Parse(s.date).ToString("yyyy/MM") ==
                dateTimePickerSearch.Value.ToString("yyyy/MM")).ToList();

            string x = dateTimePickerSearch.Value.ToString("yyyy/MM");
            var info = from NurseSchedule in db.Schedule_NurseSchedule
                       join ClinicInfo in db.Schedule_ClinicInfo on NurseSchedule.Clinic_ID equals ClinicInfo.ClinicInfo_ID
                       where ClinicInfo.date.StartsWith(x)
                       select NurseSchedule;
            var firstInfo = info.FirstOrDefault();

            if (!isUiValidated())
                return;

            if (HaveSchedules.Any())//1.先找該月份是否有門診資訊
            {
                if (firstInfo!=null && firstInfo.Schedule_ClinicInfo.doctor_ID == (int)comboDrName.SelectedValue)//2.找要排的診是否已經有護士 
                {
                    //MessageBox.Show("此月份該醫師門診已有跟診護士");
                    DialogResult result = MessageBox.Show
                   ("此月份該醫師門診已有跟診護士，是否要更新？", "提醒", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                        return;

                        var schedule = from Schedule in db.Schedule_NurseSchedule
                                   where Schedule.Schedule_ClinicInfo.date.Substring(0,7)== x &&
                                   Schedule.Schedule_ClinicInfo.doctor_ID == (int)comboDrName.SelectedValue
                                   select Schedule;
                    db.Schedule_NurseSchedule.RemoveRange(schedule);
                    db.SaveChanges();
                    AddNurseSchedule();
                }
                else
                {
                    if (firstInfo != null && firstInfo.Emp_ID == (int)combNurseName.SelectedValue)//3.找護士該月份是否已有被排其他診
                    {
                        //MessageBox.Show("該護士已存在相同月份的排班");
                        DialogResult result = MessageBox.Show
                            ("該護士已存在相同月份的排班，是否要更新？", "提醒", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                            return;

                        var schedule = from Schedule in db.Schedule_NurseSchedule
                                       where Schedule.Schedule_ClinicInfo.date.Substring(0, 7) == x &&
                                       Schedule.Emp_ID == (int)combNurseName.SelectedValue
                                       select Schedule;
                        db.Schedule_NurseSchedule.RemoveRange(schedule); 
                        db.SaveChanges();
                        AddNurseSchedule();
                    }
                    else
                    {
                        AddNurseSchedule();
                    }
                }
            }
            else
            {
                MessageBox.Show("該月份目前沒有門診資訊,無法新增跟診護士");
                return;
            }

            string r = (dateTimePickerSearch.Value).ToString("yyyy/MM");
            var Nurseschedule = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                where (r == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0, 7)
                                && (int)combNurseName.SelectedValue == tSchedule_NurseSchedule.Emp_ID)
                                orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date
                                ,tSchedule_NurseSchedule.Schedule_ClinicInfo.ClinicTime_ID
                                select new
                                {
                                    跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                    醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                    科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                    診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                    時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                    時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                    日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                    人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                };
            dataGridView1.DataSource = Nurseschedule.ToList();
            CStyle3.DataGridViewDesignForNurse(dataGridView1);

            combNurseName.SelectedIndex = -1;
            comboDrName.SelectedIndex = -1;
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string r = (dateTimePicker1.Value).ToString("yyyy/MM/dd");
            var schedulesFromDb = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                  where (r == tSchedule_NurseSchedule.Schedule_ClinicInfo.date)
                                  orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.ClinicTime_ID,
                                  tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department
                                  select new
                                  {
                                      跟診護士 =tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                      醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                      科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                      診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                      時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                      時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                      日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                      人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                  };

            var re = schedulesFromDb.ToList().Select(item => new
            {
                跟診護士 = item.跟診護士,
                醫師 = item.醫師,
                科別 = item.科別,
                診間 = item.診間,
                時段 = item.時段,
                時間 = item.時間,
                日期 = item.日期,
                星期 = CGetChineseWeek.GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                掛號上限 = item.人數上限
            });
            dataGridView1.DataSource = re.ToList();
            CStyle3.DataGridViewDesignForNurse(dataGridView1);
        }


        private void PutNurseNameInCombobox(ComboBox name)
        {
            var nurse = x.FindNurseName().ToList();
            nurse.Insert(0, new CNurseName { Nurseid = 0, NurseName = "" });
            combNurseName.DataSource = nurse;
            combNurseName.DisplayMember = "NurseName";
            combNurseName.ValueMember = "Nurseid";
        }

        private void PutDrNameInCombobox(ComboBox name)
        {
            var doctors = x.FindDoctorname().ToList();
            doctors.Insert(0, new CDoctorname { Drid = 0, Dr姓名 = "" });
            comboDrName.DataSource = doctors;
            comboDrName.DisplayMember = "Dr姓名";
            comboDrName.ValueMember = "DrId";
        }

        private void PutClinicShiftInCombobox(ComboBox name)
        {
            var shifts = x.FindShifts().ToList();
            shifts.Insert(0, new CClinicTime { ShiftID = 0, Shifts = "" });
            name.DataSource = shifts;
            name.DisplayMember = "Shifts";
            name.ValueMember = "ShiftID";
        }

        private void PutClinicRoomInCombobox(ComboBox name)
        {
            var rooms = x.FindRoomNumber().ToList();
            rooms.Insert(0, new CRoomName { Roomid = 0, Room名 = "" });
            name.DataSource = rooms;
            name.DisplayMember = "Room名";
            name.ValueMember = "Roomid";
        }

        public void AddNurseSchedule()//排班 護士班表
        {
            string start = dateTimePickerSearch.Value.ToString("yyyy/MM"); //排班起始月

            var result = (from tSchedule_ClinicInfos in db.Schedule_ClinicInfo
                          where tSchedule_ClinicInfos.Member_EmployeeList.Name == comboDrName.Text &&
                          tSchedule_ClinicInfos.date.Substring(0, 7) == start
                          select new
                          {
                              id = tSchedule_ClinicInfos.ClinicInfo_ID,
                              醫師ID = tSchedule_ClinicInfos.Member_EmployeeList.Emp_ID,
                              科別 = tSchedule_ClinicInfos.Member_EmployeeList.Department,
                              診間ID = tSchedule_ClinicInfos.RoomList.Room_ID,
                              時段ID = tSchedule_ClinicInfos.Schedule_ClinicTime.ClinicTime_ID,
                              日期 = tSchedule_ClinicInfos.date
                          }).ToList();

            foreach (var clinicInfo in result)
            {
                // 在這裡添加門診護士排班
                Schedule_NurseSchedule nurseSchedule = new Schedule_NurseSchedule
                {
                    Clinic_ID = clinicInfo.id,  // 門診排班資料表的 ID
                    Emp_ID = (int)combNurseName.SelectedValue,
                    LeaveStatus = 0
                };

                db.Schedule_NurseSchedule.Add(nurseSchedule);
            }

            db.SaveChanges();
        }

        private void dateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            string r = (dateTimePickerSearch.Value).ToString("yyyy/MM");
            var schedulesFromDb = from tSchedule_NurseSchedule in db.Schedule_NurseSchedule
                                  where (r == tSchedule_NurseSchedule.Schedule_ClinicInfo.date.Substring(0,7))
                                  orderby tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                  tSchedule_NurseSchedule.Schedule_ClinicInfo.ClinicTime_ID,
                                  tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department
                                  select new
                                  {
                                      跟診護士 = tSchedule_NurseSchedule.Member_EmployeeList.Name,
                                      醫師 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Name,
                                      科別 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Member_EmployeeList.Department,
                                      診間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RoomList.Name,
                                      時段 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                      時間 = tSchedule_NurseSchedule.Schedule_ClinicInfo.Schedule_ClinicTime.time,
                                      日期 = tSchedule_NurseSchedule.Schedule_ClinicInfo.date,
                                      人數上限 = tSchedule_NurseSchedule.Schedule_ClinicInfo.RegistrationLimit + "人"
                                  };

            var re = schedulesFromDb.ToList().Select(item => new
            {
                跟診護士 = item.跟診護士,
                醫師 = item.醫師,
                科別 = item.科別,
                診間 = item.診間,
                時段 = item.時段,
                時間 = item.時間,
                日期 = item.日期,
                星期 = CGetChineseWeek.GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                掛號上限 = item.人數上限
            });
            dataGridView1.DataSource = re.ToList();
            CStyle3.DataGridViewDesignForNurse(dataGridView1);
        }

        private bool isUiValidated()//都有選取才能新增
        {
            string msg = "";
            if (combNurseName.SelectedIndex == 0)
                msg += "\r\n必須選擇醫生";
            if (comboDrName.SelectedIndex == 0)
                msg += "\r\n必須選擇護士";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }
    }
}

