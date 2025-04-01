using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALNhanVien
    {

        public List<NhanVien> layNhanVien()
        {
            List<NhanVien> arr = new List<NhanVien>();

            Connect.openConnect();
            string get = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien x = new NhanVien(int.Parse(dr["maNhanVien"] + ""), dr["tenNhanVien"] + "", dr["soDienThoai"] + "", dr["chungMinhThu"] + "", dr["tenTaiKhoan"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }

        public List<NhanVien> layNhanVienTheoTen(string tenNhanVien)
        {
            List<NhanVien> arr = new List<NhanVien>();

            Connect.openConnect();
            string get = "select * from NhanVien where tenNhanVien LIKE @tenNhanVien + '%'";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("tenNhanVien", tenNhanVien);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien x = new NhanVien(int.Parse(dr["maNhanVien"] + ""), dr["tenNhanVien"] + "", dr["soDienThoai"] + "", dr["chungMinhThu"] + "", dr["tenTaiKhoan"] + "");

                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }

        public NhanVien layNhanVienTheoTaiKhoan(string tenTaiKhoan)
        {
            List<NhanVien> arr = new List<NhanVien>();

            Connect.openConnect();
            string get = "select * from NhanVien where tenTaiKhoan=@tenTaiKhoan";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("tenTaiKhoan", tenTaiKhoan);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien x = new NhanVien(int.Parse(dr["maNhanVien"] + ""), dr["tenNhanVien"] + "", dr["soDienThoai"] + "", dr["chungMinhThu"] + "", dr["tenTaiKhoan"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr[0];
        }
        public List<NhanVien> layNhanVienTheoMa(string maNhanVien)
        {
            List<NhanVien> arr = new List<NhanVien>();

            Connect.openConnect();
            string get = "select * from NhanVien where maNhanVien LIKE @maNhanVien + '%'";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("maNhanVien", maNhanVien);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien x = new NhanVien(int.Parse(dr["maNhanVien"] + ""), dr["tenNhanVien"] + "", dr["soDienThoai"] + "", dr["chungMinhThu"] + "", dr["tenTaiKhoan"] + "");

                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public void themNhanVien(NhanVien lkh)
        {
            string query = "insert into NhanVien values(@tenNhanVien, @soDienThoai, @chungMinhThu, @tenTaiKhoan)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("tenNhanVien", lkh.TenNhanVien);
            cmd.Parameters.AddWithValue("soDienThoai", lkh.SoDienThoai);
            cmd.Parameters.AddWithValue("chungMinhThu", lkh.ChungMinhThu);
            cmd.Parameters.AddWithValue("tenTaiKhoan", lkh.TenTaiKhoan);

            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
        public void suaNhanVien(NhanVien lkh)
        {
            string query = "update NhanVien set tenNhanVien=@tenNhanVien, soDienThoai=@soDienThoai, chungMinhThu=@chungMinhThu, tenTaiKhoan=@tenTaiKhoan where maNhanVien =@maNhanVien ";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maNhanVien", lkh.MaNhanVien);
            cmd.Parameters.AddWithValue("tenNhanVien", lkh.TenNhanVien);
            cmd.Parameters.AddWithValue("soDienThoai", lkh.SoDienThoai);
            cmd.Parameters.AddWithValue("chungMinhThu", lkh.ChungMinhThu);
            cmd.Parameters.AddWithValue("tenTaiKhoan", lkh.TenTaiKhoan);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

        public void xoaNhanVien(NhanVien lkh)
        {
            string query = "delete from NhanVien where maNhanVien=@maNhanVien";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maNhanVien", lkh.MaNhanVien);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
    }
}
