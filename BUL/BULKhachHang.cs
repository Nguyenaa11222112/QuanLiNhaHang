using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULKhachHang
    {
        DALKhachHang dalLKH = new DALKhachHang();

        public List<KhachHang> layKhachHang()
        {
            return dalLKH.layKhachHang();
        }
        public List<KhachHang> layKhachHangTheoTen(string tenKhachHang)
        {
            return dalLKH.layKhachHangTheoTen(tenKhachHang);
        }
        public List<KhachHang> layKhachHangTheoMa(string maKhachHang)
        {
            return dalLKH.layKhachHangTheoMa(maKhachHang);
        }
        public void themKhachHang(KhachHang lkh)
        {
            dalLKH.themKhachHang(lkh);
        }
        public void suaKhachHang(KhachHang lkh)
        {
            dalLKH.suaKhachHang(lkh);
        }
        public void xoaKhachHang(KhachHang lkh)
        {
            dalLKH.xoaKhachHang(lkh);
        }
        public bool coLoaiKhachHang(string maLoai)
        {
            return dalLKH.coLoaiKhachHang(maLoai);
        }
    }
}
