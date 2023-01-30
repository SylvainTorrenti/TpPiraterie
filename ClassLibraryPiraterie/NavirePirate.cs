using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPiraterie
{
    public class NavirePirate : Navire
    {

        public bool EstEndommage { get;private set; }

        public NavirePirate(int absissa, int ordered, int flag, bool damage) : base(absissa, ordered, flag)
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

        }

        public override void RecoitBoulet()
        {
            base.RecoitBoulet();
        }
    }
}
