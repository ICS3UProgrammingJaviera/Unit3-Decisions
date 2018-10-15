/*
     * Created by: Javiera Diaz
     * Created on: 10/10/18
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Name of Program
     * This program is a number guessing game that displays 'correct' or 'incorrct' labels.
    */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameJavieraD
{
    public partial class frmGuessGame : Form
    {
        public frmGuessGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare constants and variables
            const int CORRECT_GUESS = 3;
            int numGuess;

            //get guess number from textbox
            numGuess = int.Parse(txtGuess.Text);
                
            if (numGuess == CORRECT_GUESS)
            {
                lblAnswer.Text = "Correct!";
            }

            if (numGuess > CORRECT_GUESS)
            {
                lblAnswer.Text = "Incorrect guess!";
            }

            if (numGuess < CORRECT_GUESS)
            {
                lblAnswer.Text = "Incorrect guess!";
            }

            lblAnswer.Show();
        }

        private void frmGuessGame_Load(object sender, EventArgs e)
        {
            //hide this label
            lblAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblAnswer.Hide();
        }
    }
}
