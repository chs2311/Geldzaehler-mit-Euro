using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldzähler_mit_Euro_3._0
{
    public partial class Form18 : Form
    {
        public string benutzername
        {
            get { return textBox1.Text; }
        }
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passwort = textbox1
            //benutzername = textbox2
            if (textBox1.Text == "Christian Schlei")
            {
                if (textBox2.Text == "CHS-0203-PC")
                {
                    DialogResult = DialogResult.OK;
                }
                else 
                {
                    textBox1.Text = "FALSCHES PASSWORT!";
                }
            }
            else 
            {
                textBox2.Text = "FALSCHER BENUTZERNAME!";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
