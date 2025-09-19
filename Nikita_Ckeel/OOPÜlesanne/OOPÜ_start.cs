using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.OOPÜlesanne
{
    internal class OOPÜ_start
    {
        public static void Main(string[] args)
        {
            Loom loom1 = new Loom("Murka", "Kass", "Valge"); 
            Loom loom2 = new Loom("Rex", "Koer", "Must");
            Loom loom3 = new Loom("Pelu", "Kanarik", "Kollane");

            loom1.NäitaInfo();
            loom2.NäitaInfo();
            loom3.NäitaInfo();
        }
    }
}