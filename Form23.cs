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
    public partial class Form23 : Form
    {
        public string Pin 
        { 
            get { return textBox1.Text; } 
        }
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "3842")
            {
                DialogResult = DialogResult.OK;
            } else
            {
                textBox1.Text = "FALSCHE PIN";
            }
        }
    }
}
