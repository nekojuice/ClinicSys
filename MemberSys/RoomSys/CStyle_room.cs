using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCustomerSystem
{
    public class CStyle_room
    {
        public static void DataGridViewDesign(DataGridView dataGridViewName)
        {
            int j = dataGridViewName.Columns.Count - 1;
            for(int i = 0; i < j; i++)
            {
                if(i==0)
                    dataGridViewName.Columns[i].Width = 100;
                else
                    dataGridViewName.Columns[i].Width = 200;

            }
            bool isColoChanged = true;
            foreach (DataGridViewRow r in dataGridViewName.Rows)
            {
                isColoChanged = !isColoChanged;
                r.DefaultCellStyle.BackColor = Color.MistyRose;
                if (isColoChanged)
                    r.DefaultCellStyle.BackColor = Color.LightCoral;
                
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.Height = 40;
            }
        }
    }
}
