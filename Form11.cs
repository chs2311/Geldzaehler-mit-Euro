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
    public partial class Form11 : Form
    {
        int score = 0;
        int speed = 10;
        int gravity = 15;
        
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Enabled = true;
            button1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void game_Tick(object sender, EventArgs e)
        {
            string sore = score.ToString();
            label1.Text = sore;
            player.Top += gravity;
            pipe1.Left -= speed;
            pipe2.Left -= speed;
            score++;

            if (pipe1.Left < -50)
            {
                pipe1.Left = 500;
            }

            if (pipe2.Left < -25)
            {
                pipe2.Left = 500;
            }

            if (player.Bounds.IntersectsWith(pipe1.Bounds) ||
                player.Bounds.IntersectsWith(pipe2.Bounds) ||
                player.Bounds.IntersectsWith(ground.Bounds) ||
                player.Top < -25)
            {

                game.Stop();
                label2.Visible = true;
            }

           /* if (score == 100)
            {
                game.Stop();
                
            }*/
        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void up(object sender, KeyEventArgs f)
        {
            if (f.KeyCode == Keys.Space)
            {
                gravity = +5;
            }
        }
    }
}
