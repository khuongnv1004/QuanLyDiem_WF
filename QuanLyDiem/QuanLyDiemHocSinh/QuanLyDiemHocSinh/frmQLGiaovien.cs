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
using app = Microsoft.Office.Interop.Excel.Application;


namespace QuanLyDiemHocSinh
{
    public partial class frmQLGiaovien : Form
    {
        public frmQLGiaovien()
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
        public void LOADBANG_GIAOVIEN()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("select * from GIAOVIEN ");
            dataQL_Giaovien.DataSource = dta;
            dataQL_Giaovien.Columns[0].HeaderText = "Mã Giáo Viên";
            dataQL_Giaovien.Columns[1].HeaderText = "Tên Giáo Viên";
            dataQL_Giaovien.Columns[2].HeaderText = "Địa chỉ ";
            dataQL_Giaovien.Columns[3].HeaderText = "Số điện thoại";
            dataQL_Giaovien.Columns[4].HeaderText = "Mã môn học";
            dataQL_Giaovien.AutoResizeColumns();
            Hienthi_BANGGIAOVIEN();
        }
        private void Hienthi_BANGGIAOVIEN()
        {
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", dataQL_Giaovien.DataSource, "MaGiaoVien");

            txtTenGV.DataBindings.Clear();
            txtTenGV.DataBindings.Add("Text", dataQL_Giaovien.DataSource, "TenGiaoVien");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dataQL_Giaovien.DataSource, "DiaChi");

            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", dataQL_Giaovien.DataSource, "DienThoai");

            cboMaMH.DataBindings.Clear();
            cboMaMH.DataBindings.Add("Text", dataQL_Giaovien.DataSource, "MaMonHoc");
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDiachi.Text = "";
            txtSoDT.Text = "";
            cboMaMH.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlchen = "Insert Into GIAOVIEN Values('" + txtMaGV.Text + "','" + txtTenGV.Text + "','" + txtDiachi.Text + "','" + txtSoDT.Text + "','" + cboMaMH.Text + "'   )";
                ketnoi.Execute(sqlchen);
                LOADBANG_GIAOVIEN();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try { 
            string sqlsua = "Update GIAOVIEN set TenGiaoVien ='" + txtTenGV.Text + "'";
            sqlsua = sqlsua + ",DiaChi ='" + txtDiachi.Text + "',DienThoai ='" + txtSoDT.Text + "',MaMonHoc ='" + cboMaMH.Text + "' where MaGiaoVien ='" + txtMaGV.Text + "'";
            ketnoi.Execute(sqlsua);
            LOADBANG_GIAOVIEN();
            } catch (Exception)
            {
                MessageBox.Show("Lỗi kết nỗi cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Execute("delete GIAOVIEN where MaGiaoVien ='" + txtMaGV.Text + "'");
                LOADBANG_GIAOVIEN();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void frmQLGiaovien_Load(object sender, EventArgs e)
        //{
        //    DataTable dta = ketnoi.Lay_Dulieu("Select * from MONHOC");
        //    cboMaMH.DataSource = dta;
        //    cboMaMH.DisplayMember = "MaMonHoc";
        //    cboMaMH.ValueMember = "MaMonHoc";
        //    LOADBANG_GIAOVIEN();
        //}

        private void frmQLGiaovien_Load_1(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from MONHOC");
            cboMaMH.DataSource = dta;
            cboMaMH.DisplayMember = "MaMonHoc";
            cboMaMH.ValueMember = "MaMonHoc";
            LOADBANG_GIAOVIEN();
        }

        private void dataQL_Giaovien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try { 
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < dataQL_Giaovien.Columns.Count + 1; i++) { obj.Cells[1, i] = dataQL_Giaovien.Columns[i - 1].HeaderText; }
            for (int i = 0; i < dataQL_Giaovien.Rows.Count; i++)
            {
                for (int j = 0; j < dataQL_Giaovien.Columns.Count; j++)
                {
                    if (dataQL_Giaovien.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = dataQL_Giaovien.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(@"D:\" + "Giaovien" + ".xlsx");
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








        

       

       

       

     
