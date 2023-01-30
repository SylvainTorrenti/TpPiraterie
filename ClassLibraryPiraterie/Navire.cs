﻿using System.Drawing;

namespace ClassLibraryPiraterie
{
    public class Navire
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
        public virtual string Etat()
        {
            if (IsDestroyed == true)
            {
                return "Coulé";
            }
            return "Intact";
        }
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
        public virtual void Rencontre(Navire navire)
        {
            if (Distance(navire) < RAYON_RENCONTRE)
            {
                if (Flag != navire.Flag)
                {
                    Combat(navire);
                }
            }
        }
        public bool EstPacifique(Navire navire)
        {
            if (navire )
            {

            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}