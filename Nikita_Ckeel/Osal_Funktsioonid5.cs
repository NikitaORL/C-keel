using System;
using System.Collections.Generic;

namespace Nikita_Ckeel
{
    internal class Osal_Funktsioonid5
    {

        static Dictionary<string, string> okruugid = new Dictionary<string, string>()
        {
            {"Центральный", "Москва"},
            {"Северо-Западный", "Санкт-Петербург"},
            {"Приволжский", "Нижний Новгород"},
            {"Южный", "Ростов-на-Дону"},
            {"Северо-Кавказский", "Пятигорск"},
            {"Уральский", "Екатеринбург"},
            {"Сибирский", "Новосибирск"},
            {"Дальневосточный", "Хабаровск"}
        };

        static void FindStolica(string okrug)
        {
            if (okruugid.ContainsKey(okrug))
            {
                Console.WriteLine($"Столица округа {okrug}: {okruugid[okrug]}");
            }
            else
            {
                Console.WriteLine("Такого округа нет.");
                Console.Write("Хотите добавить его в словарь? (да/нет): ");
                string add = Console.ReadLine().ToLower();
                if (add == "да")
                {
                    Console.Write("Введите столицу: ");
                    string stolica = Console.ReadLine();
                    okruugid[okrug] = stolica;
                    Console.WriteLine("Добавлено!");
                }
            }
        }

        static void FindOkrug(string stolica)
        {
            foreach (var pair in okruugid)
            {
                if (pair.Value.ToLower() == stolica.ToLower())
                {
                    Console.WriteLine($"Округ столицы {stolica}: {pair.Key}");
                    return;
                }
            }

            Console.WriteLine("Такой столицы нет.");
            Console.Write("Хотите добавить её в словарь? (да/нет): ");
            string add = Console.ReadLine().ToLower();
            if (add == "да")
            {
                Console.Write("Введите округ: ");
                string okrug = Console.ReadLine();
                okruugid[okrug] = stolica;
                Console.WriteLine("Добавлено!");
            }
        }

        static void Game(int rounds = 5)
        {
            Random rnd = new Random();
            int correct = 0;
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>(okruugid);

            for (int i = 0; i < rounds; i++)
            {
                var pair = pairs[rnd.Next(pairs.Count)];
                string okrug = pair.Key;
                string stolica = pair.Value;
                int mode = rnd.Next(2); // 0 – спросить столицу, 1 – спросить округ

                if (mode == 0)
                {
                    Console.Write($"Какая столица у округа {okrug}? ");
                    string answer = Console.ReadLine();
                    if (answer.Trim().ToLower() == stolica.ToLower())
                    {
                        Console.WriteLine("✅ Правильно!");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine($"❌ Неправильно. Ответ: {stolica}");
                    }
                }
                else
                {
                    Console.Write($"Какой округ у столицы {stolica}? ");
                    string answer = Console.ReadLine();
                    if (answer.Trim().ToLower() == okrug.ToLower())
                    {
                        Console.WriteLine("✅ Правильно!");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine($"❌ Неправильно. Ответ: {okrug}");
                    }
                }
            }

            double percent = (double)correct / rounds * 100;
            Console.WriteLine($"\nРезультат: {correct} из {rounds} ({percent:F1}%)");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Меню ---");
                Console.WriteLine("1. Найти столицу по округу");
                Console.WriteLine("2. Найти округ по столице");
                Console.WriteLine("3. Игровой режим");
                Console.WriteLine("4. Выход");

                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Введите округ: ");
                    string okrug = Console.ReadLine();
                    FindStolica(okrug);
                }
                else if (choice == "2")
                {
                    Console.Write("Введите столицу: ");
                    string stolica = Console.ReadLine();
                    FindOkrug(stolica);
                }
                else if (choice == "3")
                {
                    Game(5);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Выход из программы...");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                }
            }
        }
    }
}


















//public static void test()
//        {
//            ArrayList nimed = new ArrayList();
//            nimed.Add("Kati");
//            nimed.Add("Mati");
//            nimed.Add("Juku");

//            if (nimed.Contains("Mati"))
//                Console.WriteLine("Mati olemas");

//            Console.WriteLine("Nimesid kokku: " + nimed.Count);

//            nimed.Insert(1, "Sass");

//            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
//            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

//            foreach (string nimi in nimed)
//                Console.WriteLine(nimi);

//        }
//    }
//}
