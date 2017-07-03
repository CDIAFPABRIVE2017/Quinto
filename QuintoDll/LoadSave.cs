using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuintoDll
{
    [Serializable()]
    public static class LoadSave
    {
        static HashSet<string> listeMots = new HashSet<string>();
        static HashSet<string> listeIntermediaire = new HashSet<string>();
        static string mot;

        public static HashSet<string> ListeMots
        {
            get
            {
                return listeMots;
            }

            //set
            //{
            //    listeMots = value;
            //}
        }

        public static void SaveListe (string pathEcriture)
        {
            FileStream listeMot = new FileStream(pathEcriture, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter nvxMot = new StreamWriter(listeMot);

            foreach (string mot in listeMots)
            {
                nvxMot.WriteLine(mot);
            }

            nvxMot.Close();
            listeMot.Close();

        }
        public static void LoadText(string path)
        {
          
            FileStream OuvreDico = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader AfficheDico = new StreamReader(OuvreDico, Encoding.UTF8);

            string ligne = AfficheDico.ReadLine();

            
            while (!string.IsNullOrEmpty(ligne))
            {
                IsLettre(ligne);

                ligne = AfficheDico.ReadLine();
            }
            AfficheDico.Close();
            OuvreDico.Close();
        }

        //public static void SaveText(string pathEcriture, string motSaisie)
        //{
        //    FileStream listeMot = new FileStream(pathEcriture , FileMode.Open, FileAccess.ReadWrite);
        //    StreamWriter nvxMot = new StreamWriter(listeMot);
         
        //    while (!string.IsNullOrEmpty(motSaisie))
        //    {
        //        nvxMot.WriteLine(motSaisie);
        //    }

        //    nvxMot.Close();
        //    listeMot.Close();


        //}

        public static void TraitementTampon()
        {
            IsMotValid(mot);
            if(IsMotValid(mot))
            {
                mot = Normalization(mot).ToUpper();

                if (!ListeMots.Contains(mot))
                { ListeMots.Add(mot);

                }                
            }
                  
        }

        public static bool IsMotValid(string mot)
        {
           
            if ((mot.Length >= 5 && mot.Length <= 25))
            {
                return true;
          
            }
            else return false;

        }
        
        public static string Normalization (string mot)
        {
            mot = mot.Normalize(NormalizationForm.FormD);
            string motConverti = String.Empty;
            foreach (char caractere in mot)
            {
                if (char.IsLetter(caractere))
                {
                    motConverti += (caractere.ToString());
                }
            }
            mot = motConverti;
            return mot;
            
        }

        public static void IsLettre(string ligne)
        {
            string tampon = string.Empty;
            for (int i = 0; i < ligne.Length; i++)
            {
                if (!char.IsLetter(ligne[i]))
                {
                    if (tampon != "")
                    {
                        mot = tampon;
                        TraitementTampon();
                        tampon = string.Empty;
                    }
                }
                else
                {
                    tampon += (ligne[i]);
                }
                if(i == ligne.Length-1)
                {
                    if (tampon != "")
                    {
                        mot = tampon;
                        TraitementTampon();
                        tampon = string.Empty;
                    }
                }
            }
        }

        //new public void Add(mot)
        //{
        //    if (!listeMots.Contains(mot))
        //    { listeMots.Add(mot); }
        //}

    }
}
