/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program is a rock, paper, scissors game where the user can choose between rock, paper, and schissors and the comuter will generate a random choice upon clicking the play button.
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

namespace RockPaperScissorsJaviera
{
    public partial class frmRockPaperScissors : Form
    {
        //declare global variables and contants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomeNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            //create random number generator onject
            randomeNumberGenerator = new Random();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            //hide label
            lblDeclareOutcome.Hide();

            grbCompChoice.Enabled = false;
        }

        private void mnuFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare local variable and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //get user's choice, if there is no selection set 0
            if (radUserRoxk.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radUserPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radUserScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            //assign computer's choice to randomly generated number between 1 and 3
            computerChoice = randomeNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set radio buttons for computer's choice
            if (computerChoice == ROCK)
            {
                this.radCompRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                radCompPaper.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                radCompScissors.Checked = true;
            }

            //display outcome through label
            this.lblDeclareOutcome.Show();

            if (playerChoice == ROCK)
            {
                if (computerChoice == ROCK)
                    lblDeclareOutcome.Text = "Draw";
                else if (computerChoice == PAPER)
                    lblDeclareOutcome.Text = "Computer wins!";
                else if (computerChoice == SCISSORS)
                    lblDeclareOutcome.Text = "You win!";
            }
           else if (playerChoice == PAPER)
            {
                if (computerChoice == ROCK)
                    lblDeclareOutcome.Text = "You win!";
                else if (computerChoice == PAPER)
                    lblDeclareOutcome.Text = "Draw";
                else if (computerChoice == SCISSORS)
                    lblDeclareOutcome.Text = "Computer wins!";
                       
            }
            else if (playerChoice == SCISSORS)
            {
                if (computerChoice == ROCK)
                    lblDeclareOutcome.Text = "Computer wins!";
                else if (computerChoice == PAPER)
                    lblDeclareOutcome.Text = "You win!";
                else if (computerChoice == SCISSORS)
                    lblDeclareOutcome.Text = "Draw";
            }

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
