using ClinicSysMdiParent.Model;
using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.View
{
    public partial class FrmDrSchedule : Form
    {
        ClinicSysEntities db = new ClinicSysEntities();
        CComboFactory x = new CComboFactory();
 
        public FrmDrSchedule()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

            ReFreshDataGridView();

        }

        private void ReFreshDataGridView() //秀出的是當月班表
        {
            string r = DateTime.Now.ToString("yyyy/MM"); //找到當天月份
            var schedulesFromDb = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                  where r == tSchedule_ClinicInfo.date.Substring(0, 7)
                                  orderby tSchedule_ClinicInfo.date, tSchedule_ClinicInfo.ClinicTime_ID,
                                  tSchedule_ClinicInfo.Member_EmployeeList.Department
                                  select new
                                  {
                                      醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                      科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                      診間 = tSchedule_ClinicInfo.RoomList.Name,
                                      時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                      時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                      日期 = tSchedule_ClinicInfo.date,
                                      人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                  };
            
            var re = schedulesFromDb.ToList()
                .Select(item => new
                {
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
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            CStyle3.DataGridViewDesign(dataGridView1);
        }

        private void btnSecheduling_Click(object sender, EventArgs e)  //排班按鈕
        {
            DateTime selectedtime = DTPickerSecheduling.Value;
            var schedules = db.Schedule_ClinicInfo.AsEnumerable()
                .Where(s => DateTime.Parse(s.date).ToString("yyyy-MM") == 
                selectedtime.ToString("yyyy-MM")).ToList();  //查詢是否有同月的班表

            var nurse = db.Schedule_NurseSchedule.AsEnumerable().
                Where(a => a.Clinic_ID == a.Schedule_ClinicInfo.ClinicInfo_ID && 
                DateTime.Parse(a.Schedule_ClinicInfo.date).ToString("yyyy-MM") == 
                selectedtime.ToString("yyyy-MM"));

            if (schedules.Any())
            {
                DialogResult result = MessageBox.Show
                    ("已存在相同月份的排班，是否要更新？", "提醒", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // 刪除之前的排班信息
                    db.Schedule_NurseSchedule.RemoveRange(nurse);
                    db.Schedule_ClinicInfo.RemoveRange(schedules);
                    db.SaveChanges();
                }
                else
                {
                    // 取消更新，不進行排班
                    return;
                }
            }
            ClinicScheduling();
            MessageBox.Show("成功完成排班");

            string r = (DTPickerSecheduling.Value).ToString("yyyy/MM");
            var schedulesFromDb = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                  where (r == tSchedule_ClinicInfo.date.Substring(0, 7))
                                  orderby tSchedule_ClinicInfo.date, tSchedule_ClinicInfo.ClinicTime_ID,
                                  tSchedule_ClinicInfo.Member_EmployeeList.Department
                                  select new
                                  {
                                      醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                      科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                      診間 = tSchedule_ClinicInfo.RoomList.Name,
                                      時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                      時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                      日期 = tSchedule_ClinicInfo.date,
                                      人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                  };

            var re = schedulesFromDb.ToList().Select(item => new
            {
                醫師 = item.醫師,
                科別 = item.科別,
                診間 = item.診間,
                時段 = item.時段,
                時間 = item.時間,
                日期 = item.日期,
                星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                掛號上限 = item.人數上限
            });


            dataGridView1.DataSource = re.ToList(); 
            CStyle3.DataGridViewDesign(dataGridView1);

        }

    

        private void ClinicScheduling() //排班!   目前命名: 週表Schedule_ClinicSchedule，和門診日程Schedule_ClinicInfo
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var result = (from tSchedule_ClinicSchedule in db.Schedule_ClinicSchedule
                          select new
                          {
                              醫師ID = tSchedule_ClinicSchedule.Member_EmployeeList.Emp_ID,
                              科別 = tSchedule_ClinicSchedule.Member_EmployeeList.Department,
                              診間ID = tSchedule_ClinicSchedule.RoomList.Room_ID,
                              時段ID = tSchedule_ClinicSchedule.Schedule_ClinicTime.ClinicTime_ID,
                              星期 = tSchedule_ClinicSchedule.week
                          }).ToList();


            //取得排班起始日
            //用textbox, combobox, DateTime.Now...等其他方法決定start日期
            string start = DTPickerSecheduling.Value.ToString("yyyy/MM/dd");    //假設排2023-12月班表

            string week = DateTime.Now.DayOfWeek.ToString("");    //取得今天 星期
            string startWeek = DateTime.Parse(start).DayOfWeek.ToString();  //1號的星期(英文) //五

            foreach (var item in result)    //1. 對門診表新增
            {
                var dict = daysInMonthOnWeek(DateTime.Parse(start).Year, DateTime.Parse(start).Month);//取得星期-日期對照表

               
                foreach (int day in dict[(int)item.星期]) //如果抽到禮拜三: (int day in {6, 13, 20, 27})
                {
                    Schedule_ClinicInfo info = new Schedule_ClinicInfo()
                    {
                        doctor_ID = item.醫師ID,
                        ClincRoom_ID = item.診間ID,
                        date = start.Substring(0, 8) + day.ToString("00"),  //"2023-12-" + "01" ("00"為格式，個位數會補0)
                        ClinicTime_ID = item.時段ID,
                        RegistrationLimit = 30,
                        JumpStatus = 0,
                        LeaveStatus = 0
                    };
                    db.Schedule_ClinicInfo.Add(info);   //加入資料表
                }
            }

            db.SaveChanges();
        }


        private Dictionary<int, int[]> daysInMonthOnWeek(int year, int month)//日期對照表
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);    //這個月到幾號    //31
            int weekOfFirstDay = intWeek(new DateTime(year, month, 1).DayOfWeek);        //這個月一號是禮拜幾    //5
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>(); //建立對照表 星期幾0~6 <===> 日期陣列
            List<int> sun = new List<int>();
            List<int> mon = new List<int>();
            List<int> tue = new List<int>();
            List<int> wed = new List<int>();
            List<int> thu = new List<int>();
            List<int> fri = new List<int>();
            List<int> sat = new List<int>();

            int dayCounter = 1;    //建立day計數器，直到這個月最後一天
            while (dayCounter <= daysInMonth)    //從1記到最後一天  (12.1~12.31)
            {
                for (int i = 0; i <= 6; i++)    //指針是i，依序從0填到6
                {
                    if (dayCounter == 1)
                    { i = weekOfFirstDay; }//如果是第一天，把指針移動到該星期 (2023.12.1 要填入 5=星期五)

                    if (dayCounter <= daysInMonth)
                    {
                        switch (i)
                        {
                            case 0: sun.Add(dayCounter); break;  //幾號 是 星期幾，填入
                            case 1: mon.Add(dayCounter); break;
                            case 2: tue.Add(dayCounter); break;
                            case 3: wed.Add(dayCounter); break;
                            case 4: thu.Add(dayCounter); break;
                            case 5: fri.Add(dayCounter); break;
                            case 6: sat.Add(dayCounter); break;
                        }
                        dayCounter++;
                    }
                }
            }
            dict.Add(0, sun.ToArray());
            dict.Add(1, mon.ToArray());
            dict.Add(2, tue.ToArray());
            dict.Add(3, wed.ToArray());
            dict.Add(4, thu.ToArray());
            dict.Add(5, fri.ToArray());
            dict.Add(6, sat.ToArray());

            return dict;
        }
        private int intWeek(DayOfWeek date)   //翻譯星期名成數字，才能i++
        {
            int week = 0;
            switch (date)
            {
                case DayOfWeek.Sunday: week = 0; break;
                case DayOfWeek.Monday: week = 1; break;
                case DayOfWeek.Tuesday: week = 2; break;
                case DayOfWeek.Wednesday: week = 3; break;
                case DayOfWeek.Thursday: week = 4; break;
                case DayOfWeek.Friday: week = 5; break;
                case DayOfWeek.Saturday: week = 6; break;
            }
            return week;
        }


        private string GetChineseDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "星期日";
                case DayOfWeek.Monday:
                    return "星期一";
                case DayOfWeek.Tuesday:
                    return "星期二";
                case DayOfWeek.Wednesday:
                    return "星期三";
                case DayOfWeek.Thursday:
                    return "星期四";
                case DayOfWeek.Friday:
                    return "星期五";
                case DayOfWeek.Saturday:
                    return "星期六";
                default:
                    return string.Empty;
            }
        }


        private void btnResearch_Click(object sender, EventArgs e)
        {

            if (combodepartment.SelectedIndex != 0)
            {
                string t = (DTPickerSecheduling.Value).ToString("yyyy/MM");
                string d = combodepartment.Text;
                var schedulesFromDb1 = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                       where tSchedule_ClinicInfo.Member_EmployeeList.Department == d
                                        && (t == tSchedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_ClinicInfo.date, 
                                       tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                       select new
                                       {
                                           醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_ClinicInfo.date,
                                           人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                var re1 = schedulesFromDb1.ToList().Select(item => new
                {
                    醫師 = item.醫師,
                    科別 = item.科別,
                    診間 = item.診間,
                    時段 = item.時段,
                    時間 = item.時間,
                    日期 = item.日期,
                    星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                    掛號上限 = item.人數上限
                });
                dataGridView1.DataSource = re1.ToList();
                CStyle3.DataGridViewDesign(dataGridView1);
                combodepartment.SelectedIndex = 0;
            } 

            if (combName.SelectedIndex != 0)
            {
                
                string t = (DTPickerSecheduling.Value).ToString("yyyy/MM");
                string x = combName.Text;
                var schedulesFromDb = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                      where tSchedule_ClinicInfo.Member_EmployeeList.Name == x 
                                      && (t == tSchedule_ClinicInfo.date.Substring(0, 7))
                                      orderby tSchedule_ClinicInfo.date,
                                      tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicTime_ID
                                      select new
                                      {
                                          醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                          科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                          診間 = tSchedule_ClinicInfo.RoomList.Name,
                                          時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                          時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                          日期 = tSchedule_ClinicInfo.date,
                                          人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                      };

                var re = schedulesFromDb.ToList().Select(item => new
                {
                    醫師 = item.醫師,
                    科別 = item.科別,
                    診間 = item.診間,
                    時段 = item.時段,
                    時間 = item.時間,
                    日期 = item.日期,
                    星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                    掛號上限 = item.人數上限
                });

                dataGridView1.DataSource = re.ToList();
                combName.SelectedIndex = 0;
                CStyle3.DataGridViewDesign(dataGridView1);
            }
            
            if (combClinicroom.SelectedIndex != 0)
            {
                string t = (DTPickerSecheduling.Value).ToString("yyyy/MM");
                string c = combClinicroom.Text;
                var schedulesFromDb2 = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                       where tSchedule_ClinicInfo.RoomList.Name == c
                                       && (t == tSchedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_ClinicInfo.date
                                       select new
                                       {
                                           醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_ClinicInfo.date,
                                           人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                var re2 = schedulesFromDb2.ToList().Select(item => new
                {
                    醫師 = item.醫師,
                    科別 = item.科別,
                    診間 = item.診間,
                    時段 = item.時段,
                    時間 = item.時間,
                    日期 = item.日期,
                    星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                    掛號上限 = item.人數上限
                });
                dataGridView1.DataSource = re2.ToList();
                combClinicroom.SelectedIndex = 0;
                CStyle3.DataGridViewDesign(dataGridView1);
            }

           
            if (combShifts.SelectedIndex != 0)
            {
                string d = (DTPickerSecheduling.Value).ToString("yyyy/MM");
                string t = combShifts.Text;
                var schedulesFromDb3 = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                       where tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts==t
                                       && (d == tSchedule_ClinicInfo.date.Substring(0, 7))
                                       orderby tSchedule_ClinicInfo.date,
                                       tSchedule_ClinicInfo.Member_EmployeeList.Department
                                       select new
                                       {
                                           醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                           科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                           診間 = tSchedule_ClinicInfo.RoomList.Name,
                                           時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                           時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                           日期 = tSchedule_ClinicInfo.date,
                                           人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                       };
                var re3 = schedulesFromDb3.ToList().Select(item => new
                {
                    醫師 = item.醫師,
                    科別 = item.科別,
                    診間 = item.診間,
                    時段 = item.時段,
                    時間 = item.時間,
                    日期 = item.日期,
                    星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                    掛號上限 = item.人數上限
                });
                dataGridView1.DataSource = re3.ToList();
                combShifts.SelectedIndex = 0;
                CStyle3.DataGridViewDesign(dataGridView1);

            }
        }

        private void dateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            string r = (dateTimePickerSearch.Value).ToString("yyyy/MM/dd");
            var schedulesFromDb = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                  where (r == tSchedule_ClinicInfo.date)
                                  orderby tSchedule_ClinicInfo.ClinicTime_ID, tSchedule_ClinicInfo.Member_EmployeeList.Department
                                  select new
                                  {
                                      醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                      科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                      診間 = tSchedule_ClinicInfo.RoomList.Name,
                                      時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                      時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                      日期 = tSchedule_ClinicInfo.date,
                                      人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                  };

            var re = schedulesFromDb.ToList().Select(item => new
            {
                醫師 = item.醫師,
                科別 = item.科別,
                診間 = item.診間,
                時段 = item.時段,
                時間 = item.時間,
                日期 = item.日期,
                星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                掛號上限 = item.人數上限
            });
            dataGridView1.DataSource = re.ToList();
            CStyle3.DataGridViewDesign(dataGridView1);
        }

        private void DTPickerSecheduling_ValueChanged(object sender, EventArgs e)
        {
            string r = (DTPickerSecheduling.Value).ToString("yyyy/MM");
            var schedulesFromDb = from tSchedule_ClinicInfo in db.Schedule_ClinicInfo
                                  where (r == tSchedule_ClinicInfo.date.Substring(0, 7))
                                  orderby tSchedule_ClinicInfo.date, tSchedule_ClinicInfo.ClinicTime_ID,tSchedule_ClinicInfo.Member_EmployeeList.Department
                                  select new
                                  {
                                      醫師 = tSchedule_ClinicInfo.Member_EmployeeList.Name,
                                      科別 = tSchedule_ClinicInfo.Member_EmployeeList.Department,
                                      診間 = tSchedule_ClinicInfo.RoomList.Name,
                                      時段 = tSchedule_ClinicInfo.Schedule_ClinicTime.ClinicShifts,
                                      時間 = tSchedule_ClinicInfo.Schedule_ClinicTime.time,
                                      日期 = tSchedule_ClinicInfo.date,
                                      人數上限 = tSchedule_ClinicInfo.RegistrationLimit + "人"
                                  };

            var re = schedulesFromDb.ToList()
                .Select(item => new
                {
                    醫師 = item.醫師,
                    科別 = item.科別,
                    診間 = item.診間,
                    時段 = item.時段,
                    時間 = item.時間,
                    日期 = item.日期,
                    星期 = GetChineseDayOfWeek(DateTime.Parse(item.日期).DayOfWeek),
                    掛號上限 = item.人數上限
                });

            dataGridView1.DataSource = re.ToList();
            CStyle3.DataGridViewDesign(dataGridView1);
        }

        private void btn編輯_Click(object sender, EventArgs e)
        {
            int slected = dataGridView1.SelectedCells[0].RowIndex;
            FrmClinicInfoEditor f = new FrmClinicInfoEditor();
            f.info = new CClinicInfo()
            {
                date = dataGridView1.Rows[slected].Cells["日期"].Value.ToString(),
                name = dataGridView1.Rows[slected].Cells["醫師"].Value.ToString(),
                shifts = dataGridView1.Rows[slected].Cells["時段"].Value.ToString(),
                room = dataGridView1.Rows[slected].Cells["診間"].Value.ToString(),
                limit =dataGridView1.Rows[slected].Cells["掛號上限"].Value.ToString()
            };
            f.ShowDialog();

            ReFreshDataGridView();
            CStyle3.DataGridViewDesign(dataGridView1);
        }
    }

}
