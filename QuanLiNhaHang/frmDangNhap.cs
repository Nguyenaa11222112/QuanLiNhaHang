using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;


namespace QuanLiNhaHang
{
    public partial class frmDangNhap : Form
    {
        frmNhaHang frmST;
        public frmDangNhap()
        {
            InitializeComponent();
          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
            BULTaiKhoan bul = new BULTaiKhoan();
            if (bul.dangNhap(tk))
            {
               
                BULNhanVien bulNV = new BULNhanVien();
                frmNhaHang.nv = bulNV.layNhanVienTheoTaiKhoan(txtTaiKhoan.Text);
                frmNhaHang.tk = bul.layTaiKhoanTheoTenTK(txtTaiKhoan.Text)[0];
                frmST.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Sai tài khoản - mật khẩu");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            frmST = new frmNhaHang();
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }
    }
}
