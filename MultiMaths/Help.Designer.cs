namespace MultiMaths
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(338, 579);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 63);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.lblHelp.Location = new System.Drawing.Point(1, 127);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(485, 420);
            this.lblHelp.TabIndex = 8;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Help!";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 654);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHelp);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label label1;
    }
}