using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    public interface ITööline
    {
        double ArvutiPalk();
    }
    public class Pank
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
            }
        }

        public void LisaRaha(double summa)
        {
            if (summa > 0)
            {
                saldo += summa;
                Console.WriteLine($"{summa} eurot lisatud kontole. Uus saldo: {saldo} eurot.");
            }
            else
            {
                Console.WriteLine("Summa peab olema positiivne, raha ei lisatud.");
            }
        }

        public double VõtaRaha(double summa)
        {
            if (summa <= 0)
            {
                Console.WriteLine("Summa peab olema positiivne, raha ei võetud.");
                return 0;
            }

            if (summa <= saldo)
            {
                saldo -= summa;
                Console.WriteLine($"{summa} eurot võetud kontolt. Uus saldo: {saldo} eurot.");
                return summa;
            }
            else
            {
                Console.WriteLine("Teie kontroll pole piisavalt raha");
                Console.WriteLine($"Teie kontol on {saldo} eurot");
                return 0;
            }
        }
    }
}