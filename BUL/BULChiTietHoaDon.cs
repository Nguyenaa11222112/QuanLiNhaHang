using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULChiTietHoaDon
    {
        DALChiTietHoaDon dalLKH = new DALChiTietHoaDon();

       
        public List<ChiTietHoaDon> layChiTietHoaDonTheoMa(string maHoaDon)
        {
            return dalLKH.layChiTietHoaDonTheoMa(maHoaDon);
        }
        public void themChiTietHoaDon(ChiTietHoaDon cthd)
        {
            dalLKH.themChiTietHoaDon(cthd);
        }
        public bool coHang(string ma)
        {
            return dalLKH.coHang(ma);
        }

    }
}
