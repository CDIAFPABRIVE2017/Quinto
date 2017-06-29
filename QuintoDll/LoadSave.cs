using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JeuQuintoDll
{
    [Serializable()]
    class LoadSave
    {
        static HashSet<string> listeMots = new HashSet<string>();
        static string mot;
        
     

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

        public void SaveText(string path, string motSaisie)
        {   //crée un nouveau dossier 
            FileStream listeMot = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            // Crée un StreaWriter pour écrire les variables ds le fichier txt
            StreamWriter nvxMot = new StreamWriter(listeMot);
         
            while (!string.IsNullOrEmpty(motSaisie))
            {
                nvxMot.WriteLine(motSaisie);
            }

            nvxMot.Close();
            listeMot.Close();


        }

        public static void TraitementTampon()
        {
            IsMotValid(mot);
            if(IsMotValid(mot))
            {
                mot = Normalization(mot).ToUpper();

                if (!listeMots.Contains(mot))
                { listeMots.Add(mot);
                  Console.WriteLine(mot);
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
