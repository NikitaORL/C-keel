using System;
using System.Collections.Generic;

//namespace Nikita_Ckeel
//{
//    internal class OsalFunktsioonid5
//    {
//    }













//        // Словарь округов и столиц
//        public static Dictionary<string, string> okruugid = new Dictionary<string, string>()
//        {
//            {"Харьюмаа", "Таллинн"},
//            {"Тартумаа", "Тарту"},
//            {"Пярнумаа", "Пярну"},
//            {"Ида-Вирумаа", "Йыхви"},
//            {"Ляэне-Вирумаа", "Раквере"},
//            {"Ярвамаа", "Пайде"},
//        };

//        // Поиск столицы по округу
//        public static void FindStolica(string okrug)
//        {
//            if (okruugid.ContainsKey(okrug))
//            {
//                Console.WriteLine($"Столица округа {okrug}: {okruugid[okrug]}");
//            }
//            else
//            {
//                Console.WriteLine("Такого округа нет.");
//                Console.Write("Хотите добавить его в словарь? (да/нет): ");
//                string add = Console.ReadLine().ToLower();
//                if (add == "да")
//                {
//                    Console.Write("Введите столицу: ");
//                    string stolica = Console.ReadLine();
//                    okruugid[okrug] = stolica;
//                    Console.WriteLine("Добавлено!");
//                }
//            }
//        }

//        // Поиск округа по столице
//        public static void FindOkrug(string stolica)
//        {
//            foreach (var pair in okruugid)
//            {
//                if (pair.Value.ToLower() == stolica.ToLower())
//                {
//                    Console.WriteLine($"Округ столицы {stolica}: {pair.Key}");
//                    return;
//                }
//            }

//            Console.WriteLine("Такой столицы нет.");
//            Console.Write("Хотите добавить её в словарь? (да/нет): ");
//            string add = Console.ReadLine().ToLower();
//            if (add == "да")
//            {
//                Console.Write("Введите округ: ");
//                string okrug = Console.ReadLine();
//                okruugid[okrug] = stolica;
//                Console.WriteLine("Добавлено!");
//            }
//        }

//        // Игровой режим
//        public static void Game(int rounds = 5)
//        {
//            Random rnd = new Random();
//            int correct = 0;
//            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>(okruugid);

//            for (int i = 0; i < rounds; i++)
//            {
//                var pair = pairs[rnd.Next(pairs.Count)];
//                string okrug = pair.Key;
//                string stolica = pair.Value;
//                int mode = rnd.Next(2); // 0 – спросить столицу, 1 – спросить округ

//                if (mode == 0)
//                {
//                    Console.Write($"Какая столица у округа {okrug}? ");
//                    string answer = Console.ReadLine();
//                    if (answer.Trim().ToLower() == stolica.ToLower())
//                    {
//                        Console.WriteLine(" Правильно!");
//                        correct++;
//                    }
//                    else
//                    {
//                        Console.WriteLine($" Неправильно. Ответ: {stolica}");
//                    }
//                }
//                else
//                {
//                    Console.Write($"Какой округ у столицы {stolica}? ");
//                    string answer = Console.ReadLine();
//                    if (answer.Trim().ToLower() == okrug.ToLower())
//                    {
//                        Console.WriteLine(" Правильно!");
//                        correct++;
//                    }
//                    else
//                    {
//                        Console.WriteLine($" Неправильно. Ответ: {okrug}");
//                    }
//                }
//            }

//            double percent = (double)correct / rounds * 100;
//            Console.WriteLine($"\nРезультат: {correct} из {rounds} ({percent:F1}%)");
//        }
//    }
//}



















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
