using ClinicSys;
using MemberSys.EmployeeModels;
using MemberSys.Models;
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
    public partial class FrmMemberLogin : Form
    {

        private bool _isClosed = true;
        public Member_MemberList _member = null;

        public static string loginIsMember;
        //返回登入頁面的會員信箱 編號 姓名
        public string MemberEmail
        {
            get { return _member.Mem_Email; }
        }
        public int MemberNumber
        {
            get { return _member.Member_Number; }
        }
        public string MemName
        {
            get
            {
                return _member.Name;
            }
        }

        public FrmMemberLogin()
        {
            InitializeComponent();
        }

        private void FrmMemberLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosed)

                e.Cancel = true;
            else
                return;
        }

        //登入按鈕
        private void btnMemLogin_Click(object sender, EventArgs e)
        {
            string msg = checkValidated(fbMemEmail.fieldValue);
            //msg如果都沒有值 代表格式都對 直接進入下一階段去找到該名會員是誰
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return;
            }

            //新增一個CEmpModel來比對fb裡面輸入的會員信箱 
            _member = new CMemberModel().getMemEmail(fbMemEmail.fieldValue);
            //用一字串紀錄該名會員的密碼 (來自資料庫)
            string password = _member.Mem_Password;
            if (_member != null)
            {
                if (_member.Mem_Password == fbMemPassword.fieldValue)
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
            loginIsMember = "會員";
            //FrmParent p = new FrmParent();
            //this.Close();


        }



        //判斷輸入格式錯誤與否
        private string checkValidated(string MmeEmail)
        {
            string msg = "";
            //用TryParse判斷他能不能夠轉成數字 如果有輸入文字就不能轉數字
            if (string.IsNullOrEmpty(fbMemEmail.fieldValue))

            { msg += "\r\n帳號不可空白"; }

            else if (!new CMemberModel().isValidedMemberEmail(MmeEmail))
            {
                msg += "查無此人";
            }
            //不寫
            return msg;
        }


    }
}
