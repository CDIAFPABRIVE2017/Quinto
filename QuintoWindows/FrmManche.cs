﻿using System;
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
                    manche.NbrErreur = 0;
                    txtAfficheMot.Text = ChartoString(manche.MotEncours);
                    lblNbrEssai.Text = "Nombre d'essais restant : " + (9 - manche.NbrErreur);
                    txtNbrManches.Text = "Manche :" + (manche.MancheEnCours + "/" + manche.NbrMancheMax);
                    break;
                case EtatManche.Fin:
                    panel1.Enabled = false;
                    if (manche.MancheGagne())
                    {
                        MessageBox.Show("Félicitation vous avez trouvé le mot ! \r\n Passez à la manche suivante.", "Manche gagné", MessageBoxButtons.OK);
                    }
                    if (manche.ManchePerdue())
                    {
                        MessageBox.Show("Vous avez perdu :( !", "Partie perdue", MessageBoxButtons.OK);
                    }
                    break;
                default:
                    break;
            }

        }

        private string ChartoString(char[] mot)
        {
            string retour = string.Empty;
            foreach (char item in mot)
            {
                retour += item;
            }
            return retour;
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

        private void Lettre(object sender, EventArgs e)
        {
            Button btnGeneric = sender as Button;
            manche.Lettre = Convert.ToChar(btnGeneric.Text);
            txtAfficheMot.Text = manche.DecouvreMot();
            btnGeneric.Enabled = false;

        }

        private void txtAfficheMot_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

