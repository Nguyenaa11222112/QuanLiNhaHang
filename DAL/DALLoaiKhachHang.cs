using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALLoaiKhachHang
    {
        public List<LoaiKhachHang> layLoaiKhachHang()
        {
            List<LoaiKhachHang> arr = new List<LoaiKhachHang>();

            
            Connect.openConnect();
            string query = "select * from LoaiKhachHang";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiKhachHang x = new LoaiKhachHang(int.Parse(dr["maLoaiKhachHang"] + ""), dr["tenLoaiKhachHang"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public List<LoaiKhachHang> layLoaiKhachHangTheoTen(string tenLoaiKhachHang)
        {
            List<LoaiKhachHang> arr = new List<LoaiKhachHang>();

            Connect.openConnect();
            string query = "select * from LoaiKhachHang where tenLoaiKhachHang LIKE @tenLoaiKhachHang + '%'";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("tenLoaiKhachHang", tenLoaiKhachHang);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiKhachHang x = new LoaiKhachHang(int.Parse(dr["maLoaiKhachHang"] + ""), dr["tenLoaiKhachHang"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public List<LoaiKhachHang> layLoaiKhachHangTheoMa(string maLoaiKhachHang)
        {
            List<LoaiKhachHang> arr = new List<LoaiKhachHang>();

            Connect.openConnect();
            string query = "select * from LoaiKhachHang where maLoaiKhachHang LIKE @maLoaiKhachHang + '%'";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiKhachHang", maLoaiKhachHang);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiKhachHang x = new LoaiKhachHang(int.Parse(dr["maLoaiKhachHang"] + ""), dr["tenLoaiKhachHang"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public void themLoaiKhachHang(LoaiKhachHang lkh)
        {
            string sql = "insert into LoaiKhachHang values(@tenLoaiKhachHang)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("tenLoaiKhachHang", lkh.TenLoaiKhachHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
        public void suaLoaiKhachHang(LoaiKhachHang lkh)
        {
            string sql = "update LoaiKhachHang set  tenLoaiKhachHang =@tenLoaiKhachHang where maLoaiKhachHang =@maLoaiKhachHang ";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiKhachHang", lkh.MaLoaiKhachHang);
            cmd.Parameters.AddWithValue("tenLoaiKhachHang", lkh.TenLoaiKhachHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

        public void xoaLoaiKhachHang(LoaiKhachHang lkh)
        {
            string sql = "delete from LoaiKhachHang where maLoaiKhachHang=@maLoaiKhachHang";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(sql, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiKhachHang", lkh.MaLoaiKhachHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
    }
}
