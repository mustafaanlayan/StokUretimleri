using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokUretimProgramlari
{
    public partial class FrmSiparisListesi : Form
    {
        private SqlConnection conn =
            new SqlConnection(
                @"Data Source = MUSTAFA\MUSTAFA; Initial Catalog = StokUretim; Integrated Security = True");

        void arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT S.SIPARIS_NO,M.MUSTERİ_ADI,S.SIPARIS_TARIHI,S.TESLIM_TARIHI FROM TBL_SIPARISLER S LEFT JOIN TBL_MUSTERIKAYITLARI M ON S.MUSTERI_KODU=M.MUSTERI_KODU WHERE S.SIPARIS_NO LIKE '%"+txtSiparisNo.Text+"%' AND M.MUSTERİ_ADI LIKE'%"+txtMusteriAdi.Text+"%' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        
        public FrmSiparisListesi()
        {
            InitializeComponent();
        }

        private void FrmSiparisListesi_Load(object sender, EventArgs e)
        {
            arama();
        }

        private void txtSiparisNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }
    }

     
}
