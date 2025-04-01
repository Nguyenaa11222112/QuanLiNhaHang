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
    public partial class frmSuaNCC : Form
    {
        frmNhaHang frmST;
        public frmSuaNCC(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BULNhaCungCap bul = new BULNhaCungCap();
                bul.suaNhaCungCap(new NhaCungCap(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text));
                frmST.hienDanhSachNhaCungCap();
                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            BULNhaCungCap bul = new BULNhaCungCap();
            List<NhaCungCap> arr = bul.layNhaCungCap();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaNhaCungCap + "" == txtMaNCC.Text)
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

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
