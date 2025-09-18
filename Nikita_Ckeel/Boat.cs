
using Nikita_Ckeel.OOP;
using System.Xml.Linq;

namespace Nikita_Ckeel
{
    internal class Boat : Transport
    {
        public Boat(string name) : base(name) { }

        public override void Liikumine()
        {
            Console.WriteLine($"{Name} плывет по воде");
        }
    }
}