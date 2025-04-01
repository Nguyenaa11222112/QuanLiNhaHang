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
    public partial class frmXoaNCC : Form
    {
        frmNhaHang frmST;
        public frmXoaNCC(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BULHang bulHang = new BULHang();
            if (bulHang.coNhaCungCap(txtMaNCC.Text))
            {
                MessageBox.Show("Có dữ liệu khác đang chứa nhà cung cấp này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {

                    BULNhaCungCap bul = new BULNhaCungCap();
                    bul.xoaNhaCungCap(new NhaCungCap(int.Parse(txtMaNCC.Text)));
                    frmST.hienDanhSachNhaCungCap();

                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


            
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            BULNhaCungCap bul = new BULNhaCungCap();
            List<NhaCungCap> arr = bul.layNhaCungCap ();
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaNhaCungCap+"" == txtMaNCC.Text)
                {
                    txtTenNCC.Text = arr[i].TenNhaCungCap;
                    txtDiaChi.Text = arr[i].DiaChi;
                    break;
                }
                else
                {
                    txtTenNCC.Text = "";
                    txtDiaChi.Text = "";

                }
            }
        }
    }
}
