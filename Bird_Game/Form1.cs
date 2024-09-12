using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Game
{
    public partial class Form1 : Form
    {
        int boruzhizi = 8;
        int gravity = 15;
        int skor = 0;


        public Form1()
        {
            InitializeComponent();
            Bird_Game.Top += gravity;

            Blokalt.Left -= boruzhizi;
            bloküst.Left -= boruzhizi;
            skor.Text.Text = "Score" + skor;


            if (Blokalt.Left < -150)
            {
                Blokalt.Left = 800;

            }
            if (bloküst.Left < -180)
            {
                bloküst.Left = 950;

            }
            if (Bird_Game.Bounds.IntersectsWith(Blokalt.Bounds) || Bird_Game.Bounds.IntersectsWith(bloküst.Bounds) || Bird_Game.Bounds.IntersectsWith(Zemin.Bounds))
            { 
                EndGame();
            }
        }

    }

        private void GameTimer(object sender, EventArgs e)
        {

        }

        private void gamekeydown(object sender, MouseEventArgs e)
        {


        }

        private void gamekeyup(object sender, MouseEventArgs e)
        {



        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
                skor++;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
                skor++;
            }
        }

        private void EndGame()
        {
            GameTimer.Stop();

            ScoreText.Text = "Game Over";

        }
    }

}
