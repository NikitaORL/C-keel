using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.Sõidukite_Ülesanne
{
    internal interface ISõiduk
    {
        double ArvutaKulu();      // Метод для расчёта расхода
        double ArvutaVahemaa();   // Метод для расчёта пройденного расстояния
    }
}