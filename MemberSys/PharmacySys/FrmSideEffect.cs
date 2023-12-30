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
    public partial class FrmSideEffect : Form
    {
        private DialogResult _isOK;

        public DialogResult confirm
        {
            get { return _isOK; }
        }
        private Pharmacy_tSideEffectList _sideEffectList;

        public Pharmacy_tSideEffectList sideEffectList
        {
            get 
            {
                if (_sideEffectList == null)
                    _sideEffectList=new Pharmacy_tSideEffectList();
                if (!string.IsNullOrEmpty(fbId_SideEffect.fieldValue))
                    _sideEffectList.fId_SideEffect = Convert.ToInt32(fbId_SideEffect.fieldValue);
                _sideEffectList.fSideEffectCode=fbSideEffectCode.fieldValue; 
                _sideEffectList.fSideEffect=fbSideEffect.fieldValue;
                return _sideEffectList;
            }
            set
            {
                _sideEffectList = value;
                fbId_SideEffect.fieldValue=_sideEffectList.fId_SideEffect.ToString();
                fbSideEffectCode.fieldValue=_sideEffectList.fSideEffectCode;
                fbSideEffect.fieldValue = _sideEffectList.fSideEffect;

            }
        }
        public FrmSideEffect()
        {
            InitializeComponent();
        }

        private void FrmSideEffect_Load(object sender, EventArgs e)
        {
            
        }

        private bool isUivalidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(fbSideEffectCode.fieldValue))
                msg += "\r\n代碼是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbSideEffect.fieldValue))
                msg += "\r\n副作用名稱是必填欄位，不可空白";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }
       

        private void FrmSideEffect_Activated(object sender, EventArgs e)
        {
            //CStyle.resetGridRowColor(dataGridView1);
            //dataGridView1.Columns[1].Width = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isUivalidated())
                return;
            _isOK=DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();
        }
    }
}
