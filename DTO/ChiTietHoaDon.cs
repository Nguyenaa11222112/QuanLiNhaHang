using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private int maHang;
        private int maHoaDon;
        private int soLuong;
        private float thanhTien;

        public ChiTietHoaDon(int maHang, int maHoaDon)
        {
            this.maHang = maHang;
            this.maHoaDon = maHoaDon;
        }

        public ChiTietHoaDon(int maHang, int maHoaDon, int soLuong, float thanhTien)
        {
            this.MaHang = maHang;
            this.MaHoaDon = maHoaDon;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }

        public int MaHang
        {
            get
            {
                return maHang;
            }

            set
            {
                maHang = value;
            }
        }

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

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public float ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }
    }
}
