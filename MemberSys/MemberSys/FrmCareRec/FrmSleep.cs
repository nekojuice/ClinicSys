using System;
using System.Globalization;
using System.Windows.Forms;

namespace MemberSys.FrmCareRec
{
    public partial class FrmSleep : Form
    {
        private string name;
        private string childname;
        private int NewBorn_ID;
        private DateTime startTime;
        private DateTime endTime;

        public FrmSleep()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm"; // 顯示日期和時間

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd HH:mm"; // 顯示日期和時間
        }

        public FrmSleep(string name, string childname, int newBorn_ID)
        {
            InitializeComponent();
            this.name = name;
            this.childname = childname;
            this.NewBorn_ID = newBorn_ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 開始時間
            startTime = dateTimePicker1.Value;

            // 結束時間
            endTime = dateTimePicker2.Value;

            if (endTime < startTime)
            {
                MessageBox.Show("結束時間不能早於開始時間！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan sleepDuration = endTime - startTime;

            // 將計算結果顯示在 label4 上
            lblSleep.Text = $"寶寶總共睡了 {sleepDuration.Hours} 小時 {sleepDuration.Minutes} 分鐘";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Member_Care _care;
        public Member_Care care
        {
            get
            {
                if (_care == null)
                    _care = new Member_Care();

                _care.Care_Date = startTime; // 使用開始時間
                _care.Record_Type = "睡眠";

                _care.Record_dcp = $"{(endTime - startTime).Hours} 小時"; // 使用計算結果
                _care.NewBorn_ID = NewBorn_ID;
                return _care;
            }
        }

        private void FrmSleep_Load(object sender, EventArgs e)
        {
            label1.Text = $"母親姓名：{name}，小孩姓名：{childname}";
        }
    }
}
