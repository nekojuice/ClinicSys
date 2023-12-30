using Clinicsys;
using ClinicSysMdiParent;
using ClinicSysMdiParent.View;
using MemberSys;
using MemberSys.Frm;
using MSIT155_E_MID.ApptSystem.Model;
using MSIT155_E_MID.ApptSystem.View;
using prjRoom;
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

        /// <summary>
        /// 一旦登入成功，將此員工資料全數撈出
        /// patched method
        /// 20231230-2036 by nekojuice
        /// </summary>
        /// <returns>此員工的Member_EmployeeList類別資料</returns>
        private Member_EmployeeList getEmpData(int staffNumber) 
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var result = from target in db.Member_EmployeeList
                         where target.Staff_Number == staffNumber
                         select target;
            return result.FirstOrDefault();
        }


        //檢查員工登入的部分
        private void checkEmpLogin()
        {
            if (frmLoginEmp.ShowDialog() == DialogResult.OK)
            {
                //_EMPLOYEE = new Member_EmployeeList();
                //_EMPLOYEE.Staff_Number = frmLoginEmp.staffNumber;
                //_EMPLOYEE.Emp_Type = frmLoginEmp.empType;
                //_EMPLOYEE.Name = frmLoginEmp.empName;
                _EMPLOYEE = getEmpData(frmLoginEmp.staffNumber);    //傳回整份entity

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

        private void 藥品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPharmacy f = new FrmPharmacy();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 明細種類一覽表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPharmacyDetail f = new FrmPharmacyDetail();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmEmpProdCoupOrder frm = new frmEmpProdCoupOrder();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void 購物商城ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activate_fProducts();
        }

        public void Activate_fProducts()
        {
            frmMbrShop frm = new frmMbrShop();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void 優惠券ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMbrCoupon frm = new frmMbrCoupon();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void 我的訂單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMbrOrder fOrders = new frmMbrOrder();
            fOrders.MdiParent = this;
            fOrders.WindowState = FormWindowState.Maximized;
            fOrders.Show();
            fOrders.Activate();
        }

        private void toolStripDropDownButtonRoom_Click(object sender, EventArgs e)
        {
            frmRoomMain f = new frmRoomMain();
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 門診時段維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClinic f = new FrmClinic();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 醫師班表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrSchedule f = new FrmDrSchedule();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 門診護士班表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClinicNurseSechedule f = new FrmClinicNurseSechedule();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripDropDownButtonCase_Click(object sender, EventArgs e)
        {
            FrmCases_All f = new FrmCases_All();
            f.MdiParent = this;
            //panel1.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 上下班打卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtt f = new FrmAtt();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 請假申請查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLeaveSearch f = new FrmLeaveSearch();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 審核批准ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheck f = new FrmCheck();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 費用申請查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRequestSearch f = new FrmRequestSearch();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        //----------掛號叫號
        public FrmManageAppt manageAppt { get { return _manageAppt; } set { _manageAppt = value; } }
        private FrmManageAppt _manageAppt;
        private void 掛號管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageAppt == null || manageAppt.IsDisposed)
            {
                manageAppt = new FrmManageAppt();
                manageAppt.MdiParent = this;
                manageAppt.Show();
            }
            else { manageAppt.Focus(); }
        }
        public FrmCallingUnit call { get { return _call; } set { _call = value; } }
        private FrmCallingUnit _call;
        public FrmNumberScreen screen { get { return _screen; } set { _screen = value; } }
        private FrmNumberScreen _screen;
        private void 叫號系統ToolStripMenuItem_Click(object sender, EventArgs e)    //call
        {
            if (call == null || call.IsDisposed)
            {
                int docid = _EMPLOYEE.Emp_ID;
                if (_EMPLOYEE.Emp_Type == "護士")
                { docid = new CApptCallingUnit_Model().getDocIdByNurseId(_EMPLOYEE.Emp_ID); }
                call = new FrmCallingUnit(docid);  //new時填入登入的empID
                call.screen = screen;
                if (screen != null)
                { screen.call = call; }
                call.Show();
            }
            else { call.Focus(); }
        }
        private void 號碼廣播窗ToolStripMenuItem_Click(object sender, EventArgs e) //screen
        {
            if (screen == null || screen.IsDisposed)
            {
                screen = new FrmNumberScreen();
                screen.call = call;
                if (call != null)
                { call.screen = screen; }
                screen.Show();
            }
            else { screen.Focus(); }
        }
        //----------
    }
}
