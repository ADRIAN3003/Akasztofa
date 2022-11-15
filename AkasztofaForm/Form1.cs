using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkasztofaKonzol.SajatOsztaly;

namespace AkasztofaForm
{
    public partial class frmFo : Form
    {
        string nev;
        bool nehezseg;
        Game jatek;
        List<Bitmap> kepek = new List<Bitmap>();

        public frmFo(string nev, bool nehezseg)
        {
            InitializeComponent();
            this.nev = nev;
            this.nehezseg = nehezseg;
            KepFeltoltes();
            jatek = new Game(nev, nehezseg);
            this.Text += " - " + nev + (nehezseg ? " - Nehéz" : " - Könnyű");
            lblEddigKitalalt.Text = SzetHuz(jatek.NemKitalalt);
            lblVoltak.Text = "";
            lblLehetosegek.Text = jatek.Lehetoseg + "";
            tbTipp.Focus();
        }

        private void KepFeltoltes()
        {
            kepek.Add(Properties.Resources.kep0);
            kepek.Add(Properties.Resources.kep1);
            kepek.Add(Properties.Resources.kep2);
            kepek.Add(Properties.Resources.kep3);
            kepek.Add(Properties.Resources.kep4);
            kepek.Add(Properties.Resources.kep5);
            kepek.Add(Properties.Resources.kep6);
            kepek.Add(Properties.Resources.kep7);
            kepek.Add(Properties.Resources.kep8);
            kepek.Add(Properties.Resources.kep9);
            kepek.Add(Properties.Resources.kep10);
        }

        private string SzetHuz(string nemKitalalt)
        {
            string tmp = "";

            int j = 0;
            while (nemKitalalt.Length - 1 > j)
            {
                tmp += nemKitalalt[j++] + " ";
            }
            tmp += nemKitalalt[j];

            return tmp;
        }

        private void frmFo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbTipp_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbTipp.TextLength >= 1 && e.KeyCode != Keys.Enter)
            {
                tbTipp.Text = tbTipp.Text.Substring(0, tbTipp.TextLength - 1);
            }
            if (e.KeyCode == Keys.Enter && tbTipp.TextLength == 1)
            {
                jatek.Vizsgalat(tbTipp.Text);
                lblEddigKitalalt.Text = SzetHuz(jatek.NemKitalalt);
                lblVoltak.Text = jatek.Helytelens;
                lblLehetosegek.Text = jatek.Lehetoseg + "";
                pbKepek.Image = kepek[10 - jatek.Lehetoseg];

                if (jatek.Lehetoseg == 0)
                {
                    MessageBox.Show($"Játék vége!\nNem sikerült kitalálnod a szót!\n{jatek.ToString()} szó lett volna a megfejtés!");
                    Application.Exit();
                }
                else if (jatek.Vege)
                {
                    MessageBox.Show("Siker!\nKitaláltad!");
                    Application.Exit();
                }

                tbTipp.Text = "";
                tbTipp.Focus();
            }
        }
    }
}
