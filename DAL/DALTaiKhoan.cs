using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALTaiKhoan
    {
        public List<TaiKhoan> layTaiKhoan()
        {
            List<TaiKhoan> arr = new List<TaiKhoan>();

       
            Connect.openConnect();
            string get = "select * from TaiKhoan";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TaiKhoan x = new TaiKhoan(dr["tenTaiKhoan"] + "", dr["matKhau"] + "", dr["quyen"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public bool dangNhap(TaiKhoan tk)
        {
            bool hopLe = false;
            List<TaiKhoan> arr = new List<TaiKhoan>();

            Connect.openConnect();
            Connect.openConnect();
            string get = "select * from TaiKhoan where tenTaiKhoan=@tenTaiKhoan and matKhau=@matKhau";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("tenTaiKhoan", tk.TenTaiKhoan);
            cmd.Parameters.AddWithValue("matKhau", tk.MatKhau);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                hopLe = true;
            }
            Connect.closeConnect();

            return hopLe;
        }
        public List<TaiKhoan> layTaiKhoanTheoTenTK(string tenTaiKhoan)
        {
            List<TaiKhoan> arr = new List<TaiKhoan>();

            Connect.openConnect();
            string get = "select * from TaiKhoan where tenTaiKhoan = @tenTaiKhoan";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("tenTaiKhoan", tenTaiKhoan);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TaiKhoan x = new TaiKhoan(dr["tenTaiKhoan"] + "", dr["matKhau"] + "", dr["quyen"] + "");

                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }

        public void themTaiKhoan(TaiKhoan tk)
        {
            string query = "insert into TaiKhoan values(@tenTaiKhoan, @matKhau, @quyen)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("tenTaiKhoan", tk.TenTaiKhoan);
            cmd.Parameters.AddWithValue("matKhau", tk.MatKhau);
            cmd.Parameters.AddWithValue("quyen", tk.Quyen);

            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
        public void suaTaiKhoan(TaiKhoan tk)
        {
            string query = "update TaiKhoan set matKhau=@matKhau, quyen=@quyen where tenTaiKhoan =@tenTaiKhoan ";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("tenTaiKhoan", tk.TenTaiKhoan);
            cmd.Parameters.AddWithValue("matKhau", tk.MatKhau);
            cmd.Parameters.AddWithValue("quyen", tk.Quyen);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

        public void xoaTaiKhoan(TaiKhoan tk)
        {
            string query = "delete from TaiKhoan where tenTaiKhoan=@tenTaiKhoan";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("tenTaiKhoan", tk.TenTaiKhoan);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
    }
}
