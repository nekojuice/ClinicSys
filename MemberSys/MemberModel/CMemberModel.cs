using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSys.Models
{
    public class CMemberModel
    {
        //新增一個含有全部員工(來自資料庫)的MODEL
        ClinicSysEntities db = new ClinicSysEntities();

        //進資料庫找出有沒有這個信箱 信箱不能重複註冊所以是唯一值
        public bool isValidedMemberEmail(string memEmail)
        {
            int count = db.Member_MemberList.Where(e => e.Mem_Email == memEmail).Count();
            return (count == 1) ? true : false;
        }

        //找出該名員工的信箱與輸入信箱是否相同
        public Member_MemberList getMemEmail(string memberemail)
        {
            return new ClinicSysEntities().Member_MemberList.FirstOrDefault(x => x.Mem_Email == memberemail);
        }
        //找出輸入密碼與該會員密碼是否同
        public Member_MemberList getMemPassword(string memberpassword)
        {
            return new ClinicSysEntities().Member_MemberList.FirstOrDefault(x => x.Mem_Email == memberpassword);
        }
    }
}
