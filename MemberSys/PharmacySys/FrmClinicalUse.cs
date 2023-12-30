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

namespace ClinicSysMdiParent
{
    public partial class FrmClinicalUse : Form
    {

        private DialogResult _isOK;

        public DialogResult confirm
        {
            get { return _isOK; }
        }

        private Pharmacy_tClinicalUseList _clinicalUseList;

        public Pharmacy_tClinicalUseList clinicalUseList
        {
            get
            {
                if (_clinicalUseList == null)
                    _clinicalUseList = new Pharmacy_tClinicalUseList();
                if (!string.IsNullOrEmpty(fbId_ClinicalUse.fieldValue))
                    _clinicalUseList.fId_ClinicalUse = Convert.ToInt32(fbId_ClinicalUse.fieldValue);
                _clinicalUseList.fClinicalUseCode = fbClinicalUseCode.fieldValue;
                _clinicalUseList.fClinicalUse = fbClinicalUse.fieldValue;
                return _clinicalUseList;

            }
            set
            {
                _clinicalUseList=value;
                fbId_ClinicalUse.fieldValue = _clinicalUseList.fId_ClinicalUse.ToString();
                fbClinicalUseCode.fieldValue=_clinicalUseList.fClinicalUseCode;
                fbClinicalUse.fieldValue = _clinicalUseList.fClinicalUse;

            }
        }

        public FrmClinicalUse()
        {
            InitializeComponent();
        }

        private void FrmClinicalUse_Load(object sender, EventArgs e)
        {
            
        }
        private bool isUivalidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(fbClinicalUseCode.fieldValue))
                msg += "\r\n代碼是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbClinicalUse.fieldValue))
                msg += "\r\n適應症是必填欄位，不可空白";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
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
