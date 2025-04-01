using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULLoaiKhachHang
    {
        DALLoaiKhachHang dalLKH = new DALLoaiKhachHang();

        public List<LoaiKhachHang> layLoaiKhachHang()
        {
            return dalLKH.layLoaiKhachHang();
        }
        public List<LoaiKhachHang> layLoaiKhachHangTheoTen(string tenLoaiKhachHang)
        {
            return dalLKH.layLoaiKhachHangTheoTen(tenLoaiKhachHang);
        }
        public List<LoaiKhachHang> layLoaiKhachHangTheoMa(string maLoaiKhachHang)
        {
            return dalLKH.layLoaiKhachHangTheoMa(maLoaiKhachHang);
        }
        public void themLoaiKhachHang(LoaiKhachHang lkh)
        {
            dalLKH.themLoaiKhachHang(lkh);
        }
        public void suaLoaiKhachHang(LoaiKhachHang lkh)
        {
            dalLKH.suaLoaiKhachHang(lkh);
        }
        public void xoaLoaiKhachHang(LoaiKhachHang lkh)
        {
            dalLKH.xoaLoaiKhachHang(lkh);
        }
    }
}
