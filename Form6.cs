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
    public partial class Form6 : Form
    {
        public string euro1
        {
            get { return textBox1.Text; }
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string euro = textBox1.Text;
            double res1 = Convert.ToDouble(euro) * Convert.ToDouble(0.93);
            string ausgabe1 = res1.ToString();
            textBox2.Text = ausgabe1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dollar = textBox2.Text;
            double res2 = Convert.ToDouble(dollar) * Convert.ToDouble(0.93);
            string ausgabe2 = res2.ToString();
            textBox1.Text = ausgabe2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
