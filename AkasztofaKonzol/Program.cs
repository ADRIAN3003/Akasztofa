using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkasztofaKonzol.SajatOsztaly;

namespace AkasztofaKonzol
{
    class Program
    {
        static AkasztofaJatek jatek;
        static void Main(string[] args)
        {
            Console.Write("Ki játszik: ");
            string nev = Console.ReadLine();
            Console.Write("Nehéz vagy könnnyű (n/k)? ");
            string valasz = Console.ReadLine();

            jatek = new AkasztofaJatek(nev, valasz == "n");

            jatek.JatekElinditas();

            Console.ReadKey();
        }
    }
}
