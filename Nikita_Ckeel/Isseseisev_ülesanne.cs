using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Nikita_Ckeel
{
    internal class Isseseisev_ülesanne
    //Описание:
    //Создайте класс Ученик со следующими свойствами:
    //Имя(string)
    //Оценки(List<int>)
    //Создайте как минимум 3 ученика, введите для каждого из них по 3–5 оценок, затем:
    //Вычислите среднюю оценку каждого ученика
    //Найдите самую высокую среднюю оценку в классе и выведите имя ученика, получившего ее
    //💡 Бонус: Отсортируйте учеников по средней оценке(в порядке возрастания или убывания)
    {

        public static void Lisa_opilane(List<string> opilased, List<List<int>> hinded)
        {
            Console.WriteLine("Palun sisesta õpilase nimi:");
            string nimi = Console.ReadLine();
            opilased.Add(nimi);

            Console.WriteLine("Palun sisesta 5 hinnet (läbi tühiku):");
            string sisend = Console.ReadLine();

            try
            {
                List<int> numHinded = sisend.Split(' ').Select(int.Parse).ToList();
                hinded.Add(numHinded);
                Console.WriteLine("Hinded lisatud");
            }
            catch
            {
                Console.WriteLine("Viga! Palun sisesta ainult numbrid.");
            }
        }

        public static void Keskmine_Hinne(List<string> opilased, List<List<int>> hinded)
        {
            Console.WriteLine("Palun sisesta õpilase nimi:");
            string nimi = Console.ReadLine();

            int index = opilased.IndexOf(nimi);
            if (index != -1)
            {
                List<int> opHinded = hinded[index];
                Console.WriteLine($"{nimi} hinded: " + string.Join(", ", opHinded));

                double keskmine = opHinded.Average();
                Console.WriteLine($"Keskmine hinne: {keskmine:F2}");
            }
            else
            {
                Console.WriteLine("Sellist õpilast ei leitud.");
            }
        }
    }
}

    