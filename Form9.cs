using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldzähler_mit_Euro
{
    public partial class Form9 : Form
    {
        public string gewicht1 { get { return textBox1.Text; } }
        public string gewicht2 { get { return textBox2.Text; } }
        public string gewicht3 { get { return textBox3.Text; } }
        public string gewicht4 { get { return textBox4.Text; } }
        public string gewicht5 { get { return textBox5.Text; } }
        public string gewicht6 { get { return textBox6.Text; } }
        public string gewicht7 { get { return textBox7.Text; } }
        public string gewicht8 { get { return textBox8.Text; } }

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
