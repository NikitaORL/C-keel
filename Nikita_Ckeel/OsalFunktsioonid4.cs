using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nikita_Ckeel
{
    internal class OsalFunktsioonid4
    {
        public static void kirjuta_failisse()
        {
            try
            {
                string path = @"C:\Users\opilane\source\repos\C-keel\Uus kaust (5)\Nikita_Ckeel\Kuud.txt";
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }

        public static void Failide_lugemine(string failinimi)
        {
            try
            {
                string path = @"C:\Users\opilane\source\repos\C-keel\Uus kaust (5)\Nikita_Ckeel\Kuud.txt";
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        // Новый метод для работы со списком месяцев
        public static void Kuude_töötlus()
        {
            List<string> kuude_list = new List<string>
            {
                "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni",
                "Juuli", "August", "September", "Oktoober", "November", "Detsember"
            };

            // Вывод всех месяцев
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Удаляем "Juuni"
            kuude_list.Remove("Juuni");

            // Изменяем первый элемент
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            // Вывод после изменений
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
        }
    }
}
