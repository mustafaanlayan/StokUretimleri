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
        void isemricontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_ISEMRI", conn);
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
