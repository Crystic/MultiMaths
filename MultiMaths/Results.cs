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
    public partial class Results : Form
    {    
        public Results()
        {
            InitializeComponent();
        }

        /*
         * This form is the form that is shown with the users results on it.
         */

        /*
         * Three floats (Because division cannot be done with ints and they have to be converted to floats.)
         * The first two are conversions of the two variables we set in the Questions form to hold the players score and the total number of quesions asked.
         * The third is used to store the players final percentage of questions that were correct.
         * 
         * As I am writing this it seems that I did not declare the forms as I should have done, however it does not seem to have mattered that much
         * so just go with it :P
        */

        public float playerScore = Questions.numQRight;
        public float questionsAsked = Questions.numQTotal;
        public float playerPercent;
        
        //This method is run when the form loads, you can get this method by double clicking on the form itself in design mode.
        private void Results_Load(object sender, EventArgs e)
        {
            lblQRight.Text = playerScore.ToString(); //Displays the players score.
            lblQTotal.Text = questionsAsked.ToString(); //Displays the total number of questions asked.

            playerPercent = playerScore / questionsAsked * 100; //Calculates the players percent by taking the playerScore variable, dividing it by the questionsAskedVariable and then multiplying it by 100 (Basic maths)
            lblCorrectPercent.Text = playerPercent.ToString(); //Displays the percentage that was just calculated.

            //This section displays the text required in the spec.
            if (playerPercent <= 50) //If the playerPercent variable is less than or equal to (<= 50) 50...
            {
                lblFeedback.Text = "More practice is needed."; //Show this text in the label.
            }
            else if (playerPercent >= 51 && playerPercent <= 75) //If the playerPercent variable is more than or equal to (>= 51) 51 AND (&&) less than or equal to 75(>= 75)...
            {
                lblFeedback.Text = "Doing well, keep practising."; //Show this text.
            }
            else if (playerPercent >= 76 && playerPercent <= 99) //You get the idea?
            {
                lblFeedback.Text = "You are really getting this."; // I hope you do...
            }
            else if (playerPercent == 100) //Exactly equal to 100...
            {
                lblFeedback.Text = "You are a times table genius."; //Do thing.
            }
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Ignore these two
        private void lblQRight_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }


    }
}
