using Nikita_Ckeel;
using Nikita_Ckeel.OOP;
using Nikita_Ckeel.Sõidukite_Ülesanne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    public class StartClassOOP
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


            ////Inimene inimene1 = new Inimene();

            //Õpilane inimene1 = new Õpilane();
            //inimene1.Nimi = "Juku";
            //inimene1.Vanus = 12;
            //inimene1.Tervita();

            //Õpilane inimene2 = new Õpilane("Kati", 28);
            //inimene2.Mida_teeb();

            //Töötaja töötaja1 = new Töötaja();
            //töötaja1.Nimi = "Mati";
            //töötaja1.Vanus = 45;
            //töötaja1.Ametikoht = "Autojuht";
            //töötaja1.Tervita();
            //töötaja1.Töötan();

            //töötaja1.Tunnid = 160;
            //double palk = töötaja1.ArvutaPalk();
            //Console.WriteLine($"Töötaja {töötaja1.Nimi} tennib kuus {palk} eurot");

            //Console.WriteLine($"Algune konto on {töötaja1.Konto.Saldo} eurot");
            //töötaja1.Konto.Saldo += palk;
            //Console.WriteLine($"Pärast palka kontol {töötaja1.Konto.Saldo}");
            //töötaja1.Konto.VõtaRaha(200);
            //Console.WriteLine($"Pärast sulraha võtmist on kontol {töötaja1.Konto.Saldo}");
            //töötaja1.Konto.LisaRaha(500);
            //Console.WriteLine($"Pärast raha lisamist on kontol {töötaja1.Konto.Saldo}");
            //1 ülesanne
            //3- Tee ise vähemalt 2 alamklassi ja kasuta neid siin
            //4.5- Tee enda põhiklass ja 2 alamklassi ning kasuta neid siin
            //2 ülesanne
            /*- Tee enda põhiklass(Loom) ja 2-3 alamklassi(Kass, Koer, Lehm)
            ning kasuta abstraktset meetodit*/
        }

    }
}