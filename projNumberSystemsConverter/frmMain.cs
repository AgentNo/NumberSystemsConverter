using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projNumberSystemsConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //Populate combo boxes with number systems
            cboConvertFrom.Items.AddRange(new object[] { "Decimal", "Binary", "Octal", "Hexadecimal" });
            cboConvertTo.Items.AddRange(new object[] { "Decimal", "Binary", "Octal", "Hexadecimal" });
        }//frmMain()

        //************************
        //   BUTTON EVENTS
        //************************

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input;

            /* This button will connect together all the methods in this class.
             * First, validation must take place to ensure that the user has correctly filled out the form and entered valid input
             * Next, the input itself must be checked to ensure that it is valid within the number system that the user has selected
             * Finally, if the input is valid, the appropriate conversion method is called.
            */

            // First clear the tooltips if they triggered in a previous attempt
            lblConvertFromCbo.Text = "";
            lblConvertFromTxt.Text = "";
            lblConvertToCbo.Text = "";

            // Presence checks on combo boxes - ensure that there is something there. Error messages are handled by the validateComboBoxes method
            if (validateComboBoxes())
            {
                // If true, return
                return;
            }//if

            // Check for whitespace, then OverflowExceptions. If none, assign text to input
            if (String.IsNullOrWhiteSpace(txtConvertFrom.Text))
            {
                MessageBox.Show("Please enter a number to convert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertFromTxt.Text = ("*");
                return;
            }
            else if (catchOverflowException())
            {
                MessageBox.Show("Input number is too big! Enter a smaller number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConvertFrom.Clear();
                lblConvertFromTxt.Text = ("*");
                return;
            }
            else
            {
                // ToLower() is used to sanitise Hex stirngs for validation
                input = Convert.ToString(txtConvertFrom.Text).ToLower();
            }//if

            // Now validate the content of the string against the number system that the user has selected. If this passes, then call the appropriate conversion method.
            if (validateStringContent(input))
            {
                if (cboConvertFrom.SelectedIndex == 0 && cboConvertTo.SelectedIndex == 1)
                {
                    decimalToBinary(input);
                }
                else if (cboConvertFrom.SelectedIndex == 2 && cboConvertTo.SelectedIndex == 1)
                {
                    octalToBinary(input);
                }
                else if (cboConvertFrom.SelectedIndex == 3 && cboConvertTo.SelectedIndex == 1)
                {
                    hexToBinary(input);
                }
                else if (cboConvertFrom.SelectedIndex == 0 && cboConvertTo.SelectedIndex == 2)
                {
                    decimalToOctal(input);
                }
                else if (cboConvertFrom.SelectedIndex == 1 && cboConvertTo.SelectedIndex == 2)
                {
                    binaryToOctal(input);
                }
                else if (cboConvertFrom.SelectedIndex == 3 && cboConvertTo.SelectedIndex == 2)
                {
                    hexToOctal(input);
                }
                else if (cboConvertFrom.SelectedIndex == 0 && cboConvertTo.SelectedIndex == 3)
                {
                    decimalToHex(input);
                }
                else if (cboConvertFrom.SelectedIndex == 1 && cboConvertTo.SelectedIndex == 3)
                {
                    binaryToHex(input);
                }
                else if (cboConvertFrom.SelectedIndex == 2 && cboConvertTo.SelectedIndex == 3)
                {
                    octalToHex(input);
                }
                else if (cboConvertFrom.SelectedIndex == 1 && cboConvertTo.SelectedIndex == 0)
                {
                    binaryToDecimal(input);
                }
                else if (cboConvertFrom.SelectedIndex == 2 && cboConvertTo.SelectedIndex == 0)
                {
                    octalToDecimal(input);
                }
                else if (cboConvertFrom.SelectedIndex == 3 && cboConvertTo.SelectedIndex == 0)
                {
                    hexToDecimal(input);
                }//if
            }
            else
            {
                // Error messages are handled by the validateStringContent() methods
                return;
            }//if
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

            //Clear tooltips (if they were used)
            lblConvertFromCbo.Text = "";
            lblConvertFromTxt.Text = "";
            lblConvertToCbo.Text = "";

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
                return;
            }
        }//btnHelp_Click

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
                return;
            }
        }//btnExit_Click

        private void btnConvert_Enter(object sender, KeyEventArgs e)
        {
            //Allows the user to press the enter key to activate the Convert button, as long as it is highlighted.
            if (e.KeyCode == Keys.Enter)
            {
                btnConvert_Click(this, new EventArgs());
            }//if
        }//btnConvert_Enter

        //************************
        //   CONVERSION METHODS
        //************************

        private string decimalToBinary(string input)
        {
            int tempInput = Convert.ToInt32(input, 10);
            return Convert.ToString(tempInput, 2);
        }//decimalToBinary

        private string octalToBinary(string input)
        {
            int tempInput = Convert.ToInt32(input, 8);
            return Convert.ToString(tempInput, 2);
        }//octalToBinary

        private string hexToBinary(string input)
        {
            int tempInput = Convert.ToInt32(input, 16);
            return Convert.ToString(tempInput, 2);
        }//hexToBinary

        private string decimalToOctal(string input)
        {
            int tempInput = Convert.ToInt32(input, 10);
            return Convert.ToString(tempInput, 8);
        }//decimalToOctal

        private string binaryToOctal(string input)
        {
            int tempInput = Convert.ToInt32(input, 2);
            return Convert.ToString(tempInput, 8);
        }//binaryToOctal

        private string hexToOctal(string input)
        {
            int tempInput = Convert.ToInt32(input, 16);
            return Convert.ToString(tempInput, 8);
        }//hexToOctal

        private string decimalToHex(string input)
        {
            int tempInput = Convert.ToInt32(input, 10);
            return Convert.ToString(tempInput, 16).ToUpper();
        }//decimalToHex

        private string binaryToHex(string input)
        {
            int tempInput = Convert.ToInt32(input, 2);
            return Convert.ToString(tempInput, 16).ToUpper();
        }//binaryToHex

        private string octalToHex(string input)
        {
            int tempInput = Convert.ToInt32(input, 8);
            return Convert.ToString(tempInput, 16).ToUpper();
        }//octalToHex

        private string binaryToDecimal(string input)
        {
            int tempInput = Convert.ToInt32(input, 2);
            return Convert.ToString(input);
        }//binaryToDecimal

        private string octalToDecimal(string input)
        {
            int tempInput = Convert.ToInt32(input, 8);
            return Convert.ToString(input);
        }//binaryToDecimal

        private string hexToDecimal(string input)
        {
            int tempInput = Convert.ToInt32(input, 16);
            return Convert.ToString(input);
        }//binaryToDecimal

        //************************
        //   VALIDATION METHODS
        //************************

        private Boolean catchOverflowException()
        {
            /* This method checks the input for potential OverflowExceptions by attempting to convert the text in the input area to an int.
             * If the catch is triggered, return true. Else, if the number system is set to Hex or the catch is not triggered, return false.
            */ 
            try
            {
                //Exempt Hex as it is string-based, but first check to see that there is something in txtConvertFrom
                if (cboConvertFrom.SelectedIndex != 3)
                {
                    int tempVal = Convert.ToInt32(txtConvertFrom.Text);
                }
                else
                {
                    return false;
                }//if
            }
            catch (OverflowException)
            {
                return true;
            }//trycatch

            return false;
        }//catchOverflowException

        private Boolean validateComboBoxes()
        {
            // Ensure that something is selected for both boxes and that both boxes are not set to the same option
            if (cboConvertFrom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a number system to convert from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertFromCbo.Text = "*";
                return true;

            }
            else if (cboConvertTo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a number system to convert to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertToCbo.Text = "*";
                return true;
            }
            else if (((cboConvertTo.SelectedIndex) == (cboConvertFrom.SelectedIndex)))
            {
                MessageBox.Show("You are converting to the same number system! Please select a different number system and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Assuming only cboConvertTo needs to be cleared - do so
                cboConvertTo.SelectedIndex = -1;
                txtConvertTo.Clear();
                lblConvertToCbo.Text = "*";
                return true;
            }
            else
            {
                return false;
            }//if
        }//validateComboBoxes

        private Boolean validateStringContent(string input)
        {
            // This will validate the content of the string against the selected number system by calling the appropriate validator
            if (cboConvertFrom.SelectedIndex == 0)
            {
                if (validateOctal(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }//if
            }
            else if (cboConvertFrom.SelectedIndex == 1)
            {
                if (validateBinary(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }//if
            }
            else if (cboConvertFrom.SelectedIndex == 2)
            {
                if (validateOctal(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }//if
            }
            else if (cboConvertFrom.SelectedIndex == 3)
            {
                if (validateHex(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }//if
            }
            else
            {
                return false;
            }//if
        }//validateStringContent

        private Boolean validateDecimal(string input)
        {
            Regex isDecimal = new Regex("[^0-9]");
            if(!isDecimal.IsMatch(input))
            {
                return true;
            }
            else
            {
                // Inform the user and return false
                MessageBox.Show("Decimal can only contain numbers 0-9. Check input and try again,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertFromTxt.Text = ("*");
                return false;
            }//if
        }//validateDecimal

        private Boolean validateBinary(string input)
        {
            Regex isBinary = new Regex("[^0-1]");
            if (!isBinary.IsMatch(input))
            {
                return true;
            }
            else
            {
                // Inform the user and return false
                MessageBox.Show("Binary can only contain numbers 0 and 1. Check input and try again,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertFromTxt.Text = ("*");
                return false;
            }//if
        }//validateBinary

        private Boolean validateOctal(string input)
        {
            Regex isOctal = new Regex("[^0-7]");
            if (!isOctal.IsMatch(input))
            {
                return true;
            }
            else
            {
                // Inform the user and return false
                MessageBox.Show("Octal can only contain numbers 0-7. Check input and try again,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertFromTxt.Text = ("*");
                return false;
            }//if
        }//validateOctal

        private Boolean validateHex(string input)
        {
            Regex isHex = new Regex("[^0-9a-f]");
            if (!isHex.IsMatch(input))
            {
                return true;
            }
            else
            {
                // Inform the user and return false
                MessageBox.Show("Hexadecimal can only contain numbers 0-9 and letters A-F. Check input and try again,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConvertFromTxt.Text = ("*");
                return false;
            }//if
        }//validateHex
    }//class
}//namespace
