using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkasztofaKonzol.SajatOsztaly;

namespace AkasztofaKonzol.SajatOsztaly
{
    class AkasztofaJatek
    {
        Game jatek;

        public AkasztofaJatek(string nev, bool nehezseg)
        {
            jatek = new Game(nev, nehezseg);
            
            JatekElinditas();
        }

        private void JatekElinditas()
        {
            string tipp;

            while (!jatek.Vege)
            {
                Console.WriteLine($"Szóhossz: " + jatek.OsszProba);
                Console.WriteLine($"Lehetőség: " + jatek.Lehetoseg);
                Console.WriteLine($"Helytelen tippek: " + jatek.Helytelens);
                Console.WriteLine($"Nem kitalált: " + jatek.NemKitalalt);
                Console.Write("Kérek egy tippet: ");
                tipp = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");
                jatek.Vizsgalat(tipp);
            }

            if (jatek.Lehetoseg == 0)
            {
                Console.WriteLine(jatek.ToString());
                Console.WriteLine("A játéknak vége");
            }
            else
            {
                Console.WriteLine(jatek.NemKitalalt);
                Console.WriteLine("Sikerült kitalálni");
            }
        }
    }
}
