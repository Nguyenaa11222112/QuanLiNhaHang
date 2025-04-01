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
    public partial class frmThemNhanVien : Form
    {
        frmNhaHang frmST;
        public frmThemNhanVien(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            addComboQuyen();
        }
        void addComboQuyen()
        {
            List<string> s = new List<string>();
            s.Add("Quản lý");
            s.Add("Nhân viên bán hàng");
            cbQuyen.DataSource = s;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BULTaiKhoan bultk = new BULTaiKhoan();
                bultk.themTaiKhoan(new TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, cbQuyen.Text));

                BULNhanVien bul = new BULNhanVien();
                bul.themNhanVien(new NhanVien(0,txtTenNhanVien.Text,txtSoDienThoai.Text,txtChungMinhThu.Text,txtTaiKhoan.Text));
                frmST.hienDanhSachNhanVien();
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
