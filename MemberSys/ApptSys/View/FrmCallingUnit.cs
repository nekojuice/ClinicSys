using MSIT155_E_MID.ApptSystem.Model;
using MSIT155_E_MID.ApptSystem.Extension;
using MSIT155_E_MID.ApptSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PCSC.Monitoring;
using PCSC;
using static System.Windows.Forms.AxHost;
using System.Media;

namespace MSIT155_E_MID.ApptSystem.View
{
    public partial class FrmCallingUnit : Form
    {
        public FrmNumberScreen screen { get; set; }
        public EntityCallingUnit_ClinicInfoType clinifinfo { get; set; }

        public int docID { get; set; } //醫師ID，抓登入資料
        private int _clinicState = 0;    //看診狀態計數器，辨識插號排序用，只有0,1,2
        public int clinicID { get; set; }
        public DataTable table { get; set; }

        //private string today = DateTime.Now.Date.ToString("yyyy/MM/dd");
        //抓今天日期，這裡先鎖死成2023/12/01
        private string today = "2023/12/01";

        CApptCallingUnit_Model _Controller = new CApptCallingUnit_Model();



        public FrmCallingUnit(int empID)    //new此視窗必須帶入登入醫師ID
        {
            InitializeComponent();
            this.docID = empID;
            clinifinfo = _Controller.GetClinitInfo(empID, today);
            if (clinifinfo == null) { return; }
            lbInfo.Text = $"{clinifinfo.roomName}, {clinifinfo.docName} 醫師, {today}({DateTime.Parse(today).DayOfWeek.chineseWeek()})";

            if (screen == null)
            { return; }
            screen.table = table;
        }



        private void FrmCallingUnit_Load(object sender, EventArgs e)    //初始化時選選項0，顯示"選擇時段"
        {
            FrmCallingUnit_Load2(sender, e);
            cbxSelectTimeShift.SelectedIndex = 0;
            if (screen == null)
            { return; }
            screen.clinifinfo = clinifinfo;

        }

        private void cbxSelectTimeShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectTimeShift.SelectedIndex != 0 && cbxSelectTimeShift.Items.Count > 3)    //選擇任意後，把"選擇時段"從選項刪除
            {
                cbxSelectTimeShift.Items.RemoveAt(0);
            }
            if (cbxSelectTimeShift.Items.Count == 3)   //有登入且已選擇時段時，撈插號狀態與資料
            {
                var result = _Controller.GetClinitState((int)docID, today, cbxSelectTimeShift.SelectedItem.ToString());
                clinicID = result.Item1;
                _clinicState = result.Item2;
                LoadData();
                showCurrentPatient();
                connectScreenUpdataData(table);
            }
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("stateID").DataType = typeof(int);
            dt.Columns.Add("診號").DataType = typeof(int);
            dt.Columns.Add("姓名");
            dt.Columns.Add("性別");
            dt.Columns.Add("身分證字號");
            dt.Columns.Add("狀態");
            dt.Columns.Add("birth");

            //有空嘗試，只要查一次: 方法2，照state1~8順序排，檢查3號之間有無空位，再移動4(遲到候補)號
            //排序插號2:1， 正常 正常 插號 正常 正常 插號...
            int jumpingPower = 0;   //排序1個正常時間報到者+1
            List<int> jumpingIndex = new List<int>();   //記下插號位置

            foreach (EntityCallingUnitDataType item in _Controller.GetTodayPatientList((int)docID, today, cbxSelectTimeShift.SelectedItem.ToString()).Item1)
            {
                if (item.patientStateId == 3)   //state:3為正常報到者
                {
                    jumpingPower++;
                    if (jumpingPower % 2 == 0 && jumpingPower != 0)      //每2個正常報到者
                    {
                        jumpingIndex.Add(dt.Rows.Count + jumpingPower / 2 - _clinicState);    //記下插號位置
                    }
                }
                DataRow r = dt.NewRow();
                r[0] = item.patientStateId;
                r[1] = item.patientClinicNumber;
                r[2] = item.patientName;
                r[3] = item.patientGender;
                r[4] = item.patientNationalID;
                r[5] = item.patientState;
                r[6] = item.patientBirth;
                dt.Rows.Add(r);
            }

