using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSys
{
    public partial class FieldBox : UserControl
    {
        public FieldBox()
        {
            InitializeComponent();
        }
        public char passwordMask
        {
            get { return textBox1.PasswordChar; }
            set { textBox1.PasswordChar = value; }
        }
        public bool fieldRequired
        {
            get { return label2.Visible; }
            set { label2.Visible = value; }
        }
        public string fieldName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string fieldValue { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }


    }
}
