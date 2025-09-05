using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    internal class OsalFunktsioonid
    {

        public static float Kalkulator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }
        public static string Kuu_Nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Octoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "December"; break;
                default:
                    kuu = "???";
                    break;
            }
            return kuu;
        }
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";

            // Возвращаем "Talv", если месяц декабрь, январь или февраль
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12)
            {
                hoo = "Talv"; // Зима
            }
            else if (kuu_nr > 3 && kuu_nr < 5)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 6 && kuu_nr < 8)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 9 && kuu_nr < 11)
            {
                hoo = "Sügis";
            }
            return hoo;
        }

        public static string juku(string vastus, int vanus)
        {
            string hind = "";
            if (vanus < 6)
            {
                hind = "tasuta";
            }
            else if (vanus > 5 && vanus < 15)
            {
                hind = "lastepilet";
            }
            else if (vanus > 14 && vanus < 66)
            {
                hind = "täispilet";
            }
            else if (vanus > 65)
            {
                hind = "sooduspilet";
            }
            else if (vanus < 0 || vanus > 100)
            {
                hind = "viga andmetega";
            }
            return hind;


        }

        public static string pingi(int a)
        {
            string tulemus = "";
            if (a == 0)
            {
                tulemus = "Te olete pinginaabrid";
            }
            else if (a == 1)
            {
                tulemus = "Te ei ole pinginaabrid(((";
            }
            return tulemus;
        }

        public static float Plochad(float Dlina, float Shirina)
        {
            if (Dlina <= 0 || Shirina <= 0)
            {
                Console.WriteLine("Длина и ширина должны быть положительными!");
                return 0;
            }

            float S = Dlina * Shirina;
            return S;
        }

    }
}
    