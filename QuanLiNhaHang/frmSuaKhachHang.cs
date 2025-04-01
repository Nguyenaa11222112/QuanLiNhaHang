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
    public partial class frmSuaKhachHang : Form
    {
        frmNhaHang frmST;
        public frmSuaKhachHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BULKhachHang bul = new BULKhachHang();
                bul.suaKhachHang(new KhachHang(int.Parse(txtMaKhachHang.Text) , txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, int.Parse(txtMaKhachHang.Text)));
                frmST.hienDanhSachKhachHang();
                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
