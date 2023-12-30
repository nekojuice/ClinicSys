using System.Security.Permissions;
using System.Windows.Forms;

namespace ClinicSys
{
    public interface ICRUD
    {
        void ShowAll();
        void Create();
        void Delete();
        void Update();
        void Search(string keyword);
        void mountDateGridView(DataGridView grd);

    }
}