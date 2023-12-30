using MemberSys;
using prjCustomerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRoom
{
    public partial class frmSurgery : Form, IOperation
    {
        public frmSurgery()
        {
            InitializeComponent();
        }

        public void create()
        {
            frmScheduleEditor f = new frmScheduleEditor();
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                ClinicSysEntities db = new ClinicSysEntities();
                
                db.Appointment_Room_Schedule.Add(f.schedule);

                db.SaveChanges();
                refresh();
            }
        }
        public void delete()
        {
            if (RoomListdataGridView1.CurrentRow == null)
                return;
            string id = RoomListdataGridView1.CurrentRow.Cells[0].Value.ToString();
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
            ClinicSysEntities db = new ClinicSysEntities();
            var products = db.RoomList.Where(p => p.Name.Contains(keyword));
            RoomListdataGridView1.DataSource = products.ToList();
            CStyle_room.DataGridViewDesign(RoomListdataGridView1);
        }

        public void update()
        {
            if (RoomListdataGridView1.CurrentRow == null)
                return;
            string id = RoomListdataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fId = Convert.ToInt32(id);
            ClinicSysEntities db = new ClinicSysEntities();
            Appointment_Room_Schedule prod = db.Appointment_Room_Schedule.FirstOrDefault(p => p.Appointment_ID == fId);
            if (prod == null)
                return;
            frmScheduleEditor f = new frmScheduleEditor();
            f.schedule = prod;
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                prod.Room_ID = f.schedule.Room_ID;
                prod.Member_ID = f.schedule.Member_ID;
                prod.StartDate = f.schedule.StartDate;
                prod.EndDate = f.schedule.EndDate;
                prod.Doctor_ID = f.schedule.Doctor_ID;
                prod.Nurse_ID = f.schedule.Nurse_ID;

                db.SaveChanges();
                refresh();
            }
        }
      
        

           

        

        private void refresh()
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var Room_Schedule = from p in db.Appointment_Room_Schedule
                                where (p.RoomList.RoomTypeList.Name == "產房")
                                select p;
            RoomListdataGridView1.DataSource = Room_Schedule.ToList();
            this.RoomListdataGridView1.Columns["Member_EmployeeList"].Visible = false;
            this.RoomListdataGridView1.Columns["Member_MemberList"].Visible = false;
            this.RoomListdataGridView1.Columns["RoomList"].Visible = false;
            this.RoomListdataGridView1.Columns["Emp_ID"].Visible = false;

            CStyle_room.DataGridViewDesign(RoomListdataGridView1);
        }

        private void frmSurgery_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
