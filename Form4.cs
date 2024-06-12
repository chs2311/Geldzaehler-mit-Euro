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
    public partial class Form4 : Form
    {
        public string dicke1 { get { return box1.Text; } }
        public string dicke2 { get { return box2.Text; } }
        public string dicke3 { get { return box3.Text; } }
        public string dicke4 { get { return box4.Text; } }
        public string dicke5 { get { return box5.Text; } }
        public string dicke6 { get { return box6.Text; } }
        public string dicke7 { get { return box7.Text; } }
        public string dicke8 { get { return box8.Text; } }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            box1.Text = "0";
            box2.Text = "0";
            box3.Text = "0";
            box4.Text = "0";
            box5.Text = "0";
            box6.Text = "0";
            box7.Text = "0";
            box8.Text = "0";
        }
    }
}
