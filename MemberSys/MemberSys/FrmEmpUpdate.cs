using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys
{
    public partial class FrmEmpUpdate : Form
    {

        private DialogResult _isOk;

        public DialogResult confirm
        {
            get { return _isOk; }
        }


        public FrmEmpUpdate()
        {
            InitializeComponent();
        }

        private Member_EmployeeList _employee;
        public Member_EmployeeList employee
        {
            get
            {

                _employee.Name = fbName.fieldValue;
                _employee.Staff_Number = Convert.ToInt32(fbEmpNum.fieldValue);
                _employee.Gender = cboGender.Text == "男";

                _employee.Blood_Type = fbBlood.fieldValue;
                _employee.National_ID = fbNID.fieldValue;
                _employee.Address = fbAddress.fieldValue;
                _employee.Contact_Address = fbCAddress.fieldValue;
                _employee.Phone = fbPhone.fieldValue;
                _employee.Birth_Date = dtPickerBirth.Value;
                _employee.Emp_Type = cboEmpType.Text;
                _employee.Department = cboDepartment.Text;
                _employee.Emp_Password = fbEmpPassword.fieldValue;
                //以下get圖片的byte資料
               

                //20231227這邊寫成return employee  沒有搞懂主畫面上新增員工班級按鈕那邊要傳回誰 出現stackoverflow 
                //因為他自己跟自己要資料 無限迴圈 因此溢出
                return _employee;
            }
            set
            {
                _employee = value;
                fbName.fieldValue = _employee.Name;
                fbEmpNum.fieldValue = _employee.Staff_Number.ToString();
                cboGender.fieldValue = _employee.Gender ? "男" : "女";
                fbBlood.fieldValue = _employee.Blood_Type.ToString();
                fbNID.fieldValue = _employee.National_ID.ToString();
                fbAddress.fieldValue = _employee.Address.ToString();
                fbCAddress.fieldValue = _employee.Contact_Address.ToString();

                fbPhone.fieldValue = _employee.Phone.ToString();
                dtPickerBirth.Value = _employee.Birth_Date;
                cboEmpType.Text = _employee.Emp_Type.ToString();
                cboDepartment.Text = _employee.Department.ToString();
                fbEmpPassword.fieldValue = _employee.Emp_Password.ToString();






                // 圖片的set
                //if (empoyee.EmpPhoto != null && empoyee.EmpPhoto.Length > 0)
                //{
                //using (MemoryStream stream = new MemoryStream(_employee.EmpPhoto))
                //{
                //    // 使用Bitmap類別讀取MemoryStream中的圖片
                //    Bitmap image = new Bitmap(stream);

                //    // 將讀取的圖片顯示在PictureBox中
                //    pictureBoxEmp.Image = image;
                //}
                //}
                //else
                //{

                //    pictureBoxEmp.Image = SystemIcons.Exclamation.ToBitmap(); // 沒有就用系統圖
                //}

            }
        }




        private Image GetImageFromBytes(byte[] bytes)
        {
            try
            {

                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);

                return Image.FromStream(ms);
            }
            catch
            {
                return this.pictureBoxEmp.ErrorImage;
            }
        }

        private void FrmEmpUpdate_Load(object sender, EventArgs e)
        {
            pictureBoxEmp.Image = GetImageFromBytes(_employee.EmpPhoto);
            _isOk = DialogResult.Cancel;
            cboEmpType.Items.Add("醫生");
            cboEmpType.Items.Add("護士");
            cboEmpType.Items.Add("行政");
            cboEmpType.Items.Add("藥師");


            cboGender.Items.Add("男");
            cboGender.Items.Add("女");
        }

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

        private void btnOk_Click(object sender, EventArgs e)
        {
            //20231227 10:11 按下確定按鈕把圖片轉成2進制存進資料庫
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBoxEmp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            _employee.EmpPhoto = bytes;
            MessageBox.Show("修改成功");
            _isOk = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }


        private void pictureBoxEmp_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxEmp.Image = Image.FromFile(this.openFileDialog1.FileName);

            }
        }
    }
}
