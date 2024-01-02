using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public class CStyle
    {
        public static void SetDataGridViewRowStyle(DataGridView gv, int fontSize, int rowHeight)
        {
            gv.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", fontSize);
            bool isColoChanged = true;
            foreach (DataGridViewRow r in gv.Rows)
            {
                isColoChanged = !isColoChanged;
                if (isColoChanged)
                    r.DefaultCellStyle.BackColor = Color.MistyRose;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", fontSize);
                r.Height = rowHeight;
            }

            foreach (DataGridViewColumn col in gv.Columns)
            {
                string c = col.Name.ToString();
                if (c.Contains("產品照片") == true)
                {
                    gv.Columns[c].Width = 90;
                }
                else if (c.Contains("產品名稱") == true)
                {
                    gv.Columns[c].Width = 200;
                }
                else if (c.Contains("產品描述") == true)
                {
                    gv.Columns[c].Width = 250;
                }
                else if (c.Contains("訂單折扣金額") == true)
                {
                    gv.Columns[c].Width = 250;
                }
                else if (c.Contains("說明") == true)
                {
                    gv.Columns[c].Width = 500;
                }
                else if (c.Contains("分類") == true)
                {
                    gv.Columns[c].Width = 180;
                }
                else if (c.Contains("照片") == true)
                {
                    gv.Columns[c].Width = 205;
                }
                else if (c.Contains("訂單金額") == true)
                {
                    gv.Columns[c].Width = 200;
                }
                else { gv.Columns[c].Width = 120; }
            }

        }

        public static void setDataGridViewHieghtLightStyle(DataGridView gv, string heightLightKeyword)
        {
            foreach (DataGridViewRow row in gv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value!=null && cell.Value.ToString().Contains(heightLightKeyword))
                    {
                        cell.Style.BackColor = Color.OrangeRed;
                        cell.Style.ForeColor = Color.WhiteSmoke;
                    }
                }
            }
        }
    }
}
