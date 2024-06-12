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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sie müssen zu jeder Münzen (bzw. Schein) die Anzahl hinzufügen, indem sie auf 'Hinzufügen' klicken und die Anzahl eingeben.             Zum berechnen:                   -> Datei -> Berechnen.";
        }
    }
}
