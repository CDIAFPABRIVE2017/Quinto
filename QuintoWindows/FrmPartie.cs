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
            string Lettrebtn;
            Button btnGeneric = sender as Button;
            Lettrebtn = btnGeneric.Text;
           
        }

        private void Partie_Load(object sender, EventArgs e)
        {
            ChargerPartie();

        }

        private void ChargerPartie()
        {
            
        }

       
    }
}
