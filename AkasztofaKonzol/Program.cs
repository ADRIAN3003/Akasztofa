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
            Game janos = new Game("János", true);
            Game gabor = new Game("Gábor", false);

            Console.ReadKey();
        }
    }
}
