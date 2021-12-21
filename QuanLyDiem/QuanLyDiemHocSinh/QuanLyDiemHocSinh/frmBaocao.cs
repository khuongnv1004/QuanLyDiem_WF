using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocSinh
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * from DIEM");
            BCDIEM BC = new BCDIEM();
            BC.SetDataSource(dta);
            CRV_BCDIEM.ReportSource = BC;
        }
    }
}
