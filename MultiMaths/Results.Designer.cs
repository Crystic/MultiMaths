namespace MultiMaths
{
    partial class Results
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQRightText = new System.Windows.Forms.Label();
            this.lblQRight = new System.Windows.Forms.Label();
            this.lblQTotalText = new System.Windows.Forms.Label();
            this.lblQTotal = new System.Windows.Forms.Label();
            this.lblCorrectPercentText = new System.Windows.Forms.Label();
            this.lblCorrectPercent = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(474, 364);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 35);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(79, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 95);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "MultiMaths";
            // 
            // lblQRightText
            // 
            this.lblQRightText.AutoSize = true;
            this.lblQRightText.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblQRightText.Location = new System.Drawing.Point(12, 114);
            this.lblQRightText.Name = "lblQRightText";
            this.lblQRightText.Size = new System.Drawing.Size(246, 45);
            this.lblQRightText.TabIndex = 11;
            this.lblQRightText.Text = "Right Answers:";
            // 
            // lblQRight
            // 
            this.lblQRight.AutoSize = true;
            this.lblQRight.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblQRight.Location = new System.Drawing.Point(340, 114);
            this.lblQRight.Name = "lblQRight";
            this.lblQRight.Size = new System.Drawing.Size(47, 45);
            this.lblQRight.TabIndex = 12;
            this.lblQRight.Text = "#";
            this.lblQRight.Click += new System.EventHandler(this.lblQRight_Click);
            // 
            // lblQTotalText
            // 
            this.lblQTotalText.AutoSize = true;
            this.lblQTotalText.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblQTotalText.Location = new System.Drawing.Point(12, 172);
            this.lblQTotalText.Name = "lblQTotalText";
            this.lblQTotalText.Size = new System.Drawing.Size(286, 45);
            this.lblQTotalText.TabIndex = 13;
            this.lblQTotalText.Text = "Questions Asked:";
            // 
            // lblQTotal
            // 
            this.lblQTotal.AutoSize = true;
            this.lblQTotal.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblQTotal.Location = new System.Drawing.Point(340, 172);
            this.lblQTotal.Name = "lblQTotal";
            this.lblQTotal.Size = new System.Drawing.Size(47, 45);
            this.lblQTotal.TabIndex = 14;
            this.lblQTotal.Text = "#";
            // 
            // lblCorrectPercentText
            // 
            this.lblCorrectPercentText.AutoSize = true;
            this.lblCorrectPercentText.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblCorrectPercentText.Location = new System.Drawing.Point(12, 231);
            this.lblCorrectPercentText.Name = "lblCorrectPercentText";
            this.lblCorrectPercentText.Size = new System.Drawing.Size(322, 45);
            this.lblCorrectPercentText.TabIndex = 15;
            this.lblCorrectPercentText.Text = "Percentage Correct:";
            // 
            // lblCorrectPercent
            // 
            this.lblCorrectPercent.AutoSize = true;
            this.lblCorrectPercent.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblCorrectPercent.Location = new System.Drawing.Point(340, 231);
            this.lblCorrectPercent.Name = "lblCorrectPercent";
            this.lblCorrectPercent.Size = new System.Drawing.Size(47, 45);
            this.lblCorrectPercent.TabIndex = 16;
            this.lblCorrectPercent.Text = "#";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lblFeedback.Location = new System.Drawing.Point(12, 311);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(47, 45);
            this.lblFeedback.TabIndex = 17;
            this.lblFeedback.Text = "#";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 411);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblCorrectPercent);
            this.Controls.Add(this.lblCorrectPercentText);
            this.Controls.Add(this.lblQTotal);
            this.Controls.Add(this.lblQTotalText);
            this.Controls.Add(this.lblQRight);
            this.Controls.Add(this.lblQRightText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQRightText;
        private System.Windows.Forms.Label lblQRight;
        private System.Windows.Forms.Label lblQTotalText;
        private System.Windows.Forms.Label lblQTotal;
        private System.Windows.Forms.Label lblCorrectPercentText;
        private System.Windows.Forms.Label lblCorrectPercent;
        private System.Windows.Forms.Label lblFeedback;
    }
}