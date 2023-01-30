using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPiraterie
{
    public class NavireMarchand : Navire
    {
        public NavireMarchand(int absissa, int ordered, int flag) : base(absissa, ordered, flag)
        {
            RAYON_RENCONTRE = 20;
        }

        public override string Nom()
        {
            return base.Nom() + "marchand";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
