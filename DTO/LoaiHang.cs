using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang
    {
        private int maLoaiHang;
        private string tenLoaiHang;

        public LoaiHang(int maLoaiHang)
        {
            this.maLoaiHang = maLoaiHang;
        }

        public LoaiHang(int maLoaiHang, string tenLoaiHang)
        {
            this.MaLoaiHang = maLoaiHang;
            this.TenLoaiHang = tenLoaiHang;
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

        public string TenLoaiHang
        {
            get
            {
                return tenLoaiHang;
            }

            set
            {
                tenLoaiHang = value;
            }
        }
    }
}
