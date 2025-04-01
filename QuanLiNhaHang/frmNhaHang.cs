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
using Microsoft.Reporting.WinForms;

namespace QuanLiNhaHang
{
    public partial class frmNhaHang : Form
    {
        public static NhanVien nv;
        public static TaiKhoan tk;
        public frmNhaHang()
        {
            InitializeComponent();
        }

        private void frmNhaHang_Load(object sender, EventArgs e)
        {
         
            if (tk != null)
            {
               
                if (tk.Quyen == "Quản lý")
                {
                    pKhachHang.Visible = false;
                    pHang.Visible = false;
                    stiHoaDon.Visible = false;
                    tiNCC.Visible = true;
                }
                else
                {
                    pNhaCungCap.Visible = false;
                    pNhanVien.Visible = false;
                    tiHang.Visible = true;

                }
            }

            hienDanhSachLoaiKhachHang();
            hienDanhSachHang();
            hienDanhSachHoaDon();
            hienDanhSachKhachHang();
            hienDanhSachLoaiHang();
            hienDanhSachNhaCungCap();
            hienDanhSachNhanVien();
           

        }
        public void hienDanhSachLoaiKhachHang()
        {
            BULLoaiKhachHang bul = new BULLoaiKhachHang();
            dgvLoaiKhachHang.DataSource = bul.layLoaiKhachHang();
            //dgvLoaiKhachHang.Columns[0].HeaderText = "Mã loại khách hàng";
            //dgvLoaiKhachHang.Columns[1].HeaderText = "Tên loại khách hàng";
        }
        public void hienDanhSachNhaCungCap()
        {
            BULNhaCungCap bul = new BULNhaCungCap();
            dgvNhaCungCap.DataSource = bul.layNhaCungCap();
            dgvNhaCungCap.Columns[0].HeaderText = "Mã NCC";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên NCC";
            dgvNhaCungCap.Columns[2].HeaderText = "Địa chỉ";


        }
        public void hienDanhSachNhanVien()
        {
            BULNhanVien bul = new BULNhanVien();
            dgvNhanVien.DataSource = bul.layNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[3].HeaderText = "Chứng minh thư";
            dgvNhanVien.Columns[4].HeaderText = "Tên tài khoản";
            
        }
        public void hienDanhSachLoaiHang()
        {
            BULLoaiHang bul = new BULLoaiHang();
            dgvLoaiHang.DataSource = bul.layLoaiHang();
            dgvLoaiHang.Columns[0].HeaderText = "Mã món ăn";
            dgvLoaiHang.Columns[1].HeaderText = "Tên loại món ăn";

        }
        public void hienDanhSachHang()
        {
            BULHang bul = new BULHang();
            dgvHang.DataSource = bul.layHang();
            dgvHang.Columns[0].HeaderText = "Mã món ăn";
            dgvHang.Columns[1].HeaderText = "Tên món ăn";
            dgvHang.Columns[2].HeaderText = "Đơn vị tính";
            dgvHang.Columns[3].HeaderText = "Đơn giá";
            dgvHang.Columns[4].HeaderText = "Số lượng còn";
            dgvHang.Columns[5].HeaderText = "Mã loại món ăn";
            dgvHang.Columns[6].HeaderText = "Mã NCC";



        }
        public void hienDanhSachKhachHang()
        {
            BULKhachHang bul = new BULKhachHang();
            dgvKhachHang.DataSource = bul.layKhachHang();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Họ tên";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Mã loại KH";


        }
        public void hienDanhSachHoaDon()
        {
            BULHoaDon bul = new BULHoaDon();
            dgvHoaDon.DataSource = bul.layHoaDon();
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Ngày tạo";
            dgvHoaDon.Columns[2].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns[3].HeaderText = "Mã nhân viên";

        }

        private void btnTimKiemNCCTheoMa_Click(object sender, EventArgs e)
        {
            BULNhaCungCap bul = new BULNhaCungCap();
            if (txtMaNCC.Text != "")
            {
                dgvNhaCungCap.DataSource = bul.layNhaCungCapTheoMa(txtMaNCC.Text);
            }
            else
            {
                dgvNhaCungCap.DataSource = bul.layNhaCungCap();
            }
        }

