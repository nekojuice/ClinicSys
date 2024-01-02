using MemberSys.EmployeeModels;
using MemberSys.FrmCareRec;
using MemberSys.Models;
using MemberSys.ViewModel;
using prjCustomerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys.Frm
{
    public partial class FrmReal : Form
    {

        private int Member_Id;
        ClinicSysEntities db = new ClinicSysEntities();
        List<CMemberViewModel> listMember;
        List<CEmpViewModel> listEmp;
        List<CMemberViewModel> listforMemSearch;
        List<CEmpViewModel> listforEmpSearch;
        List<CEmpViewModel> listyourSearch;
        public FrmReal()
        {
            InitializeComponent();
            dateTimePicker1.Value= DateTime.Now.AddDays(-7);
            dateTimePicker2.Value = DateTime.Now.AddDays(1);
            dataGridViewFeed.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 14);
            dataGridViewCareMem.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 14);

        }
        #region 各種打開頁面
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            FrmMember frm = new FrmMember();    
            frm.ShowDialog();
        }

        #endregion 各種打開頁面

        #region 該畫面一載入





        private void FrmReal_Activated(object sender, EventArgs e)
        {
            CStyle.resetGridRowColor(dataGridView_Member);
            CStyle.resetGridRowColor(dataGridViewEmp);

        }
        #endregion 該畫面一載入


        #region 會員資料
        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            if ((txtBoxMemSearch.Text) == "")
            {
                refreshMemberList();
                //CMemberStyle.resetGridRowColor(dataGridView_Member);
                return;
            }

            listforMemSearch = new List<CMemberViewModel>();
            ClinicSysEntities db = new ClinicSysEntities();
            var members = db.Member_MemberList
                            .Where(t => t.Name.ToUpper().Contains(txtBoxMemSearch.Text.ToUpper())
                                     || t.National_ID.ToUpper().Contains(txtBoxMemSearch.Text.ToUpper())
                                     || t.Address.ToUpper().Contains(txtBoxMemSearch.Text.ToUpper())
                                     || t.Phone.ToUpper().Contains(txtBoxMemSearch.Text.ToUpper()))
                            .ToArray();

            foreach (var m in members)
            {
                listforMemSearch.Add(new CMemberViewModel(m));

            }
            dataGridView_Member.DataSource = listforMemSearch;
            //解決跑板問題，新增資料後也有跑板問題，控制版面也是
            CStyle.resetGridRowColor(dataGridView_Member);
            CStyle.AddBtn(dataGridView_Member);
        }

        private void btnMemberClear_Click(object sender, EventArgs e)
        {
            txtBoxMemSearch.Text = "";
        }


        //會員資料一載入的畫面
        private void refreshMemberList()
        {
            //dataGridViewCareMem.Columns.Clear();
            //在清單上加上按鈕
            CStyle.AddBtn(dataGridView_Member);
            //直接把把resetGridRowColor放在refreshMemberList使用 2023/12/23

            listMember = new List<CMemberViewModel>();
            ClinicSysEntities db = new ClinicSysEntities();
            var members = from m in db.Member_MemberList
                          select m;
            foreach (var m in members)
            {
                listMember.Add(new CMemberViewModel(m));

            }
            dataGridView_Member.DataSource = listMember;
            
            CStyle.resetGridRowColor(dataGridView_Member);
        }

       

        //會員資料畫面上的編輯按鈕
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView_Member.Columns["memberEdit"].Index && e.RowIndex >= 0)
            {
                int mem_number = Convert.ToInt32(dataGridView_Member.Rows[e.RowIndex].Cells["會員編號"].Value);
                FrmMemberEditor f = new FrmMemberEditor("會員資料編輯");

                //m 是CMemberViewModel的東西
                f.member = listMember.FirstOrDefault(m => m.會員編號.Equals(mem_number) );
                f.ShowDialog();
                if (f.confirm == DialogResult.OK)
                {
                    
                    refreshMemberList();
                }
            }
        }

        private void btnInsertMem_Click(object sender, EventArgs e)
        {
            FrmMemberEditor f = new FrmMemberEditor("新增會員資料");
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                ClinicSysEntities db = new ClinicSysEntities();
                db.Member_MemberList.Add(f.memberinsert);
                db.SaveChanges();
                refreshMemberList();
            }
        }
        #endregion 會員資料

        #region 員工資料

        private void bnEmpClear_Click(object sender, EventArgs e)
        {
            txtBoxEmp.Text = "";
        }
        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            if ((txtBoxEmp.Text) == "")
            {
                refreshEmpList();
                //CMemberStyle.resetGridRowColor(dataGridView_Member);
                return;
            }

            listforEmpSearch = new List<CEmpViewModel>();
            ClinicSysEntities db = new ClinicSysEntities();
            var emp = db.Member_EmployeeList
                            .Where(t => t.Name.ToUpper().Contains(txtBoxEmp.Text.ToUpper())
                                     || t.National_ID.ToUpper().Contains(txtBoxEmp.Text.ToUpper())
                                     || t.Address.ToUpper().Contains(txtBoxEmp.Text.ToUpper())
                                     || t.Phone.ToUpper().Contains(txtBoxEmp.Text.ToUpper()))
                            .ToArray();

            foreach (var m in emp)
            {
                listforEmpSearch.Add(new CEmpViewModel(m));

            }
            dataGridViewEmp.DataSource = listforEmpSearch;
            //解決跑板問題，新增資料後也有跑板問題，控制版面也是
            CStyle.resetGridRowColor(dataGridViewEmp);
            CEmpStyle.AddBtn(dataGridViewEmp);
        }


        private void btnEmpInsert_Click(object sender, EventArgs e)
        {
            FrmEmployeeEditor f = new FrmEmployeeEditor();
            f.ShowDialog();
            if(f.confirm == DialogResult.OK)
            {
                refreshEmpList();
            }
        }

        //員工資料一載入畫面
        private void refreshEmpList()
        {
            dataGridViewEmp.Columns.Clear();
            CEmpStyle.AddBtn(dataGridViewEmp);
            listEmp =new CEmpViewModel().GetAllVwEmp();
            dataGridViewEmp.DataSource = listEmp;
            
            //直接把把resetGridRowColor放在refreshMemberList使用 2023/12/23
            //CMemberStyle.resetGridRowColor(dataGridViewEmp);
        }


        //20231226 11:31在員工加上編輯按鈕 用員工編號去找哪筆資料 一點就把找到的資料bind到編輯畫面上的欄位
        private void dataGridViewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewEmp.Columns["empEdit"].Index && e.RowIndex >= 0)
            {
                int emp_number = Convert.ToInt32(dataGridViewEmp.Rows[e.RowIndex].Cells["員工編號"].Value);
                Member_EmployeeList emp = db.Member_EmployeeList.FirstOrDefault(m => m.Staff_Number == emp_number);
                if (emp == null) return;
                FrmEmpUpdate f = new FrmEmpUpdate();
                f.employee = emp;
                f.ShowDialog();
                if (f.confirm == DialogResult.OK)
                {
                    emp.Name = f.employee.Name;
                    emp.Address = f.employee.Address;
                    emp.Staff_Number = emp_number;
                    emp.Department = f.employee.Department;
                    emp.Gender = f.employee.Gender;
                    emp.Phone = f.employee.Phone;
                    emp.Birth_Date = f.employee.Birth_Date;
                    emp.Emp_Password = f.employee.Emp_Password;
                    emp.Blood_Type = f.employee.Blood_Type;
                    emp.Contact_Address = f.employee.Contact_Address;
                    emp.Emp_Type = f.employee.Emp_Type;
                    emp.EmpPhoto = f.employee.EmpPhoto;
                    emp.National_ID = f.employee.National_ID;
                    emp.Phone = f.employee.Phone.ToString();
                    db.SaveChanges();
                    dataGridViewEmp.DataSource = null;
                    //因為更新過db所以要把最上面的listEmp抓下來更新
                    dataGridViewEmp.DataSource = new CEmpViewModel().GetAllVwEmp();
                }

                //m 是CEmpViewModel的東西
                //f.employee = listEmp.FirstOrDefault(m => m.員工編號.Equals(emp_number));
                //f.employee = listEmp[emp_number];


            }
        }



        #endregion 員工資料

        private void dataGridView_Member_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.resetGridRowColor(dataGridView_Member);
            CStyle.DisplayTotalRowNumber(dataGridView_Member, lblMemTotal);
           
        }


        private void dataGridViewEmp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CStyle.resetGridRowColor(dataGridViewEmp);
            CStyle.DisplayTotalRowNumber(dataGridViewEmp, lblEmpTotalDisplay);
        }

        //public void reflashDataGriView()
        //{
        //    dataGridView2.DataSource = null;
        //    //List<Member_EmployeeList> emp= new CEmpModel().getEmps();
        //    string keyword = "123";
        //    List<Member_EmployeeList> emps = new CEmpModel().getEmpsbyKeyword(keyword);
        //    dataGridView2.DataSource = new CEmpViewModel().GetAllVwEmp();
        //}


        private void FrmReal_Load_1(object sender, EventArgs e)
        {
            refreshMemberList();
            refreshEmpList();

            //會員畫面下方顯示當下頁面總共資料筆數
            CStyle.DisplayTotalRowNumber(dataGridView_Member, lblMemTotal);
            //CStyle.DisplayTotalRowNumber(dataGridViewEmp, lblEmpTotalDisplay);
        }

