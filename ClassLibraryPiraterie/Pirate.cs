using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPiraterie
{
    public class Pirate : Navire
    {

        public bool EstEndommage { get;private set; }

        public Pirate(int absissa, int ordered, int flag, bool damage) : base(absissa, ordered, flag)
        {
            EstEndommage = damage;
            RAYON_RENCONTRE = 20;
        }
        public override string Nom()
        {
            return base.Nom() + "pirate";
        }

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

        public override string? ToString()
        {
            return $"{Nom()} avec drapeau {Flag} en ({Abscissa},{Ordered}) - Il est {Etat()}";
        }
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
    }
}
