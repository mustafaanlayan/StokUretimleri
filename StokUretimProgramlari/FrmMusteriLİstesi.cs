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
    
    public partial class FrmMusteriLİstesi : Form
    {
        public static string musterikodu; 
        SqlConnection conn = new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmMusteriLİstesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            conn.Open();
            DataTable dt =
                new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_KODU,MUSTERİ_ADI,IL,ILCE FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU LIKE '%"+txtMusteriKodu.Text+"%' AND MUSTERİ_ADI LIKE '%"+txtMusteriAdi.Text+"%' AND IL LIKE '%"+txtIl.Text+"%' AND ILCE LIKE '%"+txtIlce.Text+"%' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }

        private void FrmMusteriLİstesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtMusteriKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIlce_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (musterikodu=="musterikayit")
            {
                musterikodu = x["MUSTERI_KODU"].ToString();
                this.Hide();
                FrmMusteriSiparis frm = new FrmMusteriSiparis();
                frm.Activate();
            }
            else
            {
                if (musterikodu=="sipariskayıt")
                {
                    musterikodu = x["MUSTERI_KODU"].ToString();
                    FrmSiparisKaydi.siparisx = "musteri";
                    this.Hide();
                    FrmSiparisKaydi frm = new FrmSiparisKaydi();
                    frm.Activate();
                }
            }
        }

        private void FrmMusteriLİstesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            musterikodu = "";
        }
    }
}
