using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinicsys
{
    public partial class userControlDateTimePicker : UserControl
    {
        public userControlDateTimePicker()
        {
            InitializeComponent();
        }

        public string title
        {
            get { return lalTitle.Text; }
            set { lalTitle.Text = value; }
        }

        public DateTime value
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public bool showStar
        {
            get { return lblStar.Visible; }
            set { lblStar.Visible = value; }
        }
    }
}
