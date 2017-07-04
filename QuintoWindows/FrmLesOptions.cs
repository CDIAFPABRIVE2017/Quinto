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
    public partial class FrmLesOptions : Form
    {
       

        public FrmLesOptions()
        {
            InitializeComponent();
        }

        private void Enregistrer_Clk(object sender, EventArgs e)
        {           
            Properties.Settings.Default.Save();
            MessageBox.Show("Vos options ont bien été enregistrées.", "Information", MessageBoxButtons.OK);
        }
        enum ContextesOptionsNbrManches
        {
            Manches2 = 0,
            Manches3 = 1,
            Manches4 = 2,
            Manches5 = 3
        }

        //void GestionnaireNbrManches (ContextesOptionsNbrManches NbrManches)
        //{
        //    string textContexte = "";
        //    switch (NbrManches)
        //    {
        //        case ContextesOptionsNbrManches.Manches2:
        //            Properties.Settings.Default.NbrM = 2;
        //            textContexte = btn_2Manches.Text;
        //            break;
        //        case ContextesOptionsNbrManches.Manches3:
        //           //anche.NbrMancheMax = 3;
        //            textContexte = btn_3Manches.Text;
        //            break;
        //        case ContextesOptionsNbrManches.Manches4:
        //            manche.NbrMancheMax = 4;
        //            textContexte = btn_4Manches.Text;
        //            break;
        //        case ContextesOptionsNbrManches.Manches5:
        //            manche.NbrMancheMax = 5;
        //            textContexte = btn_5Manches.Text;
        //            break;
        //        default:
        //            break;
        //    }
            
        //}

        private void NbrManches_Changed(object sender, EventArgs e)
        {
            if (btn_2Manches.Checked)
            {
            //  GestionnaireNbrManches(ContextesOptionsNbrManches.Manches2);
                Properties.Settings.Default.NbrM = 2;
            }
            if (btn_3Manches.Checked)
            {
              //GestionnaireNbrManches(ContextesOptionsNbrManches.Manches3);
                Properties.Settings.Default.NbrM = 3;
            }
            if (btn_4Manches.Checked)
            {
           //   GestionnaireNbrManches(ContextesOptionsNbrManches.Manches4);
                Properties.Settings.Default.NbrM = 4;
            }
            if (btn_5Manches.Checked)
            {
              //GestionnaireNbrManches(ContextesOptionsNbrManches.Manches5);
                Properties.Settings.Default.NbrM = 5;
            }

            //Méthode Thomas qui fontionne aussi.
            //foreach (Control item in gbNbrManches.Controls)
            //{
            //    if (((RadioButton)item).Checked)
            //    {
            //        MessageBox.Show((string)item.Tag);
            //        GestionnaireNbrManches((ContextesOptionsNbrManches)(int.Parse((string)(item.Tag))));
            //    }
                   
            //}


        }

        private void LoadOptions(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.NbrM)
            {
                case 2:
                    btn_2Manches.Checked = true;

                    break;
                case 3:
                    btn_3Manches.Checked = true;
                    break;
                case 4:
                    btn_4Manches.Checked = true;
                    break;
                case 5:
                    btn_5Manches.Checked = true;
                    break;

                default:
                    break;
            }
        }
    }
}
