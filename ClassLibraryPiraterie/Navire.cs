using System.Drawing;

namespace ClassLibraryPiraterie
{
    public abstract class Navire
    {
        #region Constructeur
        /// <summary>
        /// Constructeur du Navire
        /// </summary>
        /// <param name="abscissa"></param>
        /// <param name="ordered"></param>
        /// <param name="flag"></param>
        public Navire(int abscissa, int ordered, int flag)
        {
            Abscissa = abscissa;
            Ordered = ordered;
            Flag = flag;
            RAYON_RENCONTRE = 20;
        } 
        #endregion
        #region props
        /// <summary>
        /// Abscisse
        /// </summary>
        public int Abscissa { get; protected set; }
        /// <summary>
        /// Ordonée
        /// </summary>
        public int Ordered { get; protected set; }
        /// <summary>
        /// Drapeau
        /// </summary>
        public int Flag { get; protected set; }
        /// <summary>
        /// Detruit ou non (bool)
        /// </summary>
        public bool IsDestroyed { get; protected set; }
        /// <summary>
        /// Constante pour distance minimal pour la rencontre
        /// </summary>
        public int RAYON_RENCONTRE { get; protected set; } 
        #endregion
        #region Methode
        /// <summary>
        /// Methode qui calcule la distance entre 2 navires
        /// </summary>
        /// <param name="ship"></param>
        /// <returns></returns>
        public double Distance(Navire ship)
        {
            return Math.Sqrt(Math.Pow(Abscissa - ship.Abscissa, 2) + Math.Pow(Ordered - ship.Ordered, 2));
        }
        /// <summary>
        /// Methode qui permet de faire bouger les navires
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Avance(int x, int y)
        {
            Abscissa += x;
            Ordered += y;
        }
        /// <summary>
        /// Methode abstraite pour indiquer l'état
        /// </summary>
        /// <returns></returns>
        public abstract string Etat();
        /// <summary>
        /// Methode qui permet de signifier qu'un navire est coulé
        /// </summary>
        /// <returns></returns>
        public bool Coule()
        {
            return IsDestroyed = true;
        }
        /// <summary>
        /// Indique le nom du navire
        /// </summary>
        /// <returns></returns>
        public virtual string Nom()
        {
            return "Bateau";
        }
        /// <summary>
        /// indique toutes les caractéristique du navire
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Nom()} avec drapeau {Flag} en ({Abscissa},{Ordered}) - Il est {Etat()}";
        }
        /// <summary>
        /// Methode abstraite de verification de la rencontre
        /// </summary>
        /// <param name="navire"></param>
        public abstract void Rencontre(Navire navire);
        /// <summary>
        /// Permet de voir si un navire est pacifique
        /// </summary>
        /// <param name="navire"></param>
        /// <returns></returns>
        public bool EstPacifique(Navire navire)
        {
            if (navire is Pirate)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Permet de savoir le "type" du navire
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Pirate)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methode abstrait de reception de boulet
        /// </summary>
        public abstract void RecoitBoulet(); 
        #endregion
    }
}