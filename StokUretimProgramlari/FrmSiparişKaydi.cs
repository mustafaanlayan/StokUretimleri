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

        void siparisbilgicekeme2()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU,STOK_ADI,MIKTAR,FIYAT,KDV,SIPKALEM_ID FROM TBL_SIPARISKALEMLERİ WHERE SIPARIS_NO='"+txtSiparisNo.Text+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }

        string x2 = "0";
        void mustericontrol()
        {
           conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT (*) FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='" + txtMusteriKodlari.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }
           conn.Close();
        }

        void mustertibilgisicekme()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERİ_ADI,IL,ILCE FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='"+txtMusteriKodlari.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
               txtMusteriAdlari.Text= dr[0].ToString();
               txtIl.Text = dr[1].ToString();
               txtIlce.Text = dr[2].ToString();
            }
            conn.Close();
        }
    }
}
