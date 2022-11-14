﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkasztofaForm
{
    public partial class frmUjJatek : Form
    {
        public frmUjJatek()
        {
            InitializeComponent();
            rbKonnyu.Checked = true;
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKezdes_Click(object sender, EventArgs e)
        {
            if (tbNev.Text.Length == 0)
            {
                MessageBox.Show("A játékosnév mező nem lehet üres!");
            } 
            else
            {
                this.Hide();
                frmFo frmFo = new frmFo(tbNev.Text, rbKonnyu.Checked);
                frmFo.Show();
            }
        }
    }
}
