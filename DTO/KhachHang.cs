using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private int maKhachHang;
        private string hoTen;
        private string diaChi;
        private string soDienThoai;
        private int maLoaiKhachHang;

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

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
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

        public int MaLoaiKhachHang
        {
            get
            {
                return maLoaiKhachHang;
            }

            set
            {
                maLoaiKhachHang = value;
            }
        }

        public KhachHang(int maKhachHang, string hoTen, string diaChi, string soDienThoai, int maLoaiKhachHang)
        {
            this.MaKhachHang = maKhachHang;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.MaLoaiKhachHang = maLoaiKhachHang;
        }

        public KhachHang(int maKhachHang)
        {
            this.maKhachHang = maKhachHang;
        }
    }
}
