using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public delegate void selectedChangeEvent();

    public partial class userControlComboBox : UserControl
    {
        public event selectedChangeEvent onSelectedChange;
        public userControlComboBox()
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
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public bool showStar
        {
            get { return lblStar.Visible; }
            set { lblStar.Visible = value; }
        }

        private List<string> _items;
        public List<string> items
        {
            get { return _items; }
            set
            {
                _items = value;
                comboBox1.Items.AddRange(_items.ToArray());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (onSelectedChange != null)
            onSelectedChange();
        }
    }
}
