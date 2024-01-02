using MemberSys;
using prjCustomerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRoom
{
    public partial class frmRoomList : Form, IOperation
    {
        public frmRoomList()
        {
            InitializeComponent();
        }

        public void create()
        {
            frmRoomEditor f = new frmRoomEditor();
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                ClinicSysEntities db = new ClinicSysEntities();
             
                db.RoomList.Add(f.roomlist);
                
                db.SaveChanges();
                refresh();
            }
        }
            public void delete()
            {
            if (RoomListdataGridView.CurrentRow == null)
                return;
            string id = RoomListdataGridView.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int fId = Convert.ToInt32(id);
            ClinicSysEntities db = new ClinicSysEntities();
            RoomList prod = db.RoomList.FirstOrDefault(p => p.Room_ID == fId);
            if (prod == null)
                return;
            db.RoomList.Remove(prod);
            db.SaveChanges();
            refresh();
        }

            public void search(string keyword)
            {
           // ClinicSysEntities db = new ClinicSysEntities();
           // var products = db.RoomList.Where(p => p.Name.Contains(keyword));
          //  RoomListdataGridView.DataSource = products.ToList();
         //   CStyle_room.DataGridViewDesign(RoomListdataGridView);
        }

        public void update()
        {
            if (RoomListdataGridView.CurrentRow == null)
                return;
            string id = RoomListdataGridView.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fId = Convert.ToInt32(id);
            ClinicSysEntities db = new ClinicSysEntities();
            RoomList prod = db.RoomList.FirstOrDefault(p => p.Room_ID == fId);
            if (prod == null)
                return;
            frmRoomEditor f = new frmRoomEditor();
            f.roomlist = prod;
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                prod.Name = f.roomlist.Name;
                prod.Type_ID = f.roomlist.Type_ID;
              
                db.SaveChanges();
                refresh();
            }
        }
            private void frmRoomList_Load(object sender, EventArgs e)
            {

                refresh();

            }

            private void refresh()
            {
                ClinicSysEntities db = new ClinicSysEntities();
            var roomLists = from p in db.RoomList
                            select new
                            {

                                房間ID = p.Room_ID,
                                房間名稱 = p.Name,
                                房型ID = p.Type_ID,
                                    
                                };
            RoomListdataGridView.DataSource = roomLists.ToList();
              


            //for(int i=3;i< RoomListdataGridView.ColumnCount; i++) {
            //    RoomListdataGridView.ColumnHeadersVisible = false;
            //}
            //this.RoomListdataGridView.Columns["RoomTypeList"].Visible = false;
            CStyle_room.DataGridViewDesign(RoomListdataGridView);
        }

       
    }

   
    
    }
