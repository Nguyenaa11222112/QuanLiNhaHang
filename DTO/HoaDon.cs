using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int maHoaDon;
        private string ngayGioTao;
        private int maKhachHang;
        private int maNhanVien;

        public int MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        public string NgayGioTao
        {
            get
            {
                return ngayGioTao;
            }

            set
            {
                ngayGioTao = value;
            }
        }

        public int MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public int MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public HoaDon(int maHoaDon, string ngayGioTao, int maKhachHang, int maNhanVien)
        {
            this.MaHoaDon = maHoaDon;
            this.NgayGioTao = ngayGioTao;
            this.MaKhachHang = maKhachHang;
            this.MaNhanVien = maNhanVien;
        }

        public HoaDon(int maHoaDon)
        {
            this.maHoaDon = maHoaDon;
        }
    }
}
