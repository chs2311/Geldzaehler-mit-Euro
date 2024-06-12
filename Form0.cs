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
    public partial class Form0 : Form
    {
        int Score = 0;
        int Speed = 1;
        int Gravity = 15;
        public Form0()
        {
            InitializeComponent();
        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -2;
            }
        }

        private void up(object sender, KeyEventArgs f)
        {
            if (f.KeyCode == Keys.Space)
            {
                Gravity = +5;
            }
        }

        private void game_Tick(object sender, EventArgs e)
        {
            string score = Score.ToString();
            label1.Text = " YOUR SCORE: " + score;
            player.Top += Gravity;
            fail1.Left -= Speed;
            fail2.Left -= Speed;
            Score++;

            if (fail1.Left < -50)
            {
                fail1.Left = 600;
            }
            if (fail2.Left < -25)
            {
                fail2.Left = 600;
            }

            if(player.Bounds.IntersectsWith(fail1.Bounds) ||
               player.Bounds.IntersectsWith(fail2.Bounds) ||
               player.Bounds.IntersectsWith(fail3.Bounds) || 
               player.Top < -25)
            {

                game.Stop();
                label2.Visible = true;
            }


        }
    }
    }

