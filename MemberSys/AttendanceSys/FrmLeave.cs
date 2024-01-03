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

namespace ClinicSys
{
    public partial class FrmLeave : Form
    {
        private const string connectionString = "data source=192.168.21.14;initial catalog=ClinicSys;persist security info=True;user id=cat;password=cat;MultipleActiveResultSets=True;App=EntityFramework&quot;";
         int leaveid = 0;
        FrmLeaveSearch form1 = Application.OpenForms.OfType<FrmLeaveSearch>().FirstOrDefault();
        public FrmLeave()
        {
            InitializeComponent();
        }

        private void FrmLeave_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            StarDP.Value= DateTime.Now;
            EndDP.Value= DateTime.Now;
            DisplayEmployeeNAME();
        }
        private void LoadComboBoxData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 資料庫查詢
                    string query = "SELECT fLeaveTypeName,fLeaveTypeID  FROM Attendance_tLeaveTypes";
                    SqlCommand command = new SqlCommand(query, connection);

                    // 使用DataAdapter填充DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Attendance_tLeaveTypes");

                    // 從DataSet中取得資料，加入ComboBox
                    foreach (DataRow row in dataSet.Tables["Attendance_tLeaveTypes"].Rows)
                    {
                        CBLeaveType.Items.Add(row["fLeaveTypeName"].ToString());
                        CBLeaveType.Tag=(row["fLeaveTypeID"].ToString());
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫錯誤: " + ex.Message);
                }
            }
        }
        string selectName;
        object TypeID;
        public void ApplyLeave()
        {
            selectName = CBLeaveType.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT fLeaveTypeID  FROM Attendance_tLeaveTypes WHERE fLeaveTypeName=@selectCB";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectCB", selectName);
                    TypeID = command.ExecuteScalar();
                }
                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Attendance_tLeave (fEmployeeID, fLeaveTypeID, fStartDate, fEndDate, fSubstitute,fLeaveStatus,fLeaveDescription) " +
                               "VALUES (@EmployeeID,@LeaveTypeID, @StartDate, @EndDate, @Substitute,@LeaveStatus,@LeaveDescription)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", FrmParent._EMPLOYEE.Emp_ID);//要改
                    command.Parameters.AddWithValue("@LeaveTypeID", TypeID);
                    command.Parameters.AddWithValue("@StartDate", StarDP.Text);
                    command.Parameters.AddWithValue("@EndDate", EndDP.Text);
                    command.Parameters.AddWithValue("@Substitute", CBOtherP.Text);
                    command.Parameters.AddWithValue("@LeaveStatus", "待審核");
                    command.Parameters.AddWithValue("@LeaveDescription", txtBDe.Text);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("申請成功");
                connection.Close();
            }
            
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
                                string job = reader.GetString(1);
                                lblName.Text = data;
                                lblJob.Text = job;
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
        private void xButton1_Click(object sender, EventArgs e)
        {
            ApplyLeave();

            form1.DisplayEmployeeLeave("SELECT a.fEmployeeID ,Name ,fLeaveTypeName,fStartDate,fEndDate,fSubstitute,fLeaveStatus from Attendance_tLeave as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tLeaveTypes as c on a.fLeaveTypeID = c.fLeaveTypeID WHERE a.fEmployeeID = @EmployeeId ");
            
            this.Close();
            
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBDe_Click(object sender, EventArgs e)
        {
            txtBDe.Text = "";
        }
    }
}
       