#region 照顧紀錄

        List<CCareListViewModel> mem1 = new List<CCareListViewModel>();


        #endregion 搜尋結束

        private int _babyID;
        //確認抓到哪筆小孩資料並且變數儲存並顯示在label9
        private void dataGridViewCareMem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow selectedRow = dataGridViewCareMem.Rows[e.RowIndex];
            string name = selectedRow.Cells["媽媽"].Value.ToString();
            string childname = selectedRow.Cells["新生兒"].Value.ToString();

            // 20231229 mem1是存在gridview上的清單 所以要拿index去裡面拿
            _babyID = mem1[e.RowIndex].NewBorn_ID;
            label9.Text = $"媽媽：{name}\r\n小孩：{childname}";

            //以下為了要秀右邊gridview用

            resetDataGridView_Cares();
        }

        private void resetDataGridView_Cares()
        {
            //透過list把資料顯示在dv object只是一個空殼 沒有值 要灌給他
            List<Member_Care> cares = new ClinicSysEntities().Cases_NewBornList.FirstOrDefault(x => x.NewBorn_ID == _babyID).Member_Care.Where(c => c.Care_Date > this.dateTimePicker1.Value && c.Care_Date < this.dateTimePicker2.Value).ToList();
            List<object> feedModle = new List<object>();
            cares.Where(c=>c.Record_Type == "配方奶" || c.Record_Type == "母乳").ToList().ForEach(c => feedModle.Add(new { 時間 = c.Care_Date, 奶水類型 = c.Record_Type, 記錄值 = c.Record_dcp }));
            dataGridViewFeed.DataSource = feedModle;
            List<object> pooModle = new List<object>();
            cares.Where(c => c.Record_Type == "排便" ).ToList().ForEach(c => pooModle.Add(new { 時間 = c.Care_Date,  記錄值 = c.Record_dcp }));
            dataGridViewPoo.DataSource = pooModle;
            List<object> sleepModle = new List<object>();
            cares.Where(c => c.Record_Type == "睡眠").ToList().ForEach(c => sleepModle.Add(new { 時間 = c.Care_Date, 記錄值 = c.Record_dcp }));
            dataGridViewSleep.DataSource = sleepModle;
        }

        //全部照顧資料
        //cares.ForEach(c => sleepModle.Add(new { 時間 = c.Care_Date, 照顧型態 = c.Record_Type, 記錄值 = c.Record_dcp }));

        //新增餵奶紀錄 按下餵奶按鈕後
        public void createFeed(string name, string childname, int currentNewBornId)
        {

            FrmFeed f = new FrmFeed(name, childname, currentNewBornId);

            if (f.ShowDialog() == DialogResult.OK)
            {
                ClinicSysEntities db = new ClinicSysEntities();
                db.Member_Care.Add(f.care);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("請先選擇一列資料！");
            }
        }

        private void btnCareSearch_Click(object sender, EventArgs e)
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var mem = from t in db.Member_MemberList
                      where t.Name.Contains(textBox3.Text) ||
                            t.National_ID.Contains(textBox3.Text.ToUpper()) ||
                            t.Address.ToUpper().Contains(textBox3.Text.ToUpper()) ||
                            t.Phone.ToUpper().Contains(textBox3.Text.ToUpper())
                      join n in db.Cases_NewBornList on t.Member_ID equals n.Member_ID
                      select new CCareListViewModel
                      {

                          媽媽 = (t.Member_Number) + " " + t.Name,
                          新生兒 = (n.Name) + " " + (n.NewBorn_ID).ToString(),
                          NewBorn_ID = n.NewBorn_ID
                      };

            mem1 = mem.ToList();

            if (mem1.Count > 0)
            {
                dataGridViewCareMem.DataSource = mem1;
            }
            else
            {
                MessageBox.Show("找不到資料，也有可能是該會員沒有小孩", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewCareMem.DataSource = null;
            }
        }

        public void clickshow()
        {

            if (!isValidated())

                label9.Text = "家長姓名" + dataGridViewCareMem.Columns[0] + "小孩姓名" + dataGridViewCareMem.Columns[3];


        }
        private bool isValidated()
        {
            if (dataGridViewCareMem.Rows.Count <= 0)
            {
                MessageBox.Show("目前沒有選到資料。");
                return false;
            }
            if (dataGridViewCareMem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("沒有指定會員資料。");
                return false;
            }
            return true;
        }

        //新增餵奶紀錄
        private void btnFeedNew_Click(object sender, EventArgs e)
        {
            if (dataGridViewCareMem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCareMem.SelectedRows[0];
                CCareListViewModel selectedMember = selectedRow.DataBoundItem as CCareListViewModel;

                if (selectedMember != null)
                {
                    FrmFeed frmFeed = new FrmFeed(selectedMember.媽媽, selectedMember.新生兒, _babyID);
                    if (frmFeed.ShowDialog()== DialogResult.OK)
                    {
                        Member_Care care = frmFeed.care;
                        ClinicSysEntities db = new ClinicSysEntities();
                        db.Member_Care.Add(care);
                        db.SaveChanges();
                        MessageBox.Show("新增成功");
                    }

                    resetDataGridView_Cares();
                    // 如果需要，這裡可以刷新 DataGridView 或進行其他後續操作。
                }
            }
            else
            {
                MessageBox.Show("請選擇一行資料。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        

        private void panelEmpTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPoo_Click(object sender, EventArgs e)
        {
            if (dataGridViewCareMem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCareMem.SelectedRows[0];
                CCareListViewModel selectedMember = selectedRow.DataBoundItem as CCareListViewModel;

                if (selectedMember != null)
                {
                    FrmPoo frmpoo = new FrmPoo(selectedMember.媽媽, selectedMember.新生兒, _babyID);
                    if (frmpoo.ShowDialog() == DialogResult.OK)
                    {
                        Member_Care care = frmpoo.care;
                        ClinicSysEntities db = new ClinicSysEntities();
                        db.Member_Care.Add(care);
                        db.SaveChanges();
                        MessageBox.Show("新增成功");
                    }

                    resetDataGridView_Cares();
                    // 如果需要，這裡可以刷新 DataGridView 或進行其他後續操作。
                }
            }
            else
            {
                MessageBox.Show("請選擇一行資料。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (dataGridViewCareMem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCareMem.SelectedRows[0];
                CCareListViewModel selectedMember = selectedRow.DataBoundItem as CCareListViewModel;

                if (selectedMember != null)
                {
                    //小孩id透過viewmodel拿到
                    FrmSleep frmsleep = new FrmSleep(selectedMember.媽媽, selectedMember.新生兒, _babyID);
                    if (frmsleep.ShowDialog() == DialogResult.OK)
                    {
                        Member_Care care = frmsleep.care;
                        ClinicSysEntities db = new ClinicSysEntities();
                        db.Member_Care.Add(care);
                        db.SaveChanges();
                        MessageBox.Show("新增成功");
                    }

                    resetDataGridView_Cares();
                    // 如果需要，這裡可以刷新 DataGridView 或進行其他後續操作。
                }
            }
            else
            {
                MessageBox.Show("請選擇一行資料。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}








