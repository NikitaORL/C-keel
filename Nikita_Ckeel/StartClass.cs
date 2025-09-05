using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{

    internal class StartClass
    {
        public static void Main(string[] args)
        {
            string jah = "";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Укажите длину стен:");
            float Dlina = float.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ширину стен:");
            float Shirina = float.Parse(Console.ReadLine());

            float S = OsalFunktsioonid.Plochad(Dlina, Shirina);

            Console.WriteLine($"Площадь пола: {S} м²");
            Console.WriteLine("Хотите ли вы сделать реомнт?");
            string remont = Console.ReadLine();
            if (remont == jah.ToLower())
            {
                Console.WriteLine("Какая цена за квадратный метр?");
                float hind = float.Parse(Console.ReadLine());
                float tulemus = (S * hind);
                Console.WriteLine($"Цена вот такая: {tulemus} евро");
            }
            else
            {
                Console.WriteLine("Ты тормози да, нормальный ответ дай!");
            }

        }
    }
}










            //Console.WriteLine("Mis sinu nimi on?");
            //string sinuNimi = Console.ReadLine();
            //Console.WriteLine("Mis Mis nimi on su pinginaabril?");
            //string pingiNimi = Console.ReadLine();
            //Random rand = new Random();
            //int a = rand.Next(0, 2);
            //string pinginaabrid = OsalFunktsioonid.pingi(a);
            //Console.WriteLine(pinginaabrid);











            //string juku = "juku";
            //Console.WriteLine("Mis sinu nimi on?");
            //string vastus = Console.ReadLine();
            //if (vastus == juku.ToLower())
            //{
            //Console.WriteLine("lähme Jukuga kinno");
            //    Console.WriteLine("Kui vana sa oled?");
            //    int vanus = int.Parse(Console.ReadLine());
            //    string pilet = OsalFunktsioonid.juku(vastus, vanus);        // вызываем функцию
            //    Console.WriteLine($"Sinu pilet: {pilet}"); // выводим результат
            //}
            //else
            //{
            //    Console.WriteLine("Sina ei ole Juku, ei saa kinno minna");
            //}





            //Random rnd = new Random();
            ////2. Osa Valikud
            //int kuu_number = rnd.Next(1,12);
            //string nimetus = OsalFunktsioonid.Kuu_Nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number}-{nimetus}");
            //Console.WriteLine("Kas tahad dekodeerida arv -> nimetusse?");
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha, siis ei taha)");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.WriteLine("Palun sisesta number: ");
            //        kuu_number = int.Parse(Console.ReadLine());
            //        Console.WriteLine(OsalFunktsioonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception error)
            //    {

            //        Console.WriteLine(error);
            //    }

            //}












            //// Установка цвета фона и текста консоли в зеленый

            //    Console.OutputEncoding = Encoding.UTF8;

            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.Green;

            //    Console.WriteLine("Tere tulemast! Mis on sinu nimi"); // Вывод приветственного сообщения и запрос имени пользователя
            //    string tekst = Console.ReadLine();  // Чтение введенного имени
            //    Console.WriteLine($"{tekst}, Rõõm näha!"); // Приветствие пользователя по имени
            //    // Объявление целочисленной переменной a и символа taht
            //    int a = 1000;
            //    char taht = 'A';
            //    Console.WriteLine($"Esimine arv on {a}, Sisesta b= ....."); // Вывод значения переменной a и запрос ввода числа b
            //    int b = int.Parse(Console.ReadLine());  // Чтение и преобразование введенного числа в int
            //    // Вывод суммы чисел a и b с использованием форматированной строки
            //    Console.WriteLine("Esimine arv on {0}, Sisesta {1}. Summa on {2}", a, b, a + b);
            //    double d = double.Parse(Console.ReadLine());  // Чтение и вывод числа типа double
            //    Console.WriteLine(d);
            //    float f = float.Parse(Console.ReadLine()); // Чтение и вывод числа типа float
            //    Console.WriteLine(f);
            //    bool t = true;            // Объявление булевой переменной t, присваивание true

            //    Random rand = new Random(); //создание обьекта для генерации случайных чисел
            //    a = rand.Next(1, 101); // от 1 до 101
            //    Console.WriteLine(a);

            //    float vastus = OsalFunktsioonid.Kalkulator(f, a);
            //    Console.WriteLine(vastus);
        
    
