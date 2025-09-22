using Nikita_Ckeel.Sõidukite_Ülesanne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    public class StartClassÜL
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Создаём список транспорта
            List<ISõiduk> list = new List<ISõiduk>();
            double sum = 0;

            // ✅ Данные задаём прямо в коде
            // Формат: тип, название, расход, километры, пассажиры (для автобуса)
            string[][] data = new string[][]
            {
                new string[] { "авто", "Toyota", "7.5", "120", "0" },
                new string[] { "велосипед", "Merida", "0", "25", "0" },
                new string[] { "автобус", "Scania", "20", "300", "40" },
                new string[] { "электросамокат", "Xiaomi", "1.2", "15", "0" }
            };

            // Обрабатываем каждую строку данных
            foreach (string[] p in data)
            {
                string type = p[0].Trim().ToLower();
                string name = p[1].Trim();
                double kulu = 0, km = 0;
                int reisijad = 0;

                double.TryParse(p[2], out kulu);
                double.TryParse(p[3], out km);
                int.TryParse(p[4], out reisijad);

                if (type == "авто") list.Add(new Auto(name, kulu, km));
                else if (type == "велосипед") list.Add(new Jalgratas(name, km));
                else if (type == "автобус") list.Add(new Buss(name, kulu, km, reisijad));
                else if (type == "электросамокат") list.Add(new Elektritouk(name, kulu, km));
            }

            // Выводим все объекты и считаем общий расход
            foreach (ISõiduk t in list)
            {
                Console.WriteLine(t.ToString());
                sum += t.ArvutaKulu();
            }

            Console.WriteLine("Общий расход: " + sum.ToString("0.0"));
        }
    }
}