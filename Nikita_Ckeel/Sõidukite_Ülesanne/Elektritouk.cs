using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.Sõidukite_Ülesanne
{
    public class Elektritouk : ISõiduk
    {
        private string Nimi;
        private double Kulu; // кВт·ч/100 км
        private double Km;

        public Elektritouk(string nimi, double kulu, double km)
        {
            Nimi = nimi;
            Kulu = kulu;
            Km = km;
        }

        public double ArvutaKulu()
        {
            return Kulu * (Km / 100);
        }

        public double ArvutaVahemaa()
        {
            return Km;
        }

        public override string ToString()
        {
            return $"Электросамокат {Nimi}: расход {ArvutaKulu():0.0} кВт·ч, расстояние {Km} км";
        }
    }
}