using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys.Models
{
    public class CMemberViewModel
    {
        ClinicSysEntities db = new ClinicSysEntities();
        //Member_MemberList來自db
        public Member_MemberList db_member;
        public CMemberViewModel(Member_MemberList m)
        {
            db_member = m;
        }

        [Browsable(false)]
        public int 會員ID { get { return db_member.Member_ID; } }
        public int 會員編號 { get { return db_member.Member_Number; }}
        public string 會員姓名 { get { return db_member.Name; } }
        public string 生理性別
        {          
            get
            { 
                //從資料庫來的資料會是真和假，如果是真就是男的
                //寫進資料庫也是如此，我表單上選女，進到資料庫就是假，也就是0
                return db_member.Gender ==true ? "男" : "女"; }
            //set { db_member.Gender = (value == "男" ? true : false); }
        } 
        public string 血型 { get { return db_member.Blood_Type; } }
        public string 身份證字號 { get { return db_member.National_ID; } }
        public string 戶籍地址 { get { return db_member.Address; } }
        public string 聯絡地址 { get { return db_member.Contact_Address; } }
        public string 聯絡電話 { get { return db_member.Phone; } }
        public DateTime 生日 { get { return db_member.Birth_Date; } }
        //public string 生日 { get { return db_member.Birth_Date; } }
        [Browsable(false)]
        public string 會員密碼 { get { return db_member.Mem_Password; } }
        [Browsable(false)]
        //判斷來自資料庫的資料是否為NULL，不等於NULL時顯示DB的那個資料，等於NULL時顯示""即可
        public string 信箱 
        { get { return db_member.Mem_Email!=null?db_member.Mem_Email:"目前無資料"; } }
        public string 緊急聯絡人 { get { return db_member.ICE_Name; } }
        public string 緊急聯人電話{ get { return db_member.ICE_Number; } }



        public void delete(int memberid)
        {
            try
            {
                var mem = (from m in db.Member_MemberList where m.Member_ID == memberid 
                           select m).FirstOrDefault();
                db.Member_MemberList.Remove(mem);
                db.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("刪除成功");
            }
        }
    }
}
