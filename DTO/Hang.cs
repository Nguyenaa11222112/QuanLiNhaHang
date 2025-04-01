using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang
    {
        private int maHang;
        private string tenHang;
        private string donViTinh;
        private float donGia;
        private int soLuongCon;
        private int maLoaiHang;
        private int maNhaCungCap;

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

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public int SoLuongCon
        {
            get
            {
                return soLuongCon;
            }

            set
            {
                soLuongCon = value;
            }
        }

        public int MaLoaiHang
        {
            get
            {
                return maLoaiHang;
            }

            set
            {
                maLoaiHang = value;
            }
        }

        public int MaNhaCungCap
        {
            get
            {
                return maNhaCungCap;
            }

            set
            {
                maNhaCungCap = value;
            }
        }

        public Hang(int maHang, string tenHang, string donViTinh, float donGia, int soLuongCon, int maLoaiHang, int maNhaCungCap)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.DonViTinh = donViTinh;
            this.DonGia = donGia;
            this.SoLuongCon = soLuongCon;
            this.MaLoaiHang = maLoaiHang;
            this.MaNhaCungCap = maNhaCungCap;
        }

        public Hang(int maHang)
        {
            this.maHang = maHang;
        }
    }
}
