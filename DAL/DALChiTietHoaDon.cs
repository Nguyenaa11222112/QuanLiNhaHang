using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALChiTietHoaDon
    {


        public List<ChiTietHoaDon> layChiTietHoaDonTheoMa(string maHoaDon)
        {
            List<ChiTietHoaDon> arr = new List<ChiTietHoaDon>();

            Connect.openConnect();
            string query = "select * from ChiTietHoaDon where maHoaDon=@maHoaDon ";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maHoaDon", maHoaDon);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChiTietHoaDon x = new ChiTietHoaDon(int.Parse(dr["maHang"] + ""), int.Parse(dr["maHoaDon"] + ""), int.Parse(dr["soLuong"] + ""), float.Parse(dr["thanhTien"] + "") );
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public bool coHang(string maHang)
        {
            bool check = false;
            List<ChiTietHoaDon> arr = new List<ChiTietHoaDon>();

            Connect.openConnect();
            string query = "select * from ChiTietHoaDon where maHang=@maHang ";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maHang", maHang);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;
            }
            Connect.closeConnect();
            return check;
        }
        public void themChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string sql = "insert into ChiTietHoaDon values(@maHang, @maHoaDon, @soLuong, @thanhTien)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("maHang", cthd.MaHang);
            cmd.Parameters.AddWithValue("maHoaDon", cthd.MaHoaDon);
            cmd.Parameters.AddWithValue("soLuong", cthd.SoLuong);
            cmd.Parameters.AddWithValue("thanhTien", cthd.ThanhTien);

            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

    }
}
