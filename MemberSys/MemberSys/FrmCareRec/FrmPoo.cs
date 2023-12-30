using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys
{
    public partial class FrmPoo : Form
    {
        public FrmPoo()
        {
            InitializeComponent();
        }

        private string name;
        private string childname;
        private int NewBorn_ID;

        public FrmPoo(string name, string childname, int newBorn_ID)
        {
            InitializeComponent();
            this.name = name;
            this.childname = childname;
            this.NewBorn_ID = newBorn_ID;
        }

        private Member_Care _care;
        public Member_Care care
        {
            get
            {
                if (_care == null)
                    _care = new Member_Care();
                _care.Care_Date = Convert.ToDateTime(dateTimePicker1.Text);
                _care.Record_Type = "排便";
                _care.Record_dcp = ("狀態" + cboPooType.Text) + ("顏色" + cboPooColor.Text) + ("份量" + cboPooAmount.Text);
                _care.NewBorn_ID = NewBorn_ID;
                return _care;
            }
    
        }

        private void FrmPoo_Load(object sender, EventArgs e)
        {
            cboPooType.Items.Add("正常");
            cboPooType.Items.Add("偏軟");
            cboPooType.Items.Add("偏硬");
            cboPooType.Items.Add("糊狀");
            cboPooType.Items.Add("稀狀");
            cboPooColor.Items.Add("正常");
            cboPooColor.Items.Add("偏綠");
            cboPooColor.Items.Add("偏黑");
            cboPooColor.Items.Add("偏黃");
            cboPooAmount.Items.Add("正常");
            cboPooAmount.Items.Add("量少");
            cboPooAmount.Items.Add("量多");
            lblPoo.Text = $"母親姓名：{name}，小孩姓名：{childname}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            string PooType = cboPooType.SelectedItem?.ToString() ?? "";
            string Color = cboPooColor.SelectedItem?.ToString() ?? "";
            string Amount = cboPooAmount.SelectedItem?.ToString() ?? "";

            // 組合兩個選擇項目的字符串
            string combinedText =
                $"狀態 {PooType}\n" +
                $"顏色 {Color}\n" +
                $"份量 {Amount}";

            // 將組合後的字符串顯示在 Label 上
            labelPoo.Text = combinedText;
        }
    }
}
