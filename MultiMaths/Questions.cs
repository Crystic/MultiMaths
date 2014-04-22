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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        /*
         *  This form is the one where the user will read the question and input their answer.
         *  It is the main game screen if you'd like.
         */


        Random randomGenerator = new Random(); //Random Number Generator.
        
        //Stores the two numbers that will be asked in the question.        
        private int firstNumber;
        private int secondNumber;

        //Booleans allow us to set the difficulty and ask the correct difficulty of questions.
        public bool easyMode = false;
        public bool mediumMode = false;
        public bool hardMode = false;

        //The different times for each difficulty.
        public int easyTime = 60;
        public int mediumTime = 90;
        public int hardTime = 120;
        
        //This needs to be declared somewhere. It does not need to equal anything, it just needs to exist.
        public int countdown = 60;

        /*
         * These keep track of the number of questions the user has answered correctly (their score) and the total number of questions that have been asked.
         * They are both needed to calculate a percentage of correct answers on the results form.
         */ 
        public static int numQRight;
        public static int numQTotal;    
        
        //This method is triggered first when the easy button is pressed, then whenever new question is asked.      
        public void easyQuestion()
        {
            firstNumber = randomGenerator.Next(0, 6); //Generates the first random number.
            secondNumber = randomGenerator.Next(0, 6); //Generates the second random number.
            /*
             * The "(0, 6)" part of the two lines above are the paramiters that the random gernator will work inside.
             * This means that the program will only generate a number between and including 0 and 5.
             */ 

            lblNumOne.Text = firstNumber.ToString(); //Puts the first number into the label where the first number should be.
            lblNumTwo.Text = secondNumber.ToString(); //Puts the second number into the label where the second number should be.

        }

        //The following two methods are identical to the one above, just with the random paramiters adjusted for the difficulties.

        public void mediumQuestion()
        { 
            firstNumber = randomGenerator.Next(0, 11);
            secondNumber = randomGenerator.Next(0, 11);

            lblNumOne.Text = firstNumber.ToString();
            lblNumTwo.Text = secondNumber.ToString();
        }

        public void hardQuestion()
        {
            firstNumber = randomGenerator.Next(5, 11);
            secondNumber = randomGenerator.Next(5, 11);

            lblNumOne.Text = firstNumber.ToString();
            lblNumTwo.Text = secondNumber.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Form1 frmMenu = new Form1(); //THIS FORM MUST BE DECLARED LOCALLY (Within a method) OTHERWISE THE PROGRAM WILL CRASH.

            this.Hide(); //Hies this form.
            frmMenu.Show(); //Shows the menu form.
            easyMode = false; //Resets the difficulty.
            mediumMode = false; //Same as above.
            hardMode = false; //Same as above.
        }


        //This next part is for when the user clicks the button to submit their asnwer.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtAnswer.Text)) //First an error handler checks to make sure the box is not empty. If you do not have this, the program will crash if the box is empty and the button is clicked. (The ! is what makes this, ! means not, this says "If txtAnswer is not empty, do thing. If it is empty, nothing will happen.)
            {
                int answer; //Where the computers answer will be stored.
                string userAnswer; //Where the users string version of the answer is stored.
                int userAnswerInt; //Where the users int version of the answer is stored.

                answer = (firstNumber * secondNumber); //Computer does the caluclation itself, taking the firstNumber and multiplying it by the secondNumber variable we did at the top.
                userAnswer = txtAnswer.Text; //Gets the users answer and stores it in userAnswer.
                userAnswerInt = int.Parse(txtAnswer.Text); //Changes the userAnswer into an int.

                if (userAnswerInt == answer) //Checks to see if the userAnswerInt is exactly equal to the computers answer.
                {

                    lblFeedback.Text = "correct."; //If it is, it will show the word "correct." in the label.
                    txtAnswer.Clear(); //Then clear the text box.
                    //Then it will check to see what difficulty the program is running on and generate a new question based on that.
                    if (easyMode) //This says "If the boolean "easyMode" is true (Which it will be if easy difficulty is chosen as the button set it to true when clicked), run the method "easyQuestion" (Which is above).
                    {
                        easyQuestion();
                    }
                    else if (mediumMode) //The next two are exactly the same as the one above except for medium and hard difficulties.
                    {
                        mediumQuestion();
                    }
                    else if (hardMode) 
                    {
                        hardQuestion();
                    }
                    //Once it has generated a new question, if the answer was correct...
                    numQRight++; //One will be added to the variable numQRight.
                    numQTotal++; //One will also be added to the variable numQTotal.
                    lblCorrect.Text = numQRight.ToString(); //Displays the variable numQRight as a score.
                }
                else //This is what happens if the userAnswerInt is anything except exactly the same as the computers answer.
                {
                    lblFeedback.Text = "wrong."; //The label will change to wrong.
                    txtAnswer.Clear(); //The text box will be cleared.
                    if (easyMode) //A new question will be generated.
                    {
                        easyQuestion();
                    }
                    else if (mediumMode)
                    {
                        mediumQuestion();
                    }
                    else if (hardMode)
                    {
                        hardQuestion();
                    }
                    numQTotal++; //One will be added ONLY to the number of total questions. It will not add one to the number of correct answers because they got it wrong!
                }
            }
        }

        /*
         * This part is to do with the timer. To use this, you must go to the design view of the form and in the toolbox find the timer tool.
         * drag it onto the form, it wont appear anywhere but it will appear under the design. Go to the properties of the timer.
         * Give it a good name, set "Enabled" to "True" and set "Interval" to "1000". This sets the timer up to tick every 1 second.
         */ 

        private void tmr_Countdown_Tick(object sender, EventArgs e)
        {
            Results frmResults = new Results(); //Declaring the results form as it will open when the timer hits 0. Declaring locally otherwise the program will crash.

            lblTime.Text = countdown.ToString(); //Displays the countdown variable.
            if (countdown != 0) //This says "If the countdown does not equal 0, take away one" and this will be performed every tick (One second) of the timer.
            {
                countdown -= 1;
            }
            else if (countdown == 0) //This says "If the timer does equal exactly 0"...
            {
                this.Hide(); //Hide the questions form.
                frmResults.Show(); //Open the results form.
                countdown++; //Add one to the countdown variable (Otherwise it will keep checking to see if the countdown equals 0 and will keep opening the results form)
                tmr_Countdown.Stop(); //Stop the timer, so it stops counting down.
            }
        }
    }
}
