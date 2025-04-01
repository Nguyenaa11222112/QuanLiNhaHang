using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private int maNhanVien;
        private string tenNhanVien;
        private string soDienThoai;
        private string chungMinhThu;
        private string tenTaiKhoan;

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

        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }

            set
            {
                tenNhanVien = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string ChungMinhThu
        {
            get
            {
                return chungMinhThu;
            }

            set
            {
                chungMinhThu = value;
            }
        }

        public string TenTaiKhoan
        {
            get
            {
                return tenTaiKhoan;
            }

            set
            {
                tenTaiKhoan = value;
            }
        }

        public NhanVien(int maNhanVien, string tenNhanVien, string soDienThoai, string chungMinhThu, string tenTaiKhoan)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.SoDienThoai = soDienThoai;
            this.ChungMinhThu = chungMinhThu;
            this.TenTaiKhoan = tenTaiKhoan;
        }

        public NhanVien(string tenNhanVien, string soDienThoai, string chungMinhThu, string tenTaiKhoan)
        {
            this.tenNhanVien = tenNhanVien;
            this.soDienThoai = soDienThoai;
            this.chungMinhThu = chungMinhThu;
            this.tenTaiKhoan = tenTaiKhoan;
        }

        public NhanVien(int maNhanVien)
        {
            this.maNhanVien = maNhanVien;
        }
    }
}
