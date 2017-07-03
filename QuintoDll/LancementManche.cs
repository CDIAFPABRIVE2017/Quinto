using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuintoDll
{
    public enum EtatManche
    {
        Debut = 0,
        Fin = 1,

    }
    public enum Etatpartie
    {
        Debut = 0,
        Fin = 1,
    }
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
        string lettre;
        #endregion

        public LancementManche()
        {
            NbrErreur = 0;
            etat = EtatManche.Debut;
            motADecouvrir = PiocheClass.ExtraireMot();
            InitialiseMotEnCours();
            AfficheUnderscore();


        }
        #region Propiréié
        public string MotADecouvrir
        {

            get
            {
                return motADecouvrir;
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
                InitialiseMotEnCours();
                return motEncours;
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
                motEncours[i] = MotADecouvrir[i];
            }

            return new string(motEncours);
        }

        public string AfficheUnderscore()
        {
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
                if (motADecouvrir[i] == Lettre[0])
                {
                    motEncours[i] = Lettre[0];
                }
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

            }
            return false;
        }
        public bool MancheGagne()
        {
            if (MotEncours.ToString() == MotADecouvrir && NbrErreur <= 9)
            {
                return true;
            }

            //if (NbrErreur < 9)

            else return false;



        }

    }
}




