using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {
            // Установка цвета фона и текста консоли в зеленый
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Tere tulemast! Mis on sinu nimi"); // Вывод приветственного сообщения и запрос имени пользователя
            string tekst = Console.ReadLine();  // Чтение введенного имени
            Console.WriteLine($"{tekst}, Rõõm näha!"); // Приветствие пользователя по имени
            // Объявление целочисленной переменной a и символа taht
            int a = 1000;
            char taht = 'A';
            Console.WriteLine($"Esimine arv on {a}, Sisesta b= ....."); // Вывод значения переменной a и запрос ввода числа b
            int b = int.Parse(Console.ReadLine());  // Чтение и преобразование введенного числа в int
            // Вывод суммы чисел a и b с использованием форматированной строки
            Console.WriteLine("Esimine arv on {0}, Sisesta {1}. Summa on {2}", a, b, a + b);
            double d = double.Parse(Console.ReadLine());  // Чтение и вывод числа типа double
            Console.WriteLine(d);
            float f = float.Parse(Console.ReadLine()); // Чтение и вывод числа типа float
            Console.WriteLine(f);
            bool t = true;            // Объявление булевой переменной t, присваивание true

            Random rand = new Random(); //создание обьекта для генерации случайных чисел
            a = rand.Next(1, 101); // от 1 до 101
            Console.WriteLine(a);

            float vastus = OsalFunktsioonid.Kalkulator(f, a);
            Console.WriteLine(vastus);-
        }
    }
}