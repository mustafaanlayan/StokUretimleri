using System;
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
    public partial class FrmIsEmri : Form
    {
        public FrmIsEmri()
        {
            InitializeComponent();
        }

        private void sbtnIsEmriListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriListesi frm = new FrmIsEmriListesi();
            frm.Show();
        }

        private void btnSiparisListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriSiparisleri frm = new FrmIsEmriSiparisleri();
            frm.Show();
        }
    }
}
