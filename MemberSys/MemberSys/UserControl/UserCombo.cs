using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MemberSys
{
    public partial class UserCombo : UserControl
    {
        public UserCombo()
        {
            InitializeComponent();
        }

        public string fieldName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string fieldValue
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public ObjectCollection Items
        {
            get { return comboBox1.Items; }  
        }
    }
}
