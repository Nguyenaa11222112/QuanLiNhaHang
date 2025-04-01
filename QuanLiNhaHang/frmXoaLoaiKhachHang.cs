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
    public partial class frmXoaLoaiKhachHang : Form
    {
        frmNhaHang frmST;
        public frmXoaLoaiKhachHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BULKhachHang bulKhacHang = new BULKhachHang();
            if (bulKhacHang.coLoaiKhachHang(txtMaLoaiKhachHang.Text))
            {
                MessageBox.Show("Có dữ liệu khác đang chứa loại khách hàng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                try
                {
                    BULLoaiKhachHang bul = new BULLoaiKhachHang();
                    bul.xoaLoaiKhachHang(new LoaiKhachHang(int.Parse(txtMaLoaiKhachHang.Text)));
                    frmST.hienDanhSachLoaiKhachHang();
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
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
