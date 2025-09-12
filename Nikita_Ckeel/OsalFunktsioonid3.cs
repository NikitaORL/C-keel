using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Nikita_Ckeel
{
    internal class OsalFunktsioonid3
    {
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {

            //





            int[,] korrutustabel = new int[ridadeArv, veergudeArv];


            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    korrutustabel[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    Console.Write(korrutustabel[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            return korrutustabel;
        }

        static void Main(string[] args)
        {
            int[,] tabel = GenereeriKorrutustabel(10, 10);
            
        }
    }
}









//Задача:
////Компьютер выбирает случайное число[1–100].
//У пользователя есть 5 попыток.
//Создайте метод ArvaArv(), который:
//при каждой попытке сообщает, «слишком большое», «слишком маленькое» или «правильное» число,
//игра заканчивается при правильном отгадывании или после пятой попытки.
//Дополнительно: после игры спросите, хочет ли пользователь сыграть еще раз.
//public static  int ArvaArv( int Arv,  int vastus)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.WriteLine("Попробуй угадать число от 1 до 100");
//            Random rnd = new Random();
//            vastus = rnd.Next(1, 101);
//            Console.WriteLine($"Ответ равен {vastus}");
//                for (int i = 0; i < 6; i++)
//            {
//                Console.WriteLine($"Попытка {i + 1}: ");
//                Arv = int.Parse(Console.ReadLine());
//                if (Arv > vastus)
//                {
//                    Console.WriteLine("Число слишком большое");
//                }
//                if (Arv < vastus)
//                {
//                    Console.WriteLine("Число слишком маленькое");
//                }
//                if (Arv == vastus)
//                {
//                    Console.WriteLine("Красава!!!! Правильный ответ!");
//                    break;
//                }
//            }
//            return Arv;
//        }















//Купи слона!
//Задача:
//Создайте метод повторного ввода KuniMärksõnani(строка ключевое слово, строка фраза), который:
//запрашивает у пользователя ввод, пока он не будет точно соответствовать ключевому слову,
//каждый раз перед этим перезаписывает фразу,
//все введенные данные сохраняются и в конце выводятся на печать.


//        public static string KuniMärksõnani(string märksõna, string fraas)
//        {
//            märksõna = "Ok";
//            do
//            {
//                Console.WriteLine("Osta elevant ära! Kui sa tahad, palun sisesta 'Ok'");
//                fraas = Console.ReadLine();
//            } while (fraas.ToLower() != märksõna.ToLower());
//            return fraas;
//        }
//    }
//}