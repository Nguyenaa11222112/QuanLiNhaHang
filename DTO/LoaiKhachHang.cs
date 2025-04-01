using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHang
    {
        private int maLoaiKhachHang;
        private string tenLoaiKhachHang;

        public LoaiKhachHang(int maLoaiKhachHang)
        {
            this.maLoaiKhachHang = maLoaiKhachHang;
        }

        public LoaiKhachHang(int maLoaiKhachHang, string tenLoaiKhachHang)
        {
            this.MaLoaiKhachHang = maLoaiKhachHang;
            this.TenLoaiKhachHang = tenLoaiKhachHang;
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

        public string TenLoaiKhachHang
        {
            get
            {
                return tenLoaiKhachHang;
            }

            set
            {
                tenLoaiKhachHang = value;
            }
        }
    }
}
