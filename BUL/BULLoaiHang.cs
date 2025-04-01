using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULLoaiHang
    {
        DALLoaiHang dalLKH = new DALLoaiHang();

        public List<LoaiHang> layLoaiHang()
        {
            return dalLKH.layLoaiHang();
        }
        public List<LoaiHang> layLoaiHangTheoTen(string tenLoaiHang)
        {
            return dalLKH.layLoaiHangTheoTen(tenLoaiHang);
        }
        public List<LoaiHang> layLoaiHangTheoMa(string maLoaiHang)
        {
            return dalLKH.layLoaiHangTheoMa(maLoaiHang);
        }
        public void themLoaiHang(LoaiHang lkh)
        {
            dalLKH.themLoaiHang(lkh);
        }
        public void suaLoaiHang(LoaiHang lkh)
        {
            dalLKH.suaLoaiHang(lkh);
        }
        public void xoaLoaiHang(LoaiHang lkh)
        {
            dalLKH.xoaLoaiHang(lkh);
        }
        
    }
}
