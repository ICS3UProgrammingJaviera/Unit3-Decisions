/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Name of Program
 * This program...
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

namespace RandomNumberJav
{
    public partial class frmRandomNumber : Form
    {
        public frmRandomNumber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRandomNumber_Load(object sender, EventArgs e)
        {
            lblRandomNumber.Hide();
        }

        private void btnRandomNumber_Click(object sender, EventArgs e)
        {
            //declare local constants and variables
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            Random randomNumberGenerator = new Random();

            //get the randoom number
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //assign random number to label
            lblRandomNumber.Text = Convert.ToString(aRandomNumber);

            //show label
            lblRandomNumber.Show();
        }
    }
}
