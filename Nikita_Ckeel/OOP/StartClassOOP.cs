using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.OOP
{
    public static class Program  // Добавил класс Program, т.к. Main должен быть в классе
    {
        public static void Main(string[] args)
        {
            // Здесь можно создать объекты и вызвать методы
        }

        internal class Transport
        {
            public string Name;

            public Transport(string name)
            {
                Name = name;
            }

            public virtual void Liikumine()
            {
                Console.WriteLine($"{Name} двигается");
            }
        }
    }
}



//internal class OOP
//    {
//        public static void Main(string[] args)
//        {
//            Inimine inimine1 = new Inimine("Juku", 12);
//            inimine1.Tervita();

//            Inimine inimine2 = new Inimine("Kati", 28);
//            inimine2.Tervita();

//            Töötaja töötaja1 = new Töötaja("Mati", 42, "Arst");
//            töötaja1.Tervita();
//            töötaja1.Töötan();
//        }
//    }
//}