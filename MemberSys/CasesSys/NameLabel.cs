using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSysMdiParent
{
    public partial class TLBox : UserControl
    {
        public TLBox()
        {
            InitializeComponent();
        }
        public string Ttext
        {
            get { return TitleText.Text; }
            set { TitleText.Text = value; }
        }
        public string Ntext
        {
            get { return NameText.Text; }
            set { NameText.Text = value; }
        }

    }
}
