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
                    szos.Add(sr.ReadLine());
                }
            }
        }
    }
}
