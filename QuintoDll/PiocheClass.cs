using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuintoDll
{
    public class PiocheClass
    {
        #region Méthodes
      
        static HashSet<string> listeMots = new HashSet<string>();
        
        //static string mot;

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

        public static void LoadPioche(string pathPioche)
        {
            if (File.Exists(pathPioche))
            {

           

            FileStream OuvreDico = new FileStream(pathPioche, FileMode.Open, FileAccess.Read);
            StreamReader AfficheDico = new StreamReader(OuvreDico, Encoding.UTF8);

            string mot = AfficheDico.ReadLine();


            while (!string.IsNullOrEmpty(mot))
            {
                listeMots.Add(mot);
                    mot = AfficheDico.ReadLine();
                }
            AfficheDico.Close();
            OuvreDico.Close();
            }
        }
        public static void SavePioche(string pathPioche)
        {
            FileStream listeMot = new FileStream(pathPioche, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter nvxMot = new StreamWriter(listeMot);

            foreach (string mot in listeMots)
            {
                nvxMot.WriteLine(mot);
            }

            nvxMot.Close();
            listeMot.Close();

        }
        public static string ExtraireMot()
        {
            Random rand = new Random();
            int randCount = rand.Next(0, listeMots.Count);
            int i = 0;
          
           return   listeMots.ElementAt(randCount);
               
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

        public static void AjouterMot(string mot)
        {
              // string motConverti = Normaliser(mot).ToUpper();

                //if (!listeMots.Contains(motConverti))
                //{
                listeMots.Add(mot);

            //    }
    

        }

        public static bool IsMotValid(string mot)
        {

        return (mot.Length >= 5 && mot.Length <= 25);
           

        }
    /// <summary>
    /// Transforme une chaine accentuée en chaine non accentuée
    /// </summary>
    /// <param name="mot"></param>
    /// <returns></returns>
        public static string Normaliser(string mot)
        {
        string motConverti = mot.Normalize(NormalizationForm.FormD);
        StringBuilder motCanonique = new StringBuilder();
        foreach (char caractere in motConverti)
        {
            if (char.IsLetter(caractere))
            {
                motCanonique.Append(caractere);
            }
        }
        return motCanonique.ToString();

    }

     

       

    }
    #endregion
}

