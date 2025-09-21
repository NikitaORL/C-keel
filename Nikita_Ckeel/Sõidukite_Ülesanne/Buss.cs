using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.Sõidukite_Ülesanne
{
    public class Buss : ISõiduk
    {
        private string Nimi;
        private double Kulu;  // л/100км
        private double Km;
        private int reisijad;

        public Buss(string nimi, double kulu, double km, int reisijad)
        {
            Nimi = nimi;
            Kulu = kulu;
            Km = km;
            reisijad = Math.Max(1, reisijad); // чтобы не делить на 0
        }

        public double ArvutaKulu()
        {
            // расход на одного пассажира
            return Kulu * (Km / 100) / reisijad;
        }

        public double ArvutaVahemaa()
        {
            return Km;
        }

        public override string ToString()
        {
            return $"Автобус {Nimi}: расход на пассажира {ArvutaKulu():0.0} л, расстояние {Km} км, пассажиров {reisijad}";
        }
    }
}