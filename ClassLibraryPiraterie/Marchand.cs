using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPiraterie
{
    public class Marchand : Navire
    {
        public Marchand(int absissa, int ordered, int flag) : base(absissa, ordered, flag)
        {
            RAYON_RENCONTRE = 20;
        }
        public override string Etat()
        {
            if (IsDestroyed == true)
            {
                return "Coulé";
            }
            return "Intact";
        }
        public override void RecoitBoulet()
        {
                IsDestroyed = true;
        }
        public override string Nom()
        {
            return base.Nom() + "marchand";
        }

        public override string? ToString()
        {
            return base.ToString();
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
                    if (!(EstPacifique(navire)))
                    {
                        Combat(navire);
                    }

                }
            }
        }
    }
}
