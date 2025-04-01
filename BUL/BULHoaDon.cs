using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULHoaDon
    {
        DALHoaDon dalLKH = new DALHoaDon();

        public List<HoaDon> layHoaDon()
        {
            return dalLKH.layHoaDon();
        }

        public List<HoaDon> layHoaDonTheoMa(string maHoaDon)
        {
            return dalLKH.layHoaDonTheoMa(maHoaDon);
        }
        public void themHoaDon(HoaDon lkh)
        {
            dalLKH.themHoaDon(lkh);
        }
        public bool coKhachHang(string ma)
        {
            return dalLKH.coKhachHang(ma);
        }
        public bool coNhanVien(string ma)
        {
            return dalLKH.coNhanVien(ma);
        }
        public int layHoaDonVuaThem()
        {
            return dalLKH.layHoaDonVuaThem();
        }
        
    }
}
