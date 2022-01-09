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
    public partial class FrmIsEmriListesi : Form
    {
        public static string isemrino;
        SqlConnection conn = new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmIsEmriListesi()
        {
            InitializeComponent();
        }
        void arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISEMRİ_NO,STOK_KODU,STOK_ADI,SIPARIS_NO FROM TBL_ISEMRI WHERE ISEMRİ_NO LIKE'%"+txtIsEmriNo.Text+"%' AND STOK_KODU LIKE'%"+txtStokKodu.Text+"%' AND STOK_ADI LIKE '%"+txtStokAdi.Text+"%' AND SIPARIS_NO LIKE '%"+txtSiparisNo.Text+"%'  ",conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        private void FrmIsEmriListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (isemrino=="isemrikayıt")
            {
                isemrino = x["ISEMRİ_NO"].ToString();
                FrmIsEmri.isemrix = "isemri";
                this.Hide();
                FrmIsEmri frm=new FrmIsEmri();
                frm.Activate();
            }
        }

        private void FrmIsEmriListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            isemrino = "";
        }

        private void txtIsEmriNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtSiparisNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }
    }
}
