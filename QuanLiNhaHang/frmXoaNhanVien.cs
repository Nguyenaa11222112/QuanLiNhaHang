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
    public partial class frmXoaNhanVien : Form
    {
        frmNhaHang frmST;
        public frmXoaNhanVien(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmXoaNhanVien_Load(object sender, EventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == frmNhaHang.nv.MaNhanVien +"")
            {
                MessageBox.Show("Thao tác thất bạt, không được xóa chính bạn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                BULHoaDon bulHoaDon = new BULHoaDon();
                if (bulHoaDon.coNhanVien(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Có dữ liệu khác đang chứa nhân viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {

                        BULNhanVien bul = new BULNhanVien();
                        bul.xoaNhanVien(new NhanVien(int.Parse(txtMaNhanVien.Text)));
                        frmST.hienDanhSachNhanVien();

                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            BULNhanVien bul = new BULNhanVien();
            List<NhanVien> arr = bul.layNhanVien();
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaNhanVien+"" == txtMaNhanVien.Text)
                {
                    txtTenNhanVien.Text = arr[i].TenNhanVien;
                    txtTaiKhoan.Text = arr[i].TenTaiKhoan;
                    txtSoDienThoai.Text = arr[i].SoDienThoai;
                   
                    txtChungMinhThu.Text = arr[i].ChungMinhThu;
                    BULTaiKhoan bultk = new BULTaiKhoan();
                    txtMatKhau.Text = bultk.layTaiKhoanTheoTenTK(txtTaiKhoan.Text)[0].MatKhau;
                    cbQuyen.Text = bultk.layTaiKhoanTheoTenTK(txtTaiKhoan.Text)[0].Quyen;
                    break;
                }
                else
                {
                    txtTenNhanVien.Text = "";
                    txtTaiKhoan.Text = "";
                    txtSoDienThoai.Text = "";

                    txtChungMinhThu.Text = "";
                   
                    txtMatKhau.Text = "";
                  
                }
            }
        }
    }
}
