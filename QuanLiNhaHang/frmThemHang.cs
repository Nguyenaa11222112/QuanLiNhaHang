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
    public partial class frmThemHang : Form
    {
        frmNhaHang frmST;
        public frmThemHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void frmThemHang_Load(object sender, EventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BULHang bul = new BULHang();
                bul.themHang(new Hang(1, txtTenHang.Text, txtDonViTinh.Text, float.Parse(txtDonGia.Text), int.Parse(txtSoLuongCon.Text), int.Parse(cbLoaiHang.SelectedValue + ""), int.Parse(cbNCC.SelectedValue + "")));
                frmST.hienDanhSachHang();
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
