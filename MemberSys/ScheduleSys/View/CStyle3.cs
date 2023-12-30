using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent.View
{
    public static class CStyle3

    {
        public static void DataGridViewDesign(DataGridView dataGridViewName)
        {
            dataGridViewName.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10); 
            int j = dataGridViewName.Columns.Count - 1;
            for (int i = 0; i < j; i++)
            {
                if (i == 4||i == 5)
                    dataGridViewName.Columns[i].Width = 130;
                else
                dataGridViewName.Columns[i].Width = 90;
            }
            bool isColorChange = true;
            foreach (DataGridViewRow r in dataGridViewName.Rows)
            {
                isColorChange = (!isColorChange);
                r.DefaultCellStyle.BackColor = Color.MistyRose;
                if (isColorChange)
                    r.DefaultCellStyle.BackColor = Color.LightCoral;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.Height = 40;
            }
        }
        public static void DataGridViewDesign2(DataGridView dataGridViewName)
        {
            int cellSize = 100;
            dataGridViewName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridViewName.BackgroundColor = Color.Snow;
            dataGridViewName.DefaultCellStyle.BackColor = Color.MistyRose;
            dataGridViewName.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
            

             foreach (DataGridViewRow row in dataGridViewName.Rows)
             {
                 row.Height = cellSize;
             }

             // 設定每一列的寬度
             foreach (DataGridViewColumn col in dataGridViewName.Columns)
             {
                 col.Width = cellSize;
             }

             //設定單元格的對齊方式
            dataGridViewName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static void DataGridViewDesignForNurse(DataGridView dataGridViewName)
        {
            dataGridViewName.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10);
            int j = dataGridViewName.Columns.Count - 1;
            for (int i = 0; i < j; i++)
            {
                if (i == 5 || i == 6)
                    dataGridViewName.Columns[i].Width = 130;
                else
                    dataGridViewName.Columns[i].Width = 90;
            }
            bool isColorChange = true;
            foreach (DataGridViewRow r in dataGridViewName.Rows)
            {
                isColorChange = (!isColorChange);
                r.DefaultCellStyle.BackColor = Color.MistyRose;
                if (isColorChange)
                    r.DefaultCellStyle.BackColor = Color.LightCoral;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.Height = 40;
            }
        }
    }
}
