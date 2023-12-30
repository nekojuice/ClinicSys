using MSIT155_E_MID.ApptSystem.Extension;
using MSIT155_E_MID.ApptSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC.Monitoring;
using PCSC;
using MSIT155_E_MID.ApptSystem.Model;

namespace MSIT155_E_MID.ApptSystem.View
{
    public partial class FrmNumberScreen : Form
    {
        public FrmNumberScreen()
        {
            InitializeComponent();
        }

        public FrmCallingUnit call { get; set; }

        public int calledID { set { lbCurrent.Text = value.ToString(); } }
        public int nextID { set { lbNext.Text = value.ToString(); } }

        private EntityCallingUnit_ClinicInfoType _clinifinfo;
        public EntityCallingUnit_ClinicInfoType clinifinfo
        {
            get { return _clinifinfo; }
            set
            {
                if (value == null) { return; }
                _clinifinfo = value;
                lbRoomName.Text = _clinifinfo.roomName;
                lbDocName.Text = _clinifinfo.docName;
                lbDepartment.Text = _clinifinfo.deptName;
                lbNurseName.Text = _clinifinfo.nurseName;
            }
        }
        private string _timeShift;
        public string timeShift
        {
            get { return _timeShift; }
            set
            {
                _timeShift = value;
                lbTimeShift.Text = _timeShift;
            }
        }

        private DataTable _table;
        public DataTable table
        {
            get
            { return _table; }
            set
            {
                _table = value;
                dataGridView1.DataSource = _table;
                if (value == null)
                { return; }
                if (value.Rows.Count <= 0)
                { return; }
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["birth"].Visible = false;
                dataGridView1.Columns["身分證字號"].Visible = false;
                dataGridView1.style_MistyRose();
                //目前診號要改成"叫號"按下才更新
                //if (value.Rows.Count >= 1)
                //{ lbCurrent.Text = value.Rows[0]["診號"].ToString(); }
                //if (value.Rows.Count >= 2)
                //{ lbNext.Text = value.Rows[1]["診號"].ToString(); }
            }
        }

        private void FrmNumberScreen_Load(object sender, EventArgs e)
        {
            if (call == null)
            { return; }
            table = call.table;
            clinifinfo = call.clinifinfo;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null && e.Value.ToString().Length >= 2)
                {
                    e.Value = e.Value.ToString().Remove(1, 1);
                    e.Value = e.Value.ToString().Insert(1, "O");
                }
            }
        }
        public async void calledFlashing()
        {
            lbCurrent.Visible = false;
            await Task.Delay(500);
            lbCurrent.Visible = true;
            await Task.Delay(500);
            lbCurrent.Visible = false;
            await Task.Delay(500);
            lbCurrent.Visible = true;
            await Task.Delay(500);
            lbCurrent.Visible = false;
            await Task.Delay(500);
            lbCurrent.Visible = true;
            await Task.Delay(500);
        }


    }
}