            int lastcountIndex = 0; //從後面數
            foreach (EntityCallingUnitDataType item in _Controller.GetTodayPatientList((int)docID, today, cbxSelectTimeShift.SelectedItem.ToString()).Item2)
            {
                DataRow r = dt.NewRow();
                r[0] = item.patientStateId;
                r[1] = item.patientClinicNumber;
                r[2] = item.patientName;
                r[3] = item.patientGender;
                r[4] = item.patientNationalID;
                r[5] = item.patientState;
                r[6] = item.patientBirth;
                if (jumpingIndex.Count > 0 && (item.patientStateId == 4))   //將插號者依記下的填入
                {
                    dt.Rows.InsertAt(r, jumpingIndex.First());
                    jumpingIndex.RemoveAt(0);   //填好後把位置紀錄刪掉
                }
                else
                {
                    for (int i = dt.Rows.Count - 1; i > 0; i--)   //如果插號者太多，插號位已用光，全部填後面，從後面填剩下的
                    {
                        if ((int)dt.Rows[i][0] < 5 && (int)dt.Rows[i][0] > 2)
                        { lastcountIndex = i; break; }
                    }
                    dt.Rows.InsertAt(r, lastcountIndex);
                }
            }

            dataGridView1.DataSource = dt;
            connectScreenUpdataData(dt);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["birth"].Visible = false;
            dataGridView1.style_CallingUnit();
        }
        private void connectScreenUpdataData(DataTable dt)
        {
            if (dt == null)
            { return; }
            this.table = dt;
            if (screen == null)
            { return; }
            screen.timeShift = cbxSelectTimeShift.SelectedItem.ToString();
            screen.table = table;
        }

        private void showCurrentPatient()   //下方小窗，顯示幕前操作的病患
        {
            if (dataGridView1.DataSource == null)
            {
                return;
            }
            //if ((int)((DataTable)dataGridView1.DataSource).Rows[0]["stateID"] == 1)
            if ((int)((DataTable)dataGridView1.DataSource).Rows.Count > 0)
            {
                txtCurrentNum.Text = ((DataTable)dataGridView1.DataSource).Rows[0]["診號"].ToString();
                txtCurrentName.Text = ((DataTable)dataGridView1.DataSource).Rows[0]["姓名"].ToString();
                int state = (int)((DataTable)dataGridView1.DataSource).Rows[0]["stateID"];
                if (state >= 1 && state <= 5) { btnCall.Enabled = btnState1.Enabled = btnState5.Enabled = btnState6.Enabled = btnState7.Enabled = true; }
            }
            else
            { btnCall.Enabled = btnState1.Enabled = btnState5.Enabled = btnState6.Enabled = btnState7.Enabled = false; }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)  //雙擊表格內資料，進入詳細資料
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dataGridView1.SelectedCells.Count <= 0)
            { return; }
            int index = dataGridView1.SelectedCells[0].RowIndex;
            if (index < 0)
            { return; }
            DataRow r = dt.Rows[index];

            DialogCallingUnit_PatientInfo f = new DialogCallingUnit_PatientInfo(
                new EntityCallingUnitDataType()
                {
                    patientStateId = (int)r["stateID"],
                    patientClinicNumber = (int)r["診號"],
                    patientName = (string)r["姓名"],
                    patientGender = (string)r["性別"],
                    patientNationalID = (string)r["身分證字號"],
                    patientBirth = DateTime.Parse(r["birth"].ToString()),
                    patientState = (string)r["狀態"]
                }, (int)docID, cbxSelectTimeShift.SelectedItem.ToString(), today
                , screen);

            f.ShowDialog();
            if (f.isChanged)    //如果有變動，重新整理
            {
                cbxSelectTimeShift_SelectedIndexChanged(sender, e);
            }
        }

        private void btnState1_Click(object sender, EventArgs e)    //按鈕切換狀態
        { btnClickEvent(1); }
        private void btnState5_Click(object sender, EventArgs e)
        { btnClickEvent(5); }
        private void btnState6_Click(object sender, EventArgs e)
        { btnClickEvent(6); }
        private void btnState7_Click(object sender, EventArgs e)
        { btnClickEvent(7); }
        private void btnClickEvent(int state)   //herererere
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return;
            CApptCallingUnit_Model c = new CApptCallingUnit_Model();
            c.UpdatePatientState((int)docID, today, cbxSelectTimeShift.SelectedItem.ToString(),
                dt.Rows[0]["身分證字號"].ToString(), state);
            cbxSelectTimeShift_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            if (screen != null)
            {
                screen.calledID = (int)table.Rows[0]["診號"];
                screen.nextID = (int)table.Rows[1]["診號"];
                screen.calledFlashing();
            }
        }

        //-----------------------------------------------------------------------
        //讀卡機

        public delegate void D_info2(EntitySmartCardInfoType info);
        public delegate void D_infoclear2();

        private ISCardContext oReaders = PCSC.ContextFactory.Instance.Establish(PCSC.SCardScope.User);
        private ISCardMonitor oMonitor;
        private void FrmCallingUnit_Load2(object sender, EventArgs e)
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
                    //D_infoclear del = new D_infoclear(SmartCardRemove);
                    //this.Invoke(del);
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

        private void SmartCardRead(EntitySmartCardInfoType info)
        {
            if (!table.AsEnumerable().Any(row => row.Field<string>("身分證字號") == info.cID))
            {
                new SoundPlayer(MemberSys.Properties.Resources.報到失敗).Play();
                MessageBox.Show("報到失敗，沒有掛號紀錄");
                return;
            }
            int clinicNum = (int)table.AsEnumerable().FirstOrDefault(row => row.Field<string>("身分證字號") == info.cID)["診號"];
            int beforeState = (int)table.AsEnumerable().FirstOrDefault(row => row.Field<string>("身分證字號") == info.cID)["stateID"];

            switch (beforeState)
            {
                case 8:
                    if ((int)((DataTable)dataGridView1.DataSource).Rows[0]["診號"] > clinicNum)
                    {
                        changePatientStatus(4, info.cID, clinicNum); //過號
                    }
                    else if ((int)((DataTable)dataGridView1.DataSource).Rows[0]["診號"] < clinicNum)
                    {
                        changePatientStatus(3, info.cID, clinicNum); //已報到
                    }
                    break;
                case 5:
                    changePatientStatus(2, info.cID, clinicNum);
                    break;
                case 6:
                    changePatientStatus(4, info.cID, clinicNum);
                    break;

                default:
                    new SoundPlayer(MemberSys.Properties.Resources.報到失敗).Play();
                    MessageBox.Show("報到失敗");
                    break;
            }

        }

        private void changePatientStatus(int state, string nationalID, int clinicnum)
        {
            int docID = this.docID;
            string today = "2023/12/01";
            string timeshift = cbxSelectTimeShift.SelectedItem.ToString();
            string patientNationalID = nationalID;

            new CApptCallingUnit_Model().UpdatePatientState(docID, today, timeshift, patientNationalID, state);
            checkInPlaySound(clinicnum);
            MessageBox.Show("報到成功，可以抽離健保卡");
            cbxSelectTimeShift_SelectedIndexChanged(new object(), new EventArgs());
        }
        private void checkInPlaySound(int clinicNum)
        {
            string xx = clinicNum.ToString().Substring(0, 1);
            string x = clinicNum.ToString().Substring(1, 1);
            switch (xx)
            {
                case "9": new SoundPlayer(MemberSys.Properties.Resources.九).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "8": new SoundPlayer(MemberSys.Properties.Resources.八).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "7": new SoundPlayer(MemberSys.Properties.Resources.七).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "6": new SoundPlayer(MemberSys.Properties.Resources.六).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "5": new SoundPlayer(MemberSys.Properties.Resources.五).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "4": new SoundPlayer(MemberSys.Properties.Resources.四).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "3": new SoundPlayer(MemberSys.Properties.Resources.三).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "2": new SoundPlayer(MemberSys.Properties.Resources.二).PlaySync(); new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "1": new SoundPlayer(MemberSys.Properties.Resources.十).PlaySync(); break;
                case "0": break;
            }
            switch (x)
            {
                case "9": new SoundPlayer(MemberSys.Properties.Resources.九).PlaySync(); break;
                case "8": new SoundPlayer(MemberSys.Properties.Resources.八).PlaySync(); break;
                case "7": new SoundPlayer(MemberSys.Properties.Resources.七).PlaySync(); break;
                case "6": new SoundPlayer(MemberSys.Properties.Resources.六).PlaySync(); break;
                case "5": new SoundPlayer(MemberSys.Properties.Resources.五).PlaySync(); break;
                case "4": new SoundPlayer(MemberSys.Properties.Resources.四).PlaySync(); break;
                case "3": new SoundPlayer(MemberSys.Properties.Resources.三).PlaySync(); break;
                case "2": new SoundPlayer(MemberSys.Properties.Resources.二).PlaySync(); break;
                case "1": new SoundPlayer(MemberSys.Properties.Resources.一).PlaySync(); break;
                case "0": break;
            }
            new SoundPlayer(MemberSys.Properties.Resources.號).PlaySync();
            new SoundPlayer(MemberSys.Properties.Resources.報到成功).Play();
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
    }
}
