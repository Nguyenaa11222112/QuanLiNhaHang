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
    public partial class frmThemKhachHang : Form
    {
        frmNhaHang frmST;
        public frmThemKhachHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BULKhachHang bul = new BULKhachHang();
                bul.themKhachHang(new KhachHang(1, txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, int.Parse(cbLoaiKhachHang.SelectedValue +"")));
                frmST.hienDanhSachKhachHang();
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
