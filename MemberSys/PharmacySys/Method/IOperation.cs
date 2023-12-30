using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.Method
{
    public interface IOperation
    {
        void refresh();
        void create();
        void delete();
        void update();
        void search(string keyword);
    }
}
