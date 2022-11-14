using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkasztofaKonzol.SajatOsztaly
{
    public class Game
    {
        public int SzoHossz { get { return szo.Length; } }

        public bool Vege { get; private set; }

        private Szavak szavas = new Szavak();

        private string nev;

        public string Nev
        {
            get { return nev; }
        }


        private string szo;

        private int osszProba;

        public int OsszProba
        {
            get { return osszProba; }
        }

        public int Lehetoseg { get; private set; }

        private bool nehezseg;

        private string helytelens;

        public string Helytelens
        {
            get { return helytelens; }
        }

        public void Vizsgalat(string tipp)
        {
            if (!NemKitalalt.Contains(tipp) && !helytelens.Contains(tipp))
            {
                if (szo.Contains(tipp))
                {
                    //el kell helyezni a megfelelő helyre
                    //szo = "ALMA"
                    //tipp = "A"
                    //nemkitalalt = "_ _ _ _"

                    string tmp = "";
                    for (int i = 0; i < szo.Length; i++)
                    {
                        if (szo[i].ToString() == tipp)
                        {
                            tmp += tipp;
                        } 
                        else
                        {
                            tmp += NemKitalalt[i];
                        }
                    }
                    NemKitalalt = tmp;
                }
                else
                {
                    helytelens += tipp;
                    Lehetoseg--;
                    if (Lehetoseg == 0)
                    {
                        Vege = true;
                    }
                }
            }

            if (!NemKitalalt.Contains("_"))
            {
                Vege = true;
            }
        }

        private int tipp;

        public int Tipp
        {
            get { return tipp; }
        }

        public string NemKitalalt { get; private set; }

        public Game(string nev, bool nehezseg)
        {
            this.nev = nev;
            this.nehezseg = nehezseg;
            szo = szavas.VeletlenSzo(nehezseg);
            AlapBeallitasok();
        }

        private void AlapBeallitasok()
        {
            osszProba = 10;
            Lehetoseg = 10;
            Vege = false;
            helytelens = "";
            NemKitalalt = "";
            for (int i = 0; i < szo.Length; i++)
            {
                NemKitalalt += "_";
            }
        }

        public override string ToString()
        {
            return szo;
        }
    }
}
