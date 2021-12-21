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


namespace QuanLyDiemHocSinh
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from DANTOC");
            cbomadantoc.DataSource = dta;
            cbomadantoc.DisplayMember = "MaDanToc";
            cbomadantoc.ValueMember = "MaDanToc";

            DataTable dta1= ketnoi.Lay_Dulieu("Select * from TONGIAO");
            cbomatongiao.DataSource = dta1;
            cbomatongiao.DisplayMember = "MaTonGiao";
            cbomatongiao.ValueMember = "MaTonGiao";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (obtmadt.Checked == true)
            {
                sqltk = "SELECT *FROM HOCSINH  where MaDanToc  like '" + cbomadantoc.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (obtmahs.Checked == true)
            {
               sqltk = "SELECT *FROM HOCSINH  where MaHocSinh  like '" + txtMaHS.Text + "'";
               dta = ketnoi.Lay_Dulieu(sqltk);
            }
            if (obttenhs.Checked == true)
            {
                sqltk = "SELECT *FROM HOCSINH  where HoTen  like '%" + txttenhs.Text + "%'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            if (obtmatg.Checked == true)
            {
                sqltk = "SELECT *FROM HOCSINH  where MaTonGiao  like '" + cbomatongiao.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }


            dataGridView1.DataSource = dta;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm1 = new frmMain();
            frm1.Show();
        }
    }
}
