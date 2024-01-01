using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MSIT155_E_MID.ApptSystem.Extension;
using MSIT155_E_MID.ApptSystem.Entity;
using MSIT155_E_MID.ApptSystem.Model;
using MSIT155_E_MID.ApptSystem.View;
using PCSC.Monitoring;
using PCSC;
using System.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace MSIT155_E_MID.ApptSystem.View
{
    public delegate void D_info(EntitySmartCardInfoType info);
    public delegate void D_rmInfo();
    public delegate void D_infoclear();
    public partial class FrmManageAppt : Form
    {
        public FrmManageAppt()
        {
            InitializeComponent();
        }
        private CApptManager_Model _Controller = new CApptManager_Model();

        //繪製左側Tab文字和顏色、點擊顏色
        private void EventDrawTab(object sender, DrawItemEventArgs e)
        {
            if (tabControl1.SelectedIndex == e.Index)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), e.Bounds);
            }
            Graphics g = e.Graphics;
            Font font = new Font("微軟正黑體", 16.0f, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF rect = tabControl1.GetTabRect(e.Index);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Near;
            g.DrawString(tabControl1.Controls[e.Index].Text, font, brush, rect, format);

            ImageList list = new ImageList();
            list.Images.Add("0", MemberSys.Properties.Resources.clinic_64px);
            list.Images.Add("1", MemberSys.Properties.Resources.patient_64px);
            list.Images.Add("2", MemberSys.Properties.Resources.card_64px);
            list.ImageSize = new Size(45, 45);

            Point loc = tabControl1.GetTabRect(e.Index).Location;
            g.DrawImage(list.Images[e.Index], new Point(loc.X, loc.Y + 8));
        }

        //啟動時載入預設資料
        private void FrmManageAppt_Shown(object sender, EventArgs e)    //初始載入以及刷新資料
        {
            cbxMonth.Items.Clear();
            FillcbxMonth();     //<<A>>
            cbxDept.SelectedIndex = 0;  //<<C>>
            if (cbxDoctorName.SelectedIndex != 0)
            {
                cbxDept_SelectedIndexChanged(sender, e);
            }
            dataGridView1.DataSource = null;
            checkApptDataSelected();
        }
        public void FillcbxMonth()  //填充 年月選擇<<A>>
        {
            foreach (var item in _Controller.GetScheduleYM())
            {
                cbxMonth.Items.Add(item);
                cbxMonth2.Items.Add(item);
            }
            try
            {
                cbxMonth.SelectedIndex = cbxMonth.Items.IndexOf($"{DateTime.Now.ToString("yyyy/MM")}");
                cbxMonth2.SelectedIndex = cbxMonth.Items.IndexOf($"{DateTime.Now.ToString("yyyy/MM")}");
            }//嘗試選當前時間月份//<<B>>
            catch (Exception) { } //do nothing
        }
        private void cbxDept_SelectedIndexChanged(object sender, EventArgs e)   //<<C>>
        {
            cbxDoctorName.Items.Clear();
            FillDocName();//<<D>>
        }
        private void FillDocName()//<<D>>
        {
            cbxDoctorName.Items.Add("全部");
            foreach (var item in _Controller.GetDocName(cbxDept.Text))
            { cbxDoctorName.Items.Add(item); }
            try
            { cbxDoctorName.SelectedIndex = 0; }//<<E>>
            catch (Exception) { }
        }

        private void cbxs_LoadClinicData(object sender, EventArgs e)//<<B>>//<<C>>//<<E>>//初始載入時會執行3次(因載入時選擇default)，需要最佳化
        {
            listData.Items.Clear();
            listData.ItemTagListClear();
            DateTime date = DateTime.Parse(cbxMonth.Text + "/01");

            foreach (EntityApptLINQDataType x in _Controller.GetClinicSchedule(cbxMonth.Text + "/01", cbxMonth.Text + DateTime.DaysInMonth(date.Year, date.Month).ToString("yyyy/MM/dd"), cbxDept.Text, cbxDoctorName.Text))
            {
                listData.AddItem($"{x.date}({DateTime.Parse(x.date).DayOfWeek.chineseWeek()}), {x.clinicShifts}, {x.department}" +
                $", {x.docname}, 上限{x.registrationLimit}人 目前[0]", x.clinic_ID);
            }
            btnPaitientNumReload_Click(sender, e);
            btnModifyLimit_EnabledCheck();
        }
        //當前掛號人數重新整理
        private void btnPaitientNumReload_Click(object sender, EventArgs e) //回傳總人數
        {
            for (int i = 0; i < listData.Items.Count; i++)
            {
                int total = _Controller.GetApptPatientCount((int)listData.ItemTagGet(i));    //從tag拿到clinicID
                int temp = listData.Items[i].ToString().LastIndexOf('[') + 1;   //尋找分隔符號
                listData.Items[i] = listData.Items[i].ToString().Substring(0, temp) + total + "]";  //填裝人數及符號
            }
            lbInfo.Text = listData.SelectedItem?.ToString();
        }
        //小月曆選擇日期
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            listData.Items.Clear();
            listData.ItemTagListClear();
            foreach (EntityApptLINQDataType x in _Controller.GetClinicSchedule(e.Start.ToString("yyyy/MM/dd"), e.End.ToString("yyyy/MM/dd"), cbxDept.Text, cbxDoctorName.Text))
            {
                listData.AddItem($"{x.date}({DateTime.Parse(x.date).DayOfWeek.chineseWeek()}), {x.clinicShifts}, {x.department}" +
                $", {x.docname}, 上限{x.registrationLimit}人 目前[0]", x.clinic_ID);
            }
            btnPaitientNumReload_Click(sender, e);
            btnModifyLimit_EnabledCheck();
        }
        //小月曆選擇全部
        private void btnMonthCalSelectAll_Click(object sender, EventArgs e)
        {
            cbxs_LoadClinicData(sender, e);
            monthCalendar1.Focus();
            btnModifyLimit_EnabledCheck();
        }
        //小月曆切換月份
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (cbxMonth.Items.Contains(e.Start.ToString("yyyy/MM")))
            {
                cbxMonth.SelectedItem = e.Start.ToString("yyyy/MM");
            }
        }
        //驗證是否允許修改上限
        private void btnModifyLimit_EnabledCheck()
        {
            if (listData.SelectedIndex < 0)
            { toolStripbtnModifyLimit.Enabled = false; }
            else
            { toolStripbtnModifyLimit.Enabled = true; }

        }
        //點選門診並載入資料
        private void listData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listData.SelectedIndex < 0)
            {
                btnModifyLimit_EnabledCheck();
                return;
            }
            lbInfo.Text = listData.SelectedItem.ToString();

            DataTable tableShowOnly = new DataTable();
            tableShowOnly.Columns.Add("病患診號");
            tableShowOnly.Columns["病患診號"].DataType = Type.GetType("System.Int32");
            tableShowOnly.Columns.Add("姓名");
            tableShowOnly.Columns.Add("生日");
            tableShowOnly.Columns.Add("性別");
            tableShowOnly.Columns.Add("身分證字號");
            tableShowOnly.Columns.Add("是否退掛");
            tableShowOnly.Columns.Add("看診狀態");

            foreach (EntityApptLINQDataType item in _Controller.GetClinicData((int)listData.ItemTagGet(listData.SelectedIndex)))
            {
                string gender = item.member_gender ? "男" : "女"; //轉換性別bool成字串
                string isCancelled = item.patient_isCancelled ? "是" : "否";  //轉換退掛bool成字串

                tableShowOnly.Rows.Add(item.patientClinicNumber, item.member_name, item.member_birth.ToString("yyyy/MM/dd"), gender,
                    item.member_National_ID, isCancelled, item.patientState_Name);
            }
            tableShowOnly.DefaultView.Sort = "病患診號 asc";
            dataGridView1.DataSource = tableShowOnly;

            checkApptDataSelected();
            btnModifyLimit_EnabledCheck();
        }
        //新增掛號
        private void btnNewAppt_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = !panelAdd.Visible;
            if (panelAdd.Visible)
            {
                cbxSearch1.Focus();
            }
        }
        //小月曆顯示相關
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            btnMonthCalSelectAll.Visible = monthCalendar1.Visible = !monthCalendar1.Visible;
            monthCalendar1.Focus();
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            if (btnMonthCalSelectAll.Focused || btnCalendar.Focused)
            { return; }
            btnMonthCalSelectAll.Visible = monthCalendar1.Visible = false;
        }

        //檢查是否選擇欄位，按鈕是否可用
        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count <= 0)
            { toolStripbtnModifyAppt.Enabled = false; }
            else
            { toolStripbtnModifyAppt.Enabled = true; }
        }
        //修改掛號
        private void btnModifyAppt_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            btnMonthCalSelectAll.Visible = monthCalendar1.Visible = false;  //把浮動顯示窗都關掉

            int clinic_ID = (int)listData.ItemTagGet(listData.SelectedIndex);
            string member_NationalID = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["身分證字號"].Value.ToString();
            int clinicpatientNumber = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["病患診號"].Value;

            DialogModifyAppt f = new DialogModifyAppt();
            f.ClinicpatientNumber = clinicpatientNumber;
            f.clinicInfo = lbInfo.Text;
            f.clinicID = clinic_ID;
            f.paitientNationalID = member_NationalID;

            f.ShowDialog();
            if (f.dialogResult == DialogResult.OK)
                btnPaitientNumReload_Click(sender, e);
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridView1.style_MistyRose();
        }
        private void btnSearchPaitient_Click(object sender, EventArgs e)    //搜尋病患小窗
        {
            string searchbox = "";
            DataGridView view = new DataGridView();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    searchbox = cbxSearch1.Text;
                    view = dataGridView2;
                    break;
                case 1:
                    searchbox = cbxSearch2.Text;
                    view = dataGridView3;
                    break;
            }
            if (string.IsNullOrEmpty(searchbox))
            { return; }
            DataTable tableShowOnly = new DataTable();
            tableShowOnly.Columns.Add("身分證字號");
            tableShowOnly.Columns.Add("性別");
            tableShowOnly.Columns.Add("姓名");
            tableShowOnly.Columns.Add("生日");
            tableShowOnly.Columns.Add("會員編號");

            foreach (EntityApptLINQDataType item in _Controller.GetPatientInfo(searchbox))
            {
                string gender = item.member_gender ? "男" : "女"; //轉換性別bool成字串
                tableShowOnly.Rows.Add(item.member_National_ID, gender, item.member_name, item.member_birth.ToString("yyyy/MM/dd"), item.member_ID);
            }
            view.DataSource = tableShowOnly;
            view.Columns["生日"].Visible = false;
            view.Columns["會員編號"].Visible = false;
            if (view.Rows.Count == 1)  //如果查詢資料只有一筆，直接選擇
            {
                dataGridView2_Click(sender, e);
            }
            dataGridView2.style_MistyRose();
            dataGridView3.style_MistyRose();
        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int selectedRows = 0;
            PatientInfo box = new PatientInfo();
            DataGridView view = new DataGridView();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    selectedRows = dataGridView2.SelectedRows.Count;
                    box = patientInfo2;
                    view = dataGridView2;
                    break;
                case 1:
                    selectedRows = dataGridView3.SelectedRows.Count;
                    box = patientInfo3;
                    view = dataGridView3;
                    break;
            }

            if (selectedRows <= 0)
            { return; }

            box.info = new EntitySmartCardInfoType()
            {
                cName = view.SelectedRows[0].Cells["姓名"].Value.ToString(),
                cGender = view.SelectedRows[0].Cells["性別"].Value.ToString(),
                cID = view.SelectedRows[0].Cells["身分證字號"].Value.ToString(),
                cBirthday = view.SelectedRows[0].Cells["生日"].Value.ToString()
            };
            if (tabControl1.SelectedIndex == 0)
            {
                checkApptDataSelected();    //+掛號按鈕亮起
            }
            if (tabControl1.SelectedIndex == 1)
            {
                checkSearchDataSelected();
            }
        }

        private void checkSearchDataSelected()
        {
            if (!string.IsNullOrEmpty(patientInfo3.txtID))
            {
                btnSearchPatientAppt.Enabled = true;
            }
            else
                btnSearchPatientAppt.Enabled = false;
        }
        private void checkCardInsert()
        {
            if (!string.IsNullOrEmpty(patientInfo1.txtID))
            {
                btnGoCheckIn.Enabled = true;
            }
            else
                btnGoCheckIn.Enabled = false;
        }
        //====================================================================================================

        public void SmartCardRead(EntitySmartCardInfoType info)
        {
            patientInfo1.info = info;
            patientInfo2.info = info;
            patientInfo3.info = info;
            lbIsInfoRead.Text = "資料已讀取";
            lbIsInfoRead.BackColor = Color.Lime;
            checkCardInsert();
            checkApptDataSelected();
            checkSearchDataSelected();
            btnGoCheckIn.PerformClick();
        }
        public void SmartCardRemove()
        {
            new PatientInfo().Clear(patientInfo1);
            new PatientInfo().Clear(patientInfo2);
            new PatientInfo().Clear(patientInfo3);
            lbIsInfoRead.Text = "卡片未插入";
            lbIsInfoRead.BackColor = Color.LightGray;
            checkCardInsert();
            checkApptDataSelected();
            checkSearchDataSelected();
        }

        private void btnInfoRead_Click(object sender, EventArgs e)
        {
            CApptCard_Model x = new CApptCard_Model(
                new D_info(SmartCardRead), new D_rmInfo(SmartCardRemove));
            x.CardReaderInit();
            checkApptDataSelected();
            checkSearchDataSelected();
            checkCardInsert();
        }

        private void btnInfoClear_Click(object sender, EventArgs e) //
        {
            SmartCardRemove();
            checkApptDataSelected();
            checkSearchDataSelected();
            checkCardInsert();
        }

        private void cbxSearch1_KeyDown(object sender, KeyEventArgs e)  //搜尋按enter
        {
            if (e.KeyCode == Keys.Enter)
            { btnSearchPaitient_Click(sender, e); }
        }

        private void checkApptDataSelected()
        {
            if (listData.SelectedIndex >= 0 && !string.IsNullOrEmpty(patientInfo2.txtID))
            {
                btnAppendNewAppt.Enabled = true;
            }
            else
                btnAppendNewAppt.Enabled = false;
        }
        private void btnAppendNewAppt_Click(object sender, EventArgs e)
        {
            DataTable t = (DataTable)dataGridView2.DataSource;
            int clinic_ID = (int)listData.ItemTagGet(listData.SelectedIndex);
            string member_NationalID = patientInfo2.txtID;
            if (string.IsNullOrEmpty(member_NationalID))
            { MessageBox.Show("資料已變動，請重新操作"); }

            if (_Controller.IsRegularNewAppt(clinic_ID, member_NationalID))
            {
                MessageBox.Show("此病患已重複掛號");
            }
            else
            {
                DialogAddNewAppt f = new DialogAddNewAppt();
                f.patientInfo = new EntitySmartCardInfoType()    //傳入病患資料
                {
                    cBirthday = patientInfo2.txtBirth,
                    cGender = patientInfo2.txtGender,
                    cID = patientInfo2.txtID,
                    cName = patientInfo2.txtName
                };

                f.clinicInfo = listData.SelectedItem.ToString();    //傳入診間資料
                f.ShowDialog();
                if (f.dialogResult == DialogResult.Yes)
                {
                    _Controller.AddNewAppt2(clinic_ID, member_NationalID, f.isVIP);
                    MessageBox.Show("已新增掛號");
                    btnPaitientNumReload_Click(sender, e);
                }
            }
        }

        private void toolStripbtnModifyLimit_Click(object sender, EventArgs e)
        {
            DialogModifyLimit f = new DialogModifyLimit();
            f.clinic_ID = (int)listData.ItemTagGet(listData.SelectedIndex);
            f.clinicInfo = listData.SelectedItem.ToString();
            f.ShowDialog();
            if (f.dialogResult == DialogResult.OK)
            {
                cbxs_LoadClinicData(sender, e);
            }
        }

        private void btnSearchPatientAppt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(patientInfo3.txtID))
            { lbSearchPatientInfo.Text = $"{patientInfo3.txtID}, {patientInfo3.txtName}, {patientInfo3.txtGender}, {patientInfo3.txtBirth}"; }

            var result = _Controller.GetPatientAllAppt(patientInfo3.txtID, cbxMonth2.SelectedItem.ToString());
            if (result == null)
            { return; }
            DataTable dt = new DataTable();
            dt.Columns.Add("門診日期");
            dt.Columns.Add("門診時段");
            dt.Columns.Add("科別");
            dt.Columns.Add("醫師");
            dt.Columns.Add("診號");
            dt.Columns.Add("退掛");
            dt.Columns.Add("VIP");
            dt.Columns.Add("門診ID"); //不顯示
            foreach (EntityApptLINQDataType item in result)
            {
                DataRow r = dt.NewRow();
                r[0] = item.date;
                r[1] = item.clinicShifts;
                r[2] = item.department;
                r[3] = item.docname;
                r[4] = item.patientClinicNumber;
                r[5] = item.patient_isCancelled ? "是" : "否";
                r[6] = item.isVIP ? "是" : "否";
                r[7] = item.clinic_ID;
                dt.Rows.Add(r);
            }
            dataGridView4.DataSource = dt;
            dataGridView4.Columns["門診ID"].Visible = false;
            dataGridView4.style_MistyRose();
        }

        private void toolStripModify2_Click(object sender, EventArgs e)
        {
            int index = dataGridView4.SelectedCells[0].RowIndex;
            DialogModifyAppt f = new DialogModifyAppt();

            EntityApptLINQDataType x = _Controller.GetClinicInfo(Convert.ToInt32(dataGridView4.Rows[index].Cells["門診ID"].Value));
            if (x != null)
            {
                f.clinicInfo = $"{x.date}({DateTime.Parse(x.date).DayOfWeek.chineseWeek()}), {x.clinicShifts}, {x.department}" +
                $", {x.docname}";
            }
            f.clinicID = Convert.ToInt32(dataGridView4.Rows[index].Cells["門診ID"].Value);
            f.ClinicpatientNumber = Convert.ToInt32(dataGridView4.Rows[index].Cells["診號"].Value);
            f.paitientNationalID = patientInfo3.txtID;
            f.ShowDialog();
            if (f.dialogResult == DialogResult.OK)
            {
                btnSearchPatientAppt_Click(sender, e);  //畫面重整
            }


        }

        private void toolStripbtnFilter_Click(object sender, EventArgs e)
        {
            panelFIlterAppt.Visible = !panelFIlterAppt.Visible;
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedCells.Count != 0)
                toolStripModify2.Enabled = true;
            else
                toolStripModify2.Enabled = false;
        }

        private void dataGridView4_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView4.SelectedCells.Count != 0)
                toolStripModify2.Enabled = true;
            else
                toolStripModify2.Enabled = false;
        }

        private void cb_allcheck_Click(object sender, EventArgs e)
        {
            cb_dept_1.Checked = cb_dept_2.Checked = cb_time_1.Checked = cb_time_2.Checked = cb_time_3.Checked = cb_vip_N.Checked = cb_vip_Y.Checked = cb_can_N.Checked = cb_can_Y.Checked = true;
            isFiltered = false;
            btnSearchPatientAppt_Click(sender, e);
        }

        private bool isFiltered = false;
        private DataTable dtdource = null;
        private void cb_dept_1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView4.DataSource == null)
            {
                return;
            }
            if (cb_dept_1.Checked && cb_dept_2.Checked && cb_time_1.Checked && cb_time_2.Checked && cb_time_3.Checked && cb_time_3.Checked && cb_vip_Y.Checked && cb_vip_N.Checked && cb_can_N.Checked && cb_can_Y.Checked)
            {
                isFiltered = false;
                btnSearchPatientAppt_Click(sender, e);
                return;
            }
            if (isFiltered == false)
            {
                dtdource = (DataTable)dataGridView4.DataSource;
            }
            DataView dv = dtdource.DefaultView;
            string filter = "";
            if (!cb_dept_1.Checked) { filter += " And 科別 <> '小兒科'"; }
            if (!cb_dept_2.Checked) { filter += " And 科別 <> '婦產科'"; }
            if (!cb_time_1.Checked) { filter += " And 門診時段 <> '早診'"; }
            if (!cb_time_2.Checked) { filter += " And 門診時段 <> '午診'"; }
            if (!cb_time_3.Checked) { filter += " And 門診時段 <> '晚診'"; }
            if (!cb_can_Y.Checked) { filter += " And 退掛 <> '是'"; }
            if (!cb_can_N.Checked) { filter += " And 退掛 <> '否'"; }
            if (!cb_vip_Y.Checked) { filter += " And VIP <> '是'"; }
            if (!cb_vip_N.Checked) { filter += " And VIP <> '否'"; }
            if (filter.Substring(0, 5) == " And ")
            { filter = filter.Remove(0, 5); }

            dv.RowFilter = filter;
            isFiltered = true;
            dataGridView4.DataSource = dv;
            dataGridView4.style_MistyRose();
        }

        private void cbxMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearchPatientAppt_Click(sender, e);
        }

        //-----------------------------------------------------------------------
        //讀卡機

        public delegate void D_info2(EntitySmartCardInfoType info);
        public delegate void D_infoclear2();

        private ISCardContext oReaders = PCSC.ContextFactory.Instance.Establish(PCSC.SCardScope.User);
        private ISCardMonitor oMonitor;
        private void FrmManageAppt_Load(object sender, EventArgs e)
        {
            EntitySmartCardInfoType info;
            string cReader = oReaders.GetReaders().FirstOrDefault();
            if (string.IsNullOrEmpty(cReader))
            {
                MessageBox.Show("找不到任何讀卡機，請重新檢查硬體");
                return;     //找不到任何PSCS讀卡機就跳走
            }
            else
            {
                //MessageBox.Show($"已偵測到讀卡機{cReader}，程式運行期間請勿任意移除設備。");
                oMonitor = PCSC.Monitoring.MonitorFactory.Instance.Create(PCSC.SCardScope.System);
            }

            oMonitor.CardRemoved += (oSender, oArgs) =>
            {
                //MessageBox.Show("# 偵測到晶片卡移除。");
                if (this.InvokeRequired)
                {
                    D_infoclear del = new D_infoclear(SmartCardRemove);
                    this.Invoke(del);
                }
            };
            oMonitor.CardInserted += (oSender, oArgs) =>
            {
                //MessageBox.Show("# 偵測到晶片卡插入。");
                info = GetCardInfo(cReader);  //讀取健保卡顯性資料
                if (this.InvokeRequired)
                {
                    D_info del = new D_info(SmartCardRead);
                    this.Invoke(del, info);
                }
            };
            oMonitor.MonitorException += (oSender, oArgs) =>
            {
                MessageBox.Show("讀卡機被移除或是讀取晶片卡出現異常，請重新啟動程式。");
                return;
            };
            oMonitor.Start(cReader);
            //有可能執行程式前讀卡機與卡片就都已經準備好，如此一來並不會觸發事件，因此先強制執行一次讀取看看
            try
            {
                info = GetCardInfo(cReader);
                if (this.InvokeRequired)
                {
                    D_info del = new D_info(SmartCardRead);
                    this.Invoke(del, info);
                }
            }
            catch
            { return; }
        }

        private EntitySmartCardInfoType GetCardInfo(string cReader)
        {
            using (var oContext = PCSC.ContextFactory.Instance.Establish(PCSC.SCardScope.User))
            using (var oReader = new PCSC.Iso7816.IsoReader(
              context: oContext,
              readerName: cReader,
              mode: PCSC.SCardShareMode.Shared,
              protocol: PCSC.SCardProtocol.Any
            ))
            {
                //Console.WriteLine("－－－－－");
                //初始化健保卡
                var oAdpuInit = new PCSC.Iso7816.CommandApdu(PCSC.Iso7816.IsoCase.Case4Short, oReader.ActiveProtocol)
                {
                    CLA = 0x00,
                    INS = 0xA4,
                    P1 = 0x04,
                    P2 = 0x00,
                    Data = new byte[] { 0xD1, 0x58, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11 }
                };
                //Console.WriteLine($"@ APDU InitCard:   {System.BitConverter.ToString(oAdpuInit.ToArray())}");
                //取得初始化健保卡回應
                var oAdpuInitResponse = oReader.Transmit(oAdpuInit);
                //Console.WriteLine($"@ Response:        SW1={oAdpuInitResponse.SW1.ToString("X")}｜SW2={oAdpuInitResponse.SW2.ToString("X")}");
                //檢查回應是否正確（144；00）
                if (!(oAdpuInitResponse.SW1.Equals(144) && oAdpuInitResponse.SW2.Equals(0)))
                {
                    //Console.WriteLine("－－－－－");
                    MessageBox.Show("# 晶片卡並非健保卡，請換張卡片試看看。");
                    return null;
                }
                //讀取健保顯性資訊
                var oAdpuProfile = new PCSC.Iso7816.CommandApdu(PCSC.Iso7816.IsoCase.Case4Short, oReader.ActiveProtocol)
                {
                    CLA = 0x00,
                    INS = 0xCA,
                    P1 = 0x11,
                    P2 = 0x00,
                    Data = new byte[] { 0x00, 0x00 }
                };
                //Console.WriteLine($"@ APDU GetProfile: {System.BitConverter.ToString(oAdpuProfile.ToArray())}");
                //取得讀取健保卡顯性資訊回應
                var oAdpuProfileResponse = oReader.Transmit(oAdpuProfile);
                //Console.WriteLine($"@ Response:        SW1={oAdpuProfileResponse.SW1.ToString("X")}｜SW2={oAdpuProfileResponse.SW2.ToString("X")}");
                //檢查回應是否正確（144；00）
                if (!(oAdpuInitResponse.SW1.Equals(144) && oAdpuInitResponse.SW2.Equals(0)))
                {
                    //Console.WriteLine("－－－－－");
                    System.Windows.Forms.MessageBox.Show("# 健保卡讀取錯誤，請換張卡片試看看。");
                    return null;
                }
                //如果有回應且具備資料的話，就將其輸出到畫面上
                if (oAdpuProfileResponse.HasData)
                { //播放提示音
                    //Console.Beep();
                    //位元組資料
                    byte[] aryData = oAdpuProfileResponse.GetData();
                    //文字編碼解碼器
                    var oUTF8 = System.Text.Encoding.UTF8;
                    var oBIG5 = System.Text.Encoding.GetEncoding("big5");
                    //建立使用者匿名物件
                    var oUser = new
                    {
                        cCardNumber = oUTF8.GetString(aryData.Take(12).ToArray()),
                        cName = oBIG5.GetString(aryData.Skip(12).Take(20).ToArray()),
                        cID = oUTF8.GetString(aryData.Skip(32).Take(10).ToArray()),
                        cBirthday = oUTF8.GetString(aryData.Skip(42).Take(7).ToArray()),
                        cGender = oUTF8.GetString(aryData.Skip(49).Take(1).ToArray()) == "M" ? "男" : "女",
                        cCardPublish = oUTF8.GetString(aryData.Skip(50).Take(7).ToArray())
                    };
                    return new EntitySmartCardInfoType()
                    {
                        cCardNumber = oUser.cCardNumber,
                        cName = (oUser.cName).Trim(),
                        cID = oUser.cID,
                        cBirthday = Extension_DateTime.TWdateFormate(oUser.cBirthday),
                        cGender = oUser.cGender,
                        cCardPublish = oUser.cCardPublish
                    };
                }
                return null;
            }
        }


        //-----------------------------------------------------------
        private void btnGoCheckIn_Click(object sender, EventArgs e)
        {
            //鎖死今日為2023/12/01
            string today = "2023/12/01";
            //撈取現在看診號 或者沒有掛號紀錄
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("科別");
            dataTable.Columns.Add("醫師");
            dataTable.Columns.Add("時段");
            dataTable.Columns.Add("姓名");
            dataTable.Columns.Add("診號");
            dataTable.Columns.Add("已過號");
            dataTable.Columns.Add("狀態");

            var result = _Controller.GetPatientTodayAppt(patientInfo1.txtID, today);
            foreach (EntityApptLINQDataType item in result)
            {
                DataRow r = dataTable.NewRow();
                int current = new CApptCallingUnit_Model().currentNumber(item.clinic_ID);
                r["科別"] = item.department;
                r["醫師"] = item.docname;
                r["時段"] = item.clinicShifts;
                r["姓名"] = item.member_name;
                r["診號"] = item.patientClinicNumber;
                r["狀態"] = item.patientState_Name;
                r["已過號"] = (current > item.patientClinicNumber) ? "是" : "否";
                dataTable.Rows.Add(r);
            }

            dataGridView5.DataSource = dataTable;

            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.Name = "報到";
            btncol.Text = "報到";
            btncol.UseColumnTextForButtonValue = true;
            if (dataGridView5.Columns.Contains("報到"))
            { dataGridView5.Columns.Remove("報到"); }
            dataGridView5.Columns.Add(btncol);

            dataGridView5.style_MistyRose();


        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (dataGridView5.Rows[e.RowIndex].Cells["狀態"].Value.ToString())
                {
                    case "未報到":
                        if (dataGridView5.Rows[e.RowIndex].Cells["已過號"].Value.ToString() == "是")
                        {
                            changePatientStatus(e.RowIndex,4); //過號
                        }
                        else 
                        {
                            changePatientStatus(e.RowIndex, 3); //已報到
                        }
                        break;
                    case "離場 檢查中":
                        changePatientStatus(e.RowIndex, 2); //覆診
                        break;
                    case "離場 叫號未到":
                        changePatientStatus(e.RowIndex, 4); //過號
                        break;
                    default:
                        MessageBox.Show("無法重複報到");
                        break;
                }
            }
        }
        private void changePatientStatus(int currentindex,int state)
        {
            int docID = _Controller.GetEmpID(dataGridView5.Rows[currentindex].Cells["醫師"].Value.ToString());
            string today = "2023/12/01";
            string timeshift = dataGridView5.Rows[currentindex].Cells["時段"].Value.ToString();
            string patientNationalID = patientInfo1.txtID;

            if (string.IsNullOrEmpty(patientNationalID))
            {
                MessageBox.Show("請插入健保卡");
                return;
            }

            new CApptCallingUnit_Model().UpdatePatientState(docID, today, timeshift, patientNationalID, state);
            MessageBox.Show("報到成功，可以抽離健保卡");
            btnGoCheckIn_Click(new object(), new EventArgs());
        }

    }
}
