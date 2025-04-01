using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALHang
    {
        DataContext db = new DataContext();
        public List<Hang> layHang()
        {
            List<Hang> arr = new List<Hang>();

            var hs = from x in db.HangLinqs
                     select new { x.maHang, x.tenHang, x.donViTinh, x.donGia, x.soLuongCon, x.maLoaiHang, x.maNhaCungCap };
            foreach (var x in hs)
            {
                Hang h = new Hang(x.maHang, x.tenHang, x.donViTinh, (float)x.donGia, x.soLuongCon, x.maLoaiHang, x.maNhaCungCap);
                arr.Add(h);
            }
            return arr;
        }
        public List<Hang> layHangTheoTen(string tenHang)
        {
            List<Hang> arr = new List<Hang>();

            var hs = from x in db.HangLinqs
                     where x.tenHang == tenHang
                     select x;
            foreach (var x in hs)
            {
                Hang h = new Hang(x.maHang, x.tenHang, x.donViTinh, (float)x.donGia, x.soLuongCon, x.maLoaiHang, x.maNhaCungCap);
                arr.Add(h);
            }
            return arr;
        }
        public bool coLoaiHang(string maLoaiHang)
        {
            bool check = false;
            List<Hang> arr = new List<Hang>();

            Connect.openConnect();
            string query = "select * from Hang where maLoaiHang = @maLoaiHang";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maLoaiHang", maLoaiHang);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;
            }
            Connect.closeConnect();
            return check;
        }
        public bool coNhaCungCap(string maNhaCungCap)
        {
            bool check = false;
            List<Hang> arr = new List<Hang>();

            Connect.openConnect();
            string query = "select * from Hang where maNhaCungCap = @maNhaCungCap";
            SqlCommand cmd = new SqlCommand(query, Connect.connect);
            cmd.Parameters.AddWithValue("maNhaCungCap", maNhaCungCap);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;
            }
            Connect.closeConnect();
            return check;
        }
        public List<Hang> layHangTheoMa(string maHang)
        {
            List<Hang> arr = new List<Hang>();

            var hs = from x in db.HangLinqs
                     where x.maHang == int.Parse(maHang)
                     select x;
            foreach (var x in hs)
            {
                Hang h = new Hang(x.maHang, x.tenHang, x.donViTinh, (float)x.donGia, x.soLuongCon, x.maLoaiHang, x.maNhaCungCap);
                arr.Add(h);
            }
            return arr;
        }
        public void themHang(Hang h)
        {
            HangLinq monan = new HangLinq();
            monan.maHang = h.MaHang;
            monan.tenHang = h.TenHang;
            monan.donViTinh = h.DonViTinh;
            monan.soLuongCon = h.SoLuongCon;
            monan.maLoaiHang = h.MaLoaiHang;
            monan.maNhaCungCap = h.MaNhaCungCap;
            monan.donGia = h.DonGia;
            db.HangLinqs.InsertOnSubmit(monan);
            db.SubmitChanges();
        }
        public void suaHang(Hang h)
        {
            var capnhat = db.HangLinqs.Single(monan => monan.maHang == h.MaHang);
            capnhat.maHang = h.MaHang;
            capnhat.tenHang = h.TenHang;
            capnhat.donViTinh = h.DonViTinh;
            capnhat.soLuongCon = h.SoLuongCon;
            capnhat.maLoaiHang = h.MaLoaiHang;
            capnhat.maNhaCungCap = h.MaNhaCungCap;
            capnhat.donGia = h.DonGia;
            db.SubmitChanges();
        }

        public void xoaHang(Hang h)
        {
            var xoa = from monan in db.HangLinqs where monan.maHang == h.MaHang select monan;
            foreach (var i in xoa)
            {
                db.HangLinqs.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
        }
    }
}
