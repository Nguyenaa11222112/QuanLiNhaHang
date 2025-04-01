using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULNhaCungCap
    {
        DALNhaCungCap dalLKH = new DALNhaCungCap();

        public List<NhaCungCap> layNhaCungCap()
        {
            return dalLKH.layNhaCungCap();
        }
        public List<NhaCungCap> layNhaCungCapTheoTen(string tenNhaCungCap)
        {
            return dalLKH.layNhaCungCapTheoTen(tenNhaCungCap);
        }
        public List<NhaCungCap> layNhaCungCapTheoMa(string maNhaCungCap)
        {
            return dalLKH.layNhaCungCapTheoMa(maNhaCungCap);
        }
        public void themNhaCungCap(NhaCungCap lkh)
        {
            dalLKH.themNhaCungCap(lkh);
        }
        public void suaNhaCungCap(NhaCungCap lkh)
        {
            dalLKH.suaNhaCungCap(lkh);
        }
        public void xoaNhaCungCap(NhaCungCap lkh)
        {
            dalLKH.xoaNhaCungCap(lkh);
        }
    }
}
