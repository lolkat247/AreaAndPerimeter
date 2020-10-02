using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // get numeric value of inputs
            double length = 0.0;
            double width = 0.0;
            try
            {
                length = Convert.ToDouble(tbLength.Text);
                width = Convert.ToDouble(tbWidth.Text);
            }
            catch (System.FormatException)
            {
                var mb = MessageBox.Show("Invalid Entry");
                tbArea.Text = "";
                tbPerim.Text = "";
                return;
            }

            // calculate and display results
            tbArea.Text = Convert.ToString(length * width);
            tbPerim.Text = Convert.ToString(2.0 * length + (2.0 * width));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
