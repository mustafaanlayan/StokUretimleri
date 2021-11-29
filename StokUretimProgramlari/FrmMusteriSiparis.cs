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
    public partial class FrmMusteriSiparis : Form
    {
        private SqlConnection adres =
            new SqlConnection(
                @"Data Source = MUSTAFA\MUSTAFA; Initial Catalog = StokUretim; Integrated Security = True");
        public FrmMusteriSiparis()
        {
            InitializeComponent();
        }

        private string x1 = "0";

        void mustericontrol()
        {
            adres.Open();

            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT (*) FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='" + txtMusteriKodu.Text+"'", adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }
            adres.Close();
        }

        void musteribilgisicekme()
        {
            adres.Open();
            SqlCommand sorgu1 =
                new SqlCommand("SELECT * FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'",
                    adres);
            SqlDataReader dr = sorgu1.ExecuteReader();

            
            while (dr.Read())
            {
                txtMusteriAdi.Text = dr[1].ToString();
                txtAdres.Text = dr[2].ToString();
                cmbIlce.Text = dr[4].ToString();
                cmbIl.Text = dr[3].ToString();
                txtTelefon.Text = dr[5].ToString();
                txtEposta.Text = dr[6].ToString();
                string x = dr[7].ToString();
                if (x=="A")
                {
                    rAlici.Checked = true;
                }
                else
                {
                    rSatici.Checked = true;
                }
            }
            adres.Close();
            illisteleme();
            ilcelisteleme();
        }

        void illisteleme()
        {
            cmbIl.Properties.Items.Clear();
            adres.Open();
            SqlCommand sorgu1 =
                new SqlCommand("SELECT ISIM FROM TBL_IL",
                    adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            adres.Close();
        }

        void ilcelisteleme()
        {
            cmbIlce.Properties.Items.Clear();
            adres.Open();
            SqlCommand sorgu1 =
                new SqlCommand("SELECT ISIM FROM TBL_ILCE WHERE IL_ID='"+(cmbIl.SelectedIndex+1)+"'",
                    adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            adres.Close();
        }

        void temizle()
        {
            txtAdres.Text = "";
            txtAdres.Text = "";
            txtMusteriAdi.Text = "";
            txtTelefon.Text = "";
            txtEposta.Text = "";
            cmbIlce.Properties.Items.Clear();
            cmbIlce.Text = "";
            cmbIl.Properties.Items.Clear();
            cmbIl.Text = "";
            rAlici.Checked = false;
            rSatici.Checked = false;
        }

        private void FrmMusteriSiparis_Load(object sender, EventArgs e)
        {
            illisteleme();
        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e)
        {
            if (txtMusteriKodu.Text=="")
            {
                txtMusteriKodu.Focus();
            }
            else
            {
                 mustericontrol();
                if (Convert.ToInt16(x1)==1)
                {
                    musteribilgisicekme();
                    ilcelisteleme();
                }
                else
                {
                    temizle();
                    illisteleme();
                }
            }
           
        }
        

        private void cmbIl_Leave(object sender, EventArgs e)
        {
            ilcelisteleme();
            cmbIlce.Text = "";
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            mustericontrol();
            if (Convert.ToInt16(x1)==1)
            {
                if (rAlici.Checked==true)
                {
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_MUSTERIKAYITLARI SET MUSTERI_ADI='"+txtMusteriAdi.Text+"',ADRES='"+txtAdres.Text+"',IL='"+cmbIl.Text+"',ILCE='"+cmbIlce.Text+"',TELEFON='"+txtTelefon.Text+"',EPOSTA='"+txtEposta.Text+"',TIP='A' WHERE MUSTERI_KODU='"+txtMusteriKodu.Text+"'", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                }
                else
                {
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_MUSTERIKAYITLARI SET MUSTERI_ADI='" + txtMusteriAdi.Text + "',ADRES='" + txtAdres.Text + "',IL='" + cmbIl.Text + "',ILCE='" + cmbIlce.Text + "',TELEFON='" + txtTelefon.Text + "',EPOSTA='" + txtEposta.Text + "',TIP='S' WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                }
            }
            else
            {
                //ekleme
                if (rAlici.Checked==true)
                {
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT TBL_MUSTERIKAYITLARI(MUSTERI_KODU,MUSTERİ_ADI,ADRES,IL,ILCE,TELEFON,EPOSTA,TIP) VALUES ('"+txtMusteriKodu.Text+"','"+txtMusteriAdi.Text+"','"+txtAdres.Text+"','"+cmbIl.Text+"','"+cmbIlce.Text+"','"+txtTelefon.Text+"','"+txtEposta.Text+"','A') " , adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                }
                else
                {
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT TBL_MUSTERIKAYITLARI(MUSTERI_KODU,MUSTERI_ADI,ADRES,IL,ILCE,TELEFON,EPOSTA,TIP) VALUES ('" + txtMusteriKodu.Text + "','" + txtMusteriAdi.Text + "','" + txtAdres.Text + "','" + cmbIl.Text + "','" + cmbIlce.Text + "','" + txtTelefon.Text + "','" + txtEposta.Text + "','S') ", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                }
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            adres.Open();
            SqlCommand sorgu1 = new SqlCommand("DELETE TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='"+txtMusteriKodu.Text+"' ", adres);
            sorgu1.ExecuteNonQuery();
            adres.Close();
            temizle();
            txtMusteriKodu.Text = "";
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmMusteriLİstesi.musterikodu = "musterikayit";
            FrmMusteriLİstesi frm = new FrmMusteriLİstesi();
            frm.Show();
        }

        private void FrmMusteriSiparis_Activated(object sender, EventArgs e)
        {
            if (FrmMusteriLİstesi.musterikodu=="")
            {
                temizle();
                txtMusteriKodu.Text = "";
            }
            else
            {
                txtMusteriKodu.Text = FrmMusteriLİstesi.musterikodu;
                musteribilgisicekme();
            }
        }
    }
}
