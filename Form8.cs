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
    public partial class Form8 : Form
    {
        public string fett1 { get { return textBox1.Text; } }
        public string fett2 { get { return textBox2.Text; } }
        public string fett3 { get { return textBox3.Text; } }
        public string fett4 { get { return textBox4.Text; } }
        public string fett5 { get { return textBox5.Text; } }
        public string fett6 { get { return textBox6.Text; } }
        public string fett7 { get { return textBox7.Text; } }
        public string fett8 { get { return textBox8.Text; } }

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
