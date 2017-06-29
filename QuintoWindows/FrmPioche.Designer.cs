namespace QuintoWindows
{
    partial class FrmPioche
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
            this.txtAjout = new System.Windows.Forms.TextBox();
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.btn_Retire = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPioche = new System.Windows.Forms.ListBox();
            this.lbPoubelle = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAjout
            // 
            this.txtAjout.Location = new System.Drawing.Point(328, 116);
            this.txtAjout.Name = "txtAjout";
            this.txtAjout.Size = new System.Drawing.Size(144, 20);
            this.txtAjout.TabIndex = 2;
            // 
            // btn_Ajout
            // 
            this.btn_Ajout.Location = new System.Drawing.Point(360, 142);
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.Size = new System.Drawing.Size(74, 22);
            this.btn_Ajout.TabIndex = 4;
            this.btn_Ajout.Text = "Ajouter";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            this.btn_Ajout.Click += new System.EventHandler(this.Ajout_Clk);
            // 
            // btn_Retire
            // 
            this.btn_Retire.Location = new System.Drawing.Point(360, 170);
            this.btn_Retire.Name = "btn_Retire";
            this.btn_Retire.Size = new System.Drawing.Size(74, 22);
            this.btn_Retire.TabIndex = 5;
            this.btn_Retire.Text = "Retirer";
            this.btn_Retire.UseVisualStyleBackColor = true;
            this.btn_Retire.Click += new System.EventHandler(this.Retirer_Clk);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // lbPioche
            // 
            this.lbPioche.FormattingEnabled = true;
            this.lbPioche.Location = new System.Drawing.Point(38, 29);
            this.lbPioche.Name = "lbPioche";
            this.lbPioche.ScrollAlwaysVisible = true;
            this.lbPioche.Size = new System.Drawing.Size(201, 381);
            this.lbPioche.TabIndex = 8;
            // 
            // lbPoubelle
            // 
            this.lbPoubelle.FormattingEnabled = true;
            this.lbPoubelle.Location = new System.Drawing.Point(556, 29);
            this.lbPoubelle.Name = "lbPoubelle";
            this.lbPoubelle.ScrollAlwaysVisible = true;
            this.lbPoubelle.Size = new System.Drawing.Size(201, 381);
            this.lbPoubelle.TabIndex = 9;
            // 
            // FrmPioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 460);
            this.Controls.Add(this.lbPoubelle);
            this.Controls.Add(this.lbPioche);
            this.Controls.Add(this.btn_Retire);
            this.Controls.Add(this.btn_Ajout);
            this.Controls.Add(this.txtAjout);
            this.Name = "FrmPioche";
            this.Text = "Pioche";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAjout;
        private System.Windows.Forms.Button btn_Ajout;
        private System.Windows.Forms.Button btn_Retire;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ListBox lbPioche;
        private System.Windows.Forms.ListBox lbPoubelle;
    }
}