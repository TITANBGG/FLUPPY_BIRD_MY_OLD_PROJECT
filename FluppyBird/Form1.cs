using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluppyBird
{
    public partial class Form1 : Form
    {
        int boruHizi = 80;
        int gravity = 5;
        int skor = 0;

        public Form1()
        {
            InitializeComponent();
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            FlyBird.Top += gravity;

            BlokAsagi.Left -= boruHizi;

            BlokYukari.Left -= boruHizi;

            if (BlokAsagi.Left < -150)
            {
                BlokAsagi.Left = 800;
                skor++;
            }

            if (BlokYukari.Left < -180)
            {
                BlokYukari.Left = 950;
                skor++;
            }

            CheckCollisions();
            UpdateScore();
        }

        private void CheckCollisions()
        {
            if (FlyBird.Bounds.IntersectsWith(BlokAsagi.Bounds) ||
                FlyBird.Bounds.IntersectsWith(BlokYukari.Bounds) ||
                FlyBird.Bounds.IntersectsWith(Zemin.Bounds) ||
                FlyBird.Top < -25)
            {
                EndGame();
            }
        }

        private void UpdateScore()
        {
            ScoreText.Text = "Score : " + skor;
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5; // Klavye tuşuna basıldığında yerçekimini tersine çevir (yukarı yönlü)
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5; // Klavye tuşu bırakıldığında yerçekimi tekrar aşağı yönlü yap
            }
        }

        private void EndGame()
        {
            GameTimer.Stop();
            ScoreText.Text = "Game Over";
        }
    }
}
