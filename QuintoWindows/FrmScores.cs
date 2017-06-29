using System;
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
    public partial class FrmScores : Form
    {
        public FrmScores()
        {
            InitializeComponent();
        }
        private void Scores_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Items.Add("joe").SubItems.Add(" 32");
            listView1.Items.Add("Lamia").SubItems.Add("21");
            listView1.Items.Add("Précilia").SubItems.Add("2");
        }
    }
}
