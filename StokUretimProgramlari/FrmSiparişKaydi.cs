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
         string sipkalem = "";
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
                new SqlCommand("SELECT COUNT (*) FROM TBL_SIPARISLER WHERE SIPARIS_NO='" + txtSiparisNo.Text + "'", conn);
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
                new SqlCommand("SELECT * FROM TBL_SIPARISLER WHERE SIPARIS_NO='" + txtSiparisNo.Text + "'", conn);
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

         string x3="0";
        void stokkontrol()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT (*) FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x3 = dr[0].ToString();
            }
            conn.Close();
        }

        void stokbilgisicekme()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI, FIYAT, KDV_ORANI FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtStokAdi.Text = dr1[0].ToString();
                txtFiyat.Text = dr1[1].ToString();
                txtKdv.Text = dr1[2].ToString();
            }
            conn.Close();
        }


        void geneltoplamhesaplama()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT SUM((MIKTAR*FIYAT)*((KDV/100)+1)) FROM TBL_SIPARISKALEMLERİ WHERE SIPARIS_NO='"+txtSiparisNo.Text+"'GROUP BY SIPARIS_NO" , conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtToplamTutar.Text = dr1[0].ToString();
            }
            conn.Close();
        }

        private string x4 = "0";

        void kalemsayma()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_SIPARISKALEMLERİ WHERE SIPARIS_NO='"+txtSiparisNo.Text+"' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x4= dr1[0].ToString();
            }
            conn.Close();
        }

        void temizle1()
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
            txtUrunAciklamasi.Text = "";
            txtFiyat.Text = "";
            txtKdv.Text = "";
            txtMiktar.Text = "";
        }

        void temizle2()
        {
            txtSiparisTarihi.Text = "";
            txtTeslimTarihi.Text = "";
            txtMusteriKodlari.Text = "";
            txtMusteriAdlari.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtToplamTutar.Text = "";
            temizle1();

        }
        string x6 = "0";

        void sipgenelisemrikontrol()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT (*) FROM TBL_SIPARISKALEMLERİ WHERE SIPARIS_NO='"+txtSiparisNo.Text+ "'AND (URETIM_DURUMU='A' OR URETIM_DURUMU='B' OR URETIM_DURUMU='S')", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x6 = dr1[0].ToString();
            }
            conn.Close();
        }

        private string x5 = "0";
        void sipariskalemleriisemrikontrol()
        {
            conn.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT URETIM_DURUMU FROM TBL_SIPARISKALEMLERİ WHERE SIPKALEM_ID='"+sipkalem+"' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x5 = (dr1[0].ToString()).Trim();
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

        private void txtSiparisNo_Leave(object sender, EventArgs e)
        {
            txtMusteriAdlari.Enabled = false;
            txtIl.Enabled = false;
            txtIlce.Enabled = false;
            txtStokKodu.Enabled = true;
            sipariscontrol();
            if (Convert.ToInt16(x1)==1)
            {
                siparisbilgicekeme1();
                siparisbilgicekeme2();
                mustertibilgisicekme();
                txtMusteriKodlari.Enabled = false;
            }
            else
            {
                if (txtSiparisNo.Text=="")
                {
                    txtSiparisNo.Focus();

                }
                else
                {
                    siparisbilgicekeme2();
                    temizle2();
                    txtMusteriKodlari.Enabled = true;
                }
            }
        }

        private void txtMusteriKodlari_Leave(object sender, EventArgs e)
        {
            mustericontrol();
            if (Convert.ToInt16(x2)==1)
            {
                mustertibilgisicekme();
            }
            else
            {
                txtMusteriKodlari.Focus();
            }
        }

        private void FrmSiparişKaydi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            txtStokAdi.Enabled = false;
            txtKdv.Enabled = false;
            txtFiyat.Enabled = false;
            txtUrunAciklamasi.Enabled = false;
            txtMiktar.Enabled = false;
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            stokkontrol();
            if (Convert.ToInt16(x3)==1)
            {
                stokbilgisicekme();
                txtUrunAciklamasi.Enabled = true;
                //txtStokAdi.Enabled = true;
                txtFiyat.Enabled = true;
                txtKdv.Enabled = true;
                txtMiktar.Enabled = true;
                txtMiktar.Text = "0,00";
            }
            else
            {
                txtStokKodu.Focus();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (sipkalem=="")
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand(
                    "INSERT INTO TBL_SIPARISKALEMLERİ (SIPARIS_NO,STOK_KODU,STOK_ADI,MIKTAR,URUN_ACIKLAMA,FIYAT,KDV,URETIM_DURUMU)VALUES ('" +
                    txtSiparisNo.Text + "','" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" +
                    txtMiktar.Text.Replace(',', '.') + "','" + txtUrunAciklamasi.Text + "','" +
                    txtFiyat.Text.Replace(',', '.') + "','" + txtKdv.Text.Replace(',', '.') + "','K')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle1();
                siparisbilgicekeme2();
                geneltoplamhesaplama();
            }
            else
            {
               conn.Open();
               SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERİ SET MIKTAR='"+ txtMiktar.Text.Replace(',','.')+"',URUN_ACIKLAMA='"+txtUrunAciklamasi.Text+"',FIYAT='"+txtFiyat.Text.Replace(',','.')+"',KDV='"+txtKdv.Text.Replace(',','.')+"' WHERE SIPKALEM_ID='"+sipkalem+"'",conn);
               sorgu1.ExecuteNonQuery();
               conn.Close();
               temizle1();
               siparisbilgicekeme2();
               geneltoplamhesaplama();
            }

            sipariscontrol();
            if (Convert.ToInt16(x1)==1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISLER SET SIPARIS_TARIHI='"+txtSiparisTarihi.Text+"',TESLIM_TARIHI='"+txtTeslimTarihi.Text+"',TOPLAM_TUTAR='"+txtToplamTutar.Text.Replace(',','.')+"' WHERE SIPARIS_NO='"+txtSiparisNo.Text+"' ", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT TBL_SIPARISLER (SIPARIS_NO,MUSTERI_KODU,SIPARIS_TARIHI,TESLIM_TARIHI,TOPLAM_TUTAR) VALUES ('"+txtSiparisNo.Text+"','"+txtMusteriKodlari.Text+"','"+txtSiparisTarihi.Text+"','"+txtTeslimTarihi.Text+"','"+txtToplamTutar.Text.Replace(',','.')+"')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtStokKodu.Text = x["STOK_KODU"].ToString();
            txtStokAdi.Text = x["STOK_ADI"].ToString();
            txtFiyat.Text = x["FIYAT"].ToString();
            txtMiktar.Text = x["MIKTAR"].ToString();
            txtKdv.Text = x["KDV"].ToString();
            sipkalem = x["SIPKALEM_ID"].ToString();
            txtStokKodu.Enabled = true;
            txtMiktar.Enabled = true;
            txtKdv.Enabled = true;
            txtUrunAciklamasi.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
            sipariskalemleriisemrikontrol();
            if (x5=="K")
            {
                
                conn.Open();
                SqlCommand sorgu1 =
                    new SqlCommand("DELETE TBL_SIPARISKALEMLERİ WHERE SIPKALEM_ID='" + sipkalem + "'",conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle1();
                siparisbilgicekeme2();
                sipkalem = "";
                txtStokKodu.Enabled = true;
                kalemsayma();
                if (Convert.ToInt16(x4)==0)
                {
                    txtToplamTutar.Text = "0,00";
                }
                else
                {
                    geneltoplamhesaplama();
                }
                conn.Open();
                SqlCommand sorgu2 = new SqlCommand("UPDATE TBL_SIPARISLER SET SIPARIS_TARIHI='" + txtSiparisTarihi.Text + "',TESLIM_TARIHI='" + txtTeslimTarihi.Text + "',TOPLAM_TUTAR='" + txtToplamTutar.Text.Replace(',', '.') + "' WHERE SIPARIS_NO='" + txtSiparisNo.Text + "' ", conn);
                sorgu2.ExecuteNonQuery();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Bu Sipariş Kalemine Ait İş Emri Bulunmaktadır");
            }
           
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            sipgenelisemrikontrol();
            if (Convert.ToInt16(x6)==0)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_SIPARISLER WHERE SIPARIS_NO='"+txtSiparisNo.Text+"'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand sorgu2 = new SqlCommand("DELETE TBL_SIPARISKALEMLERİ WHERE SIPARIS_NO='" + txtSiparisNo.Text + "'", conn);
                sorgu2.ExecuteNonQuery();
                conn.Close();
                temizle2();
                txtSiparisNo.Text = "";
                siparisbilgicekeme2();
            }
            else
            {
                MessageBox.Show("Bu Siparişe Ait İş Emri Kaydı veya Kayıtları Bulunmaktadır "); 
            }

        }

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            sipariscontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISLER SET SIPARIS_TARIHI='" + txtSiparisTarihi.Text + "',TESLIM_TARIHI='" + txtTeslimTarihi.Text + "',TOPLAM_TUTAR='" + txtToplamTutar.Text.Replace(',', '.') + "' WHERE SIPARIS_NO='" + txtSiparisNo.Text + "' ", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT TBL_SIPARISLER (SIPARIS_NO,MUSTERI_KODU,SIPARIS_TARIHI,TESLIM_TARIHI,TOPLAM_TUTAR) VALUES ('" + txtSiparisNo.Text + "','" + txtMusteriKodlari.Text + "','" + txtSiparisTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtToplamTutar.Text.Replace(',', '.') + "')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            siparisbilgicekeme1();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmMusteriLİstesi frm = new FrmMusteriLİstesi();
            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }
    }
}