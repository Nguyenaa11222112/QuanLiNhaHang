using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALKhachHang
    {
        public List<KhachHang> layKhachHang()
        {
            List<KhachHang> arr = new List<KhachHang>();

           
            Connect.openConnect();
            string query = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHang x = new KhachHang(int.Parse(dr["maKhachHang"] + ""), dr["hoTen"] + "", dr["diaChi"] + "", dr["soDienThoai"] + "",int.Parse(dr["maLoaiKhachHang"] + ""));
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public List<KhachHang> layKhachHangTheoTen(string hoTen)
        {
            List<KhachHang> arr = new List<KhachHang>();

            Connect.openConnect();
            string query = "select * from KhachHang where hoTen LIKE @hoTen + '%'";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("hoTen", hoTen);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHang x = new KhachHang(int.Parse(dr["maKhachHang"] + ""), dr["hoTen"] + "", dr["diaChi"] + "", dr["soDienThoai"] + "", int.Parse(dr["maLoaiKhachHang"] + ""));

                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public bool coLoaiKhachHang(string maLoaiKhachHang)
        {
            bool check = false;
            List<KhachHang> arr = new List<KhachHang>();

            Connect.openConnect();
            string query = "select * from KhachHang where maLoaiKhachHang = @maLoaiKhachHang";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiKhachHang", maLoaiKhachHang);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;
            }
            Connect.closeConnect();
            return check;
        }
        public List<KhachHang> layKhachHangTheoMa(string maKhachHang)
        {
            List<KhachHang> arr = new List<KhachHang>();

            Connect.openConnect();
            string query = "select * from KhachHang where maKhachHang LIKE @maKhachHang + '%'";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maKhachHang", maKhachHang);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHang x = new KhachHang(int.Parse(dr["maKhachHang"] + ""), dr["hoTen"] + "", dr["diaChi"] + "", dr["soDienThoai"] + "", int.Parse(dr["maLoaiKhachHang"] + ""));

                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public void themKhachHang(KhachHang kh)
        {
            string sql = "insert into KhachHang values(@hoTen, @diaChi, @soDienThoai, @maLoaiKhachHang)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("hoTen", kh.HoTen);
            cmd.Parameters.AddWithValue("diaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("maLoaiKhachHang", kh.MaLoaiKhachHang);

            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
        public void suaKhachHang(KhachHang kh)
        {
            string sql = "update KhachHang set hoTen=@hoTen, diaChi=@diaChi, soDienThoai=@soDienThoai, maLoaiKhachHang=@maLoaiKhachHang where maKhachHang =@maKhachHang ";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("maKhachHang", kh.MaKhachHang);
            cmd.Parameters.AddWithValue("hoTen", kh.HoTen);
            cmd.Parameters.AddWithValue("diaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("maLoaiKhachHang", kh.MaLoaiKhachHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

        public void xoaKhachHang(KhachHang kh)
        {
            string sql = "delete from KhachHang where maKhachHang=@maKhachHang";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("maKhachHang", kh.MaKhachHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
    }
}
