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
    public partial class DialogCallingUnit_PatientInfo : Form
    {
        private EntityCallingUnitDataType _data;
        public int docID { get; set; }
        public string timeshift { get; set; }
        public string today { get; set; }
        private int _originalState = 0;
        public bool isChanged { get; set; }

        public FrmNumberScreen screen { get; set; }
        public DialogCallingUnit_PatientInfo(EntityCallingUnitDataType data, int docID, string timeshift, string today, FrmNumberScreen screen)
        {
            InitializeComponent();
            this.docID = docID;
            this._data = data;
            this.timeshift = timeshift;
            this.today = today;
            txtName.Text = _data.patientName;
            txtGender.Text = _data.patientGender;
            txtNationalID.Text = _data.patientNationalID;
            txtBirth.Text = _data.patientBirth.ToString("yyyy/MM/dd");
            txtClinicNumber.Text = _data.patientClinicNumber.ToString();
            btnColorChange();
            this._originalState = data.patientStateId;
            this.screen = screen;
        }

        private void btnColorChange()
        {
            paintClearBtn(btnState1);
            paintClearBtn(btnState2);
            paintClearBtn(btnState3);
            paintClearBtn(btnState4);
            paintClearBtn(btnState5);
            paintClearBtn(btnState6);
            paintClearBtn(btnState7);
            switch (_data.patientStateId)
            {
                case 1: paintBtn(btnState1); break;
                case 2: paintBtn(btnState2); break;
                case 3: paintBtn(btnState3); break;
                case 4: paintBtn(btnState4); break;
                case 5: paintBtn(btnState5); break;
                case 6: paintBtn(btnState6); break;
                case 7: paintBtn(btnState7); break;
                case 0:
                case 8:
                    btnState1.Enabled = false;
                    btnState2.Enabled = false;
                    btnState3.Enabled = false;
                    btnState4.Enabled = false;
                    btnState5.Enabled = false;
                    btnState6.Enabled = false;
                    btnState7.Enabled = false;
                    return;
                default:
                    break;
            }
        }
        private void paintBtn(Button btn)
        { btn.BackColor = Color.LimeGreen; }
        private void paintClearBtn(Button btn)
        { btn.BackColor = Color.Gray; }

        private void btnState1_Click(object sender, EventArgs e)
        { btnClickEvent(1); }
        private void btnState2_Click(object sender, EventArgs e)
        { btnClickEvent(2); }
        private void btnState3_Click(object sender, EventArgs e)
        { btnClickEvent(3); }
        private void btnState4_Click(object sender, EventArgs e)
        { btnClickEvent(4); }
        private void btnState5_Click(object sender, EventArgs e)
        { btnClickEvent(5); }
        private void btnState6_Click(object sender, EventArgs e)
        { btnClickEvent(6); }
        private void btnState7_Click(object sender, EventArgs e)
        { btnClickEvent(7); }

        private void btnClickEvent(int state)
        {
            _data.patientStateId = state;
            btnColorChange();
            CApptCallingUnit_Model c = new CApptCallingUnit_Model();
            c.UpdatePatientState(docID, today, timeshift, _data.patientNationalID, state);

            btnClose_Click(new object(), new EventArgs());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_originalState != _data.patientStateId)
            { isChanged = true; }
            this.Close();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            if (screen is null || screen.IsDisposed)
            { return; }
            screen.calledID = Convert.ToInt32(txtClinicNumber.Text);
            screen.calledFlashing();
        }
    }
}
