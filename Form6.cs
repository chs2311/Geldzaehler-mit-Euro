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
    public partial class Form6 : Form
    {
        public string kunetoeuro
        {
            get { return eu.Text; }
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aeuro = eu.Text;
            string akurs = "7,53";

            double adid = Convert.ToDouble(aeuro) * Convert.ToDouble(akurs);
            string aausgb = adid + "";
            rub.Text = aausgb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aeuro = rub.Text;
            string akurs = "7,53";

            double adid = Convert.ToDouble(aeuro) / Convert.ToDouble(akurs);
            string aausgb = adid + "";
            eu.Text = aausgb;
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
