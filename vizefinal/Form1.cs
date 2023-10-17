﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizefinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float final, vize,ortalama;
            final = Convert.ToSingle(txtFinal.Text);
            vize = Convert.ToSingle(txtVize.Text);
            ortalama = vize * 0.4f + final * 0.6f;

            lblOrtalama.Text = "Ortalama: " + ortalama;
            if (ortalama >= 50 && final >= 50)
            {
                lblDurum.Text = "Durum: Geçtiniz";
            }
            else
            {
                lblDurum.Text = "Durum: Kaldınız:(";
            }
        }
    }
}
