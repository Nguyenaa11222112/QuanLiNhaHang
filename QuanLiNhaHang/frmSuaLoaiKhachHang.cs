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
    public partial class frmSuaLoaiKhachHang : Form
    {
        frmNhaHang frmST;
        public frmSuaLoaiKhachHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BULLoaiKhachHang bul = new BULLoaiKhachHang();
                bul.suaLoaiKhachHang(new LoaiKhachHang(int.Parse(txtMaLoaiKhachHang.Text), txtTenLoaiKhachHang.Text));
                frmST.hienDanhSachKhachHang();
                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void txtMaLoaiKhachHang_TextChanged(object sender, EventArgs e)
        {
            BULLoaiKhachHang bul = new BULLoaiKhachHang();
            List<LoaiKhachHang> arr = bul.layLoaiKhachHang();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaLoaiKhachHang + "" == txtMaLoaiKhachHang.Text)
                {

                    txtTenLoaiKhachHang.Text = arr[i].TenLoaiKhachHang;
                    break;
                }
                else
                {
                    txtTenLoaiKhachHang.Text = "";
                }
            }
        }
    }
}
