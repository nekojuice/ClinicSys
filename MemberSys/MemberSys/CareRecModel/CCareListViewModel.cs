using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSys.ViewModel
{
    public class CCareListViewModel
    {
        [Browsable(false)]
        public int 會員編號 { get; set; }

        public string 媽媽 { get; set; }
        [Browsable(false)]
        public bool 性別 { get; set; }
        [Browsable(false)]
        public string 生日 { get; set; }
        [Browsable(false)]
        public string 血型 { get; set; }
        public string 新生兒 { get; set; }
        [Browsable(false)]

        //int?讓它可以是null 不然會程式壞掉
        //public int? NewBorn_ID { get; set; }
        public int NewBorn_ID { get; set; }





    }
}
