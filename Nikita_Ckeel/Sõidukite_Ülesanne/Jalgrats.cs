using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.Sõidukite_Ülesanne
{
    public class Jalgratas : ISõiduk
    {
        private string Nimi;
        private double Km;

        public Jalgratas(string nimi, double km)
        {
            Nimi = nimi;
            Km = km;
        }

        public double ArvutaKulu()
        {
            return 0; // Велосипед не расходует топливо
        }

        public double ArvutaVahemaa()
        {
            return Km;
        }

        public override string ToString()
        {
            return $"Велосипед {Nimi}: расход 0, расстояние {Km} км";
        }
    }
}
