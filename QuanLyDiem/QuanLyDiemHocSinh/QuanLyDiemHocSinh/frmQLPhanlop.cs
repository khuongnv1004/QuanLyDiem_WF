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
    public partial class frmQLPhanlop : Form
    {

        Ketnoi ketnoi = new Ketnoi();
        public frmQLPhanlop()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm1 = new frmMain();
            frm1.Show();
        }
        public void LOADBANG_PHANLOP()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("select * from PHANLOP ");
            dataGridView1.DataSource = dta;
            Hienthi_BANGPHANLOP();
        }
        private void Hienthi_BANGPHANLOP()
        {
            cboMaNH.DataBindings.Clear();
            cboMaNH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNamHoc");

            cboMaKhoi.DataBindings.Clear();
            cboMaKhoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhoiLop");

            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MaLOp");

            cboMaHS.DataBindings.Clear();
            cboMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "MaHocSinh");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Execute("delete PHANLOP where MaNamHoc ='" + cboMaNH.Text + "'");
                LOADBANG_PHANLOP();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlchen = "Insert Into PHANLOP Values('" + cboMaNH.Text + "','" + cboMaKhoi.Text + "','" + cboMaLop.Text + "','" + cboMaHS.Text + "')";
                ketnoi.Execute(sqlchen);
                LOADBANG_PHANLOP();
            }
            catch (Exception)
            {
                MessageBox.Show("Học sinh không tồn tại hoặc đã được phân lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            cboMaNH.Text = "";
            cboMaKhoi.Text = "";
            cboMaLop.Text = "";
            cboMaHS.Text = "";
        }

        private void frmQLPhanlop_Load(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from NAMHOC");
            DataTable dt = ketnoi.Lay_Dulieu("Select * from LOP");
            DataTable dt1 = ketnoi.Lay_Dulieu("Select * from KHOILOP");
            DataTable dt2 = ketnoi.Lay_Dulieu("Select * from HOCSINH");
            cboMaNH.DataSource = dta;
            cboMaNH.DisplayMember = "MaNamHoc";
            cboMaNH.ValueMember = "MaNamHoc";
            cboMaKhoi.DataSource = dt1;
            cboMaKhoi.DisplayMember = "MaKhoiLop";
            cboMaKhoi.ValueMember = "MaKhoiLop";
            cboMaLop.DataSource = dt;
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";
            cboMaHS.DataSource = dt2;
            cboMaHS.DisplayMember = "MaHocSinh";
            cboMaHS.ValueMember = "MaHocSinh";
            LOADBANG_PHANLOP();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


        
       

    

      

     

