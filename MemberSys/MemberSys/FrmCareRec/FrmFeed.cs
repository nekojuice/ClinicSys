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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MemberSys
{
    public partial class FrmFeed : Form
    {
        public FrmFeed()
        {
            InitializeComponent();
        }

        private string name;
        private string childname;
        private int NewBorn_ID;

        public FrmFeed(string name, string childname, int newBorn_ID)
        {
            InitializeComponent();
            this.name = name;
            this.childname = childname;
            this.NewBorn_ID = newBorn_ID;
        }
        private void FrmFeed_Load(object sender, EventArgs e)
        {
            cboBoMilk.Items.Add("配方奶");
            cboBoMilk.Items.Add("母乳");
            cboBoml.Items.Add("10ml");
            cboBoml.Items.Add("50ml");
            cboBoml.Items.Add("100ml");
            lblFeed.Text = $"母親姓名：{name}，小孩姓名：{childname}";
        }

        private Member_Care _care;
        public Member_Care care
        {
            get
            {
                if (_care == null)
                    _care = new Member_Care();
                _care.Care_Date = Convert.ToDateTime(dateTimePicker1.Text);
                _care.Record_Type = cboBoMilk.Text;
                _care.Record_dcp = cboBoml.Text;
                _care.NewBorn_ID = NewBorn_ID;
                return _care;
            }
            set
            {
                _care = value;
                dateTimePicker1.Value = care.Care_Date;
                cboBoMilk.Text = care.Record_Type.ToString();
                cboBoml.Text = care.Record_dcp.ToString();
            }
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

        private void UpdateLabel()
        {
            string milk = cboBoMilk.SelectedItem?.ToString() ?? "";
            string milkML = cboBoml.SelectedItem?.ToString() ?? "";

            // 組合兩個選擇項目的字符串
            string combinedText = $"{milk} - {milkML}";

            // 將組合後的字符串顯示在 Label 上
            label4.Text = combinedText;
        }

    }
}
