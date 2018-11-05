/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program displays factorial numbers and answer in a listbox and label.
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

namespace FactorialAnswerJav
{
    public partial class frmFactorialAnswerJav : Form
    {
        public frmFactorialAnswerJav()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            //clear listbox
            this.lstFactorialNumbers.Items.Clear();

            //initialize final answer to 1
            factorialAnswer = 1;

            //get number from user
            factorialNumber = Convert.ToDouble(this.txtUsersNumber.Text);

            //set counter to 0
            factorialCounter = 0;

            //multiply counter by next incremented number until it reaches the user's number
            do
            {
                //increment counter by 1
                factorialCounter = factorialCounter + 1;

                //list counter number in the listbox to display to the user
                lstFactorialNumbers.Items.Add(factorialCounter);

                //multiply the counter by the answer
                factorialAnswer = factorialCounter * factorialAnswer;

            } while (factorialCounter < factorialNumber);

            //convert fcatorialAnswer to string and insert into the label
            this.lblFactorialAnswer.Text = this.txtUsersNumber.Text + "1 = " + Convert.ToString(factorialAnswer);
        }
    }
}
