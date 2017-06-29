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
    public partial class FrmPioche : Form
    {
        
        public FrmPioche()
        {
            InitializeComponent();
        }
        PiocheClass AjoutMot = new PiocheClass();
        
        private void Ajout_Clk(object sender, EventArgs e)
        {
            if(txtAjout.Text == "")
            {
                string s = (string)lbPoubelle.SelectedItem;
                lbPioche.Items.Add(s);
                lbPoubelle.Items.Remove(s);
            }
            if(txtAjout.Text != "")
            {
                string saisie = PiocheClass.IsMotValid(txtAjout.Text);
                if (saisie == "")
                {
                    error.SetError(txtAjout, "Le mot que vous avez entré n'est pas valide.");
                    txtAjout.Clear();
                    txtAjout.Focus();
                }
                else
                {
                    lbPioche.Items.Add(saisie);
                    txtAjout.Clear();
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
    }
        
            
}
                
            



