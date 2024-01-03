using Sunny.UI;

using System;
using System.Collections;
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
    public partial class Frmexpen : Form
    {
        FrmRequestSearch form1 = Application.OpenForms.OfType<FrmRequestSearch>().FirstOrDefault();
        private const string connectionString = "data source = 192.168.21.14; initial catalog = ClinicSys; persist security info=True;user id = cat; password=cat;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        public Frmexpen()
        {
            InitializeComponent();
        }

        private void Frmexpen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;   //執行個體化Graphics 對象g
            Color FColor = Color.MistyRose; //顏色1
            Color TColor = Color.Snow;  //顏色2
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.Vertical);  //執行個體化刷子，第一個參數指示上色地區，第二個和第三個參數分別漸層顏色的開始和結束，第四個參數表示顏色的方向。
            g.FillRectangle(b, this.ClientRectangle);  //進行上色
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

                        CBex.Items.Add(row["fexpensetypename"].ToString());
                        
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
            
            selectName = CBex.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT fExpenseTypeID  FROM Attendance_tExpenseTypes WHERE fexpensetypename=@selectCB";
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

                string query = "INSERT INTO Attendance_tExpenseRequests (fEmployeeID, fExpenseTypeID, fAmount, fRequestDate, fExpenseDate,fRequestsDescription,fApprovalStatus,fPayStatus) " +
                               "VALUES (@EmployeeID,@ExpenseTypeID, @Amount, @RequestDate, @ExpenseDate,@RequestsDescription,@ApprovalStatus,@PayStatus)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", FrmParent._EMPLOYEE.Emp_ID);//要改
                    command.Parameters.AddWithValue("@ExpenseTypeID", Convert.ToInt32(TypeID));
                    command.Parameters.AddWithValue("@Amount", Convert.ToInt32(txtAmount.Text));
                    command.Parameters.AddWithValue("@RequestDate", DPapply.Text);
                    command.Parameters.AddWithValue("@ExpenseDate", DPuse.Text);
                    command.Parameters.AddWithValue("@RequestsDescription", txtDes.Text);
                    command.Parameters.AddWithValue("@ApprovalStatus", "待審核");
                    command.Parameters.AddWithValue("@PayStatus", "待審核");
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
                                string name = reader.GetString(1);
                                lblJob.Text = name;
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
        private void Frmexpen_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            DPapply.Value = DateTime.Now;
            DPuse.Value = DateTime.Now;
            DisplayEmployeeNAME();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            ApplyLeave();
            form1.DisplayEmployeeExpense("SELECT a.fEmployeeID ,Name ,fExpenseTypeName,fRequestDate,fExpenseDate,fAmount,fApprovalStatus from Attendance_tExpenseRequests as a LEFT JOIN Member_EmployeeList as b on a.fEmployeeID = b.Emp_ID LEFT JOIN Attendance_tExpenseTypes as c on a.fExpenseTypeID = c.fExpenseTypeID WHERE a.fEmployeeID = @EmployeeId");
            this.Close();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private void txtDes_Click(object sender, EventArgs e)
        {
            txtDes.Text = "";
        }
    }
}
