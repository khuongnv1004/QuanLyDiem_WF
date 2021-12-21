using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyDiemHocSinh
{
    class Ketnoi
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dta;

        public void KetNoi_Dulieu()
        {
            string strKetNoi = @"Data Source=DESKTOP-84SCD87;Initial Catalog=QLHocSinhTHPT_1;Integrated Security=True";
            conn = new SqlConnection(strKetNoi);
            conn.Open();
        }
        public void HuyKetNoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable Lay_Dulieu(string Sql)
        {
            KetNoi_Dulieu();
            da = new SqlDataAdapter(Sql, conn);
            dta = new DataTable();
            da.Fill(dta);
            return dta;
        }

        public void Execute(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }

    }
}
