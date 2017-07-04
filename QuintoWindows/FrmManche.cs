using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuintoDll;

namespace QuintoWindows
{
    public partial class FrmManche : Form
    {
        LancementManche manche = new LancementManche();


        public FrmManche()
        {
            InitializeComponent();
        }
        void GestionnaireMarche(EtatManche etatManche)
        {
            switch (etatManche)
            {
                case EtatManche.Debut:
                    panel1.Enabled = true;
                    manche.MancheEnCours++;
                    manche.NbrErreur = 0;
                    manche.InitialiseMotEnCours();
                    txtAfficheMot.Text = manche.ChartoString(manche.MotEncours);
                    lblNbrEssai.Text = "Nombre d'essais restant : " + (9 - manche.NbrErreur);
                    txtNbrManches.Text = "Manche :" + (manche.MancheEnCours + "/" + manche.NbrMancheMax);
                    break;
                case EtatManche.Gagne:
                    panel1.Enabled = false;
                    if (manche.MancheGagne())
                    {
                        MessageBox.Show("Félicitation vous avez trouvé le mot ! \r\n Passez à la manche suivante.", "Manche gagné", MessageBoxButtons.OK);
                        txtAfficheMot.Text = string.Empty;
                        GestionnaireMarche(EtatManche.Debut);
                    }
                    break;
                case EtatManche.Perdu:
                    panel1.Enabled = false;
                    if (manche.ManchePerdue())
                    {
                        MessageBox.Show("Vous avez perdu :( !", "Partie perdue", MessageBoxButtons.RetryCancel);
                    }
                    break;
                default:
                    break;
            }
        }

        private void MessageBoxButtons_Click(object sender, EventArgs e)
        {
            GestionnaireMarche(EtatManche.Debut);
        }

        private void Partie_Load(object sender, EventArgs e)
        {
            GestionnaireMarche(EtatManche.Debut);
        }
        private void txtAfficheMot_TextChanged(object sender, EventArgs e)
        {
            txtAfficheMot.Text = manche.MotEncours.ToString();
        }
        private void lblChrono_Click(object sender, EventArgs e)
        {

        }

        private void LettreSaise(object sender, EventArgs e)
        {
            Button btnGeneric = sender as Button;
            manche.Lettre = Convert.ToChar(btnGeneric.Text);
            txtAfficheMot.Text = manche.DecouvreMot();
            btnGeneric.Enabled = false;
            if (manche.AddErreur())
            {
                manche.NbrErreur++;
                lblNbrEssai.Text = "Nombre d'essais restant : " + (9 - manche.NbrErreur);
            }
            if (manche.MancheGagne())
            {
                GestionnaireMarche(EtatManche.Gagne);

            }
            if (manche.ManchePerdue())
            {
                GestionnaireMarche(EtatManche.Perdu);
                btnGeneric.Enabled = true;
            }
        }
    }
}

