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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokKayitlari frm = new FrmStokKayitlari();
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteriSiparis frm = new FrmMusteriSiparis();
            frm.Show();
        }

        private void btnSiparisKayitlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSiparisKaydi frm = new FrmSiparisKaydi();
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIsEmri frm = new FrmIsEmri();
            frm.Show();
        }
    }
}
