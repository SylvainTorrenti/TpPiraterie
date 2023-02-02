using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPiraterie
{
    public class Pirate : Navire
    {
        #region Props
        /// <summary>
        /// Est endommager (bool)
        /// </summary>
        public bool EstEndommage { get; private set; } 
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="absissa"></param>
        /// <param name="ordered"></param>
        /// <param name="flag"></param>
        /// <param name="damage"></param>
        public Pirate(int absissa, int ordered, int flag, bool damage) : base(absissa, ordered, flag)
        {
            EstEndommage = damage;
            RAYON_RENCONTRE = 20;
        } 
        #endregion
        #region methode
        /// <summary>
        /// Indique le nom
        /// </summary>
        /// <returns></returns>
        public override string Nom()
        {
            return base.Nom() + "pirate";
        }
        /// <summary>
        /// Indique l'état
        /// </summary>
        /// <returns></returns>
        public override string Etat()
        {
            if (IsDestroyed == true)
            {
                return "Coulé";
            }
            else if (EstEndommage == true)
            {
                return "Endommagé";
            }
            return "Intact";
        }
        /// <summary>
        /// affiche toutes les caractériqtique du navire
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Nom()} avec drapeau {Flag} en ({Abscissa},{Ordered}) - Il est {Etat()}";
        }
        /// <summary>
        /// indique comment un combat se resoud
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
        /// indique si une rencontre à lieu
        /// </summary>
        /// <param name="navire"></param>
        public override void Rencontre(Navire navire)
        {
            if (Distance(navire) < RAYON_RENCONTRE)
            {
                if (Flag != navire.Flag)
                {
                    Combat(navire);
                }
            }
        }
        /// <summary>
        /// indique la maniére dont le boulet est pris
        /// </summary>
        public override void RecoitBoulet()
        {
            if (EstEndommage == true)
            {
                IsDestroyed = true;
            }
            else
            {
                EstEndommage = true;
            }
        } 
#endregion
    }
}
