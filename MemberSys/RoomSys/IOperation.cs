using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCustomerSystem
{
    public interface IOperation
    {
        void create();
        void delete();
        void update();
        void search(string keyword);
    }
}

