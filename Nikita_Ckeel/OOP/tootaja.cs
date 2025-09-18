using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.OOP
{
    internal class Töötaja : Inimine
    {
        public string Ametikoht;

        public Töötaja(string nimi, int vanus, string ametikoht) : base(nimi, vanus)
        {
            Ametikoht = ametikoht;
        }

        public new void Tervita()
        {
            Console.WriteLine($"Tere! Mina olen {Nimi}, ma olen {Vanus} aastat vana ja töötan {Ametikoht}.");
        }

        public void Töötan()
        {
            Console.WriteLine($"Ma töötan {Ametikoht}.");
        }
    }
}