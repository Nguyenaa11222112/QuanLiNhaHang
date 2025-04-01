using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace QuanLiNhaHang
{
    public partial class frmXoaKhachHang : Form
    {
        frmNhaHang frmST;
        public frmXoaKhachHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmXoaKhachHang_Load(object sender, EventArgs e)
        {
            hienLoaiKH();
        }
        void hienLoaiKH()
        {
            BULLoaiKhachHang bul = new BULLoaiKhachHang();
            cbLoaiKhachHang.DataSource = bul.layLoaiKhachHang();
            cbLoaiKhachHang.DisplayMember = "tenLoaiKhachHang";
            cbLoaiKhachHang.ValueMember = "maLoaiKhachHang";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BULHoaDon bulHoaDon = new BULHoaDon();
            if (bulHoaDon.coKhachHang(txtMaKhachHang.Text))
            {
                MessageBox.Show("Có dữ liệu khác đang chứa khách hàng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    BULKhachHang bul = new BULKhachHang();
                    bul.xoaKhachHang(new KhachHang(int.Parse(txtMaKhachHang.Text)));
                    frmST.hienDanhSachKhachHang();
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
                
            
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            BULKhachHang bul = new BULKhachHang();
            List<KhachHang> arr = bul.layKhachHang();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaKhachHang + "" == txtMaKhachHang.Text)
                {

                    txtHoTen.Text = arr[i].HoTen;
                    txtDiaChi.Text = arr[i].DiaChi;
                    txtSoDienThoai.Text = arr[i].SoDienThoai;
                    cbLoaiKhachHang.SelectedValue = arr[i].MaLoaiKhachHang;
                    break;
                }
                else
                {
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                }
            }
        }
    }
}
