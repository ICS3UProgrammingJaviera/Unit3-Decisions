/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Name of Program
 * This program calculates and displays all perfect sqaures from a number that the user enters into the up-down box
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

namespace PerfectSquareJav
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInterger;

            //set initial values
            value = 1;
            endingValue = 1;

            //clear all items from listbox
            this.lstPefSqr.Items.Clear();

            //get uder's end value from numeric up-down
            endingValue = Convert.ToInt32(this.numValue.Value);

            //continue stating perfect squares between min value and user's selection of value
            while (value <= endingValue)
            {
                //take square root of value as double
                squareRootAsDouble = Math.Sqrt(value);

                //convert double to int
                squareRootAsInterger = Convert.ToInt32(squareRootAsDouble);

                //compare values to see if they are perfect squares
                if (squareRootAsInterger == squareRootAsDouble)
                {
                    this.lstPefSqr.Items.Add(value + "is a perfect square");
                   
                    //refresh form
                    this.Refresh();
                }

                //increment this value
                value = value + 1;
            }

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
