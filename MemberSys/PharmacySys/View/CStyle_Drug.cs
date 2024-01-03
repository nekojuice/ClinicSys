using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.View
{
    public class CStyle_Drug
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
            grd.Columns[1].Width = 800;
        }

        public static void resetGrdWithInDrug(DataGridView grd)
        {
            grd.Columns[0].Width = 100;
            grd.Columns[1].Width = 150;
            grd.Columns[2].Width = 300;
            grd.Columns[3].Width = 300;
            grd.Columns[4].Width = 250;
            grd.Columns[5].Width = 100;
            grd.Columns[6].Width = 300;
            grd.Columns[7].Width = 300;
            grd.Columns[8].Width = 150;
            grd.Columns[9].Width = 200;
            grd.Columns[10].Width = 200;
            grd.Columns[11].Width = 300;
            grd.Columns[12].Width = 300;
            grd.Columns[13].Width = 300;
        }

       
    }
}