        private void btnTimKiemNCCTheoTen_Click(object sender, EventArgs e)
        {
            BULNhaCungCap bul = new BULNhaCungCap();
            if (txtTenNCC.Text != "")
            {
                dgvNhaCungCap.DataSource = bul.layNhaCungCapTheoTen(txtTenNCC.Text);
            }
            else
            {
                dgvNhaCungCap.DataSource = bul.layNhaCungCap();
            }
        }

        private void btnTimKiemNhanVienTheoMa_Click(object sender, EventArgs e)
        {
            BULNhanVien bul = new BULNhanVien();
            if (txtMaNhanVien.Text != "")
            {
                dgvNhanVien.DataSource = bul.layNhanVienTheoMa(txtMaNhanVien.Text);
            }
            else
            {
                dgvNhanVien.DataSource = bul.layNhanVien();
            }
        }

        private void btnTimKiemNhanVienTheoTen_Click(object sender, EventArgs e)
        {
            BULNhanVien bul = new BULNhanVien();
            if (txtTenNhanVien.Text != "")
            {
                dgvNhanVien.DataSource = bul.layNhanVienTheoTen(txtTenNhanVien.Text);
            }
            else
            {
                dgvNhanVien.DataSource = bul.layNhanVien();
            }
        }

        private void btnTimKiemLoaiHangTheoMa_Click(object sender, EventArgs e)
        {
            BULLoaiHang bul = new BULLoaiHang();
            if (txtMaLoaiHang.Text != "")
            {
                dgvLoaiHang.DataSource = bul.layLoaiHangTheoMa(txtMaLoaiHang.Text);
            }
            else
            {
                dgvLoaiHang.DataSource = bul.layLoaiHang();
            }
        }

        private void btnTimKiemLoaiHangTheoten_Click(object sender, EventArgs e)
        {
            BULLoaiHang bul = new BULLoaiHang();
            if (txtTenLoaiHang.Text != "")
            {
                dgvLoaiHang.DataSource = bul.layLoaiHangTheoTen(txtTenLoaiHang.Text);
            }
            else
            {
                dgvLoaiHang.DataSource = bul.layLoaiHang();
            }
        }

        private void btnTimKiemKhachHangTheoMa_Click(object sender, EventArgs e)
        {
            BULKhachHang bul = new BULKhachHang();
            if (txtMaKhachHang.Text != "")
            {
                dgvKhachHang.DataSource = bul.layKhachHangTheoMa(txtMaKhachHang.Text);
            }
            else
            {
                dgvKhachHang.DataSource = bul.layKhachHang();
            }
        }

        private void btnTimKiemKhachHangTheoTen_Click(object sender, EventArgs e)
        {
            BULKhachHang bul = new BULKhachHang();
            if (txtTenKhachHang.Text != "")
            {
                dgvKhachHang.DataSource = bul.layKhachHangTheoTen(txtTenKhachHang.Text);
            }
            else
            {
                dgvKhachHang.DataSource = bul.layKhachHang();
            }
        }

        private void btnTimHangTheoMa_Click(object sender, EventArgs e)
        {
            BULHang bul = new BULHang();
            if (txtMaHang.Text != "")
            {
                dgvHang.DataSource = bul.layHangTheoMa(txtMaHang.Text);
            }
            else
            {
                dgvHang.DataSource = bul.layHang();
            }
        }

        private void btnTimHangTheoten_Click(object sender, EventArgs e)
        {
            BULHang bul = new BULHang();
            if (txtTenHang.Text != "")
            {
                dgvHang.DataSource = bul.layHangTheoTen(txtTenHang.Text);
            }
            else
            {
                dgvHang.DataSource = bul.layHang();
            }
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            BULHoaDon bul = new BULHoaDon();
            if (txtMaHoaDon.Text != "")
            {
                dgvHoaDon.DataSource = bul.layHoaDonTheoMa(txtMaHoaDon.Text);
            }
            else
            {
                dgvHoaDon.DataSource = bul.layHoaDon();
            }
        }

