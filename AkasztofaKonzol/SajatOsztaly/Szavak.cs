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
        List<string> szosKonnyu = new List<string>();
        List<string> szosNehez = new List<string>();

        public int SzavakSzama { get; private set; }

        public Szavak()
        {
            SzavakFeltoltese();
        }

        private void SzavakFeltoltese()
        {
            using (StreamReader sr = new StreamReader("magyar_szavak.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor.Length >= 5 && sor.Length <= 7)
                    {
                        szosKonnyu.Add(sor);
                    }
                    else if (sor.Length >= 8)
                    {
                        szosNehez.Add(sor);
                    }
                }
            }
            SzavakSzama = szosKonnyu.Count + szosNehez.Count;
        }

        /*
            nehez = true -> 8 -
            nehez = false -> 5 - 7

           a véletlen szót kivesszük a 'szos'-ból
        */

        public string VeletlenSzo(bool nehez)
        {
            string valasztott = "";
            valasztott = nehez ? Kivalaszt(szosNehez) : Kivalaszt(szosKonnyu);
            SzavakSzama = szosKonnyu.Count + szosNehez.Count;
            //if (nehez)
            //{
            //    valasztott = Kivalaszt(szosNehez);
            //}
            //else
            //{
            //    valasztott = Kivalaszt(szosKonnyu);
            //}
            return valasztott;
        }

        private string Kivalaszt(List<string> szosNehez)
        {
            string tmp = "";
            Random rnd = new Random();
            int random = rnd.Next(szosNehez.Count);
            tmp = szosNehez[random];
            szosNehez.RemoveAt(random);
            return tmp;
        }
    }
}
