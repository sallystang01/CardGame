﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Startup frmStart = new Startup();
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            frmStart.Show();
        }

        private void Game_Load(object sender, EventArgs e)
        {


            List<Image> cards = new List<Image>();

            int index;
            index = 0;

            for (index = 0; index < ilCards.Images.Count; index++)
            {

                cards.Add(ilCards.Images[index]);
                pictureBox1.Image = cards[index];
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblGamePlayerTwo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblGame_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
