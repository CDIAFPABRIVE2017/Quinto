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

namespace QuintoWindows
{
    public partial class FrmPartie : Form
    {

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
            //switch (etatManche)
            //{
            //    case EtatManche.Debut:


            //}

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

        }

       
    }
}
