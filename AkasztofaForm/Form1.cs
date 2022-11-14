﻿using System;
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
            this.Text += " - " + nev;
        }

        private void frmFo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
