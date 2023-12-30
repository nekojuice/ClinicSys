using MemberSys.EmployeeModels;
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
    public partial class FrmLoginMain : Form
    {

        private bool _isClosed = true;
        private Member_EmployeeList _employee = null;
        public int staffNumber
        {
            get { return Convert.ToInt32(fbStaffNum.fieldValue); }
        }
        public string empType
        {
            get { return _employee.Emp_Type; }
        }

        public string empName
        {
            get { return _employee.Name; }
        }

        public FrmLoginMain()
        {
            InitializeComponent();
        }

        private string checkValidated(string staffNumber)
        {
            string msg = "";
            //用TryParse判斷他能不能夠轉成數字 如果有輸入文字就不能轉數字
            if (string.IsNullOrEmpty(fbStaffNum.fieldValue))

            { msg += "\r\n員工編號不可空白"; }
            else if (!int.TryParse(staffNumber, out int a))
            {
                msg += "員工編號只能輸入數字";
            }
            else if (staffNumber.Length != 4)
            {
                msg += "員工編號只有四碼";
            }
            else if (!new CEmpModel().isValidedEmpNumber(Convert.ToInt32(staffNumber)))
            {
                msg += "查無此人";
            }
            //不寫
            return msg;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string msg = checkValidated(fbStaffNum.fieldValue);
            //msg如果都沒有值 代表格式都對 直接進入下一階段去找到該名員工是誰
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return;
            }

            //新增一個CEmpModel來比對fbStaffNum裡面輸入的員工編號 要先轉數字
            _employee = new CEmpModel().getEmpbyNumber(Convert.ToInt32(fbStaffNum.fieldValue));
            //用一字串紀錄該名員工的密碼 (來自資料庫)
            string password = _employee.Emp_Password;
            if (_employee != null)
            {
                if (_employee.Emp_Password == fbEmpPassword.fieldValue)
                {
                    //這個this代表當下這個form 密碼對了就是代表ok，
                    //FrmParent那頁會抓到該名成功登入者的資料為了判斷他是誰 可以開啟那些系統功能
                    //還要能夠顯示在左下角
                    this.DialogResult = DialogResult.OK;
                    _isClosed = false;
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("帳號與密碼不符");
        }
        //new CEmpViewModel(_employee);

        //寫一個方法判斷員工編號那邊的狀態

    }
    
    
}
