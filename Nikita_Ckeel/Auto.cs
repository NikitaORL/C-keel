using Nikita_Ckeel.Sõidukite_Ülesanne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    public class Auto : ISõiduk
    {
        private string Nimi;
        private double Kulu;  // л/100км
        private double Km;

        public Auto(string nimi, double kulu, double km)
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
            return $"Автомобиль {Nimi}: расход {ArvutaKulu():0.0} л, расстояние {Km} км";
        }
    }
}
