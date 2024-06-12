using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldzähler_mit_Euro_4._0
{
    public partial class Form5 : Form
    {
        public string gewicht1 { get { return box1.Text; } }
        public string gewicht2 { get { return box2.Text; } }
        public string gewicht3 { get { return box3.Text; } }
        public string gewicht4 { get { return box4.Text; } }
        public string gewicht5 { get { return box5.Text; } }
        public string gewicht6 { get { return box6.Text; } }
        public string gewicht7 { get { return box7.Text; } }
        public string gewicht8 { get { return box8.Text; } }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            box1.Text = "0";
            box2.Text = "0";
            box3.Text = "0";
            box4.Text = "0";
            box5.Text = "0";
            box6.Text = "0";
            box7.Text = "0";
            box8.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
