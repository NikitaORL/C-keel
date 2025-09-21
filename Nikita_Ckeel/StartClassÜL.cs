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
            List<ISõiduk> list = new List<ISõiduk>();
            double sum = 0;

            string[] lines = File.ReadAllLines("transport.txt");
            foreach (string line in lines)
            {
                if (line == "" || line.StartsWith("#")) continue;

                string[] p = line.Split(';');
                if (p.Length < 5) continue;

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

            foreach (ISõiduk t in list)
            {
                Console.WriteLine(t.ToString());
                sum += t.ArvutaKulu();
            }

            Console.WriteLine("Общий расход: " + sum.ToString("0.0"));
        }
    }
}