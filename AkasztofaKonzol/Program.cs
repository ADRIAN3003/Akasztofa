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
            //Game janos = new Game("János", true);
            Game gabor = new Game("Gábor", false);
            string tipp;

            while (!gabor.Vege)
            {
                Console.WriteLine($"Szóhossz: " + gabor.OsszProba);
                Console.WriteLine($"Lehetőség: " + gabor.Lehetoseg);
                Console.WriteLine($"Helytelen tippek: " + gabor.Helytelens);
                Console.WriteLine($"Nem kitalált: " + gabor.NemKitalalt);
                Console.Write("Kérek egy tippet: ");
                tipp = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");
                gabor.Vizsgalat(tipp);
            }

            if (gabor.Lehetoseg == 0)
            {
                Console.WriteLine(gabor.ToString());
                Console.WriteLine("A játéknak vége");
            }
            else
            {
                Console.WriteLine(gabor.NemKitalalt);
                Console.WriteLine("Sikerült kitalálni");
            }

            Console.ReadKey();
        }
    }
}
