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
using System.Data.Sql;

namespace QuanLyDiemHocSinh
{
    public partial class frmDangNhap : Form
    {
        Ketnoi kn = new Ketnoi();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            try
            {

                string select = "Select * From NGUOIDUNG where TenDNhap='" + txtUser.Text + "' and MatKhau='" + txtPassword.Text + "'";

                SqlCommand cmd = new SqlCommand(select, Ketnoi.conn);
                SqlDataReader datRed = cmd.ExecuteReader();
                if (datRed.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    frmMain frm1 = new frmMain();
                    frm1.Show();
                    // Visible = false;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với Cơ sở dữ liệu!");
            }
        }
    }
}
