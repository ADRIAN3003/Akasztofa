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

        public frmFo(string nev, bool nehezseg)
        {
            InitializeComponent();
            this.nev = nev;
            this.nehezseg = nehezseg;

            jatek = new Game(nev, nehezseg);
            this.Text += " - " + nev + (nehezseg ? " - Könnyű" : " - Nehéz");
            lblEddigKitalalt.Text = SzetHuz(jatek.NemKitalalt);
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
                MessageBox.Show(tbTipp.Text);
            }
        }
    }
}
