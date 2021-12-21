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
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyDiemHocSinh
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }
            Ketnoi ketnoi = new Ketnoi();

        public void LOADBANG_Danhsach()
        {
            try
            {
                string stringconn = "Data Source=DESKTOP-84SCD87;Initial Catalog=QLHocSinhTHPT_1;Integrated Security=True";
                SqlConnection sqlconn = new SqlConnection(stringconn);
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DIEMHS";
                cmd.Parameters.Add(new SqlParameter("@mahocsinh", cboMaHS.Text));
                cmd.Connection = sqlconn;
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataDSHocSinh.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
            }
        
        }

            private void btnIn_Click_1(object sender, EventArgs e)
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < dataDSHocSinh.Columns.Count + 1; i++) { obj.Cells[1, i] = dataDSHocSinh.Columns[i - 1].HeaderText; }
                for (int i = 0; i < dataDSHocSinh.Rows.Count; i++)
                {
                    for (int j = 0; j < dataDSHocSinh.Columns.Count; j++)
                    {
                        if (dataDSHocSinh.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = dataDSHocSinh.Rows[i].Cells[j].Value.ToString(); }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(@"D:\" + "Diemhocsinh" + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
            }

            private void frmXuatDSLop_Load(object sender, EventArgs e)
            {
                DataTable dta = ketnoi.Lay_Dulieu("Select * from HOCSINH");
                cboMaHS.DataSource = dta;
                cboMaHS.DisplayMember = "MaHocSinh";
                cboMaHS.ValueMember = "MaHocSinh";
                LOADBANG_Danhsach();
            }

            private void btnXem_Click(object sender, EventArgs e)
            {
                LOADBANG_Danhsach();
            }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm1 = new frmMain();
            frm1.Show();

        }
    }
}
