using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULHang
    {
        DALHang dalLKH = new DALHang();

        public List<Hang> layHang()
        {
            return dalLKH.layHang();
        }
        public List<Hang> layHangTheoTen(string tenHang)
        {
            return dalLKH.layHangTheoTen(tenHang);
        }
        public List<Hang> layHangTheoMa(string maHang)
        {
            return dalLKH.layHangTheoMa(maHang);
        }
        public void themHang(Hang lkh)
        {
            dalLKH.themHang(lkh);
        }
        public void suaHang(Hang lkh)
        {
            dalLKH.suaHang(lkh);
        }
        public void xoaHang(Hang lkh)
        {
            dalLKH.xoaHang(lkh);
        }
        public bool coLoaiHang(string ma)
        {
            return dalLKH.coLoaiHang(ma);
        }
        public bool coNhaCungCap(string ma)
        {
            return dalLKH.coNhaCungCap(ma);
        }
    }
}