        private void btnTimKiemLoaiKhachHangTheoMa_Click(object sender, EventArgs e)
        {
            BULLoaiKhachHang bul = new BULLoaiKhachHang();
            if (txtMaLoaiKhachHang.Text != "")
            {
                dgvLoaiKhachHang.DataSource = bul.layLoaiKhachHangTheoMa(txtMaLoaiKhachHang.Text);
            }
            else
            {
                dgvLoaiKhachHang.DataSource = bul.layLoaiKhachHang();
            }
        }

        private void btnTimKiemLoaiKhachLoaiKhachHangTheoTen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiemLoaiKhachHangTheoTen_Click(object sender, EventArgs e)
        {
            BULLoaiKhachHang bul = new BULLoaiKhachHang();
            if (txtTenLoaiKhachHang.Text != "")
            {
                dgvLoaiKhachHang.DataSource = bul.layLoaiKhachHangTheoTen(txtTenLoaiKhachHang.Text);
            }
            else
            {
                dgvLoaiKhachHang.DataSource = bul.layLoaiKhachHang();
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = true;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            tiNhanVien.Visible = true;
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            tiHang.Visible = true;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = true;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = true;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon(this);
            frm.ShowDialog();
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = true;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnHangBanTheoNgay_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnHangTonCuoiThang_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }

        private void btnDoanhSoBanHangThang_Click(object sender, EventArgs e)
        {
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = false;

        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien(this);
            frm.ShowDialog();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            frmSuaNhanVien frm = new frmSuaNhanVien(this);
            frm.ShowDialog();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien frm = new frmXoaNhanVien(this);
            frm.ShowDialog();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            frmThemHang frm = new frmThemHang(this);
            frm.ShowDialog();
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            frmSuaHang frm = new frmSuaHang(this);
            frm.ShowDialog();
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            frmXoaHang frm = new frmXoaHang(this);
            frm.ShowDialog();
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang frm = new frmThemLoaiHang(this);
            frm.ShowDialog();
        }

        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            frmSuaLoaiHang frm = new frmSuaLoaiHang(this);
            frm.ShowDialog();
        }

        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            frmXoaLoaiHang frm = new frmXoaLoaiHang(this);
            frm.ShowDialog();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang(this);
            frm.ShowDialog();
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang frm = new frmSuaKhachHang(this);
            frm.ShowDialog();
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            frmXoaKhachHang frm = new frmXoaKhachHang(this);
            frm.ShowDialog();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            frmThemNCC frm = new frmThemNCC(this);
            frm.ShowDialog();
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            frmSuaNCC frm = new frmSuaNCC(this);
            frm.ShowDialog();
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            frmXoaNCC frm = new frmXoaNCC(this);
            frm.ShowDialog();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDonCT.Text != "")
            {
                BULChiTietHoaDon bul = new BULChiTietHoaDon();
                dgvChiTiet.DataSource = bul.layChiTietHoaDonTheoMa(txtMaHoaDonCT.Text);
               
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            BULChiTietHoaDon bul = new BULChiTietHoaDon();
            dgvChiTiet.DataSource = bul.layChiTietHoaDonTheoMa("");
            dgvChiTiet.Columns[0].HeaderText = "Mã hàng";
            dgvChiTiet.Columns[1].HeaderText = "Mã hóa đơn";
            dgvChiTiet.Columns[2].HeaderText = "Số lượng";
            dgvChiTiet.Columns[3].HeaderText = "Thành tiền";
            tiHang.Visible = false;
            tiHoaDon.Visible = false;
            tiKhachHang.Visible = false;
            tiLoaiHang.Visible = false;
            //tiLoaiKhachHang.Visible = false;
            tiNCC.Visible = false;
            tiNhanVien.Visible = false;
            tiChiTietHoaDon.Visible = true;
        }

        private void frmSieuThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ds_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {

        }
    }
}
