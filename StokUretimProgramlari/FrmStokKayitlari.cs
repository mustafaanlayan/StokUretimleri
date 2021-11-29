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
using DevExpress.XtraPrinting.BarCode.Native;

namespace StokUretimProgramlari
{
    public partial class FrmStokKayitlari : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmStokKayitlari()
        {
            InitializeComponent();
        }

        private string x1 = "0";
        void stokkartkontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*)FROM TBL_STOKKAYITLARI WHERE STOK_KODU='"+ txtStokKodu.Text+"'",conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }
            
            conn.Close();
        }

        private string x2="0";

        void grupkontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*)FROM TBL_GRUPKOD WHERE GRUP_KODU='"+txtGrupKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }

            conn.Close();
        }


        void temizle()
        {
            txtFiyat.Text = "";
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            txtKdvOrani.Text = "";
            txtStokAdi.Text = "";
        }

        void stokbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[1].ToString();
                txtGrupKodu.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtKdvOrani.Text = dr[4].ToString();
            }
            conn.Close();
        }

        void grupbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT GRUP_ADI FROM TBL_GRUPKOD WHERE GRUP_KODU='" + txtGrupKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtGrupAdi.Text = dr[0].ToString();
            }
            conn.Close();
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmStokListesi.stokkodu = "kayit";
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            FrmStokGrupKodlari frm = new FrmStokGrupKodlari();
            frm.Show();
        }

        private void FrmStokKayitlari_Load(object sender, EventArgs e)
        {
            stokkartkontrol();
            txtFiyat.Text = "0,00";
            txtKdvOrani.Text = "0,00";
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            if (txtStokKodu.Text=="")
            {
                txtStokKodu.Focus();
            }
            else
            {
                FrmStokListesi.stokkodu = txtStokKodu.Text;
                 stokkartkontrol();
            if (Convert.ToInt32(x1)==1)
            {
                stokbilgisicekme();
                grupbilgisicekme();
            }
            else
            {
               temizle();
               txtFiyat.Text = "0,00";
               txtKdvOrani.Text = "0,00";

            }
            }
           
        }

        private void FrmStokKayitlari_Activated(object sender, EventArgs e)
        {
            if (FrmStokListesi.stokkodu=="")
            {
                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                txtStokKodu.Text = FrmStokListesi.stokkodu;
                stokbilgisicekme(); 
                grupbilgisicekme();
            }
            
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupkontrol();
            if (Convert.ToInt16(x2)==1)
            {
                grupbilgisicekme();
            }
            else
            {
                txtGrupKodu.Focus();
            }
        }

        private void FrmStokKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmStokListesi.stokkodu = "";
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            stokkartkontrol();
            if (Convert.ToInt16(x1)==1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_STOKKAYITLARI SET STOK_ADI='"+txtStokAdi.Text+"',GRUP_KODU='"+txtGrupKodu.Text.Trim()+"',FİYAT='"+txtFiyat.Text.Replace(',','.')+"',KDV_ORANI='"+txtKdvOrani.Text.Replace(',','.')+"'WHERE STOK_KODU='"+txtStokKodu.Text+"'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_STOKKAYITLARI(STOK_KODU,STOK_ADI,GRUP_KODU,FİYAT,KDV_ORANI) VALUES ('"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtGrupKodu.Text+"','"+txtFiyat.Text.Replace(',','.')+"','"+txtKdvOrani.Text.Replace(',','.')+"')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            stokkartkontrol();
            if (Convert.ToInt16(x1)==1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_STOKKAYITLARI WHERE STOK_KODU='"+txtStokKodu.Text+"'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                MessageBox.Show("Böyel Bir Stok Kodu Bulunmamaktadır");
            }
        }
    }
}
