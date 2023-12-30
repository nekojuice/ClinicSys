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

namespace ClinicSysMdiParent.View
{
    public partial class FrmClinic : Form
    {
        public FrmClinic()
        {
            InitializeComponent();
        }

        CComboFactory x = new CComboFactory();
        List<int> dcctorid = new List<int>();
        ClinicSysEntities db = new ClinicSysEntities();


        private void Form1_Load(object sender, EventArgs e)
        {
            var doctors = x.FindDoctorname().ToList();
            doctors.Insert(0, new CDoctorname { Drid = 0, Dr姓名 = "" });
            combName.DataSource = doctors;
            combName.DisplayMember = "Dr姓名";
            combName.ValueMember = "DrId";
        }


        private void combName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combName.SelectedIndex <= 0)
                return;
            
                string selectedDrName = combName.SelectedItem.ToString();
                int fid = Convert.ToInt32(combName.SelectedValue);

                var result = from target in db.Schedule_ClinicSchedule
                             orderby target.Schedule_ClinicTime.ClinicShifts
                             where target.Doctor_ID == fid
                             select target;

                isShowClinicTime(result);
        }

        private void isShowClinicTime(IQueryable<Schedule_ClinicSchedule> result)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("時段");
            dt.Columns.Add("日");
            dt.Columns.Add("一");
            dt.Columns.Add("二");
            dt.Columns.Add("三");
            dt.Columns.Add("四");
            dt.Columns.Add("五");
            dt.Columns.Add("六");

            var morning = result.Where(x => x.Schedule_ClinicTime.ClinicShifts == "早診");
            var afternoon = result.Where(x => x.Schedule_ClinicTime.ClinicShifts == "午診");
            var night = result.Where(x => x.Schedule_ClinicTime.ClinicShifts == "晚診");

            DataRow r = dt.NewRow();
            r[0] = "\r\n"+"早診" +""+ "\r\n" + "09:00~12:30" + "\r\n";
            foreach (Schedule_ClinicSchedule item in morning)
            {
                switch (item.week)
                {
                    case 0: r[1] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;//周日
                    case 1: r[2] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 2: r[3] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 3: r[4] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 4: r[5] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 5: r[6] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 6: r[7] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;//周六
                }
            }
            dt.Rows.Add(r);

            r = dt.NewRow();
            r[0] = "\r\n"+"午診" + "" + "\r\n" + "13:30~17:00" + "\r\n";
            foreach (Schedule_ClinicSchedule item in afternoon)
            {
                switch (item.week)
                {
                    case 0: r[1] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;//周日
                    case 1: r[2] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 2: r[3] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 3: r[4] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 4: r[5] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 5: r[6] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 6: r[7] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;//周六
                }
            }
            dt.Rows.Add(r);

            r = dt.NewRow();
            r[0] = "\r\n" + "晚診" + "" + "\r\n" + "18:00~21:30" + "\r\n";
            foreach (Schedule_ClinicSchedule item in night)
            {
                switch (item.week)
                {
                    case 0: r[1] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;//周日
                    case 1: r[2] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 2: r[3] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 3: r[4] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 4: r[5] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 5: r[6] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;
                    case 6: r[7] += "\r\n" + item.Member_EmployeeList.Name + "\r\n"; break;//周六
                }
            }
            dt.Rows.Add(r);
            
            CStyle3.DataGridViewDesign2(dataGridView1);

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //讓他可以換行
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DataSource = dt;
            
        }


        private void btn新增門診_Click(object sender, EventArgs e)
        {
            FrmClinicScheduleEditor f = new FrmClinicScheduleEditor();
            f.ShowDialog();   
            UpdateClinicTimeTable();//新增後門診表及時同步更新
        }

        private void UpdateClinicTimeTable() // 更新資料
        {
            // 在這裡重新查詢門診時間表的資料
            int selectedDoctorId = (int)combName.SelectedValue;
            if (selectedDoctorId <= 0) return;
            var result = from target in db.Schedule_ClinicSchedule
                         where target.Doctor_ID == selectedDoctorId
                         orderby target.Schedule_ClinicTime.ClinicShifts
                         select target;
            isShowClinicTime(result);
        }

        private void combName_SelectedIndexChanged(object sender, EventArgs e)
        {   // 選擇不同的醫生時，也更新
            UpdateClinicTimeTable();
        }



        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0]; // 取得第一個選取的儲存格

                // 獲取儲存格的行索引和列索引
                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;

                // 獲取星期和時段的值
                int dayOfWeek = ConvertDayOfWeekToInt(dataGridView1.Columns[columnIndex].HeaderText);// 表頭的星期名稱

                string clinicShifts = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString().Substring(2, 2); // 第一列的時段名稱

                // 根據星期和時段查找相應的 Schedule_ClinicSchedule 記錄
                Schedule_ClinicSchedule scheduleToDelete = FindScheduleFromDatabase(dayOfWeek, clinicShifts);

                if (scheduleToDelete != null)
                {
                    DialogResult result = MessageBox.Show("確定要刪除此筆資料嗎？", "確認刪除", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        // 如果選擇確定，執行刪除
                        DeleteScheduleFromDatabase(scheduleToDelete);

                        // 更新 dataGridView1
                        UpdateClinicTimeTable();
                    }
                }
                else
                {
                    MessageBox.Show("必須選取門診時段");
                }
            }
            else
            {
                MessageBox.Show("未選取任何門診時段");
            }
        }
        private Schedule_ClinicSchedule FindScheduleFromDatabase(int dayOfWeek, string clinicShifts)
        {
            var result = db.Schedule_ClinicSchedule.
                FirstOrDefault(x =>x.Member_EmployeeList.Name == combName.Text &&
                x.week == dayOfWeek &&
                x.Schedule_ClinicTime.ClinicShifts == clinicShifts);

            return result;
        }
        private void DeleteScheduleFromDatabase(Schedule_ClinicSchedule schedule)
        {
            using (var context = new ClinicSysEntities())
            {
                // 根據星期和時段查找相應的 Schedule_ClinicSchedule 記錄
                var scheduleToDelete = context.Schedule_ClinicSchedule
                 .FirstOrDefault(s => s.Doctor_ID == schedule.Doctor_ID &&
                            s.week == schedule.week &&
                            s.time_ID == schedule.time_ID &&
                            s.Room_ID == schedule.Room_ID);

                if (scheduleToDelete != null)
                {
                    // 刪除該筆記錄
                    context.Schedule_ClinicSchedule.Remove(scheduleToDelete);
                    context.SaveChanges();
                }
            }
        }

        private int ConvertDayOfWeekToInt(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "日":
                    return 0;
                case "一":
                    return 1;
                case "二":
                    return 2;
                case "三":
                    return 3;
                case "四":
                    return 4;
                case "五":
                    return 5;
                case "六":
                    return 6;
                default:
                    return -1;
            }
        }

      


    }
}
