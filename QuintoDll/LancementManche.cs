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
        char lettre;
        bool _addErreur;
        #endregion

        public LancementManche()
        {
            NbrErreur = 0;
            etat = EtatManche.Debut;
            motADecouvrir = PiocheClass.ExtraireMot();
            InitialiseMotEnCours();
            //AddErreur();
            MancheGagne();
            ManchePerdue();
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
                if (_addErreur)
                {
                    nbrErreur++;
                }
                nbrErreur = value;
            }
        }

        public int MancheEnCours
        {
            get
            {
                return 1 /*mancheEnCours*/;
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
                return 5;
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
            _addErreur = true;
            for (int i = 0; i < MotADecouvrir.Length; i++)
            {
                if (motADecouvrir[i] == Lettre)
                {
                    motEncours[i] = Lettre;
                    _addErreur = false; 
                }
            }
            return new string(MotEncours);
        }

        //public bool AddErreur()
        //{
        //    for (int i = 0; i < MotADecouvrir.Length; i++)
        //    {
        //        if (motADecouvrir[i] == Lettre)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}
        public bool MancheGagne()
        {
            if (MotEncours.ToString() == MotADecouvrir && NbrErreur <= 9)
            {
                return true;
            }

            else return false;
        }

        public bool ManchePerdue()
        {
            if (nbrErreur < 9)
            {
                return true;
            }
            else return false;
        }



    }
}




