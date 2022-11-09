using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkasztofaKonzol.SajatOsztaly
{
    public class Game
    {
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

        private string helytelen;

        public string Helytelen
        {
            get { return helytelen; }
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
            osszProba = szo.Length;
            Lehetoseg = szo.Length;
            Vege = false;
            helytelen = "";
            NemKitalalt = "";
            for (int i = 0; i < szo.Length; i++)
            {
                NemKitalalt += "_";
            }
        }
    }
}
