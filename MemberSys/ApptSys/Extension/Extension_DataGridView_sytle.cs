using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT155_E_MID.ApptSystem.Extension
{
    public static class Extension_DataGridView_sytle
    {
        public static void style_CallingUnit(this DataGridView v)
        {
            bool paintSwitcher = true;
            foreach (DataGridViewRow row in v.Rows)
            {
                row.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                if (paintSwitcher)
                { foreachMethod2(row, Color.MistyRose); }
                else
                { foreachMethod2(row, Color.White); }
                paintSwitcher = !paintSwitcher;
            }
            foreach (DataGridViewColumn c in v.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private static void foreachMethod2(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell item in row.Cells)
            {
                item.Style.BackColor = color;
                
                switch (item.Value.ToString())
                {
                    case "未報到": item.Style.BackColor = Color.Gray; break;
                    case "已報到": item.Style.BackColor = Color.White; break;
                    case "過號 已報到": item.Style.BackColor = Color.LightYellow; break;
                    case "覆診 已報到": item.Style.BackColor = Color.LightYellow; break;
                    case "看診中": item.Style.BackColor = Color.LightGreen; break;
                    case "離場 檢查中": item.Style.BackColor = Color.LightBlue; break;
                    case "離場 叫號未到": item.Style.BackColor = Color.OrangeRed; break;
                    case "已結束": item.Style.BackColor = Color.Gray; break;
                    default:
                        break;
                }
            }
        }

        public static void style_MistyRose(this DataGridView v)
        {   
            if (v.Rows.Count == 0) return;
            bool paintSwitcher = true;
            foreach (DataGridViewRow row in v.Rows)
            {
                row.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                if (paintSwitcher)
                { foreachMethod(row, Color.MistyRose); }
                else
                { foreachMethod(row, Color.White); }
                paintSwitcher = !paintSwitcher;
            }
        }

        private static void foreachMethod(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell item in row.Cells)
            {
                item.Style.BackColor = color;
                if (item.Value == null) return;
                if (item.Value.ToString().Equals("是") || item.Value.ToString().Equals("未報到"))  //字為"是"者 底色顯示
                { item.Style.BackColor = Color.Yellow; }
            }
        }
    }
}
