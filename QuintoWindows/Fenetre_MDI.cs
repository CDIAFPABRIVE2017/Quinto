﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuintoWindows
{
    public partial class FrmQuinto : Form
    {
        public FrmQuinto()
        {
            InitializeComponent();
        }

       

        private void btnScore_Click(object sender, EventArgs e)
        {
            FrmScores frmQuinto1 = new FrmScores();
            frmQuinto1.Show();
            DialogResult = DialogResult.Cancel;
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            FrmOptions fOptions = new FrmOptions();
            fOptions.Show();
        }

        private void btnAlimenterPioche_Click(object sender, EventArgs e)
        {
            FrmPioche fPioche = new FrmPioche();
            fPioche.Show();
        }
    }
}
