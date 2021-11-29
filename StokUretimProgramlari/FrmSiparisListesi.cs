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
    public partial class FrmSiparisListesi : Form
    {
        private SqlConnection conn =
            new SqlConnection(
                @"Data Source = MUSTAFA\MUSTAFA; Initial Catalog = StokUretim; Integrated Security = True");
        public FrmSiparisListesi()
        {
            InitializeComponent();
        }

    }

     
}
