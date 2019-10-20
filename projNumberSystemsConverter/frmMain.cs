using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projNumberSystemsConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //Populate combo boxes with number systems
            cboConvertFrom.Items.AddRange(new object[] { "Denary/Decimal", "Binary", "Octal", "Hexadecimal" });
            cboConvertTo.Items.AddRange(new object[] { "Denary/Decimal", "Binary", "Octal", "Hexadecimal" });
        }//frmMain()

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }//btnConvert_Click

        private void btnClear_Click(object sender, EventArgs e)
        {
            //When this button is clicked, clear all fields in the form

            //Clear listboxes
            cboConvertFrom.SelectedIndex = -1;
            cboConvertTo.SelectedIndex = -1;

            //Clear textboxes
            txtConvertFrom.Clear();
            txtConvertTo.Clear();

        }//btnClear_Click

        private void btnHelp_Click(object sender, EventArgs e)
        {
            /* When this button is pressed, call a new instance of the help form (frmHelp). This provides the user with instructions 
             * on how to use the application, as well as providing some pointers on what sort of input is acceptable.
            */

            DialogResult dialogResult = MessageBox.Show("Go to the help screen?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //Open a new instance of the help form
                Form help = new frmHelp();
                help.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //otherwise do nothing
                txtConvertFrom.Focus();
            }
        }//btnHelp_Click

        private void btnExplanation_Click(object sender, EventArgs e)
        {

        }//btnExplanation_Click

        private void btnExit_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the form will close. First, display a message box to the user asking to confirm their choice

            DialogResult dialogResult = MessageBox.Show("Close the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //close the form
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //otherwise continue
                txtConvertFrom.Focus();
            }
        }//btnExit_Click
    }//class
}//namespace
