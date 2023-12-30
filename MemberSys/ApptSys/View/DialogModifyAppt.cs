using MSIT155_E_MID.ApptSystem.Model;
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
    public partial class DialogModifyAppt : Form
    {
        public DialogModifyAppt()
        {
            InitializeComponent();
        }

        public string clinicInfo { set { lbInfo.Text = value; } }
        public int clinicID { get; set; }
        public string paitientNationalID { get; set; }
        public int ClinicpatientNumber { get; set; }
        public DialogResult dialogResult { get; set; }
        
        CApptManager_Model _Controller = new CApptManager_Model();
        
        private void DialogModifyAppt_Load(object sender, EventArgs e)
        {
            EntityApptLINQDataType d = _Controller.GetClinicOneAppt(clinicID, paitientNationalID);
            if (d == null)
            {
                dialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            patientInfo1.txtBirth = d.member_birth.ToString("yyyy/MM/dd");
            patientInfo1.txtGender = d.member_gender ? "男" : "女";
            patientInfo1.txtID = d.member_National_ID;
            patientInfo1.txtName = d.member_name;

            txtPatientClinicNumber.Text = ClinicpatientNumber.ToString();
            txtIsCancelled.Text = d.patient_isCancelled ? "是" : "否";
            txtState.Text = d.patientState_Name;
            txtIsVIP.Text = d.isVIP ? "是" : "否";

            cbxIsCancelled.SelectedItem = txtIsCancelled.Text;
            cbxState.SelectedItem = txtState.Text;
            cbxIsVIP.SelectedItem = txtIsVIP.Text;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtIsVIP.Text != (string)cbxIsVIP.SelectedItem) //如果更動VIP欄位
            {
                bool isVIP = cbxIsVIP.SelectedItem.ToString().Equals("是") ? true : false;
                _Controller.DeleteAppt(clinicID, paitientNationalID);
                _Controller.AddNewAppt2(clinicID, paitientNationalID, isVIP);
                this.Close();
            }
            if ((string)cbxIsCancelled.SelectedItem != txtIsCancelled.Text
                || (string)cbxState.SelectedItem != txtState.Text) //更改退掛與狀態欄位
            {
                bool iscanceled = cbxIsCancelled.SelectedItem.ToString().Equals("是") ? true : false;
                _Controller.ModifyAppt(clinicID,paitientNationalID, iscanceled, cbxState.SelectedItem.ToString());
            }
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("確認刪除嗎?", "確認", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) { return; }
            _Controller.DeleteAppt(clinicID, paitientNationalID);/////here
            MessageBox.Show("已成功刪除");
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbxIsVIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtIsVIP.Text != (string)cbxIsVIP.SelectedItem)
            {
                cbxIsCancelled.Enabled = false;
                cbxState.Enabled = false;
            }
            else
            {
                cbxIsCancelled.Enabled = true;
                cbxState.Enabled = true;
            }
        }
    }
}
