using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialForJav
{
    public partial class frmFactorialForJav : Form
    {
        public frmFactorialForJav()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //delcare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            //clear items from listbox
            this.lstFactorialNumbers.Items.Clear();

            //initilize final answer to 1
            factorialAnswer = 1;

            //get number from the user
            factorialNumber = Convert.ToDouble(this.txtFactorial.Text);
        }
    }
}
