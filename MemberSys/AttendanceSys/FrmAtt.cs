using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

using System.Diagnostics.Eventing.Reader;

using System.Collections;

namespace ClinicSys
{
    public partial class FrmAtt : Form
    {
        private const string connectionString = "data source=192.168.21.14;initial catalog=ClinicSys;persist security info=True;user id=cat;password=cat;MultipleActiveResultSets=True;App=EntityFramework&quot;";


        int _employeeId;

        public FrmAtt()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 設定計時器間隔為1秒
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // 在計時器觸發時更新 Label 的文字內容為目前時間
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAtt_Load(object sender, EventArgs e)
        {
            uiDatePicker1.Value = DateTime.Today;
            DisplayEmployeeAttendance(uiDatePicker1.Value);
            DisplayEmployeeNAME();
            

        }
        private bool chceckalready(string P)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = $"SELECT COUNT({P}) FROM Attendance_tAttendance WHERE fEmployeeID = @EmployeeId AND fWorkDate = CONVERT(DATE, GETDATE(), 126)  ";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeId", FrmParent._EMPLOYEE.Emp_ID);


                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }


        private void RecordClockTime(string sql, string Cprint)    //參數sql 為SQL語法  ,Cprint 顯示打卡和簽退成功
        {
            

            string query = sql;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                bool isLate = DateTime.Now.TimeOfDay > new TimeSpan(9, 0, 0);

                var stasus = "";
                if (isLate)
                {
                    stasus = "遲到";
                }
                else
                {
                    stasus = "準時到";
                }
                bool isLateO = DateTime.Now.TimeOfDay < new TimeSpan(21, 0, 0);

                var stasusOut = "";

                if (isLateO)
                {
                    stasusOut = "早退";
                }
                else
                {
                    stasusOut = "正常下班";
                }
                //switch (a)
                //{
                //    case ("1"):
                //        stasus = "遲到";
                //        break;

                //    case ("0"):
                //        stasus = "準時";
                //        break;

                //    default:
                //        Console.WriteLine("One or both measurements are not valid.");
                //        break;
                //}

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Time", DateTime.Now);
                command.Parameters.AddWithValue("@DATE", DateTime.Now);
                command.Parameters.AddWithValue("@DATEW", DateTime.Today);
                command.Parameters.AddWithValue("@EmployeeId", FrmParent._EMPLOYEE.Emp_ID);
                command.Parameters.AddWithValue("@AttendanceCIS", stasus);
                command.Parameters.AddWithValue("@AttendanceCOS", stasusOut);


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($" {lblName.Text} 已經 {Cprint}");
                    }
                    else
                    {
                        MessageBox.Show($"Employee 身分 找不到");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }



        }

        private void Checkin_Click(object sender, EventArgs e)
        {
            if (!chceckalready("fCheckInTime"))

                RecordClockTime($"INSERT INTO Attendance_tAttendance (fEmployeeID, fCheckInTime, fWorkDate,fAttendanceCIS) VALUES (@EmployeeId, @Time, @DATE, @AttendanceCIS)", "打卡成功");

            else

                MessageBox.Show("已經打過卡");
            DisplayEmployeeAttendance(uiDatePicker1.Value);
            CstyleAtt.resetGridRowColor(dataGridView1);
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            if (!chceckalready("fCheckOutTime"))
                RecordClockTime($"UPDATE Attendance_tAttendance SET fCheckOutTime = @Time  ,fAttendanceCOS = @AttendanceCOS WHERE fEmployeeID = @EmployeeId AND fWorkDate=@DATEW ", "簽退成功");
            else

                MessageBox.Show("已經簽退完");
            DisplayEmployeeAttendance(uiDatePicker1.Value);
            CstyleAtt.resetGridRowColor(dataGridView1);

        }
        private void DisplayEmployeeAttendance(DateTime p)   //參數P  DATEPICKER取VALUE  
        {


            

            string query = "SELECT fCheckInTime, fCheckOutTime ,fWorkDate,fAttendanceCIS,fAttendanceCOS FROM Attendance_tAttendance WHERE fEmployeeID = @EmployeeId AND  fWorkDate=@Datetime";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", FrmParent._EMPLOYEE.Emp_ID);
                command.Parameters.AddWithValue("@Datetime", p);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, "EmployeeAttendance");

                    dataGridView1.DataSource = dataSet.Tables["EmployeeAttendance"];
                    dataGridView1.Columns["fCheckInTime"].HeaderText = "打卡時間";
                    dataGridView1.Columns["fCheckOutTime"].HeaderText = "簽退時間";
                    dataGridView1.Columns["fWorkDate"].HeaderText = "上班日期";
                    dataGridView1.Columns["fAttendanceCIS"].HeaderText = "上班狀態";
                    dataGridView1.Columns["fAttendanceCOS"].HeaderText = "下班狀態";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }

        }



        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {

            DisplayEmployeeAttendance(value);
            CstyleAtt.resetGridRowColor(dataGridView1);

        }
        private void DisplayEmployeeNAME()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 2. 建立 SQL 查詢
                string sqlQuery = "SELECT Name ,Emp_Type FROM Member_EmployeeList WHERE Emp_ID = @EmployeeId ";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", FrmParent._EMPLOYEE.Emp_ID);
                    try
                    {
                        // 3. 開啟資料庫連線
                        connection.Open();

                        // 4. 執行 SQL 查詢取得資料
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // 5. 將資料顯示在 Label 控制項上
                            if (reader.Read())
                            {
                                // 假設要從資料庫中讀取字串型態的資料
                                string data = reader.GetString(0);
                                
                                lblName.Text = data;
                                
                            }
                            else
                            {
                                lblName.Text = "未有名稱";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void FrmAtt_Activated(object sender, EventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);
        }
    }
}
