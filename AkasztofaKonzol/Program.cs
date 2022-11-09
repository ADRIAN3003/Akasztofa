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
        static Szavak szotar = new Szavak();
        static void Main(string[] args)
        {
            Console.WriteLine(szotar.SzavakSzama);
            Console.WriteLine("Nehéz: " + szotar.VeletlenSzo(true));
            Console.WriteLine("Könnyű: " + szotar.VeletlenSzo(false));
            Console.WriteLine(szotar.SzavakSzama);

            Console.ReadKey();
        }
    }
}
