using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string quyen;

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

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau, string quyen)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.Quyen = quyen;
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }

        public TaiKhoan(string tenTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
        }
    }
}
