using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuintoDll
{
    public class LancementManche
    {
      
        bool partielancer = true;

        int nbrErreur;
        int mancheEnCours;
        int nbrMancheMax;
        DateTime debut = new DateTime();
        DateTime fin = new DateTime();
        Stopwatch chrono = new Stopwatch();
        string motADecouvrir;
        char[] motEncours;
        string lettre;

        #region Propiréié
        public string MotADecouvrir
        {

            get
            {

                return ExtraireMot(LoadSave.ListeMots);

            }
        }

        public string Lettre
        {
            get
            {
                return lettre;
            }

            set
            {
                lettre = value;
            }
        }

        public char[] MotEncours
        {
            get
            {
                return motEncours;
            }

            set
            {
                AfficheUnderscore();
                motEncours = value;
            }
        }

        #endregion
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
        public string ExtraireMot(HashSet<string> s)
        {
            Random rand = new Random();
            int randCount = rand.Next(0, s.Count);
            int i = 0;
            foreach (string mot in s)
            {
                if (i == randCount)
                {
                    return mot;
                }
                i++;
            }
            return null;
        }


     public string AfficheUnderscore()
    {
        for (int i = 0; i < motADecouvrir.Length; i++)
        {
            motEncours[i] = '_';
        }
        return new string(motEncours);
    }

    public string DecouvreMot()
    {

        foreach (char i in motEncours)
        {
            if (motEncours[i].ToString() == Lettre)
            {
                motEncours[i] = Lettre[0];
            }
        }
        return new string(motEncours);
    }
     

      

    }
}
      
   


