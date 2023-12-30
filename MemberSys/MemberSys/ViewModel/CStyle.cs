using MemberSys.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCustomerSystem
{
    public class CStyle
    {
        //清單上每列可以變換顏色
        public static void resetGridRowColor(DataGridView grd)
        {
            bool isColoChanged = true;
            foreach(DataGridViewRow r in grd.Rows)
            {
            isColoChanged = !isColoChanged;
            r.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            if (isColoChanged)
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
            r.Height = 40;
            }

        }

        public static void resetGridStyle(DataGridView grd)
        {
         //grd.Columns[0].Width = 120;
         //grd.Columns[1].Width = 120;
         //grd.Columns[2].Width = 120;
         //grd.Columns[3].Width = 120;
         //grd.Columns[4].Width = 100;
         //grd.Columns[5].Width = 150;
         //grd.Columns[6].Width = 150;
         //grd.Columns[7].Width = 150;
         //grd.Columns[8].Width = 150;
         //grd.Columns[9].Width = 150;
         //grd.Columns[10].Width = 150;
         //grd.Columns[11].Width = 150;
         //   grd.Columns[10].Width = 100;
        }

        /// <summary>
        /// 在會員清單上加上按鈕
        /// </summary>
        /// <param name="grd" type="class datagridview">抓到該頁面的datagridview是誰，讓他長按鈕</param>
        public static void AddBtn(DataGridView grd)
        {

            if (grd.Columns.Contains("memberEdit") )
                return;

            // 編輯按鈕
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = "編輯";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Name = "memberEdit";
            btnEdit.HeaderText = "        ";
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            grd.Columns.Add(btnEdit);
        }

        public static void DisplayTotalRowNumber(DataGridView grd,Label labelname)
        {
            labelname.Text = "目前頁面上總共" + ((grd.Rows.Count).ToString()) + "筆資料";
        }

    }
}
