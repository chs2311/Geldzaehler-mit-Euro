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
    public partial class Form3 : Form
    {
        public string doltoeuro
        {
            get { return eu.Text; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string euro = eu.Text;
            string kurs = "1,06";

            double did = Convert.ToDouble(euro) * Convert.ToDouble(kurs);
            string ausgb = did + "";
            dol.Text = ausgb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dl = dol.Text;
            string kurs = "1,06";

            double dida = Convert.ToDouble(dl) / Convert.ToDouble(kurs);
            string ausgba = dida + "";
            eu.Text = ausgba;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
