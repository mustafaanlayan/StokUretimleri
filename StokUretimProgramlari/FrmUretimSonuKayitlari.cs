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
    public partial class FrmUretimSonuKayitlari : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmUretimSonuKayitlari()
        {
            InitializeComponent();
        }
        string x1 = "0";

        void uretimkaydısonukontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) TBL_URETIMSONUKAYITLARI WHERE URETIMSONUKAYDI_NO='"+txtFisNo.Text+"' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x1 = dr1[0].ToString();
            }
            conn.Close();
        }

        void uretimsonukaydibilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISEMRI_NO FROM TBL_URETIMSONUKAYITLARI WHERE URETIMSONUKAYDI_NO='"+txtFisNo.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtIsEmriNo.Text = dr[0].ToString();
            }
            conn.Close();
            txtIsEmriNo.Enabled = false;
            btnIsemrilistesi.Enabled = false;
        }

        string x2 = "";
        void isemrikontro()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) TBL_ISEMRI WHERE ISEMRİ_NO='"+txtIsEmriNo.Text+"'  ",conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }
            conn.Close();
        }

        void isemribilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT MR.SIPARIS_NO,MR.STOK_KODU,MR.STOK_ADI,MR.SIPKALEM_ID,MR.MIKTAR,SIP.MUSTERI_KODU,MK.MUSTERİ_ADI FROM TBL_ISEMRI MR LEFT JOIN TBL_SIPARISLER SIP ON MR.SIPARIS_NO = SIP.SIPARIS_NO LEFT JOIN TBL_MUSTERIKAYITLARI MK ON SIP.MUSTERI_KODU = MK.MUSTERI_KODU WHERE ISEMRİ_NO='"+txtIsEmriNo.Text+"'",conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtSiparisNo.Text = dr[0].ToString();
                txtStokKodu.Text = dr[1].ToString();
                txtStokAdi.Text = dr[2].ToString();
                txtSipKalem.Text = dr[3].ToString();
                txtMiktar.Text = dr[4].ToString();
                txtMusteriKodu.Text = dr[5].ToString();
                txtMusteriAdi.Text = dr[6].ToString();
            }
            conn.Close();
        }

        void stoguuretimealma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERİ SET URETIM_DURUMU='A' WHERE SIPKALEM_ID='"+txtSipKalem.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void stoguuretimealma2()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERİ SET URETIM_DURUMU='B' WHERE SIPKALEM_ID='" + txtSipKalem.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void isemriacma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET DURUM='Y' WHERE ISEMRİ_NO='" + txtIsEmriNo.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void isemrinikapatma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET DURUM='E' WHERE ISEMRİ_NO='" + txtIsEmriNo.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        private void sbtnUretimSonuListesi_Click(object sender, EventArgs e)
        {
            FrmUretimSonuListesi frm = new FrmUretimSonuListesi();
            frm.Show();
        }

        private void FrmUretimSonuKayitlari_Load(object sender, EventArgs e)
        {

        }
    }
}
