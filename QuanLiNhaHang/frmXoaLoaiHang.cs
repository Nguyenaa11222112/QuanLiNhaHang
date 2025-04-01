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
    public partial class frmXoaLoaiHang : Form
    {
        frmNhaHang frmST;
        public frmXoaLoaiHang(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BULHang bulHang = new BULHang();
            if (bulHang.coLoaiHang(txtMaLoaiHang.Text))
            {
                MessageBox.Show("Có dữ liệu khác đang chứa loại hàng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    BULLoaiHang bul = new BULLoaiHang();
                    bul.xoaLoaiHang(new LoaiHang(int.Parse(txtMaLoaiHang.Text)));
                    frmST.hienDanhSachLoaiHang();
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác thất bạt, dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
                
           
        }

        private void txtMaLoaiHang_TextChanged(object sender, EventArgs e)
        {
            BULLoaiHang bul = new BULLoaiHang();
            List<LoaiHang> arr = bul.layLoaiHang();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].MaLoaiHang + "" == txtMaLoaiHang.Text)
                {

                    txtTenLoaiHang.Text = arr[i].TenLoaiHang;
                    break;
                }
                else
                {
                    txtTenLoaiHang.Text = "";
                }
            }
        }
    }
}
