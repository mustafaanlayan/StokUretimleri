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
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_ISEMRI WHERE ISEMRİ_NO='"+txtIsEmriNo.Text+"'",conn);
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
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_ISEMRI WHERE ISEMRİ_NO='" + txtIsEmriNo.Text + "'", conn);
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

        void isemrilistesinicekme()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1=new SqlCommand("SELECT ISEMRİ_NO,STOK_KODU,STOK_ADI,SIPARIS_NO,MIKTAR,DURUM FROM TBL_ISEMRI",conn);
            SqlDataAdapter da= new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource=dt;
            conn.Close();
        }

        void siparisnovemiktaraulasma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO,MIKTAR FROM TBL_SIPARISKALEMLERİ WHERE SIPKALEM_ID='"+txtKalemId.Text+"'", conn);
            SqlDataReader dr=sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtSiparisNo.Text = dr[0].ToString();
                txtMiktar.Text = dr[1].ToString();
            }
            conn.Close();
        }

        void temizle()
        {
            txtIsEmriAciklama.Text = "";
            txtIsEmriTarihi.Text = "";
            txtKalemId.Text = "";
            txtMiktar.Text = "";
            txtSiparisNo.Text = "";
            txtStokAdi.Text = "";
            txtTeslimTarihi.Text = "";
            txtStokKodu.Enabled = true;
            txtMiktar.Enabled = true;
            txtSiparisNo.Enabled = true;
            rbYeni.Checked=true;
        }

        private void sbtnIsEmriListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriListesi frm = new FrmIsEmriListesi();
            frm.Show();
        }

        public static string stokkodu;
        public static string isemrix;
        private void btnSiparisListesi_Click(object sender, EventArgs e)
        {
            stokkodu = txtStokKodu.Text;
            FrmIsEmriSiparisleri frm = new FrmIsEmriSiparisleri();
            frm.Show();
        }

        private void FrmIsEmri_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable=false;
            isemrilistesinicekme();
        }

        private void txtIsEmriNo_Leave(object sender, EventArgs e)
        {
            if (txtIsEmriNo.Text=="")
            {
                txtIsEmriNo.Focus();
            }
            isemricontrol();
            if (Convert.ToInt16(x1)==1)
            {
                isemribilgisicekme();
            }
            else
            {
                temizle();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtIsEmriNo.Text = dr["ISEMRİ_NO"].ToString();
            isemribilgisicekme();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            isemricontrol();
            if (Convert.ToInt16(x1)==1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_ISEMRI  WHERE ISEMRİ_NO='" + txtIsEmriNo.Text + "'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                sipariskalemikapatma();
                temizle();
                txtIsEmriNo.Text = "";
                isemrilistesinicekme();
            }
            else
            {
                MessageBox.Show("Böyle Bir İş Emri Kaydı Bulunmamaktadır");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            isemricontrol();
            if (Convert.ToInt16(x1)==1)
            {
                if (rbYeni.Checked==true)
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET ISEMRI_ACIKLAMA='" + txtIsEmriAciklama.Text + "',ISEMRI_TARIHI='" + txtIsEmriTarihi.Text + "',TESLIM_TARIHI='" + txtTeslimTarihi.Text + "',DURUM='Y' WHERE ISEMRİ_NO='"+txtIsEmriNo.Text+"' ,", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskalemiacma();
                    temizle();
                    txtIsEmriNo.Text = "";
                    isemrilistesinicekme();

                }
                else
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET ISEMRI_ACIKLAMA='" + txtIsEmriAciklama.Text + "',ISEMRI_TARIHI='" + txtIsEmriTarihi.Text + "',TESLIM_TARIHI='" + txtTeslimTarihi.Text + "',DURUM='E' WHERE ISEMRİ_NO='" + txtIsEmriNo.Text + "' ,", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskalemibitirme();
                    temizle();
                    txtIsEmriNo.Text = "";
                    isemrilistesinicekme();
                }
               

            }
            else
            {
                if (rbYeni.Checked==true)
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_ISEMRI(ISEMRİ_NO,STOK_KODU,STOK_ADI,ISEMRI_ACIKLAMA,ISEMRI_TARIHI,TESLIM_TARIHI,SIPARIS_NO,MIKTAR,SIPKALEM_ID,DURUM) VALUES ('"+txtIsEmriNo.Text+"','"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtIsEmriAciklama.Text+"','"+txtIsEmriTarihi.Text+"','"+txtTeslimTarihi.Text+"','"+txtSiparisNo.Text+"','"+txtMiktar.Text.Replace(',','.')+"','"+txtKalemId.Text+"','Y') ",conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskalemiacma();
                    temizle();
                    txtSiparisNo.Text = "";
                    isemrilistesinicekme();
                }
                else
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_ISEMRI(ISEMRİ_NO,STOK_KODU,STOK_ADI,ISEMRI_ACIKLAMA,ISEMRI_TARIHI,TESLIM_TARIHI,SIPARIS_NO,MIKTAR,SIPKALEM_ID,DURUM) VALUES ('" + txtIsEmriNo.Text + "','" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" + txtIsEmriAciklama.Text + "','" + txtIsEmriTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtSiparisNo.Text + "','" + txtMiktar.Text.Replace(',', '.') + "','" + txtKalemId.Text + "','E') ", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskalemibitirme();
                    temizle();
                    txtSiparisNo.Text = "";
                    isemrilistesinicekme();
                }
            }
        }

        private void FrmIsEmri_Activated(object sender, EventArgs e)
        {
            if (isemrix=="siparis")
            {
                txtKalemId.Text = FrmIsEmriSiparisleri.kalemid;
                if (txtKalemId.Text=="")
                {

                }
                else
                {
                    siparisnovemiktaraulasma();
                    txtMiktar.Enabled = false;
                }
            }
        }
    }
}
