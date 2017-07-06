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
        LancementManche manche ;
        LancementPartieClass partie = new LancementPartieClass(Properties.Settings.Default.NbrM);

        public FrmManche()
        {
            InitializeComponent();
           
        }


        void GestionnaireMarche(EtatManche etatManche)
        {
            switch (etatManche)
            {
                case EtatManche.Debut:
                    foreach (Control button in panel1.Controls)
                    {
                        button.Enabled = true;
                    }
                    manche = partie.Manches[partie.NumeroMancheEnCours];
                    manche.MotADecouvrir = PiocheClass.ExtraireMot();
                    panel1.Enabled = true;
                    partie.NumeroMancheEnCours++;
                    manche.NbrErreur = 0;
                    manche.InitialiseMotEnCours();
                    txtAfficheMot.Text = manche.ChartoString(manche.MotEncours);
                    lblNbrEssai.Text = "Nombre d'essais restant : " + (9 - manche.NbrErreur);
                    txtNbrManches.Text = "Manche :" + (partie.NumeroMancheEnCours + "/" + partie.NombreManches );
                    manche.PartieLancer = true;
                    manche.AfficheChrono();
                    //manche.Chrono();
                    break;
                case EtatManche.Gagne:
                    panel1.Enabled = false;
                    if (manche.MancheGagne())
                    {
                        if (partie.NumeroMancheEnCours < partie.NombreManches)
                        {
                            MessageBox.Show("Félicitation vous avez trouvé le mot ! \r\n Votre score est "+ manche.CalculScoreManche() +"! \r\n Passez à la manche suivante.", "Manche gagné", MessageBoxButtons.OK);
                            txtAfficheMot.Text = string.Empty;
                            GestionnaireMarche(EtatManche.Debut);
                            manche.PartieLancer = false;
                        }

                        
                    }
                    break;
                case EtatManche.Perdu:
                    panel1.Enabled = false;
                    if (manche.ManchePerdue())
                    {
                        MessageBox.Show("Vous avez perdu :( !", "Partie perdue", MessageBoxButtons.OK);

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

        private void LettreSaise(object sender, EventArgs e)
        {
            Button btnGeneric = sender as Button;
            manche.Lettre = Convert.ToChar(btnGeneric.Text);
            txtAfficheMot.Text = manche.DecouvreMot();
            btnGeneric.Enabled = false;
            
                lblNbrEssai.Text = "Nombre d'essais restant : " + (9 - manche.NbrErreur);

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

