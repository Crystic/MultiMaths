namespace MultiMaths
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(56, -7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 95);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MultiMaths";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(72, 107);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(135, 63);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(294, 107);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(135, 63);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(185, 196);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(146, 63);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(185, 286);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(146, 63);
            this.btnMedium.TabIndex = 4;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(185, 376);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(146, 63);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(359, 376);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 63);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 451);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "MultiMaths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnQuit;
    }
}

