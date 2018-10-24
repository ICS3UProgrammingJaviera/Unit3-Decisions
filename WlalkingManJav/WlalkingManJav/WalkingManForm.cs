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
    public partial class WalkingManForm : Form
    {
        public WalkingManForm()
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
        }
    }
}
