using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JeuQuintoDll
{
    class LancementPartie
    {
        bool partielancer = true;

        int nbrErreur;
        int mancheEnCours;
        int nbrMancheMax;
        DateTime debut = new DateTime();
        DateTime fin = new DateTime();
        Stopwatch chrono = new Stopwatch();
        string motADecouvrir;
        string tampon;
        char[] motEncours;

        public string MotADecouvrir
        {
            get
            {
                return motADecouvrir;
            }

            set
            {
                motADecouvrir =  
                motADecouvrir = value;
            }
        }

        public void AfficheChrono()
        {
            

            if (partielancer)
            {
                chrono.Start();
                //Thread.Sleep(10000);
            }

            if (partielancer == false)
            {
                chrono.Stop();
                TimeSpan ts = chrono.Elapsed;
            }
        }
    }
}
