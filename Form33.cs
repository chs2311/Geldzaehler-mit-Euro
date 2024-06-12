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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wA = a.Text;
            string wechselkurs = kurs.Text;

            double res = Convert.ToDouble(wA) * Convert.ToDouble(wechselkurs);
            b.Text = res + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string wB = a.Text;
            string wechselkurs = kurs.Text;

            double res = Convert.ToDouble(wB) / Convert.ToDouble(wechselkurs);
            a.Text = res + "";
        }
    }
}
