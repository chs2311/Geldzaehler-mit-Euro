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
    public partial class Form32 : Form
    {
        public string ID { get { return id.Text; } }
        public string USname { get { return username.Text; } }
        public string USpassword { get { return password.Text; } }

        public Form32()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "Anmeldedaten";

            if(id.Text == "8X3648D_Admin" || id.Text == "7X0205B_Admin" || id.Text == "0X7324W_User")
            {
                Login lg = new Login();

                lg.username = username.Text;
                lg.password = password.Text;

                lg.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Login" + id.Text + ".chslogin");

                DialogResult = DialogResult.OK;
            }

            else
            {
                groupBox2.Text += " - ID nicht vorhanden";
            }
        }
    }
}
