using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AkasztofaKonzol.SajatOsztaly
{
    public class Szavak
    {
        List<string> szos = new List<string>();

        public int SzavakSzama { get; private set; }

        public Szavak()
        {
            SzavakFeltoltese();
            SzavakSzama = szos.Count;
        }

        private void SzavakFeltoltese()
        {
            using (StreamReader sr = new StreamReader("magyar_szavak.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor.Length >= 5)
                    {
                        szos.Add(sor);
                    }
                }
            }
        }

        /*
            nehez = true -> 8 -
            nehez = false -> 5 - 7

           a véletlen szót kivesszük a 'szos'-ból
        */

        public string VeletlenSzo(bool nehez)
        {
            Random rnd = new Random();
            if (nehez)
            {
                return szos.Where(x => x.Length >= 8).ToList()[rnd.Next(szos.Count(x => x.Length >= 8))];
            }
            else
            {
                return szos.Where(x => x.Length >= 5 && x.Length <= 7).ToList()[rnd.Next(szos.Count(x => x.Length >= 5 && x.Length <= 7))];
            }
        }
    }
}
