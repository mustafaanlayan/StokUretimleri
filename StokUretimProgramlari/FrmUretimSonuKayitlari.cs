﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokUretimProgramlari
{
    public partial class FrmUretimSonuKayitlari : Form
    {
        public FrmUretimSonuKayitlari()
        {
            InitializeComponent();
        }

        private void sbtnUretimSonuListesi_Click(object sender, EventArgs e)
        {
            FrmUretimSonuListesi frm = new FrmUretimSonuListesi();
            frm.Show();
        }
    }
}
