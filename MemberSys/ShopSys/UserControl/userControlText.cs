using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public partial class userControlText : UserControl
    {
        public userControlText()
        {
            InitializeComponent();
        }

        public string title
        {
            get { return lalTitle.Text; }
            set { lalTitle.Text = value; }
        }

        public string value
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        public bool showStar
        {
            get { return lblStar.Visible; }
            set { lblStar.Visible = value; }
        }

        public bool valueReadOnly
        {
            get { return txtValue.ReadOnly; }
            set { txtValue.ReadOnly = value; }
        }

        public bool mutiline
        {
            get { return txtValue.Multiline; }
            set { txtValue.Multiline = value; }
        }

    }
}
