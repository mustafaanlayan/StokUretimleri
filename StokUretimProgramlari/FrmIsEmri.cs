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
    public partial class FrmIsEmri : Form
    {
        SqlConnection conn=new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmIsEmri()
        {
            InitializeComponent();
        }
        string x1 = "0";
        void isemricontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_ISEMRI WHERE ISEMRI_NO='"+txtIsEmriNo.Text+"'",conn);
            SqlDataReader dr=sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1=dr[0].ToString();
            }
            conn.Close();
        }

        void isemribilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_ISEMRI WHERE ISEMRI_NO='" + txtIsEmriNo.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokKodu.Text=dr[1].ToString();
                txtStokAdi.Text= dr[2].ToString();
                txtIsEmriAciklama.Text=dr[3].ToString();
                txtIsEmriTarihi.Text=dr[4].ToString();
                txtTeslimTarihi.Text =dr[5].ToString();
                txtSiparisNo.Text=dr[6].ToString();
                txtMiktar.Text=dr[7].ToString();
                txtKalemId.Text=dr[8].ToString();  
                string x=dr[9].ToString();
                if (x=="Y")
                {
                    rbYeni.Checked = true;
                }
                else
                {
                    rbTamamlanmis.Checked = true;
                }
            }
            conn.Close();
            txtStokKodu.Enabled=false;
            txtMiktar.Enabled=false;    
            txtSiparisNo.Enabled=false;
        }
        string x2 = "0";
        void stokkartıkontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
               x2 = dr[0].ToString();
            }
            conn.Close();
        }

        void stokbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[0].ToString();
            }
            conn.Close();
        }

        void sipariskalemiacma()
        {
            conn.Open();
            SqlCommand sorgu1=new SqlCommand("UPDATE TBL_SIPARISKALEMLERİ SET URETIM_DURUMU='A' WHERE SIPKALEM_ID='"+txtKalemId.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void sipariskalemikapatma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERİ SET URETIM_DURUMU='K' WHERE SIPKALEM_ID='" + txtKalemId.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void sipariskalemibitirme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERİ SET URETIM_DURUMU='B' WHERE SIPKALEM_ID='" + txtKalemId.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
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

        private void FrmIsEmri_Load(object sender, EventArgs e)
        {

        }
    }
}
