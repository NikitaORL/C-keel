using Nikita_Ckeel.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    public class Õpilane : Inimine
    {
        public string Rühm_Klass;
        public string Kool;

        public override void Mida_teeb()
        {
            Console.WriteLine($"{nimi} õpib koolis")
        }
    }
}