using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuintoDll;

namespace QuintoWindows
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PiocheClass.LoadPioche(Properties.Settings.Default.pathPioche);
            
          
            Application.Run(new FrmQuinto());
        }
    }
}
