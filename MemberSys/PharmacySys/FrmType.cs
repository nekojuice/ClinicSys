using ClinicSysMdiParent.View;
using MemberSys;
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

namespace ClinicSysMdiParent
{
    public partial class FrmType : Form
    {
        private DialogResult _isOK;

        public DialogResult confirm
        {
            get { return _isOK; }
        }


        private Pharmacy_tTypeList _typelist;
        public Pharmacy_tTypeList typelist
        {
            get {
                if (_typelist == null)
                    _typelist = new Pharmacy_tTypeList();
                if (!string.IsNullOrEmpty(fbIdType.fieldValue))
                    _typelist.fId_Type = Convert.ToInt32(fbIdType.fieldValue);
                _typelist.fTypeCode = fbTypeCode.fieldValue;
                _typelist.fType= fbType.fieldValue;                
                return _typelist;
            }
            set
            {
                _typelist = value;
              
                fbIdType.fieldValue = _typelist.fId_Type.ToString();
                fbTypeCode.fieldValue = _typelist.fTypeCode;
                fbType.fieldValue = _typelist.fType;
                
            }
        }
        public FrmType()
        {
            InitializeComponent();
        }

        private void FrmType_Load(object sender, EventArgs e)
        {

        }
     
     
        private bool isUivalidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(fbTypeCode.fieldValue))
                msg += "\r\n代碼是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbType.fieldValue))
                msg += "\r\n劑型是必填欄位，不可空白";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg=="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isUivalidated())
                return;
            _isOK = DialogResult.OK;
            this.Close();
        }
    }
}
