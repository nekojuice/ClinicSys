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
    public partial class FrmRequestSearch : Form
    {
        private const string connectionString = "data source=192.168.21.14;initial catalog=ClinicSys;persist security info=True;user id=cat;password=cat;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        int _employeeId;
        public FrmRequestSearch()
        {
            InitializeComponent();
        }

        private void FrmRequestSearch_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;   //執行個體化Graphics 對象g
            Color FColor = Color.MistyRose; //顏色1
            Color TColor = Color.Snow;  //顏色2
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.Vertical);  //執行個體化刷子，第一個參數指示上色地區，第二個和第三個參數分別漸層顏色的開始和結束，第四個參數表示顏色的方向。
            g.FillRectangle(b, this.ClientRectangle);  //進行上色
        }

        private void FrmRequestSearch_Load(object sender, EventArgs e)
        {
            uiDatePicker1.Value = DateTime.Now;
            LoadComboBoxData();
            DisplayEmployeeExpense("SELECT a.fEmployeeID ,Name ,fExpenseTypeName,fRequestDate,fExpenseDate,fAmount,fApprovalStatus from Attendance_tExpenseRequests as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tExpenseTypes as c on a.fExpenseTypeID = c.fExpenseTypeID WHERE a.fEmployeeID = @EmployeeId");
        }
        private void LoadComboBoxData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 資料庫查詢
                    string query = "SELECT fExpenseTypeName,fExpenseTypeID  FROM Attendance_tExpenseTypes";
                    SqlCommand command = new SqlCommand(query, connection);

                    // 使用DataAdapter填充DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Attendance_tExpenseTypes");

                    // 從DataSet中取得資料，加入ComboBox
                    foreach (DataRow row in dataSet.Tables["Attendance_tExpenseTypes"].Rows)
                    {
                        uiComboBox1.Items.Add(row["fExpenseTypeName"].ToString());
                        uiComboBox1.Tag = (row["fExpenseTypeID"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫錯誤: " + ex.Message);
                }
            }
        }
        public void DisplayEmployeeExpense(string p)    
        {
            
            string query = p;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", FrmParent._EMPLOYEE.Emp_ID);
                command.Parameters.AddWithValue("@Datetime", uiDatePicker1.Text);
                command.Parameters.AddWithValue("@ExpenseTypeName", uiComboBox1.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, "EmployeeExpense");

                    dataGridView1.DataSource = dataSet.Tables["EmployeeExpense"];
                    dataGridView1.Columns["Name"].HeaderText = "員工名稱";
                    dataGridView1.Columns["fExpenseTypeName"].HeaderText = "類別";
                    dataGridView1.Columns["fRequestDate"].HeaderText = "費用申請日";
                    dataGridView1.Columns["fExpenseDate"].HeaderText = "費用核發日";
                    dataGridView1.Columns["fAmount"].HeaderText = "申請金額";
                    dataGridView1.Columns["fApprovalStatus"].HeaderText = "申請狀態";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
                CstyleAtt.resetGridRowColor(dataGridView1);
            }

        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            DisplayEmployeeExpense("SELECT a.fEmployeeID ,Name ,fExpenseTypeName,fRequestDate,fExpenseDate,fAmount,fApprovalStatus from Attendance_tExpenseRequests as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tExpenseTypes as c on a.fExpenseTypeID = c.fExpenseTypeID WHERE a.fEmployeeID = @EmployeeId AND  fExpenseTypeName=@ExpenseTypeName AND CONVERT(DATE, fRequestDate)=@Datetime");
            CstyleAtt.resetGridRowColor(dataGridView1);

        }

        private void FrmRequestSearch_Activated(object sender, EventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);

        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            Frmexpen f = new Frmexpen();
            f.Show();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CstyleAtt.resetGridRowColor(dataGridView1);
        }
    }
}
