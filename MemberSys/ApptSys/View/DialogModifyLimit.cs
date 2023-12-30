using MSIT155_E_MID.ApptSystem.Model;
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
    public partial class DialogModifyLimit : Form
    {
        public DialogModifyLimit()
        {
            InitializeComponent();
        }
        public int clinic_ID { get; set; }
        public string clinicInfo { set { lbInfo.Text = value; } }
        public DialogResult dialogResult { get; set; }
        private CApptManager_Model _Controller = new CApptManager_Model();
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtLimitModified.Text == txtLimit.Text || string.IsNullOrEmpty(txtLimitModified.Text))
            { this.Close(); }
            if (!Int32.TryParse(txtLimitModified.Text, out int result))
            {
                MessageBox.Show("輸入的值不是整數");
                return;
            }
            _Controller.ModifyApptLimit(clinic_ID,Convert.ToInt32(txtLimitModified.Text));

            dialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DialogModifyLimit_Load(object sender, EventArgs e)
        {
            txtLimitModified.Text = txtLimit.Text = _Controller.GetClinicApptLimit(clinic_ID).ToString();
        }
    }
}
