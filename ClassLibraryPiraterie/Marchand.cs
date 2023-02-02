using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPiraterie
{
    public class Marchand : Navire
    {
        #region Constructeur
        /// <summary>
        /// Constructeur du navire marchand
        /// </summary>
        /// <param name="absissa"></param>
        /// <param name="ordered"></param>
        /// <param name="flag"></param>
        public Marchand(int absissa, int ordered, int flag) : base(absissa, ordered, flag)
        {
            RAYON_RENCONTRE = 20;
        }
        #endregion
        #region Methode
        /// <summary>
        /// Methode pour changer son état
        /// </summary>
        /// <returns></returns>
        public override string Etat()
        {
            if (IsDestroyed == true)
            {
                return "Coulé";
            }
            return "Intact";
        }
        /// <summary>
        /// Methode de recevoir un boulet
        /// </summary>
        public override void RecoitBoulet()
        {
            IsDestroyed = true;
        }
        /// <summary>
        /// Methode pour afficher le nom
        /// </summary>
        /// <returns></returns>
        public override string Nom()
        {
            return base.Nom() + "marchand";
        }
        /// <summary>
        /// Methode pour afficher toutes les informations du navire
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// Methode si un combat est declenché
        /// </summary>
        /// <param name="navire"></param>
        public void Combat(Navire navire)
        {
            if (navire is Pirate)
            {
                RecoitBoulet();
                navire.RecoitBoulet();
            }
            else
            {
                navire.RecoitBoulet();
                navire.Coule();
            }
        }
        /// <summary>
        /// Methode qui verifie si une rencontre a lieu
        /// </summary>
        /// <param name="navire"></param>
        public override void Rencontre(Navire navire)
        {
            if (Distance(navire) < RAYON_RENCONTRE)
            {
                if (Flag != navire.Flag)
                {
                    if (!(EstPacifique(navire)))
                    {
                        Combat(navire);
                    }

                }
            }
        }
        #endregion
    } 
    
}
