using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private int maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;

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

        public string TenNhaCungCap
        {
            get
            {
                return tenNhaCungCap;
            }

            set
            {
                tenNhaCungCap = value;
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

        public NhaCungCap(int maNhaCungCap, string tenNhaCungCap, string diaChi)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
        }

        public NhaCungCap(int maNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
        }
    }
}
