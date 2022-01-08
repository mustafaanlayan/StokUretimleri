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
    public partial class FrmIsEmriSiparisleri : Form
    {
        public static string kalemid;
        SqlConnection conn = new SqlConnection(@"Data Source=MUSTAFA\MUSTAFA;Initial Catalog=StokUretim;Integrated Security=True");
        public FrmIsEmriSiparisleri()
        {
            InitializeComponent();
        }

        private void FrmIsEmriSiparisleri_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable=false;
            conn.Open();
            DataTable dt=new DataTable();
            SqlCommand sorgu1=new SqlCommand("SELECT SIPARIS_NO,STOK_KODU,STOK_ADI,MIKTAR,SIPKALEM_ID FROM TBL_SIPARISKALEMLERİ WHERE STOK_KODU='"+FrmIsEmri.stokkodu+"' AND URETIM_DURUMU='K'",conn);
            SqlDataAdapter da=new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();  
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            kalemid = x["SIPKALEM_ID"].ToString();
            FrmIsEmri.isemrix = "siparis";
            this.Hide();
            FrmIsEmri frm=new FrmIsEmri();
            frm.Activate();
        }
    }
}
