using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiMaths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Here we declare all of the forms that the main menu will open up
         * The syntax for writing one of these declarations is:
         * "FormName variableName = new FormName();"
         * 
         * You can check the form name by looking at the top of each form at the line something like:
         * "public partial class Form1 : Form"
         * The part that says "Form1" is what needs to go in FormName in the syntax.
         * You can name the variable anything you recommend, I suggest it begins with "frm" followed by whatever you want.
         * 
         * Example:
         * Help frmHelp = new Help();
         * Help is the forms name. frmHelp is the variable name.
         * 
         * You must use these declearations whenever you want to do anything else with another form
         * for example showing/hiding the form or getting a value from another form.
         */
        Help frmHelp = new Help();
        Rules frmRules = new Rules();
        Questions frmQuestions = new Questions();
        Results frmResults = new Results();

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp.Show(); //Shows the FormName that is assossiated with frmHelp that was declared above.
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            frmRules.Show(); //See previous.
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmQuestions.Close(); //Closes the form. Once a form is closed, it cannot be reopened.
            Application.Exit(); //Shuts the program down, stops the program from continuing to run after its closed.
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides THIS form. Use the term "this" whenever you want to refer to the form you are currently working on.
            frmQuestions.countdown = frmQuestions.easyTime; //Goes to the form "Questions", finds the variable named "countdown" and sets "countdown" to be the same as the variable "easyTime" in the form Questions.
            frmQuestions.easyMode = true; //Sets the boolean "easyMode" to true in the form Questions. The boolean should be set to false by default.
            frmQuestions.easyQuestion(); //Runs the method "easyQuestion" in the form Questions.
            frmQuestions.Show(); //Shows the form Questions.
        }

        /*
         * The next two methods are identical to the previous method, except they are for the medium and hard difficulties.
         */
        private void btnMedium_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuestions.countdown = frmQuestions.mediumTime;
            frmQuestions.mediumMode = true;
            frmQuestions.mediumQuestion();
            frmQuestions.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuestions.countdown = frmQuestions.hardTime;
            frmQuestions.hardMode = true;
            frmQuestions.hardQuestion();
            frmQuestions.Show();
        }
        
        //Ignore this.
        private void btnResults_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResults.Show();
        }

        
    }
}
