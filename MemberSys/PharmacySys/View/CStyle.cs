using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.View
{
    public class CStyle
    {
        public static void resetGridRowColor(DataGridView grd)
        {
            bool isColorChange = true; //因為一行一個顏色方便辨識，故製作一個bool
            foreach (DataGridViewRow r in grd.Rows)
            {
                isColorChange = !isColorChange; //每次都改變狀態
                r.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220); //可以自己下RGB
                if (isColorChange)
                    r.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14); //C#裡面字體是個物件 Font(字型) >字型設定
                r.Height = 40;
            }
        }
        public static void resetGrdWith(DataGridView grd)
        {
            grd.Columns[0].Width = 100;
            grd.Columns[1].Width = 300;
        }
       
    }
}
