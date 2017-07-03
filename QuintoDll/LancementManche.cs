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
        #region champs
                int nbrErreur;
                int mancheEnCours;
                int nbrMancheMax;
                DateTime debut = new DateTime();
                DateTime fin = new DateTime();
                Stopwatch chrono = new Stopwatch();
                string motADecouvrir;
                char[] motEncours;
                string lettre;
        #endregion

        #region Propiréié
        public string MotADecouvrir
        {

            get
            {
                return "bonjour";
                //return ExtraireMot(LoadSave.ListeMots);
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
                for (int i =0; i < MotADecouvrir.Length; i++)
                {
                    motEncours[i] = MotADecouvrir[i];
                }
                motEncours = value;
            }
        }

        public int NbrErreur
        {
            get
            {
                return nbrErreur;
            }

            set
            {
                nbrErreur = value;
            }
        }

        public int MancheEnCours
        {
            get
            {
                return mancheEnCours;
            }

            set
            {
                mancheEnCours = value;
            }
        }

        public int NbrMancheMax
        {
            get
            {
                return nbrMancheMax;
            }

            set
            {
                nbrMancheMax = value;
            }
        }



        #endregion
        //public void AfficheChrono()
        //{


        //    if (partielancer)
        //    {
        //        chrono.Start();
        //    }

        //    if (partielancer == false)
        //    {
        //        chrono.Stop();
        //        TimeSpan ts = chrono.Elapsed;
        //    }
        //}
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
        for (int i = 0; i < MotADecouvrir.Length; i++)
        {
            MotEncours[i] = '_';
        }
        return new string(motEncours);
    }

    public string DecouvreMot()
    {

        foreach (char i in MotEncours)
        {
                if (MotEncours[i].ToString() == Lettre)
                {
                    MotEncours[i] = Lettre[0];
                }
                else NbrErreur++;
        }
        return new string(motEncours);
    }

        public bool AddErreur()
        {
            foreach (char i in MotEncours)
            {
                if (MotEncours[i].ToString() != Lettre)
                {
                    return true;
                }
                
            }return false;
        }
        public bool MancheGagne()
        {
            if (MotEncours[] == MotADecouvrir && NbrErreur <= 9)
            {
                return true;
            }

            if (NbrErreur < 9)
            { 
            else return false;
            }
        }
    }
}
      
   


