using MemberSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent
{
    public partial class FrmDrugEditor : Form
    {

        private DialogResult _isOK;

        public DialogResult confirm
        {
            get { return _isOK; }
        }
        private Pharmacy_tMedicinesList _medicinesList;

        public Pharmacy_tMedicinesList medicinesList   //圖片已補已測試
        {
            get
            {
                if (_medicinesList == null)
                    _medicinesList = new Pharmacy_tMedicinesList();
                if (!string.IsNullOrEmpty(fbId_Drug.fieldValue))
                    _medicinesList.fId_Drug = Convert.ToInt32(fbId_Drug.fieldValue);
                _medicinesList.fDrugCode = fbDrugCode.fieldValue;
                _medicinesList.fGenericName = fbGenericName.fieldValue;
                _medicinesList.fTradeName = fbTradeName.fieldValue;
                _medicinesList.fDrugName = fbDrugName.fieldValue;
                _medicinesList.fDrugDose = fbDrugDose.fieldValue;
                _medicinesList.fMaxDose = fbMaxDose.fieldValue;
                if (comboBoxPC.SelectedItem != null && !string.IsNullOrEmpty(comboBoxPC.SelectedItem.ToString()))
                    _medicinesList.fPregnancyCategory = comboBoxPC.SelectedItem.ToString();

                _medicinesList.fPrecautions = fbPrecautions.fieldValue;
                _medicinesList.fWarnings = fbWarnings.fieldValue;
                _medicinesList.fStorage = fbStorage.fieldValue;
                _medicinesList.fSupplier = fbSupplier.fieldValue;
                _medicinesList.fBrand = fbBrand.fieldValue;
                return _medicinesList;
            }
            set
            {
                _medicinesList = value;
                fbId_Drug.fieldValue = _medicinesList.fId_Drug.ToString();
                fbDrugCode.fieldValue = _medicinesList.fDrugCode;
                fbGenericName.fieldValue = _medicinesList.fGenericName;
                fbTradeName.fieldValue = _medicinesList.fTradeName;
                fbDrugName.fieldValue = _medicinesList.fDrugName;
                fbDrugDose.fieldValue = _medicinesList.fDrugDose;
                fbMaxDose.fieldValue = _medicinesList.fMaxDose;
                comboBoxPC.SelectedText = _medicinesList.fPregnancyCategory;
                fbPrecautions.fieldValue = _medicinesList.fPrecautions;
                fbWarnings.fieldValue = _medicinesList.fWarnings;
                fbStorage.fieldValue = _medicinesList.fStorage;
                fbSupplier.fieldValue = _medicinesList.fSupplier;
                fbBrand.fieldValue = _medicinesList.fBrand;
                if (!string.IsNullOrEmpty(_medicinesList.fApperance))
                    picfApperance.Image = new Bitmap(Application.StartupPath + @"\image\" + _medicinesList.fApperance);
                if (!string.IsNullOrEmpty(_medicinesList.fImages))
                    picfImages.Image = new Bitmap(Application.StartupPath + @"\image\" + _medicinesList.fImages);
            }
        }

        private Pharmacy_tTypeDetails _Tdatails;
        public Pharmacy_tTypeDetails Tdatails
        {
            get //var & join
            {
                _Tdatails.fId_Tpye = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                return _Tdatails;
            }
            set
            {
                _Tdatails = value;
                comboBoxType.Text = _Tdatails.fId_Tpye.ToString();
            }
        }
        private List<Pharmacy_tClinicalUseDetails> _CUdetails;
        public List<Pharmacy_tClinicalUseDetails> CUdetails
        {
            get
            {
                //_CUdetails.fId_ClicicalUse=Convert.ToInt32(lbCUdetails.Items);
                return _CUdetails;
            }
            set
            {
                _CUdetails = value;
                //lbCUdetails.Items.Add( _CUdetails.fId_ClicicalUse.ToString());
                lbCUdetails.DataSource = _CUdetails;
                lbCUdetails.ValueMember = "fId_ClicicalUse";
            }
        }
        private List<Pharmacy_tSideEffectDetails> _SEdetails;

        public List<Pharmacy_tSideEffectDetails> SEdetails
        {
            get
            {
                //_SEdetails.fId_SideEffect=Convert.ToInt32(lbSEdetails.Items);
                return _SEdetails;
            }
            set
            {
                _SEdetails = value;


                //    lbSEdetails.Items.AddRange(_SEdetails);

                lbSEdetails.DataSource = _SEdetails.ToList(); //整個物件
                lbSEdetails.ValueMember = "fId_SideEffect"; //要表達物件的內容(欄位)

                // foreach(var s in _SEdetails) { lbSEdetails.Items.Add(_SEdetails.fId_SideEffect.ToString()); }
                //lbSEdetails.Items.Add(_SEdetails.fId_SideEffect.ToString());
            }
        }

        public FrmDrugEditor()
        {
            InitializeComponent();
        }



        private bool isUivalidated()  //不允許null：副作用、適應症寫在FrmSEList & FrmCUList的確認Btn中
        {
            string msg = "";
            if (string.IsNullOrEmpty(fbDrugCode.fieldValue))
                msg += "\r\n代碼是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbGenericName.fieldValue))
                msg += "\r\n學名是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbTradeName.fieldValue))
                msg += "\r\n商品名是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbDrugName.fieldValue))
                msg += "\r\n中文名是必填欄位，不可空白";
            if (comboBoxType.SelectedItem == null)
                msg += "\r\n劑型是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbStorage.fieldValue))
                msg += "\r\n儲存方法是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbSupplier.fieldValue))
                msg += "\r\n藥商是必填欄位，不可空白";
            if (string.IsNullOrEmpty(fbBrand.fieldValue))
                msg += "\r\n廠牌是必填欄位，不可空白";
            if(lbCUdetails.Items.Count<=0)
                msg+= "\r\n適應症是必填欄位，不可空白";
            if (lbSEdetails.Items.Count <= 0)
                msg += "\r\n副作用是必填欄位，不可空白";
            if (picfApperance.Image == null)
                msg += "\r\n藥品外觀是必填欄位，不可空白";
            //if (string.IsNullOrEmpty())
            //    msg += "\r\n藥品外觀是必填欄位，不可空白";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        string TypeClick = null;
        public string 劑型 { get { return TypeClick; } }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isUivalidated())
                return;
            //_isOK = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            TypeClick = comboBoxType.SelectedItem.ToString().Split('.')[0];
            this.Close();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();
        }

        List<string> fId_CU = new List<string>();
        public List<string> 適應症 { get { return fId_CU; } }
        private void button3_Click(object sender, EventArgs e) //跳進適應症選取表，確認後可回傳適應症
        {

            FrmCUList f = new FrmCUList();
            f.Id = fbId_Drug.fieldValue;
            f.學名 = fbGenericName.fieldValue;
            f.CUdetailsSelected = _CUdetails;
            f.ShowDialog();
            lbCUdetails.DataSource = null;   //update 都不選按取消不會跳例外
            lbCUdetails.Items.Clear();       //create 都不選按取消不會跳例外
            if (f._culist != null && f._culist.Count >= 1)
            {
                for (int i = 0; i < f._culist.Count; i++)
                {
                    lbCUdetails.Items.Add(f._culist[i]);
                }
                fId_CU.Clear();
                for (int i = 0; i < f._culist.Count; i++)
                {
                    fId_CU.Add(f._culist[i].Split('.')[0]);
                }
            }
        }


        List<string> fId_SE = new List<string>();  //創建一個存fId_SE使主表新增時一次寫入明細表
        public List<string> 副作用 { get { return fId_SE; } }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmSEList f = new FrmSEList();
            f.Id = fbId_Drug.fieldValue;
            f.學名 = fbGenericName.fieldValue;
            f.SEdetailsSelected = _SEdetails;
            f.ShowDialog();
            lbSEdetails.DataSource = null;
            lbSEdetails.Items.Clear();

            if (f._selist != null && f._selist.Count >= 1)   //不選取任何副作用直接關閉會出問題，前面先判斷非null
            {
                lbSEdetails.DataSource = null;
                for (int i = 0; i < f._selist.Count; i++)
                {
                    lbSEdetails.Items.Add(f._selist[i]);
                }

                fId_SE.Clear();
                for (int i = 0; i < f._selist.Count; i++)
                {
                    fId_SE.Add(f._selist[i].Split('.')[0]);
                }
            }
        }

        private void FrmDrugEditor_Load(object sender, EventArgs e)
        {
            ClinicSysEntities db = new ClinicSysEntities();
            var type = from t in db.Pharmacy_tTypeList
                       select t.fId_Type + "  .  " + t.fType;
            foreach (var i in type)
            {
                comboBoxType.Items.Add(i);
            }
            comboBoxPC.Items.Add("A");
            comboBoxPC.Items.Add("B");
            comboBoxPC.Items.Add("C");
            comboBoxPC.Items.Add("D");
            comboBoxPC.Items.Add("X");
        }

        private void picfApperance_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "藥品照片|*.jpg|藥品照片|*.png|藥品照片|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string photo = Guid.NewGuid().ToString() + ".jpg";
                this.medicinesList.fApperance = photo;
                File.Copy(openFileDialog1.FileName, Application.StartupPath + @"\image\" + photo);
                picfApperance.Image = new Bitmap(Application.StartupPath + @"\image\" + photo);
            }
        }

        private void picfImages_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "藥品照片|*.jpg|藥品照片|*.png|藥品照片|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string photo = Guid.NewGuid().ToString() + ".jpg";
                this.medicinesList.fImages = photo;
                File.Copy(openFileDialog1.FileName, Application.StartupPath + @"\image\" + photo);
                picfImages.Image = new Bitmap(Application.StartupPath + @"\image\" + photo);
            }

        }
    }
}
