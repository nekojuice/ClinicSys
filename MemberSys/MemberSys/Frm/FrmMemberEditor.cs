using MemberSys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MemberSys
{
    public partial class FrmMemberEditor : Form
    {

        private DialogResult _isOk;

        public DialogResult confirm
        {
            get { return _isOk; }
        }

        
        private Member_MemberList _member;
        //
        public CMemberViewModel member;

        public FrmMemberEditor(CMemberViewModel member)
        {
            this.member = member;
        }

        //private object comboBox1;

        public Member_MemberList memberinsert
        {
            get
            {
                if (_member == null)
                    _member = new Member_MemberList();
                if (!string.IsNullOrEmpty(fbMember_Num.fieldValue))
                    _member.Member_Number = Convert.ToInt32(fbMember_Num.fieldValue);

                _member.Name = fbName.fieldValue;
                _member.Gender = CboGender.fieldValue == "女" ? false : true;
                _member.Blood_Type = Convert.ToString(fbBlood.fieldValue);
                _member.National_ID = Convert.ToString(fbNID.fieldValue);
                _member.Address = Convert.ToString(fbAddress.fieldValue);
                _member.Contact_Address = Convert.ToString(fbCAddress.fieldValue);
                _member.Phone = (fbPhone.fieldValue);
                _member.Birth_Date = dtPickerBirth.Value.Date;
                //_member.Birth_Date = Convert.ToString(fbBirthdate.fieldValue);
                //嘗試在dtPickerBirth上顯示來自資料庫的時間
                //dtPickerBirth.Value = DateTime.ParseExact(_member.Birth_Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);


                _member.ICE_Name = Convert.ToString(fbICE.fieldValue);
                _member.ICE_Number = (fbICEPhone.fieldValue);
                _member.Mem_Password = fbPassword.fieldValue;
                return _member;
            }
            set
            {
                //_member = value;
                //fbMember_Num.fieldValue = _member.Member_Number.ToString();
                //fbName.fieldValue = _member.Name;
                //CboGender.fieldValue = _member.Gender.ToString();
                //fbBlood.fieldValue = _member.Blood_Type.ToString();
                //fbNID.fieldValue = _member.National_ID.ToString();
                //fbAddress.fieldValue = _member.Address.ToString();
                //fbCAddress.fieldValue = _member.Contact_Address.ToString();
                //fbPhone.fieldValue = _member.Phone.ToString();
                //fbBirthdate.fieldValue = _member.Birth_Date.ToString();
                //fbICE.fieldValue = _member.ICE_Name.ToString();
                //fbICEPhone.fieldValue = _member.ICE_Number.ToString();
            }
        }

        public FrmMemberEditor()
        {
            InitializeComponent();
        }
        public FrmMemberEditor(string mode)
        {
            //區分現在的模式是新增還是編輯 顯示在editor上的文字(會員資料編輯、新增會員資料)
            InitializeComponent();
            label1.Text = mode;
            this.Text = mode;
        }

        private void FrmMemberEditor_Load(object sender, EventArgs e)
        {
            //一載入就要有男女選項
            CboGender.Items.Add("男");
            CboGender.Items.Add("女");
            //先判斷有沒有選到資料 沒有代表點下了新增按鈕 
            if (member == null) return;
            //使用CMemberViewModel裡面的東西 抓到db的資料
            fbName.fieldValue = member.會員姓名;
            fbMember_Num.fieldValue = member.會員編號.ToString();
            fbPhone.fieldValue = member.聯絡電話.ToString();
            fbNID.fieldValue = member.身份證字號.ToString() ;
            fbICE.fieldValue = member.緊急聯絡人.ToString();
            fbICEPhone.fieldValue = member.緊急聯人電話.ToString();
            fbBlood.fieldValue = member.血型.ToString();
            fbCAddress.fieldValue = member.聯絡地址.ToString();
            fbAddress.fieldValue = member.戶籍地址.ToString();

            //這邊要嘗試把字串轉成時間格式並且顯示在datetimepicker上面
            dtPickerBirth.Value = member.生日;
            //fbBirthdate.fieldValue = member.生日.ToString();
            fbPassword.fieldValue = member.會員密碼.ToString();
            fbEmail.fieldValue = member.信箱.ToString();
            CboGender.fieldValue = member.生理性別.ToString();

          
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
            _isOk = DialogResult.OK;
            if(this.Text == "會員資料編輯")
             {


                ClinicSysEntities db = new ClinicSysEntities();
                try
                {
                    //遇到來自不同dbset(refreshMemberList那邊的db是另一個，editor又是另一個問題))
                    //所以無法將修改後的資料存進資料庫
                    //解決方法 至
                    var toSavedbMember = db.Member_MemberList.FirstOrDefault(m => m.Member_Number == member.會員編號);
                    toSavedbMember.Member_Number = Convert.ToInt32(fbMember_Num.fieldValue);
                    toSavedbMember.Name = fbName.fieldValue;
                    toSavedbMember.Gender = CboGender.fieldValue == "女" ? false : true;
                    toSavedbMember.Blood_Type = Convert.ToString(fbBlood.fieldValue);
                    toSavedbMember.National_ID = Convert.ToString(fbNID.fieldValue);
                    toSavedbMember.Address = Convert.ToString(fbAddress.fieldValue);
                    toSavedbMember.Contact_Address = Convert.ToString(fbCAddress.fieldValue);
                    toSavedbMember.Phone = (fbPhone.fieldValue);
                    //把會員的生日改成datetime格式
                    toSavedbMember.Birth_Date = dtPickerBirth.Value;
                    //toSavedbMember.Birth_Date = Convert.ToString(fbBirthdate.fieldValue);
                    toSavedbMember.ICE_Name = Convert.ToString(fbICE.fieldValue);
                    toSavedbMember.ICE_Number = (fbICEPhone.fieldValue);
                    toSavedbMember.Mem_Password = fbPassword.fieldValue;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex) { MessageBox.Show(ex.Message); }
                MessageBox.Show("保存成功");
            } else if(this.Text == "新增會員資料")
            {

                MessageBox.Show("新增成功");
            }
            
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
