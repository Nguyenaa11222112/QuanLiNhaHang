using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALLoaiHang
    {
        public List<LoaiHang> layLoaiHang()
        {
            List<LoaiHang> arr = new List<LoaiHang>();

            
            Connect.openConnect();
            string get = "select * from LoaiHang";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHang x = new LoaiHang(int.Parse(dr["maLoaiHang"] + ""), dr["tenLoaiHang"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public List<LoaiHang> layLoaiHangTheoTen(string tenLoaiHang)
        {
            List<LoaiHang> arr = new List<LoaiHang>();

            Connect.openConnect();
            string get = "select * from LoaiHang where tenLoaiHang LIKE @tenLoaiHang + '%'";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("tenLoaiHang", tenLoaiHang);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHang x = new LoaiHang(int.Parse(dr["maLoaiHang"] + ""), dr["tenLoaiHang"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public List<LoaiHang> layLoaiHangTheoMa(string maLoaiHang)
        {
            List<LoaiHang> arr = new List<LoaiHang>();

            Connect.openConnect();
            string get = "select * from LoaiHang where maLoaiHang LIKE @maLoaiHang + '%'";
            SqlCommand cmd = new SqlCommand(get, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiHang", maLoaiHang);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHang x = new LoaiHang(int.Parse(dr["maLoaiHang"] + ""), dr["tenLoaiHang"] + "");
                arr.Add(x);
            }
            Connect.closeConnect();
            return arr;
        }
        public void themLoaiHang(LoaiHang lh)
        {
            string query = "insert into LoaiHang values(@tenLoaiHang)";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("tenLoaiHang", lh.TenLoaiHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
        public void suaLoaiHang(LoaiHang lh)
        {
            string query = "update LoaiHang set  tenLoaiHang =@tenLoaiHang where maLoaiHang =@maLoaiHang ";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiHang", lh.MaLoaiHang);
            cmd.Parameters.AddWithValue("tenLoaiHang", lh.TenLoaiHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }

        public void xoaLoaiHang(LoaiHang lh)
        {
            string query = "delete from LoaiHang where maLoaiHang=@maLoaiHang";
            Connect.openConnect();
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiHang", lh.MaLoaiHang);
            cmd.ExecuteNonQuery();
            Connect.closeConnect();
        }
    }
}
