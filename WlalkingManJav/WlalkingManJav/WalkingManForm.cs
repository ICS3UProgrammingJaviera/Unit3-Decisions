/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Name of Program
 * This program displays a walking man when you click the 'walk' button.
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
//add librabry to use sleep timer
using System.Threading;

namespace WlalkingManJav
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            //declare local variables and consants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //continue loop while frame
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picWalkMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picWalkMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picWalkMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picWalkMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picWalkMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picWalkMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picWalkMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picWalkMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picWalkMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    this.picWalkMan.Image = Properties.Resources.walk10;
                }

                //increment counter by 1
                pictureFrameCounter = pictureFrameCounter + 1;

                //refresh form to display images in an animation
                this.Refresh();

                //pause loop for 100 miliseconds
                Thread.Sleep(100);
            }
        }
    }
}
