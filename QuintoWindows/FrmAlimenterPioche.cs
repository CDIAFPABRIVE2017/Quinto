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
using System.IO;

namespace QuintoWindows
{
    public partial class FrmAlimenterPioche : Form
    {

        public FrmAlimenterPioche()
        {
            InitializeComponent();
            lbPioche.Sorted = true;
        }


        PiocheClass AjoutMot = new PiocheClass();

        private void Ajout_Clk(object sender, EventArgs e)
        {
            //if(txtAjout.Text == "")
            //{
            //    string s = (string)lbPoubelle.SelectedItem;
            //    lbPioche.Items.Add(s);
            //    lbPoubelle.Items.Remove(s);
            //}
            if (txtAjout.Text != "")
            {
                if (PiocheClass.IsMotValid(txtAjout.Text))
                {
                    string motConverti = PiocheClass.Normaliser(txtAjout.Text).ToUpper();
                    if (!estPresent(motConverti))
                        lbPioche.Items.Add(motConverti);
                    
                    txtAjout.Clear();
                    txtAjout.Focus();
                }

                else
                {
                    error.SetError(txtAjout, "Le mot que vous avez entré n'est pas valide.");
                    // txtAjout.Clear();
                    txtAjout.Focus();
                }
            }

            //Méthode save dans dico à appeler 
            //Fichiertxt.Add
        }

        private void Retirer_Clk(object sender, EventArgs e)
        {
            string s = (string)lbPioche.SelectedItem;
            lbPoubelle.Items.Add(s);
            lbPioche.Items.Remove(s);

        }



        private void ouvrirFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = ofdSource.ShowDialog();
            if (res == DialogResult.OK)
            {
              LoadText(ofdSource.FileName);
            }
        }
        private void LoadText(string path)
        {

            FileStream OuvreDico = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader AfficheDico = new StreamReader(OuvreDico, Encoding.UTF8);

            string ligne = AfficheDico.ReadLine();


            while (!string.IsNullOrEmpty(ligne))
            {
                AjoutPhrase(ligne);

                ligne = AfficheDico.ReadLine();
            }
          
            AfficheDico.Close();
            OuvreDico.Close();
        }
        private  void AjoutPhrase(string ligne)
        {
            string tampon = string.Empty;
            for (int i = 0; i < ligne.Length; i++)
            {
                if (!char.IsLetter(ligne[i]))
                {
                    if (tampon != "")
                    {
                        if (PiocheClass.IsMotValid(tampon))
                        {
                            string motConverti = PiocheClass.Normaliser(tampon).ToUpper();
                            if (!estPresent(motConverti))
                            lbPioche.Items.Add(motConverti);
                        }

                        tampon = string.Empty;
                    }
                }
                else
                {
                    tampon += (ligne[i]);
                }
            }

            if (tampon != "")
            {
                if (PiocheClass.IsMotValid(tampon))
                {
                    string motConverti = PiocheClass.Normaliser(tampon).ToUpper();
                    if (!estPresent(motConverti))
                        lbPioche.Items.Add(motConverti);
                }

                tampon = string.Empty;
            }


        }
        private bool estPresent(string mot)
        {
            foreach (var item in lbPioche.Items)
            {
                if (item.ToString()==mot)
                {
                    return true;
                }
            }
            return false;

        }

        private void btnAlimenterPioche_Click(object sender, EventArgs e)
        {
            foreach (var item in lbPioche.Items)
            {
                PiocheClass.AjouterMot(item.ToString());

            }
            PiocheClass.SavePioche(QuintoWindows.Properties.Settings.Default.pathPioche);
        }
    }


}
