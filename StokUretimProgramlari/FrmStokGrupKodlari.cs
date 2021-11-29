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
    public partial class FrmStokGrupKodlari : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmStokGrupKodlari()
        {
            InitializeComponent();
        }

        private string x1 = "0";
        void grupkodukontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*)FROM TBL_GRUPKOD WHERE GRUP_KODU='" + txtGrupKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }

            conn.Close();
        }

        void temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
        }

        void grupkodubilgisicekme()
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

        void grupkoduListele()
        {
            conn.Open();
            DataTable dt =
                new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_GRUPKOD", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }

        private void FrmStokGrupKodlari_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            grupkoduListele();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow satir = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtGrupKodu.Text = satir["GRUP_KODU"].ToString();
            txtGrupAdi.Text = satir["GRUP_ADI"].ToString();
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupkodukontrol();
            if (Convert.ToInt16(x1)==1)
            {
                grupkodubilgisicekme();
            }
            else
            {
                txtGrupAdi.Text = "";
            }
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            grupkodukontrol();
            if (Convert.ToInt16(x1)==1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_GRUPKOD SET GRUP_ADI='"+txtGrupAdi.Text+"' WHERE GRUP_KODU='"+txtGrupKodu.Text+"'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                grupkoduListele();
            }
            else
            {
                
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT TBL_GRUPKOD(GRUP_KODU,GRUP_ADI)VALUES ('"+txtGrupKodu.Text+"','"+txtGrupAdi.Text+"')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                grupkoduListele();
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            if (txtGrupKodu.Text=="")
            {
                
            }
            else
            {
                conn.Open();
                 SqlCommand sorgu1 = new SqlCommand("DELETE TBL_GRUPKOD WHERE GRUP_KODU='" + txtGrupKodu.Text + "'", conn);
                sorgu1.ExecuteNonQuery();
                temizle();
                 conn.Close();
                 grupkoduListele();
            }
            
        }
    }
}
