using Microsoft.VisualBasic;
using Sunny.UI;

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

namespace ClinicSys
{
    public partial class FrmCheck : Form
    {
        private const string connectionString = "data source=192.168.21.14;initial catalog=ClinicSys;persist security info=True;user id=cat;password=cat;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void FrmCheck_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void xCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCheck_Load(object sender, EventArgs e)
        {
            DisplayCheck();
        }
        private void DisplayCheck()
        {
            
            string query = "SELECT Name ,fExpenseTypeName,fRequestDate=CONVERT(DATE,fRequestDate,126),fExpenseDate=CONVERT(DATE,fExpenseDate,126),fApprovalStatus \r\nfrom Attendance_tExpenseRequests as a \r\nLEFT JOIN Member_EmployeeList as b \r\non a.fEmployeeID = b.Emp_ID \r\nLEFT JOIN Attendance_tExpenseTypes as c \r\non a.fExpenseTypeID = c.fExpenseTypeID \r\nwhere fApprovalStatus = '待審核'\r\n\r\nUNION \r\nSELECT Name ,fLeaveTypeName,CONVERT(DATE,fStartDate,126),CONVERT(DATE,fEndDate,126),fLeaveStatus 　　　\r\nfrom Attendance_tLeave as a \r\nLEFT JOIN Member_EmployeeList as b \r\non a.fEmployeeID = b.Emp_ID \r\nLEFT JOIN Attendance_tLeaveTypes as c \r\non a.fLeaveTypeID = c.fLeaveTypeID \r\nwhere fLeaveStatus = '待審核'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, "EmployeeExpense");

                    dataGridView1.DataSource = dataSet.Tables["EmployeeExpense"];
                    dataGridView1.Columns["Name"].HeaderText = "員工名稱";
                    dataGridView1.Columns["fExpenseTypeName"].HeaderText = "類別";
                    dataGridView1.Columns["fRequestDate"].HeaderText = "起日";
                    dataGridView1.Columns["fExpenseDate"].HeaderText = "訖日";
                    dataGridView1.Columns["fApprovalStatus"].HeaderText = "申請狀態";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }

        }
        public void approve(string p)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand("UPDATE Attendance_tExpenseRequests SET  fApprovalStatus=@ApprovalStatus", connection))
                {
                    
                    command.Parameters.AddWithValue("@ApprovalStatus", p);
                    
                    command.ExecuteNonQuery();
                }
                
                using (SqlCommand command = new SqlCommand("UPDATE Attendance_tLeave SET fLeaveStatus=@LeaveStatus", connection))
                {

                    command.Parameters.AddWithValue("@LeaveStatus", p);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("更新成功");
                connection.Close();
            }

        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string currentStatus = selectedRow.Cells["fApprovalStatus"].Value.ToString();

                
                string currentName = selectedRow.Cells["Name"].Value.ToString();
                string typeName = selectedRow.Cells["fExpenseTypeName"].Value.ToString();
                DateTime currentDate = Convert.ToDateTime(selectedRow.Cells["fRequestDate"].Value);
                DateTime currentDate2 = Convert.ToDateTime(selectedRow.Cells["fExpenseDate"].Value);
                string status = selectedRow.Cells["fApprovalStatus"].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("UPDATE Attendance_tExpenseRequests SET  fApprovalStatus=@ApprovalStatus FROM Attendance_tExpenseRequests as a JOIN Member_EmployeeList as b ON a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tExpenseTypes as c \r\non a.fExpenseTypeID = c.fExpenseTypeID  WHERE Name=@Name AND fExpenseTypeName=@ExpenseTypeName AND fRequestDate=@RequestDate AND fExpenseDate=@ExpenseDate", connection))
                    {
                        command.Parameters.AddWithValue("@Name", currentName);
                        command.Parameters.AddWithValue("@ExpenseTypeName", typeName);
                        command.Parameters.AddWithValue("@RequestDate", currentDate);
                        command.Parameters.AddWithValue("@ExpenseDate", currentDate2);
                        command.Parameters.AddWithValue("@ApprovalStatus", "已審核");

                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand("UPDATE Attendance_tLeave  SET fLeaveStatus=@LeaveStatus from Attendance_tLeave as a \r\n JOIN Member_EmployeeList as b \r\non a.fEmployeeID = b.Emp_ID \r\nLEFT JOIN Attendance_tLeaveTypes as c \r\non a.fLeaveTypeID = c.fLeaveTypeID WHERE Name=@Name AND fLeaveTypeName=@ExpenseTypeName AND CONVERT(DATE, fStartDate)=@RequestDate AND CONVERT(DATE, fEndDate)=@ExpenseDate", connection))
                    {
                        command.Parameters.AddWithValue("@Name", currentName);
                        command.Parameters.AddWithValue("@ExpenseTypeName", typeName);
                        command.Parameters.AddWithValue("@RequestDate", currentDate);
                        command.Parameters.AddWithValue("@ExpenseDate", currentDate2);
                        command.Parameters.AddWithValue("@LeaveStatus", "已審核");

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("批准成功");
                    connection.Close();
                }


            }
            DisplayCheck();
            CstyleAtt.resetGridRowColor(dataGridView1);

        }

        private void FrmCheck_Activated(object sender, EventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);

        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            approve("已審核");
            DisplayCheck();      
            CstyleAtt.resetGridRowColor(dataGridView1);
        }

        private void xButton4_Click(object sender, EventArgs e)
        {
            approve("已撤回");
            DisplayCheck();
            CstyleAtt.resetGridRowColor(dataGridView1);
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string currentStatus = selectedRow.Cells["fApprovalStatus"].Value.ToString();


                string currentName = selectedRow.Cells["fName"].Value.ToString();
                string typeName = selectedRow.Cells["fExpenseTypeName"].Value.ToString();
                DateTime currentDate = Convert.ToDateTime(selectedRow.Cells["fRequestDate"].Value);
                DateTime currentDate2 = Convert.ToDateTime(selectedRow.Cells["fExpenseDate"].Value);
                string status = selectedRow.Cells["fApprovalStatus"].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("UPDATE Attendance_tExpenseRequests SET  fApprovalStatus=@ApprovalStatus FROM Attendance_tExpenseRequests as a JOIN Attendance_tEmployee as b ON a.fEmployeeID = b.fEmployeeID LEFT JOIN Attendance_tExpenseTypes as c \r\non a.fExpenseTypeID = c.fExpenseTypeID  WHERE fName=@Name AND fExpenseTypeName=@ExpenseTypeName AND fRequestDate=@RequestDate AND fExpenseDate=@ExpenseDate", connection))
                    {
                        command.Parameters.AddWithValue("@Name", currentName);
                        command.Parameters.AddWithValue("@ExpenseTypeName", typeName);
                        command.Parameters.AddWithValue("@RequestDate", currentDate);
                        command.Parameters.AddWithValue("@ExpenseDate", currentDate2);
                        command.Parameters.AddWithValue("@ApprovalStatus", "已撤回");

                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand("UPDATE Attendance_tLeave  SET fLeaveStatus=@LeaveStatus from Attendance_tLeave as a \r\n JOIN Attendance_tEmployee as b \r\non a.fEmployeeID = b.fEmployeeID \r\nLEFT JOIN Attendance_tLeaveTypes as c \r\non a.fLeaveTypeID = c.fLeaveTypeID WHERE fName=@Name AND fLeaveTypeName=@ExpenseTypeName AND CONVERT(DATE, fStartDate)=@RequestDate AND CONVERT(DATE, fEndDate)=@ExpenseDate", connection))
                    {
                        command.Parameters.AddWithValue("@Name", currentName);
                        command.Parameters.AddWithValue("@ExpenseTypeName", typeName);
                        command.Parameters.AddWithValue("@RequestDate", currentDate);
                        command.Parameters.AddWithValue("@ExpenseDate", currentDate2);
                        command.Parameters.AddWithValue("@LeaveStatus", "已撤回");

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("更改成功");
                    connection.Close();
                }


            }
            DisplayCheck();
            CstyleAtt.resetGridRowColor(dataGridView1);
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
