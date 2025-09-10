using System;
using System.Linq;

namespace Nikita_Ckeel
{
    internal class funktsioonid2
    {
        //// Метод для ввода чисел через пробел и преобразования их в массив double
        //public static double[] Tekstist_Arvud()
        //{
        //    Console.WriteLine("Sisesta arvud tühikuga eraldatult:");
        //    string sisend = Console.ReadLine();
        //    char[] eraldajad = new char[] { ' ' };

        //    string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
        //    double[] arvud = new double[osad.Length];
        //    for (int i = 0; i < osad.Length; i++)
        //    {
        //        arvud[i] = Convert.ToDouble(osad[i]);
        //    }
        //    return arvud;
        //}

        // Метод для подсчёта суммы, среднего и произведения и возврата их в кортеже из 3 элементов
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
    }
}
