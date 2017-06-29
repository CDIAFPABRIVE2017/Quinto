using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoDll
{
    public class PiocheClass
    {
        #region Méthodes
        public static string IsMotValid(string mot)
        {                 
            if ((mot.Length >= 5 && mot.Length <= 25))
            {
                mot = mot.Normalize(NormalizationForm.FormD);
                StringBuilder motCanonique = new StringBuilder();
                foreach (char caractere in mot)
                {
                    if (char.IsLetter(caractere))
                    {
                        motCanonique.Append(caractere);
                    }
                }  
                mot =  motCanonique.ToString().ToUpper();
                return mot;              
            }           
            return string.Empty;         
        }      
        #endregion
    }
}
