using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULNhanVien
    {
        DALNhanVien dalLKH = new DALNhanVien();

        public List<NhanVien> layNhanVien()
        {
            return dalLKH.layNhanVien();
        }
        public List<NhanVien> layNhanVienTheoTen(string tenNhanVien)
        {
            return dalLKH.layNhanVienTheoTen(tenNhanVien);
        }
        public List<NhanVien> layNhanVienTheoMa(string maNhanVien)
        {
            return dalLKH.layNhanVienTheoMa(maNhanVien);
        }
        public NhanVien layNhanVienTheoTaiKhoan(string tenTaiKhoan)
        {
            return dalLKH.layNhanVienTheoTaiKhoan(tenTaiKhoan);
        }
        public void themNhanVien(NhanVien lkh)
        {
            dalLKH.themNhanVien(lkh);
        }
        public void suaNhanVien(NhanVien lkh)
        {
            dalLKH.suaNhanVien(lkh);
        }
        public void xoaNhanVien(NhanVien lkh)
        {
            dalLKH.xoaNhanVien(lkh);
        }
    }
}
