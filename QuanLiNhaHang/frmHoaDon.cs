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
    public partial class frmHoaDon : Form
    {
        frmNhaHang frmST;
        public frmHoaDon(frmNhaHang frm)
        {
            InitializeComponent();
            this.frmST = frm;
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvGio);
                row.Cells[0].Value = txtMaHang.Text;
                row.Cells[1].Value = txtTenHang.Text;
                row.Cells[2].Value = txtDonGia.Text;
                row.Cells[3].Value = txtSoLuong.Text;
                row.Cells[4].Value = double.Parse(txtDonGia.Text) * double.Parse(txtSoLuong.Text);
                bool ktra = false;
                for (int i = 0; i < dgvGio.RowCount - 1; i++)
                {
                    if (dgvGio.Rows[i].Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        dgvGio.Rows[i].Cells[3].Value = double.Parse(dgvGio.Rows[i].Cells[3].Value + "") + double.Parse(row.Cells[3].Value + "");
                        dgvGio.Rows[i].Cells[4].Value = double.Parse(dgvGio.Rows[i].Cells[2].Value + "") * double.Parse(dgvGio.Rows[i].Cells[3].Value + "");
                        ktra = true;
                        break;
                    }
                }
                if (!ktra)
                {
                    dgvGio.Rows.Add(row);
                }

                double tongTien = 0;
                for (int i = 0; i < dgvGio.RowCount - 1; i++)
                {
                    tongTien += double.Parse(dgvGio.Rows[i].Cells[4].Value + "");
                }
                txtTongTien.Text = tongTien + "";
                txtMaHang.Text = "";
                txtSoLuong.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, xem lại dữ liệu hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
   
        }

        private void dgvGio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    txtTenHang.Text = arr[i].TenHang;
                    
                    break;
                }
                else
                {
                    txtDonGia.Text = "";
                    txtTenHang.Text = "";
                }
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

                    txtTenKhachHang.Text = arr[i].HoTen;
                  
                    break;
                }
                else
                {
                    txtTenKhachHang.Text = "";
                  
                }
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtMaNhanVien.Text = frmNhaHang.nv.MaNhanVien +"";
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                BULHoaDon bulhd = new BULHoaDon();
                bulhd.themHoaDon(new HoaDon(1, DateTime.Now.ToShortDateString(), int.Parse(txtMaKhachHang.Text), int.Parse(txtMaNhanVien.Text)));
                BULChiTietHoaDon bulct = new BULChiTietHoaDon();

                for (int i = 0; i < dgvGio.RowCount - 1; i++)
                {
                    ChiTietHoaDon cthd = new ChiTietHoaDon(int.Parse(dgvGio.Rows[i].Cells[0].Value + ""), bulhd.layHoaDonVuaThem(), int.Parse(dgvGio.Rows[i].Cells[3].Value + ""), int.Parse(dgvGio.Rows[i].Cells[4].Value + ""));

                    bulct.themChiTietHoaDon(cthd);
                }
                MessageBox.Show("Tạo hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmST.hienDanhSachHoaDon();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, xem lại dữ liệu hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }
    }
}
