
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClinicSys
{
    public partial class FrmLeaveSearch : Form
    {
        private const string connectionString = "data source=192.168.21.14;initial catalog=ClinicSys;persist security info=True;user id=cat;password=cat;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        int _employeeId;
        public FrmLeaveSearch()
        {
            InitializeComponent();
        }

        private void FrmLeaveSearch_Load(object sender, EventArgs e)
        {
            uiDatePicker1.Value = DateTime.Now;
            LoadComboBoxData();
            DisplayEmployeeLeave("SELECT a.fEmployeeID ,Name ,fLeaveTypeName,fStartDate,fEndDate,fSubstitute,fLeaveStatus from Attendance_tLeave as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tLeaveTypes as c on a.fLeaveTypeID = c.fLeaveTypeID WHERE a.fEmployeeID = @EmployeeId");
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
                        CBLeaveType.Tag = (row["fLeaveTypeID"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫錯誤: " + ex.Message);
                }
            }
        }
        private void FrmLeaveSearch_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;   //執行個體化Graphics 對象g
            Color FColor = Color.MistyRose; //顏色1
            Color TColor = Color.Snow;  //顏色2
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.Vertical);  //執行個體化刷子，第一個參數指示上色地區，第二個和第三個參數分別漸層顏色的開始和結束，第四個參數表示顏色的方向。
            g.FillRectangle(b, this.ClientRectangle);  //進行上色
        }

        public void DisplayEmployeeLeave(string p)   //參數P  DATEPICKER取VALUE  
        {
            
            string query = p;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", FrmParent._EMPLOYEE.Emp_ID);
                command.Parameters.AddWithValue("@Datetime", uiDatePicker1.Text);
                command.Parameters.AddWithValue("@LeaveTypeNAME", CBLeaveType.Text);
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, "EmployeeLeave");

                    dataGridView1.DataSource = dataSet.Tables["EmployeeLeave"];
                    dataGridView1.Columns["Name"].HeaderText = "員工名稱";
                    dataGridView1.Columns["fLeaveTypeName"].HeaderText = "假別";
                    dataGridView1.Columns["fStartDate"].HeaderText = "請假起日";
                    dataGridView1.Columns["fEndDate"].HeaderText = "請假訖日";
                    dataGridView1.Columns["fSubstitute"].HeaderText = "代理人";
                    dataGridView1.Columns["fLeaveStatus"].HeaderText = "申請狀態";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
            CstyleAtt.resetGridRowColor(dataGridView1);

        }
        private void xButton1_Click(object sender, EventArgs e)
        {
            DisplayEmployeeLeave("SELECT a.fEmployeeID ,Name ,fLeaveTypeName,fStartDate,fEndDate,fSubstitute,fLeaveStatus from Attendance_tLeave as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tLeaveTypes as c on a.fLeaveTypeID = c.fLeaveTypeID WHERE a.fEmployeeID = @EmployeeId AND  fLeaveTypeName=@LeaveTypeNAME AND CONVERT(DATE, fStartDate)=@Datetime");
            CstyleAtt.resetGridRowColor(dataGridView1);

        }

        private void FrmLeaveSearch_Activated(object sender, EventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);

        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            FrmLeave f = new FrmLeave();
            
            
            f.Show();
            
            DisplayEmployeeLeave("SELECT a.fEmployeeID ,Name ,fLeaveTypeName,fStartDate,fEndDate,fSubstitute,fLeaveStatus from Attendance_tLeave as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tLeaveTypes as c on a.fLeaveTypeID = c.fLeaveTypeID WHERE a.fEmployeeID = @EmployeeId");
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);
        }
    }
}
