using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent
{
    internal class CCstyle
    {
        public static void MainTitleDesign(Label 主標題Name)
        {
            主標題Name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
        }
        public static void SubTitleDesign(Label 副標題Name)
        {
            副標題Name.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
        }
        public static void DataGridViewDesign(DataGridView dataGridViewName)
        {
            //DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //dataGridViewName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            //dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            int j = dataGridViewName.Columns.Count;
            for (int i = 0; i < j; i++)
            {
                if (i == 0)
                {
                    dataGridViewName.Columns[i].Width = 100;
                }
                else
                {
                    dataGridViewName.Columns[i].Width = 300;
                }
            }
            bool isColoChanged = true;
            foreach (DataGridViewRow r in dataGridViewName.Rows)
            {
                isColoChanged = !isColoChanged;
                r.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
                if (isColoChanged)
                    r.DefaultCellStyle.BackColor = Color.MistyRose;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.Height = 40;
            }
        }
    }
}
