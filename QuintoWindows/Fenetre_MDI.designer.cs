namespace QuintoWindows
{
    partial class FrmQuinto
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNouvellePartie = new System.Windows.Forms.Button();
            this.btnAlimenterPioche = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvellePartie.Location = new System.Drawing.Point(313, 68);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(308, 38);
            this.btnNouvellePartie.TabIndex = 1;
            this.btnNouvellePartie.Text = "Nouvelle Partie";
            this.btnNouvellePartie.UseVisualStyleBackColor = true;
            this.btnNouvellePartie.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            // 
            // btnAlimenterPioche
            // 
            this.btnAlimenterPioche.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimenterPioche.Location = new System.Drawing.Point(313, 133);
            this.btnAlimenterPioche.Name = "btnAlimenterPioche";
            this.btnAlimenterPioche.Size = new System.Drawing.Size(308, 38);
            this.btnAlimenterPioche.TabIndex = 2;
            this.btnAlimenterPioche.Text = "Allimenter Pioche";
            this.btnAlimenterPioche.UseVisualStyleBackColor = true;
            this.btnAlimenterPioche.Click += new System.EventHandler(this.btnAlimenterPioche_Click);
            // 
            // btnOption
            // 
            this.btnOption.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.Location = new System.Drawing.Point(313, 192);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(308, 38);
            this.btnOption.TabIndex = 3;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(313, 254);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(308, 38);
            this.btnScore.TabIndex = 4;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // FrmQuinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 405);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnAlimenterPioche);
            this.Controls.Add(this.btnNouvellePartie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "FrmQuinto";
            this.Text = "Quinto";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNouvellePartie;
        private System.Windows.Forms.Button btnAlimenterPioche;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnScore;
    }
}

