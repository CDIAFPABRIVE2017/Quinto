namespace QuintoWindows
{
    public partial class FrmOptions
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
            this.gbNbrManches = new System.Windows.Forms.GroupBox();
            this.gbLangages = new System.Windows.Forms.GroupBox();
            this.btn_2Manches = new System.Windows.Forms.RadioButton();
            this.btn_3Manches = new System.Windows.Forms.RadioButton();
            this.btn_4Manches = new System.Windows.Forms.RadioButton();
            this.btn_5Manches = new System.Windows.Forms.RadioButton();
            this.btn_Fr = new System.Windows.Forms.RadioButton();
            this.btn_En = new System.Windows.Forms.RadioButton();
            this.gbMusique = new System.Windows.Forms.GroupBox();
            this.btn_OffM = new System.Windows.Forms.RadioButton();
            this.btn_OnM = new System.Windows.Forms.RadioButton();
            this.gbSon = new System.Windows.Forms.GroupBox();
            this.btn_OffS = new System.Windows.Forms.RadioButton();
            this.btn_OnS = new System.Windows.Forms.RadioButton();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.gbNbrManches.SuspendLayout();
            this.gbLangages.SuspendLayout();
            this.gbMusique.SuspendLayout();
            this.gbSon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNbrManches
            // 
            this.gbNbrManches.Controls.Add(this.btn_5Manches);
            this.gbNbrManches.Controls.Add(this.btn_4Manches);
            this.gbNbrManches.Controls.Add(this.btn_3Manches);
            this.gbNbrManches.Controls.Add(this.btn_2Manches);
            this.gbNbrManches.Location = new System.Drawing.Point(75, 36);
            this.gbNbrManches.Name = "gbNbrManches";
            this.gbNbrManches.Size = new System.Drawing.Size(200, 117);
            this.gbNbrManches.TabIndex = 0;
            this.gbNbrManches.TabStop = false;
            this.gbNbrManches.Text = "Nombre de Manches";
            // 
            // gbLangages
            // 
            this.gbLangages.Controls.Add(this.btn_En);
            this.gbLangages.Controls.Add(this.btn_Fr);
            this.gbLangages.Location = new System.Drawing.Point(75, 159);
            this.gbLangages.Name = "gbLangages";
            this.gbLangages.Size = new System.Drawing.Size(200, 79);
            this.gbLangages.TabIndex = 1;
            this.gbLangages.TabStop = false;
            this.gbLangages.Text = "Langages";
            // 
            // btn_2Manches
            // 
            this.btn_2Manches.AutoSize = true;
            this.btn_2Manches.Location = new System.Drawing.Point(58, 19);
            this.btn_2Manches.Name = "btn_2Manches";
            this.btn_2Manches.Size = new System.Drawing.Size(78, 17);
            this.btn_2Manches.TabIndex = 4;
            this.btn_2Manches.TabStop = true;
            this.btn_2Manches.Text = "2 Manches";
            this.btn_2Manches.UseVisualStyleBackColor = true;
            // 
            // btn_3Manches
            // 
            this.btn_3Manches.AutoSize = true;
            this.btn_3Manches.Location = new System.Drawing.Point(58, 42);
            this.btn_3Manches.Name = "btn_3Manches";
            this.btn_3Manches.Size = new System.Drawing.Size(78, 17);
            this.btn_3Manches.TabIndex = 5;
            this.btn_3Manches.TabStop = true;
            this.btn_3Manches.Text = "3 Manches";
            this.btn_3Manches.UseVisualStyleBackColor = true;
            // 
            // btn_4Manches
            // 
            this.btn_4Manches.AutoSize = true;
            this.btn_4Manches.Location = new System.Drawing.Point(58, 65);
            this.btn_4Manches.Name = "btn_4Manches";
            this.btn_4Manches.Size = new System.Drawing.Size(78, 17);
            this.btn_4Manches.TabIndex = 5;
            this.btn_4Manches.TabStop = true;
            this.btn_4Manches.Text = "4 Manches";
            this.btn_4Manches.UseVisualStyleBackColor = true;
            // 
            // btn_5Manches
            // 
            this.btn_5Manches.AutoSize = true;
            this.btn_5Manches.Location = new System.Drawing.Point(58, 88);
            this.btn_5Manches.Name = "btn_5Manches";
            this.btn_5Manches.Size = new System.Drawing.Size(78, 17);
            this.btn_5Manches.TabIndex = 6;
            this.btn_5Manches.TabStop = true;
            this.btn_5Manches.Text = "5 Manches";
            this.btn_5Manches.UseVisualStyleBackColor = true;
            // 
            // btn_Fr
            // 
            this.btn_Fr.AutoSize = true;
            this.btn_Fr.Location = new System.Drawing.Point(6, 31);
            this.btn_Fr.Name = "btn_Fr";
            this.btn_Fr.Size = new System.Drawing.Size(65, 17);
            this.btn_Fr.TabIndex = 5;
            this.btn_Fr.TabStop = true;
            this.btn_Fr.Text = "Français";
            this.btn_Fr.UseVisualStyleBackColor = true;
            // 
            // btn_En
            // 
            this.btn_En.AutoSize = true;
            this.btn_En.Location = new System.Drawing.Point(110, 31);
            this.btn_En.Name = "btn_En";
            this.btn_En.Size = new System.Drawing.Size(59, 17);
            this.btn_En.TabIndex = 6;
            this.btn_En.TabStop = true;
            this.btn_En.Text = "English";
            this.btn_En.UseVisualStyleBackColor = true;
            // 
            // gbMusique
            // 
            this.gbMusique.Controls.Add(this.btn_OffM);
            this.gbMusique.Controls.Add(this.btn_OnM);
            this.gbMusique.Location = new System.Drawing.Point(75, 241);
            this.gbMusique.Name = "gbMusique";
            this.gbMusique.Size = new System.Drawing.Size(200, 79);
            this.gbMusique.TabIndex = 2;
            this.gbMusique.TabStop = false;
            this.gbMusique.Text = "Musique";
            // 
            // btn_OffM
            // 
            this.btn_OffM.AutoSize = true;
            this.btn_OffM.Location = new System.Drawing.Point(110, 31);
            this.btn_OffM.Name = "btn_OffM";
            this.btn_OffM.Size = new System.Drawing.Size(39, 17);
            this.btn_OffM.TabIndex = 6;
            this.btn_OffM.TabStop = true;
            this.btn_OffM.Text = "Off";
            this.btn_OffM.UseVisualStyleBackColor = true;
            // 
            // btn_OnM
            // 
            this.btn_OnM.AutoSize = true;
            this.btn_OnM.Location = new System.Drawing.Point(6, 31);
            this.btn_OnM.Name = "btn_OnM";
            this.btn_OnM.Size = new System.Drawing.Size(39, 17);
            this.btn_OnM.TabIndex = 5;
            this.btn_OnM.TabStop = true;
            this.btn_OnM.Text = "On";
            this.btn_OnM.UseVisualStyleBackColor = true;
            // 
            // gbSon
            // 
            this.gbSon.Controls.Add(this.btn_OffS);
            this.gbSon.Controls.Add(this.btn_OnS);
            this.gbSon.Location = new System.Drawing.Point(75, 326);
            this.gbSon.Name = "gbSon";
            this.gbSon.Size = new System.Drawing.Size(200, 79);
            this.gbSon.TabIndex = 3;
            this.gbSon.TabStop = false;
            this.gbSon.Text = "Son";
            // 
            // btn_OffS
            // 
            this.btn_OffS.AutoSize = true;
            this.btn_OffS.Location = new System.Drawing.Point(110, 31);
            this.btn_OffS.Name = "btn_OffS";
            this.btn_OffS.Size = new System.Drawing.Size(39, 17);
            this.btn_OffS.TabIndex = 6;
            this.btn_OffS.TabStop = true;
            this.btn_OffS.Text = "Off";
            this.btn_OffS.UseVisualStyleBackColor = true;
            // 
            // btn_OnS
            // 
            this.btn_OnS.AutoSize = true;
            this.btn_OnS.Location = new System.Drawing.Point(6, 31);
            this.btn_OnS.Name = "btn_OnS";
            this.btn_OnS.Size = new System.Drawing.Size(39, 17);
            this.btn_OnS.TabIndex = 5;
            this.btn_OnS.TabStop = true;
            this.btn_OnS.Text = "On";
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(117, 439);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.Enregistrer.TabIndex = 0;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enrgistrer_Clk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOptions
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FrmOptions";
            this.ResumeLayout(false);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 446);
            this.Controls.Add(this.gbSon);
            this.Controls.Add(this.gbMusique);
            this.Controls.Add(this.gbLangages);
            this.Controls.Add(this.gbNbrManches);
            this.Controls.Add(this.Enregistrer);
            this.Name = "FrmOptions";
            this.Text = "Options";
            this.gbNbrManches.ResumeLayout(false);
            this.gbNbrManches.PerformLayout();
            this.gbLangages.ResumeLayout(false);
            this.gbLangages.PerformLayout();
            this.gbMusique.ResumeLayout(false);
            this.gbMusique.PerformLayout();
            this.gbSon.ResumeLayout(false);
            this.gbSon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNbrManches;
        private System.Windows.Forms.GroupBox gbLangages;
        private System.Windows.Forms.RadioButton btn_5Manches;
        private System.Windows.Forms.RadioButton btn_4Manches;
        private System.Windows.Forms.RadioButton btn_3Manches;
        private System.Windows.Forms.RadioButton btn_2Manches;
        private System.Windows.Forms.RadioButton btn_En;
        private System.Windows.Forms.RadioButton btn_Fr;
        private System.Windows.Forms.GroupBox gbMusique;
        private System.Windows.Forms.RadioButton btn_OffM;
        private System.Windows.Forms.RadioButton btn_OnM;
        private System.Windows.Forms.GroupBox gbSon;
        private System.Windows.Forms.RadioButton btn_OffS;
        private System.Windows.Forms.RadioButton btn_OnS;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

