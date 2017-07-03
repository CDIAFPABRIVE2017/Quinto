using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using QuintoDll;

namespace QuintoWindows
{
    public partial class FrmPartie : Form
    {

        enum EtatManche
        {
            Debut = 0,
            Fin = 1,

        }
        enum EtatPartie
        {
            Manches2 = 0,
            Manches3 = 1,
            Manches4 = 2,
            Manches5 = 3,
            Fin = 4
        }
        public FrmPartie()
        {
            InitializeComponent();
        }
        void GestionnaireEtatPartie(EtatPartie etatPartie)
        {
            
            


        } 
        void GestionnaireMarche(EtatManche etatManche)
        {
            switch (etatManche)
            {
                case EtatManche.Debut:
                    manche.NbrErreur = 0;
                    txtAfficheMot.Text= manche.MotADecouvrir;
                    break;
                case EtatManche.Fin:
                    panel1.Enabled = false;
                    if(manche.MancheGagne())
                    {
                        MessageBox.Show("Félicitation vous avez trouvé le mot ! \r\n Passez à la manche suivante.", "Manche gagné", MessageBoxButtons.OK);
                    }
                    MessageBox.Show("Vous avez perdu :( !", "Partie perdue", MessageBoxButtons.OK);
                    break;
                default:
                    break;
            }

        }
        private void Partie_Load(object sender, EventArgs e)
        {
            GestionnaireMarche(EtatManche.Debut);
        }
        private void txtAfficheMot_TextChanged(object sender, EventArgs e)
        {
            txtAfficheMot.Text = manche.MotADecouvrir;
        }
        private void lblChrono_Click(object sender, EventArgs e)
        {
          
        }
        private void lblManche_TextChanged(object sender, EventArgs e)
        {
            lblManche.Text = "Manche :";
        }
        private void txtNbrManches_TextChanged(object sender, EventArgs e)
        {
            txtNbrManches.Text = (manche.MancheEnCours +"/"+ manche.NbrMancheMax);
        }
        private void lblNbrEssai_TextChanged(object sender, EventArgs e)
        {
            lblNbrEssai.Text = "Nombre d'essais restant :" + (9 - manche.NbrErreur);
        }
        private void Lettre(object sender, EventArgs e)
        {
            Button btnGeneric = sender as Button;
            manche.Lettre = btnGeneric.Text;
            btnGeneric.Enabled = false;

        }

        private void Partie_Load(object sender, EventArgs e)
        {

        }

      
    }
}
