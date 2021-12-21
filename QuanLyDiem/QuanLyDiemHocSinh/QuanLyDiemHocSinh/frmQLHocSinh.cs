using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyDiemHocSinh
{
    public partial class frmQLHocSinh : Form
    {
        Ketnoi kn = new Ketnoi();
        public frmQLHocSinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm1 = new frmMain();
            frm1.Show();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            dateNgaysinh.Text = "";
            cboMaDantoc.Text = "";
            cboMaTongiao.Text = "";
            txtDiaChi.Text = "";
            txtTenMe.Text = "";
            txtTencha.Text = "";
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            Load_DuLieu_HS();
            ShowComboBox_MaDanToc();
            ShowComboBox_MaTonGiao();
        }

        public void Load_DuLieu_HS()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select *  From HOCSINH");
            dataDanhSachHS.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void SapXep()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select *  From HOCSINH Order by NgaySinh");
            dataDanhSachHS.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", dataDanhSachHS.DataSource, "MaHocSinh");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataDanhSachHS.DataSource, "HoTen");

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", dataDanhSachHS.DataSource, "GioiTinh");

            dateNgaysinh.DataBindings.Clear();
            dateNgaysinh.DataBindings.Add("Text", dataDanhSachHS.DataSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataDanhSachHS.DataSource, "NoiSinh");

            cboMaDantoc.DataBindings.Clear();
            cboMaDantoc.DataBindings.Add("Text", dataDanhSachHS.DataSource, "MaDanToc");

            cboMaTongiao.DataBindings.Clear();
            cboMaTongiao.DataBindings.Add("Text", dataDanhSachHS.DataSource, "MaTonGiao");

            txtTencha.DataBindings.Clear();
            txtTencha.DataBindings.Add("Text", dataDanhSachHS.DataSource, "HoTenCha");

            txtTenMe.DataBindings.Clear();
            txtTenMe.DataBindings.Add("Text", dataDanhSachHS.DataSource, "HoTenMe");
        }

        public void ShowComboBox_MaDanToc()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select *  From DANTOC");
            cboMaDantoc.DataSource = dta;
            cboMaDantoc.DisplayMember = "MaDanToc";
            cboMaDantoc.ValueMember = "MaDanToc";
        }

        public void ShowComboBox_MaTonGiao()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select *  From TONGIAO");
            cboMaTongiao.DataSource = dta;
            cboMaTongiao.DisplayMember = "MaTonGiao";
            cboMaTongiao.ValueMember = "MaTonGiao";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlchen = "Insert Into HOCSINH Values('" + txtMaHS.Text + "','" + txtHoTen.Text + "','" + cboGioiTinh.Text + "','" + dateNgaysinh.Text + "','" + txtDiaChi.Text + "','" + cboMaDantoc.Text + "','" + cboMaTongiao.Text + "','" + txtTencha.Text + "','" + txtTenMe.Text + "')";
                kn.Execute(sqlchen);
                Load_DuLieu_HS();
            }
            catch
            {
                MessageBox.Show("Xem lại quá trình nhập! Không được trùng mã học sinh hoặc để trống!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "Update HOCSINH Set HoTen ='" + txtHoTen.Text + "'";
                sql2 = sql2 + ", GioiTinh ='" + cboGioiTinh.Text + "', NgaySinh = '" + dateNgaysinh.Text + "', NoiSinh ='" + txtDiaChi.Text + "', MaDanToc = '" + cboMaDantoc.Text + "', MaTonGiao = '" + cboMaTongiao.Text + "', HoTenCha = '" + txtTencha.Text + "', HoTenMe = '" + txtTenMe.Text + "' where MaHocSinh = '" + txtMaHS.Text + "'";
                kn.Execute(sql2);
                Load_DuLieu_HS();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            SapXep();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                kn.Execute("Delete HOCSINH Where MaHocSinh = '" + txtMaHS.Text + "'");
                Load_DuLieu_HS();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < dataDanhSachHS.Columns.Count + 1; i++) { obj.Cells[1, i] = dataDanhSachHS.Columns[i - 1].HeaderText; }
                for (int i = 0; i < dataDanhSachHS.Rows.Count; i++)
                {
                    for (int j = 0; j < dataDanhSachHS.Columns.Count; j++)
                    {
                        if (dataDanhSachHS.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = dataDanhSachHS.Rows[i].Cells[j].Value.ToString(); }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(@"D:\" + "DS_HocSinh" + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                MessageBox.Show("Xuất file thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại file trong thư mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }
}
