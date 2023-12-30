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

namespace MSIT155_E_MID.ApptSystem.View
{
    public partial class DialogAddNewAppt : Form
    {
        public DialogAddNewAppt()
        {
            InitializeComponent();
        }

        public EntitySmartCardInfoType patientInfo
        {
            set
            {
                patientInfo1.txtBirth = value.cBirthday;
                patientInfo1.txtGender = value.cGender;
                patientInfo1.txtID = value.cID;
                patientInfo1.txtName = value.cName;
            }
        }
        public string clinicInfo
        {
            set
            {
                string[] clinicInfoString = value.Split(',');
                lbDate.Text = "日期: " + clinicInfoString[0];
                lbTimeShift.Text = "時段: " + clinicInfoString[1];
                lbDept.Text = "科別: " + clinicInfoString[2];
                lbDocName.Text = "醫師: " + clinicInfoString[3];
                lbLimitPatient.Text = clinicInfoString[4];
            }
        }

        public DialogResult dialogResult { get;set; }
        public bool isVIP { get;set; }
        private void btnYes_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Yes;
            isVIP = cbIsVip.Checked;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbIsNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbIsNormal.Checked)
            {
                cbIsNormal.Checked = true;
                cbIsVip.Checked = false;
            }
            else
            {
                cbIsNormal.Checked = true;
                cbIsVip.Checked = false;
            }
        }

        private void cbIsVip_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbIsVip.Checked)
            {
                cbIsVip.Checked = true;
                cbIsNormal.Checked = false;
            }
            else
            {
                cbIsVip.Checked = true;
                cbIsNormal.Checked = false;
            }
        }
    }
}
