namespace QuanLiNhaHang
{
    partial class frmXoaKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaKhachHang));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbLoaiKhachHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSoDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbLoaiKhachHang);
            this.panelEx1.Controls.Add(this.btnXoa);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.txtSoDienThoai);
            this.panelEx1.Controls.Add(this.txtDiaChi);
            this.panelEx1.Controls.Add(this.txtHoTen);
            this.panelEx1.Controls.Add(this.txtMaKhachHang);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(372, 299);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // cbLoaiKhachHang
            // 
            this.cbLoaiKhachHang.DisplayMember = "Text";
            this.cbLoaiKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiKhachHang.FormattingEnabled = true;
            this.cbLoaiKhachHang.ItemHeight = 20;
            this.cbLoaiKhachHang.Location = new System.Drawing.Point(154, 182);
            this.cbLoaiKhachHang.MaxDropDownItems = 5;
            this.cbLoaiKhachHang.Name = "cbLoaiKhachHang";
            this.cbLoaiKhachHang.Size = new System.Drawing.Size(165, 26);
            this.cbLoaiKhachHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiKhachHang.TabIndex = 22;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(154, 231);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 38);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(54, 184);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(85, 23);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "Loại khách hàng";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(54, 145);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(97, 23);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "Số điện thoại";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(54, 106);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "Địa chỉ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(54, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 17;
            this.labelX2.Text = "Họ tên";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(54, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "khách hàng";
            // 
            // txtSoDienThoai
            // 
            // 
            // 
            // 
            this.txtSoDienThoai.Border.BorderGradientAngle = 50;
            this.txtSoDienThoai.Border.Class = "TextBoxBorder";
            this.txtSoDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoDienThoai.Border.PaddingTop = 8;
            this.txtSoDienThoai.Location = new System.Drawing.Point(154, 141);
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(165, 30);
            this.txtSoDienThoai.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.BorderGradientAngle = 50;
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Border.PaddingTop = 8;
            this.txtDiaChi.Location = new System.Drawing.Point(154, 102);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(165, 30);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.Border.BorderGradientAngle = 50;
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoTen.Border.PaddingTop = 8;
            this.txtHoTen.Location = new System.Drawing.Point(154, 63);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(165, 30);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaKhachHang
            // 
            // 
            // 
            // 
            this.txtMaKhachHang.Border.BorderGradientAngle = 50;
            this.txtMaKhachHang.Border.Class = "TextBoxBorder";
            this.txtMaKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKhachHang.Border.PaddingTop = 8;
            this.txtMaKhachHang.Location = new System.Drawing.Point(154, 24);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(165, 30);
            this.txtMaKhachHang.TabIndex = 11;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // frmXoaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 299);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXoaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa khách hàng";
            this.Load += new System.EventHandler(this.frmXoaKhachHang_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKhachHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiKhachHang;
    }
}