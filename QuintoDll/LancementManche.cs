using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using QuintoWindows;

namespace QuintoDll
{
    public enum EtatManche
    {
        Debut = 0,
        Gagne = 1,
        Perdu = 2,
    }
    //public enum Etatpartie
    //{
    //    Debut = 0,
    //    Fin = 1,
    //}
    public class LancementManche
    {
        #region champs
        int nbrErreur;
        int mancheEnCours;
        int nbrMancheMax;
        EtatManche etat;
        DateTime debut = new DateTime();
        DateTime fin = new DateTime();
        Stopwatch chrono = new Stopwatch();
        string motADecouvrir;
        char[] motEncours;
        char lettre;
        bool _addErreur;
        #endregion

        public LancementManche()
        {
            etat = EtatManche.Debut;
            motADecouvrir = PiocheClass.ExtraireMot();
            InitialiseMotEnCours();
        }


        #region Propiréié
        public string MotADecouvrir
        {
            get
            {
                return motADecouvrir;
            }
        }

        public char Lettre
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

        public EtatManche Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
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


        public string InitialiseMotEnCours()
        {
            motEncours = new char[MotADecouvrir.Length];
            for (int i = 0; i < MotADecouvrir.Length; i++)
            {
                motEncours[i] = '_';
            }

            return new string(motEncours);
        }

        public string DecouvreMot()
        {

            for (int i = 0; i < MotADecouvrir.Length; i++)
            {
                if (motADecouvrir[i] == Lettre)
                {
                    motEncours[i] = Lettre;
                }
            }
            return new string(MotEncours);
        }

        public string ChartoString(char[] mot)
        {
            string retour = string.Empty;
            foreach (char item in mot)
            {
                retour += item;
            }
            return retour;
        }

        public bool AddErreur()
        {
            for (int i = 0; i < MotADecouvrir.Length; i++)
            {
                if (motADecouvrir[i] == Lettre)
                {
                    return false;
                }

            }
            return true;
        }
        public bool MancheGagne()
        {
            if (ChartoString(MotEncours) == MotADecouvrir && NbrErreur < 9)
            {
                return true;
            }

            else return false;
        }

        public bool ManchePerdue()
        {
            if (NbrErreur >= 9)
            {
                return true;
            }
            else return false;
        }



    }
}




