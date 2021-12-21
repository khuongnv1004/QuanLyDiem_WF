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
    public partial class frmQLLop : Form
    {
        public frmQLLop()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm1 = new frmMain();
            frm1.Show();
        }
        public void LOADBANG_LOP()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * FROM LOP");
            dataGridView1.DataSource = dta;
            Hienthi_BANGLOP();
        }
        public void LOADMAKHOI()
        {
            DataTable dta1 = ketnoi.Lay_Dulieu("Select * from KHOILOP");
            cboMaKhoi.DataSource = dta1;
            cboMaKhoi.DisplayMember = "MaKhoiLop";
            cboMaKhoi.ValueMember = "MaKhoiLop";
        }
        public void LOADNAMHOC()
        {
            DataTable dta2 = ketnoi.Lay_Dulieu("Select * from NAMHOC");
            cboMaNH.DataSource = dta2;
            cboMaNH.DisplayMember = "MaNamHoc";
            cboMaNH.ValueMember = "MaNamHoc";
        }
        public void LOADGIAOVIEN()
        {
            DataTable dta3 = ketnoi.Lay_Dulieu("Select * from GIAOVIEN");
            cboMAGV.DataSource = dta3;
            cboMAGV.DisplayMember = "MaGiaoVien";
            cboMAGV.ValueMember = "MaGiaoVien";
        }
        private void Hienthi_BANGLOP()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MaLop");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataGridView1.DataSource, "TenLop");

            cboMaKhoi.DataBindings.Clear();
            cboMaKhoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhoiLop");

            cboMaNH.DataBindings.Clear();
            cboMaNH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNamHoc");

            cboMAGV.DataBindings.Clear();
            cboMAGV.DataBindings.Add("Text", dataGridView1.DataSource, "MaGiaoVien");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Execute("Delete LOP Where MaLop = '" + txtMaLop.Text + "'");
                LOADBANG_LOP();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsua = "Update LOP Set TenLop ='" + txtTenLop.Text + "'";
                sqlsua = sqlsua + ", MaKhoiLop ='" + cboMaKhoi.Text + "', MaNamHoc ='" + cboMaNH.Text + "', MaGiaoVien ='" + cboMAGV.Text + "' where MaLop = '" + txtMaLop.Text + "'";
                ketnoi.Execute(sqlsua);
                LOADBANG_LOP();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try { 
            string sqlchen = "Insert into LOP Values('" + txtMaLop.Text + "' , '" + txtTenLop.Text + "', '" + cboMaKhoi.Text + "', '" + cboMaNH.Text + "','" + cboMAGV.Text + "')";
            ketnoi.Execute(sqlchen);
            LOADBANG_LOP();
            }
            catch (Exception)
            {
                MessageBox.Show("Xem lại quá trình nhập! Không được trùng thông tin hoặc để trống!");
            }
        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {
            LOADBANG_LOP();
            LOADMAKHOI();
            LOADGIAOVIEN();
            LOADMAKHOI();
        }
    }
}
