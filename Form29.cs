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
    public partial class Form29 : Form
    {
        public string r { get { return textBox1.Text; } }
        public string g { get { return textBox1.Text; } }
        public string b { get { return textBox1.Text; } }

        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)((byte)Convert.ToByte(textBox1.Text))))), ((int)(((byte)(Convert.ToByte(textBox2.Text))))), ((int)(((byte)(Convert.ToByte(textBox3.Text))))));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
