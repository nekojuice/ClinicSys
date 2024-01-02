using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Net;
using prjCustomerSystem;
using MemberSys;

namespace prjRoom
{
    public partial class frmRoomEditor : Form
    {
        private DialogResult _isOk;
        public DialogResult confirm
        {
            get { return _isOk; }
        }

        private RoomList _roomlist;
     




        public RoomList roomlist
        {
            get
            {
                if (_roomlist == null)
                    _roomlist = new RoomList();
                if (!string.IsNullOrEmpty(fbName.fieldValue))
                    _roomlist.Name = fbName.fieldValue;
                _roomlist.Type_ID = Convert.ToInt32(fbRoomtype.fieldValue);
                

                return _roomlist;
            }
            set
            {
                _roomlist = value;
                fbId.fieldValue = _roomlist.Room_ID.ToString();
                fbName.fieldValue = _roomlist.Name;
                fbRoomtype.fieldValue = _roomlist.Type_ID.ToString();



            }
        }







        

        public frmRoomEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isUiValidated())
                return;

            _isOk = DialogResult.OK;
            this.Close();
        }

        private bool isUiValidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(fbName.fieldValue))
                msg += "\r\n房間名稱是必填欄位不可空白";
            if (string.IsNullOrEmpty(fbRoomtype.fieldValue))
               msg += "\r\n房間編號是必填欄位，不可空白";
            if (!string.IsNullOrEmpty(fbRoomtype.fieldValue) &&
             !CNumberUtility.isNumber(fbRoomtype.fieldValue))
                msg += "\r\n房間編號必須輸入數字";

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

       

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void frmRoomEditor_Load_1(object sender, EventArgs e)
        {

        }
    }
}
