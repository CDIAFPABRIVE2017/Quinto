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
        LancementManche manche = new LancementManche();
        enum EtatManche
        {
            Debut = 0,
            Fin = 1,

        }
        enum Etatpartie
        {
            Debut = 0,
            Fin = 1,
        }
        public FrmPartie()
        {
            InitializeComponent();
        }

        void GestionnaireMarche(EtatManche etatManche)
        {
            switch (etatManche)
            {
                case EtatManche.Debut:
                    //txtAfficheMot.Text = manche.MotADecouvrir;
                    break;
                case EtatManche.Fin:
                    break;
                default:
                    break;
            }

        }
        private void lblChrono_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNbrManches_TextChanged(object sender, EventArgs e)
        {
            txtNbrManches.Text = ("Manche {0}/{1}");
        }

        private void Lettre(object sender, EventArgs e)
        {
            Button btnGeneric = sender as Button;
            manche.Lettre = btnGeneric.Text;

        }

        private void Partie_Load(object sender, EventArgs e)
        {
            GestionnaireMarche(EtatManche.Debut);
        }

        private void txtAfficheMot_TextChanged(object sender, EventArgs e)
        {
            txtAfficheMot.Text = manche.MotADecouvrir;
        }

    }
}
