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
    public partial class frmQuanLyDiem : Form
    {
        public frmQuanLyDiem()
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
        public void LOADBANG_DIEM()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("select * from DIEM ");
            dataDiem.DataSource = dta;
            Hienthi_BANGDIEM();
        }
        private void Hienthi_BANGDIEM()
        {
            cboNamhoc.DataBindings.Clear();
            cboNamhoc.DataBindings.Add("Text", dataDiem.DataSource, "MaNamHoc");

            cboHocky.DataBindings.Clear();
            cboHocky.DataBindings.Add("Text", dataDiem.DataSource, "MaHocKy");

            //cboKhoi.DataBindings.Clear();
            //cboKhoi.DataBindings.Add("Text", dataDiem.DataSource, "MaKhoiLop");

            cboLop.DataBindings.Clear();
            cboLop.DataBindings.Add("Text", dataDiem.DataSource, "MaLop");

            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", dataDiem.DataSource, "MaHocSinh");

            cboMonHoc.DataBindings.Clear();
            cboMonHoc.DataBindings.Add("Text", dataDiem.DataSource, "MaMonHoc");

            txtDiemMieng.DataBindings.Clear();
            txtDiemMieng.DataBindings.Add("Text", dataDiem.DataSource, "DiemMieng");

            txtDiem_15.DataBindings.Clear();
            txtDiem_15.DataBindings.Add("Text", dataDiem.DataSource, "Diem15");

            txtDiemKT.DataBindings.Clear();
            txtDiemKT.DataBindings.Add("Text", dataDiem.DataSource, "DiemKT");

            txtDiemThi.DataBindings.Clear();
            txtDiemThi.DataBindings.Add("Text", dataDiem.DataSource, "DiemThi");

            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("Text", dataDiem.DataSource, "STT");
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            cboNamhoc.Text = "";
            cboHocky.Text = "";
            cboKhoi.Text = "";
            cboLop.Text = "";
            txtMaHS.Text = "";
            cboMonHoc.Text = "";
            txtDiemMieng.Text = "";
            txtDiem_15.Text = "";
            txtDiemKT.Text = "";
            txtDiemThi.Text = "";
            txtSTT.Text = "";
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            
            try {
                if (cboNamhoc.Text == "" || cboHocky.Text == "" || cboLop.Text == "" || txtMaHS.Text == "" || txtDiemMieng.Text == "" || txtDiem_15.Text == "" || txtDiemKT.Text == "" || txtDiemThi.Text == "" || cboMonHoc.Text == "" ) 
                {

                    MessageBox.Show("Không để thông tin trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    float Mieng = float.Parse(txtDiemMieng.Text);
                    float Diem15 = float.Parse(txtDiem_15.Text);
                    float KT = float.Parse(txtDiemKT.Text);
                    float Thi = float.Parse(txtDiemThi.Text);
                    float txtDiemTB;
                    txtDiemTB = (Mieng + Diem15 + KT * 2 + Thi * 3) / 7;
                    string sqlchen = "Insert Into DIEM Values('" + txtSTT.Text + "','" + txtMaHS.Text + "','" + cboMonHoc.Text + "','" + cboHocky.Text + "','" + cboNamhoc.Text + "','" + cboLop.Text + "','" + txtDiemMieng.Text + "','" + txtDiem_15.Text + "','" + txtDiemKT.Text + "','" + txtDiemThi.Text + "','" + txtDiemTB + "')";
                    ketnoi.Execute(sqlchen);
                }
         
            } catch ( Exception )
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LOADBANG_DIEM();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNamhoc.Text == "" || cboHocky.Text == "" || cboLop.Text == "" || txtMaHS.Text == "" || txtDiemMieng.Text == "" || txtDiem_15.Text == "" || txtDiemKT.Text == "" || txtDiemThi.Text == "" || cboMonHoc.Text == "")
                {

                    MessageBox.Show("Không để thông tin trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    float Mieng = float.Parse(txtDiemMieng.Text);
                    float Diem15 = float.Parse(txtDiem_15.Text);
                    float KT = float.Parse(txtDiemKT.Text);
                    float Thi = float.Parse(txtDiemThi.Text);
                    float txtDiemTB;
                    txtDiemTB = (Mieng + Diem15 + KT * 2 + Thi * 3) / 7;
                    string sqlsua = "Update DIEM set MaHocSinh ='" + txtMaHS.Text + "'";
                    sqlsua = sqlsua + ",MaMonHoc ='" + cboMonHoc.Text + "',MaHocKy ='" + cboHocky.Text + "',MaNamHoc ='" + cboNamhoc.Text + "',DiemMieng ='" + txtDiemMieng.Text + "',Diem15 ='" + txtDiem_15.Text + "',DiemKT ='" + txtDiemKT.Text + "',DiemThi ='" + txtDiemThi.Text + "',DiemTB ='" + txtDiemTB + "' where STT ='" + txtSTT.Text + "'";
                    ketnoi.Execute(sqlsua);
                    LOADBANG_DIEM();
                }
            }
                
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu! Hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Execute("Delete DIEM Where STT = '" + txtSTT.Text + "'");
                LOADBANG_DIEM(); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void NamHoc()
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from NAMHOC");
            cboNamhoc.DataSource = dta;
            cboNamhoc.DisplayMember = "MaNamHoc";
            cboNamhoc.ValueMember = "MaNamHoc";
        }
        void HocKy()
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from HOCKY");
            cboHocky.DataSource = dta;
            cboHocky.DisplayMember = "MaHocKy";
            cboHocky.ValueMember = "MaHocKy";
        }
        void Khoi()
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from KHOILOP");
            cboKhoi.DataSource = dta;
            cboKhoi.DisplayMember = "MaKhoiLop";
            cboKhoi.ValueMember = "MaKhoiLop";
        }
        void Lop()
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from LOP");
            cboLop.DataSource = dta;
            cboLop.DisplayMember = "MaLop";
            cboLop.ValueMember = "MaLop";
        }
        void MonHoc()
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select * from MONHOC");
            cboMonHoc.DataSource = dta;
            cboMonHoc.DisplayMember = "MaMonHoc";
            cboMonHoc.ValueMember = "MaMonHoc";
        }
       
        private void frmQuanLyDiem_Load(object sender, EventArgs e)
        {
            LOADBANG_DIEM();
            NamHoc();
            HocKy();
            Khoi();
            Lop();
            MonHoc();    
        }
    }
}
