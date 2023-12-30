using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public class CstyleAtt
    {
        public static void resetGridRowColor(DataGridView grd)
        {
            bool isColoChanged = true;
            foreach (DataGridViewRow r in grd.Rows)
            {
                isColoChanged = !isColoChanged;
                r.DefaultCellStyle.BackColor = Color.MistyRose;
                if (isColoChanged)
                    r.DefaultCellStyle.BackColor = Color.Snow;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                r.Height = 40;
            }
        }
    }
}
