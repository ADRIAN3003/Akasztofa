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
        }

        public void JatekElinditas()
        {
            JatekMenet();
            EredmenyKiiras();
        }

        private void EredmenyKiiras()
        {
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

        private void JatekMenet()
        {
            string tipp;

            while (!jatek.Vege)
            {
                AdatokKiirasa();
                Console.Write("Kérek egy tippet: ");
                tipp = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");
                jatek.Vizsgalat(tipp);
            }
        }

        private void AdatokKiirasa()
        {
            Console.WriteLine($"Szóhossz: " + jatek.SzoHossz);
            Console.WriteLine($"Lehetőség: " + jatek.Lehetoseg);
            Console.WriteLine($"Helytelen tippek: " + jatek.Helytelens);
            Console.WriteLine($"Nem kitalált: " + jatek.NemKitalalt);
        }
    }
}
