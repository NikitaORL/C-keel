using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel.OOP
{
    internal class Inimine
{
    public string Nimi;
    public int Vanus;

    public Inimine(string nimi, int vanus)
    {
        Nimi = nimi;
        Vanus = vanus;
    }

    public void Tervita()
    {
        Console.WriteLine($"Tere! Mina olen {Nimi}, ma olen {Vanus} aastat vana.");
    }
}
}
