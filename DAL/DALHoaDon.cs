using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALHoaDon
    {
        public List<HoaDon> layHoaDon()
        {
            List<HoaDon> arr = new List<HoaDon>();

            Connect.openConnect();
            string query = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoaDon x = new HoaDon(int.Parse(dr["maHoaDon"] + ""), String.Format("{0:dd/MM/yyyy}", dr["ngayGioTao"]) + "", int.Parse(dr["maKhachHang"] + ""), int.Parse(dr["maNhanVien"] + ""));
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public int layHoaDonVuaThem()
        {
            List<int> arr = new List<int>();

            Connect.openConnect();
            string sqlString = "select max(maHoaDon) as 'maxt' from HoaDon";
            SqlCommand cmd = new SqlCommand(sqlString, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int x = int.Parse(dr["maxt"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr[0];
        }
        public bool coNhanVien(string maNhanVien)
        {
            bool check = false;
            List<KhachHang> arr = new List<KhachHang>();

            Connect.openConnect();
            string query = "select * from HoaDon where maNhanVien = @maNhanVien";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maNhanVien", maNhanVien);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;
            }
            Connect.closeConnect();
            return check;
        }
        public bool coKhachHang(string maKhachHang)
        {
            bool check = false;
            List<KhachHang> arr = new List<KhachHang>();

            Connect.openConnect();
            string query = "select * from HoaDon where maKhachHang = @maKhachHang";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maKhachHang", maKhachHang);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;
            }
            Connect.closeConnect();
            return check;
        }
        public List<HoaDon> layHoaDonTheoMa(string maHoaDon)
        {
            List<HoaDon> arr = new List<HoaDon>();

            Connect.openConnect();
            string query = "select * from HoaDon where maHoaDon LIKE @maHoaDon + '%'";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maHoaDon", maHoaDon);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoaDon x = new HoaDon(int.Parse(dr["maHoaDon"] + ""), dr["ngayGioTao"] + "", int.Parse(dr["maKhachHang"] + ""), int.Parse(dr["maNhanVien"] + ""));
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public void themHoaDon(HoaDon hd)
        {
            string sql = "insert into HoaDon values(@ngayGioTao, @maKhachHang, @maNhanVien)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("ngayGioTao", hd.NgayGioTao);
            cmd.Parameters.AddWithValue("maKhachHang", hd.MaKhachHang);
            cmd.Parameters.AddWithValue("maNhanVien", hd.MaNhanVien);

            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

    }
}
