using ClinicSys.ViewModel;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ClinicSys
{

    public interface ICRUD
    {
        void showAll();
        void create();
        void delete();
        void update();
        void search(string keyword);
        void mountDateGridView(DataGridView grd);
    }
}