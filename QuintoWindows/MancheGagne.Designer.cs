namespace QuintoWindows
{
    partial class MancheGagne
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
            this.lblGagne = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGagne
            // 
            this.lblGagne.AutoSize = true;
            this.lblGagne.Location = new System.Drawing.Point(300, 123);
            this.lblGagne.Name = "lblGagne";
            this.lblGagne.Size = new System.Drawing.Size(182, 13);
            this.lblGagne.TabIndex = 0;
            this.lblGagne.Text = "Féliciattion, vous avez trouvé le mot !";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(293, 241);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(198, 75);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "button1";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(322, 181);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(84, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Votre score est :";
            // 
            // MancheGagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 460);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblGagne);
            this.Name = "MancheGagne";
            this.Text = "ResultatManche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGagne;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label labelScore;
    }
}