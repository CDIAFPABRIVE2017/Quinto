using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuintoDll;
using QuintoWindows;


namespace QuintoDll
{
   public class LancementPartieClass 
    {
        int _nombreManches;
        LancementManche[] _manches;
        int _numeroMancheEnCours;
        int scoreTotal;

        public int NombreManches
        {
            get
            {
                return _nombreManches;
            }

          
        }

        public int ScoreTotal
        {
            get
            {
                return scoreTotal;
            }

            
        }

        public int NumeroMancheEnCours
        {
            get
            {
                return _numeroMancheEnCours;
            }

            set
            {
                _numeroMancheEnCours = value;
            }
        }

        public LancementManche[] Manches
        {
            get
            {
                return _manches;
            }

            set
            {
                _manches = value;
            }
        }

        #region Méthodes

        //LancementPartie
        public  LancementPartieClass(int nombreManches)
        {
            _nombreManches = nombreManches;
            Manches = new LancementManche[nombreManches];
            for (int i = 0; i < _nombreManches; i++)
            {
                Manches[i] = new LancementManche();
            }
            NumeroMancheEnCours = 0;

        }

        //CalculDesScores
        //public static double CalculScoreTotal(double scoreManche)
        //{
        //  //  return TotalDesManches / NombreDeManches)
            

        //}

        //public LancementPartieClass()
        //{
        //    for (int i = 0; i < 2; i++)
        //    {

        //    }
        //}

        #endregion




    }
}
