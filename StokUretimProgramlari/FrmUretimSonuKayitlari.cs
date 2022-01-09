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
