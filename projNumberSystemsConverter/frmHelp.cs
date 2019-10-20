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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            //Fill the listbox with help dialogue.
            lstHelp.Items.Add("Welcome to the Number Systems Converter");
            lstHelp.Items.Add("To use this converter, follow these instructions:");
            lstHelp.Items.Add("1. Select the number system you wish to convert from from the drop-down box.");
            lstHelp.Items.Add("2. Enter the number that you wish to convert.");
            lstHelp.Items.Add("3. Select the number system that you wish to convert your number to.");
            lstHelp.Items.Add("4. Click the convert button to perform the calculation.");
            lstHelp.Items.Add("5. Your converted number will be displayed in the bottom text box.");
            lstHelp.Items.Add("6. If you need an explanation, click the Explanation button.");
            lstHelp.Items.Add("");
            lstHelp.Items.Add("To help you use this program, remember these rules:");
            lstHelp.Items.Add("1. Binary numbers can only have the digits 0 and 1");
            lstHelp.Items.Add("2. Octal numbers can only have the digits 0 to 7");
            lstHelp.Items.Add("3. Hex numbers can only have the digits 0 to 9 and letters A to F");

        }//help

        private void btnOk_Help_Click(object sender, EventArgs e)
        {
            //Close the window
            this.Close();
        }//btnOK_Help_Click

        private void btnOk_Help_KeyDown(object sender, KeyEventArgs e)
        {
            //When the button is highlighted, the enter key can be pressed to activate it instead of clicking
            btnOk_Help_Click(this, new EventArgs());
        }//btnOK_Help_KeyDown
    }//class
}//namespace
