using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesJav
{
    public partial class frmChocolBoxes : Form
    {
        public frmChocolBoxes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            //declare local vairables
            const int MIN_VALUE = 0;
            const int MAX_VALUE = 100;
            int numBoxes;

            this.txtNumBoxes.Text = numBoxes();
            
            //
            if (numBoxes > 20)
            {
                lblReward.Text = "You get a prize.";
            }
            else if (numBoxes < 10)
            {
                lblReward.Text = "You get an honorable mention";
            }
            else if (numBoxes > 50)
            {
                lblReward.Text = "You get a big prize";
            }

            lblReward.Show();
        }

        private void frmChocolBoxes_Load(object sender, EventArgs e)
        {
            lblReward.Hide();
        }
    }
}
