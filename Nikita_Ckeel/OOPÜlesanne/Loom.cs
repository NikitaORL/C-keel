using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.OOPÜlesanne
{
    internal class Loom
    {
        public string Nimi { get; }
        public string Tüüp { get; }
        public string Värv { get; }

        public Loom(string nimi, string tüüp, string värv)
        {
            Nimi = nimi;
            Tüüp = tüüp;
            Värv = värv;
        }

        public void NäitaInfo()
        {
            Console.WriteLine($"Nimi: {Nimi}");
            Console.WriteLine($"Tüüp: {Tüüp}");
            Console.WriteLine($"Värv: {Värv}");
        }
    }
}