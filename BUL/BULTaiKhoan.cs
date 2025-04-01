using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class BULTaiKhoan
    {
        DALTaiKhoan dalLTK = new DALTaiKhoan();

        public List<TaiKhoan> layTaiKhoan()
        {
            return dalLTK.layTaiKhoan();
        }
        public List<TaiKhoan> layTaiKhoanTheoTenTK(string tenTaiKhoan)
        {
            return dalLTK.layTaiKhoanTheoTenTK(tenTaiKhoan);
        }
        public bool dangNhap(TaiKhoan tk)
        {
            return dalLTK.dangNhap(tk);
        }
        public void themTaiKhoan(TaiKhoan tk)
        {
            dalLTK.themTaiKhoan(tk);
        }
        public void suaTaiKhoan(TaiKhoan tk)
        {
            dalLTK.suaTaiKhoan(tk);
        }
        public void xoaTaiKhoan(TaiKhoan tk)
        {
            dalLTK.xoaTaiKhoan(tk);
        }
    }
}
