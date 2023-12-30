using MemberSys;
using MemberSys.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class FrmParent : Form
    {
        public static Member_EmployeeList _EMPLOYEE;
        public static Member_MemberList _MEMBER;

        FrmLogin frmLoginEmp;
        FrmMemberLogin frmLoginMem;
        string loginType;

        public FrmParent()
        {
            InitializeComponent();

            //要把login那邊的登入者id和員工類別和員工編號記錄下來 寫在建構子裡面 一開始載入就有
            
        }


        


            //檢查員工登入的部分
       private void checkEmpLogin()
        {

        
        
            if (frmLoginEmp.ShowDialog() == DialogResult.OK)
            {
                _EMPLOYEE = new Member_EmployeeList();
                _EMPLOYEE.Staff_Number = frmLoginEmp.staffNumber;
                _EMPLOYEE.Emp_Type = frmLoginEmp.empType;
                _EMPLOYEE.Name = frmLoginEmp.empName;

                toolStripLabelforshowwhologin.Text
                    = "登入者" + " " + frmLoginEmp.empType + " " + frmLoginEmp.empName + " " + "員工編號" + frmLoginEmp.staffNumber;

            }



            //這邊看到的是用switch叫他做判斷 如果是醫生 則不能打開該功能
            switch (_EMPLOYEE.Emp_Type)
            {
                case "醫生":
                    toolStripDropDownButtonMem.Enabled = false;
                    toolStripDropDownButtonShop.Enabled = false;
                    break;
                case "行政":
                    toolStripDropDownButtonCase.Enabled = false;
                    break;
                case "藥師":
                    toolStripDropDownButtonMem.Enabled = false;
                    toolStripDropDownButtonCase.Enabled = false;
                    toolStripDropDownButtonRoom.Enabled = false;
                    toolStripDropDownButtonShop.Enabled = false;
                    toolStripDropDownButtonSchedule.Enabled = false;
                    toolStripDropDownButtonAppt.Enabled = false;
                    break;
                case "護士":
                    toolStripDropDownButtonShop.Enabled = false;


                    break;
                case "會員":
                    toolStripDropDownButtonMem.Enabled = false;
                    toolStripDropDownButtonCase.Enabled = false;
                    toolStripDropDownButtonRoom.Enabled = false;

                    toolStripDropDownButtonSchedule.Enabled = false;
                    toolStripDropDownButtonAppt.Enabled = false;
                    break;

                case "管理員":
                    toolStripDropDownButtonMem.Enabled = true;
                    toolStripDropDownButtonCase.Enabled = true;
                    toolStripDropDownButtonRoom.Enabled = true;
                    toolStripDropDownButtonShop.Enabled = true;
                    toolStripDropDownButtonSchedule.Enabled = true;
                    toolStripDropDownButtonAppt.Enabled = true;
                    toolStripDropDownButtonAttendence.Enabled = true;
                    toolStripDropDownButtonDrug.Enabled = true;
                    break;

                default: break;
            }
            /*if (*///frmLogin.showdialog()==)
                    //{
                    //    //.......(function(判斷權限))
                    //}
        }


        public void resetbutton()
        {
            //foreach (Control c in this.Controls)
            //{
            //    if (c is ToolStripButton)
            //    {
            //        ToolStripButton btn = c as ToolStripButton;
            //        btn.Enabled = true;
            //    }
            //}
            toolStripDropDownButtonMem.Enabled = true;
            toolStripDropDownButtonCase.Enabled = true;
            toolStripDropDownButtonRoom.Enabled = true;
            toolStripDropDownButtonShop.Enabled = true;
            toolStripDropDownButtonSchedule.Enabled = true;
            toolStripDropDownButtonAppt.Enabled = true;
            toolStripDropDownButtonAttendence.Enabled = true;
            toolStripDropDownButtonDrug.Enabled = true;

        }







        private void 登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReal s = new FrmReal();
            s.MdiParent = this;
            s.WindowState = FormWindowState.Maximized;
            s.Show();
        }

        //這邊是帳戶管理 預計做出讓員工可以查看自己個人資料和登出
        //20231227讓他重新打開一次
        private void toolStripMenuItemlogout_Click(object sender, EventArgs e)
        {
            resetbutton();
            //1227把每個子夜面裝進list裡面然後關掉 用dispose
            List<Form> forms = this.MdiChildren.ToList();
            forms.ForEach(f => f.Dispose());
            //把底下顯示登入者的東西清空
            toolStripLabelforshowwhologin.Text = "";
            
            checkEmpLogin();


        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            frmLoginEmp = new FrmLogin();
           
            checkEmpLogin();
        }

        private void 會員登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetbutton();
            //把原本有打開的葉面關掉
            List<Form> forms = this.MdiChildren.ToList();
            forms.ForEach(f => f.Dispose());
            //把底下顯示登入者的東西清空
            toolStripLabelforshowwhologin.Text = "";

            checkMemberLogin();
            
            //memberLogin.ShowDialog();
            //memberLogin.MdiParent = this;

        }

        //檢查會員登入的部分
        private void checkMemberLogin()
        {
            FrmMemberLogin memberLogin = new FrmMemberLogin();
            //memberLogin.ShowDialog();
            if (memberLogin.ShowDialog() == DialogResult.OK)
            {
                _MEMBER = new Member_MemberList();
                _MEMBER.Name = memberLogin._member.Name;
                _MEMBER.Member_Number = memberLogin.MemberNumber;
                loginType = "會員";

                toolStripLabelforshowwhologin.Text
                    = "會員" + " " + _MEMBER.Name + "會員編號" + _MEMBER.Member_Number;

            }

            if (loginType == "會員")
            {

                toolStripDropDownButtonCase.Enabled = false;
                toolStripDropDownButtonRoom.Enabled = false;
                toolStripDropDownButtonAttendence.Enabled = false;
                toolStripDropDownButtonSchedule.Enabled = false;
                toolStripDropDownButtonAppt.Enabled = false;
                toolStripDropDownButtonDrug.Enabled = false;
                toolStripDropDownButtonShop.Enabled = true;

            }
        }

        private void toolStripDropDownButtonLogout_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButtonMem_Click(object sender, EventArgs e)
        {
            FrmReal s = new FrmReal();
            s.MdiParent = this;
            s.WindowState = FormWindowState.Maximized;
            s.Show();
        }
    }
}
