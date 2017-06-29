using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace QuintoWindows
{
    public class Score
    {
        #region Champs privés

        private int _Score1;
        private string _joueur = string.Empty;

        public string Joueur
        {
            get
            {
                return _joueur;
            }

            set
            {
                _joueur = value;
            }
        }

        public int score
        {
            get
            {
                return _Score1;
            }

            set
            {
                _Score1 = value;
            }
        }

        #endregion


        //private void ChargerJoueur()
        //{
        //    Joueurs = new Joueurs();
        //    ISauvegarde serialiseur = gestion_joueurs.DispositifSauvegarde;
        //    Joueurs.Load(serialiseur, Properties.Settings.Default.AppData);
        //    //foreach (gagnant item in joueurs)
        //    //{
        //    //    cbChoisirSalarie.Items.Add(item.Matricule);
        //    //}
        //}


        ///// <summary>
        ///// Sauvegarde
        ///// </summary>
        ///// <param name="sauvegarde"></param>
        ///// <param name="pathRepData"></param>
        //public void Save(ISauvegarde sauvegarde, string pathRepData)
        //{
        //    sauvegarde.Save(pathRepData, this);
        //}

        //public void Load(ISauvegarde sauvegarde, string pathRepData)
        //{
        //    this.SymmetricExceptWith((Joueurs)sauvegarde.Load(pathRepData, this.GetType()));
        //}













        //#region Evenements
        ///// <summary>
        ///// Evenement sur changement de joueur
        ///// </summary>
        //public event EventHandler<ChangementJoueur> ChangementSalaire;
        //#endregion
        ///// <summary>
        ///// Sauvegarde
        ///// </summary>
        ///// <param name="sauvegarde"></param>
        ///// <param name="pathRepData"></param>
        //public void Save(ISauvegarde sauvegarde, string pathRepData)
        //{
        //    sauvegarde.Save(pathRepData, this);
        //}

        //public void Load(ISauvegarde sauvegarde, string pathRepData)
        //{
        //    this.SymmetricExceptWith(()sauvegarde.Load(pathRepData, this.GetType()));
        //}

    }
}
