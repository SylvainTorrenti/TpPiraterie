using System.Drawing;

namespace ClassLibraryPiraterie
{
    public abstract class Navire
    {
        public Navire(int abscissa, int ordered, int flag)
        {
            Abscissa = abscissa;
            Ordered = ordered;
            Flag = flag;
            RAYON_RENCONTRE = 20;
        }

        public int Abscissa { get; protected set; }
        public int Ordered { get; protected set; }
        public int Flag { get; protected set; }
        public bool IsDestroyed { get; protected set; }
        public int RAYON_RENCONTRE { get; protected set; }

        public double Distance (Navire ship)
        {
            return Math.Sqrt(Math.Pow(Abscissa - ship.Abscissa, 2) + Math.Pow(Ordered - ship.Ordered, 2));
        }
        public void Avance(int x,int y)
        {
            Abscissa += x;
            Ordered += y;
        }
        public abstract string Etat();
        public bool Coule()
        {
            return IsDestroyed = true;
        }
        public virtual string Nom()
        {
            return "Bateau";
        }

        public override string? ToString()
        {
            return $"{Nom()} avec drapeau {Flag} en ({Abscissa},{Ordered}) - Il est {Etat()}";
        }
        public abstract void Rencontre(Navire navire);
               
        public bool EstPacifique(Navire navire)
        {
            if (navire is Pirate)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Pirate)
            {
                return false;
            }
            return true;
        }
        public abstract void RecoitBoulet();
    }
}