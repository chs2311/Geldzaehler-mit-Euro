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

    public partial class Form7 : Form
    {
        public string euro2
        {
            get { return textBox1.Text; }
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string euro = textBox1.Text;
            double res3 = Convert.ToDouble(euro) * Convert.ToDouble(1.21);
            string ausgabe2 = res3.ToString();
            textBox2.Text = ausgabe2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string pfund = textBox2.Text;
            double pount = Convert.ToDouble(pfund);
            double res4 = Convert.ToDouble(pfund) / Convert.ToDouble(1.21);
            string ausgabe3 = res4.ToString();
            textBox1.Text = ausgabe3;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
