using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokUretimProgramlari
{
    public partial class FrmSiparişKaydi : Form
    {
        private SqlConnection conn =
            new SqlConnection(
                @"Data Source = MUSTAFA\MUSTAFA; Initial Catalog = StokUretim; Integrated Security = True");

        public FrmSiparişKaydi()
        {
            InitializeComponent();
        }

        private void sbtnSiparisListesi_Click(object sender, EventArgs e)
        {
            FrmSiparisListesi frm = new FrmSiparisListesi();
            frm.Show();
        }

        private string x1 = "0";

        void sipariscontrol()
        {
            conn.Open();
            SqlCommand sorgu1 =
                new SqlCommand("SELECT COUNT (*) FROM TBL_SIPARISLER WHERE SIPIS_NO='" + txtSiparisNo.Text + "'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x1 = dr1[0].ToString();
            }

            conn.Close();
        }

        void siparisbilgicekeme1()
        {
            conn.Open();
            SqlCommand sorgu2 =
                new SqlCommand("SELECT * FROM TBL_SIPARISLER WHERE SIPIS_NO='" + txtSiparisNo.Text + "'", conn);
            SqlDataReader dr2 = sorgu2.ExecuteReader();
            while (dr2.Read())
            {
                txtMusteriKodlari.Text = dr2[1].ToString();
                txtSiparisTarihi.Text = dr2[2].ToString();
                txtTeslimTarihi.Text = dr2[3].ToString();
                txtToplamTutar.Text = dr2[4].ToString();
            }

            conn.Close();

          
        }
    }
}
