namespace MultiMaths
{
    partial class Questions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblNumOne = new System.Windows.Forms.Label();
            this.lblNumTwo = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tmr_Countdown = new System.Windows.Forms.Timer(this.components);
            this.lblTimeL = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(12, 9);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(404, 23);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Answer the question and then press the submit button!";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(333, 339);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 35);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(87, 63);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(57, 67);
            this.lblTimes.TabIndex = 2;
            this.lblTimes.Text = "x";
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOne.Location = new System.Drawing.Point(12, 63);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(69, 67);
            this.lblNumOne.TabIndex = 3;
            this.lblNumOne.Text = "#";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTwo.Location = new System.Drawing.Point(150, 63);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(69, 67);
            this.lblNumTwo.TabIndex = 4;
            this.lblNumTwo.Text = "#";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(225, 63);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(54, 67);
            this.lblEquals.TabIndex = 5;
            this.lblEquals.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(285, 69);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 74);
            this.txtAnswer.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(298, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(270, 188);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(47, 45);
            this.lblFeedback.TabIndex = 8;
            this.lblFeedback.Text = "#";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(276, 245);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(47, 45);
            this.lblCorrect.TabIndex = 9;
            this.lblCorrect.Text = "#";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblText.Location = new System.Drawing.Point(8, 188);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(239, 45);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Your answer is";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblPoints.Location = new System.Drawing.Point(126, 245);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(121, 45);
            this.lblPoints.TabIndex = 11;
            this.lblPoints.Text = "Points:";
            // 
            // tmr_Countdown
            // 
            this.tmr_Countdown.Enabled = true;
            this.tmr_Countdown.Interval = 1000;
            this.tmr_Countdown.Tick += new System.EventHandler(this.tmr_Countdown_Tick);
            // 
            // lblTimeL
            // 
            this.lblTimeL.AutoSize = true;
            this.lblTimeL.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblTimeL.Location = new System.Drawing.Point(18, 299);
            this.lblTimeL.Name = "lblTimeL";
            this.lblTimeL.Size = new System.Drawing.Size(252, 45);
            this.lblTimeL.TabIndex = 12;
            this.lblTimeL.Text = "Time Remaining";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(276, 299);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 45);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "#";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 386);
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeL);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblNumTwo);
            this.Controls.Add(this.lblNumOne);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblHelp);
            this.Name = "Questions";
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblNumOne;
        private System.Windows.Forms.Label lblNumTwo;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Timer tmr_Countdown;
        private System.Windows.Forms.Label lblTimeL;
        private System.Windows.Forms.Label lblTime;
    }
}