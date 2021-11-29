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
    public partial class FrmSiparişKaydi : Form
    {
        public FrmSiparişKaydi()
        {
            InitializeComponent();
        }

        private void sbtnSiparisListesi_Click(object sender, EventArgs e)
        {
            FrmSiparisListesi frm = new FrmSiparisListesi();
           frm.Show();
        }
    }
}
