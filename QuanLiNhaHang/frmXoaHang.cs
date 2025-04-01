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
    public partial class frmXoaHang : Form
    {
        frmNhaHang frmST;
        public frmXoaHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmXoaHang_Load(object sender, EventArgs e)
        {
            hienComboBox();
        }
        void hienComboBox()
        {

            BULLoaiHang bulLH = new BULLoaiHang();
            cbLoaiHang.DataSource = bulLH.layLoaiHang();
            cbLoaiHang.DisplayMember = "tenLoaiHang";
            cbLoaiHang.ValueMember = "maLoaiHang";

            BULNhaCungCap bulNCC = new BULNhaCungCap();
            cbNCC.DataSource = bulNCC.layNhaCungCap();
            cbNCC.DisplayMember = "tenNhaCungCap";
            cbNCC.ValueMember = "maNhaCungCap";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BULChiTietHoaDon bulChiTiet = new BULChiTietHoaDon();
            if (bulChiTiet.coHang(txtMaHang.Text))
            {
                MessageBox.Show("Có dữ liệu khác đang chứa hàng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                try
                {
                    BULHang bul = new BULHang();
                    bul.xoaHang(new Hang(int.Parse(txtMaHang.Text)));
                    frmST.hienDanhSachHang();
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            
            
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            BULHang bul = new BULHang();
            List<Hang> arr = bul.layHang();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaHang + "" == txtMaHang.Text)
                {
                    txtDonGia.Text = arr[i].DonGia + "";
                    txtDonViTinh.Text = arr[i].DonViTinh;
                    txtSoLuongCon.Text = arr[i].SoLuongCon + "";
                    txtTenHang.Text = arr[i].TenHang;
                    cbLoaiHang.SelectedValue = arr[i].MaLoaiHang;
                    cbNCC.SelectedValue = arr[i].MaNhaCungCap;



                    break;
                }
                else
                {
                    txtDonGia.Text = "";
                    txtDonViTinh.Text = "";
                    txtSoLuongCon.Text = "";
                    txtTenHang.Text = "";
                }
            }
        }
    }
}
