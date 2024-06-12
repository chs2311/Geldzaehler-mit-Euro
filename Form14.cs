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
  
    public partial class Form14 : Form
    {
        public string name
        {
            get { return username.Text; }
        }
        public Form14()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg = lg.Load(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Login" + id.Text + ".chslogin");

            if (username.Text == lg.username && password.Text == lg.password)
            {
                DialogResult = DialogResult.OK;
            }
            else 
            {

                groupBox2.Text = "Anmeldedaten (erneut)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form32 neu = new Form32();
            if(neu.ShowDialog() == DialogResult.OK)
            {
                id.Text = neu.ID;
                username.Text = neu.USname;
                password.Text = neu.USpassword;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar = true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Text = "Anmeldedaten";
            groupBox2.Text += " - Dann bist du eben lost. \" HAHA! \" ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            id.Text = "8X3648D_Admin";
            username.Text = "Christian Schlei";
            password.Text = "Chris!020311";

            button1_Click(sender, e);
        }
    }
}
