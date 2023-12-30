using ClinicSys;
using MemberSys.EmployeeModels;
using MemberSys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys
{
    public partial class FrmEmployeeEditor : Form
    {
        Member_EmployeeList emp = new Member_EmployeeList();
        ClinicSysEntities db = new ClinicSysEntities();
        public CEmpViewModel employee;
        private DialogResult _isOk;

        

        public int newStaffNumber;

        public DialogResult confirm
        {
            get { return _isOk; }
        }

        public FrmEmployeeEditor()
        {
            InitializeComponent();
            //20231227 11:07pm 要找到資料庫中員工編號最大值  但是抓不到值
            int maxStaffNumber = db.Member_EmployeeList.Max(staffnummax => (int?)staffnummax.Staff_Number) ?? 1000;
            //這邊的newStaffNumber不要加上int不然重複宣告
            newStaffNumber = maxStaffNumber + 1;
            //20231227 10:47pm以下要來找員工編號最大值 每次新增員工自動帶入


            fbEmpNum.fieldValue = "您的員工編號為" + newStaffNumber.ToString();
            
        }

        //按下確定就把資料送進資料庫，紀錄按下OK後 呼叫主畫面新增按鈕那邊有一個refresgEmp刷新頁面
        private void btnNewEmp_Click(object sender, EventArgs e)
        {
           
            emp.Name = fbName.fieldValue;

            emp.Gender = cboGender.fieldValue == "女" ? false : true;
            emp.National_ID = fbNID.fieldValue;
            emp.Staff_Number = newStaffNumber;
            //if (int.TryParse(fbEmpNum.fieldValue, out int newStaffNumber))
            //{
            //    emp.Staff_Number = newStaffNumber;
            //}
            //else
            //{
            //    // 轉換失敗，處理錯誤或提供使用者錯誤訊息
            //    MessageBox.Show("輸入的員工編號格式不正確。");
            //}


            emp.Address = fbAddress.fieldValue;
            emp.Contact_Address = fbCAddress.fieldValue;
            //20231226 員工生日部分使用datetime格式儲存，到時候再看查看細項時 顯示在畫面上要轉字串會不會有問題
            emp.Birth_Date = dtPickerBirth.Value.Date;
            //emp.Birth_Date = fbBirth.fieldValue;
            emp.Blood_Type = fbBlood.fieldValue;
            emp.Department = cboDepartment.Text;
            emp.Emp_Password = fbEmpPassword.fieldValue;
            emp.Emp_Type = cboEmpType.Text;
            emp.Phone = fbPhone.fieldValue;
            emp.Staff_Number = newStaffNumber;

            //emp.Staff_Number = Convert.ToInt32(fbEmpNum.fieldValue);



            //以下要來存圖片
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBoxEmp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            emp.EmpPhoto = bytes;



            db.Member_EmployeeList.Add(emp);
            db.SaveChanges();
            MessageBox.Show("新增成功");
            _isOk = DialogResult.OK;
            this.Close();
        }

        private void FrmEmployeeEditor_Load(object sender, EventArgs e)
        {

            if ((FrmParent._EMPLOYEE.Emp_Type == "管理員"))
            {
                cboEmpType.Items.Clear();
                cboEmpType.Items.Add("醫生");
                cboEmpType.Items.Add("護士");
                cboEmpType.Items.Add("行政");
                cboEmpType.Items.Add("藥師");
                cboEmpType.Items.Add("管理員");
                cboDepartment.Items.Clear();
                cboDepartment.Items.Add("病房");
                cboDepartment.Items.Add("門診");
                cboDepartment.Items.Add("婦產科");
                cboDepartment.Items.Add("小兒科");
            }
            else
            {
                cboEmpType.Items.Add("醫生");
                cboEmpType.Items.Add("護士");
                cboEmpType.Items.Add("行政");
                cboEmpType.Items.Add("藥師");
            }
            _isOk = DialogResult.Cancel;

            cboGender.Items.Add("男");
            cboGender.Items.Add("女");
           
          
            //20231227 04:27am 用get set把資料拿來之後在load裡面轉成圖片檔案 顯示在畫面上
            //不能再get set裡面轉好 他只能拿到值


        }

        private void btnEmpCancel_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        //2023 1227
        private void pictureBoxEmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "新增員工頭像";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxEmp.Image = Image.FromFile(openFileDialog.FileName);

            }
        }

        //以下程式碼用來處理編輯資料時要有對應表格 才能把抓到的資料顯示在對應欄位上 20231227 01:10am
        



        //20231227 09:49am 選到對應的員工類型出現對應的科別 行政跟藥師沒分
        private void cboEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpType.Text == "醫生")
            {
                cboDepartment.Items.Clear();
                cboDepartment.Items.Add("婦產科");
                cboDepartment.Items.Add("小兒科");
            }
            if (cboEmpType.Text == "護士")
            {
                cboDepartment.Items.Clear();
                cboDepartment.Items.Add("門診");
                cboDepartment.Items.Add("病房");
            }
            if ((cboEmpType.Text == "行政") || (cboEmpType.Text == "藥師"))
            {
                cboDepartment.Items.Clear();
            }

        }
    }
}
