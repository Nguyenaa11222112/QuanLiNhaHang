namespace QuanLiNhaHang
{
    partial class frmXoaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaHang));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbLoaiHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbNCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSoLuongCon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbLoaiHang);
            this.panelEx1.Controls.Add(this.cbNCC);
            this.panelEx1.Controls.Add(this.btnXoa);
            this.panelEx1.Controls.Add(this.labelX7);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.txtSoLuongCon);
            this.panelEx1.Controls.Add(this.txtDonGia);
            this.panelEx1.Controls.Add(this.txtDonViTinh);
            this.panelEx1.Controls.Add(this.txtTenHang);
            this.panelEx1.Controls.Add(this.txtMaHang);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(369, 392);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.DisplayMember = "Text";
            this.cbLoaiHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.ItemHeight = 20;
            this.cbLoaiHang.Location = new System.Drawing.Point(150, 227);
            this.cbLoaiHang.MaxDropDownItems = 5;
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(165, 26);
            this.cbLoaiHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiHang.TabIndex = 21;
            // 
            // cbNCC
            // 
            this.cbNCC.DisplayMember = "Text";
            this.cbNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.ItemHeight = 20;
            this.cbNCC.Location = new System.Drawing.Point(150, 266);
            this.cbNCC.MaxDropDownItems = 5;
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(165, 26);
            this.cbNCC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNCC.TabIndex = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(150, 324);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 38);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(54, 268);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 3;
            this.labelX7.Text = "Nhà cung cấp";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(54, 229);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "Loại hàng";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(54, 190);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Số lượng còn";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(54, 151);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Đơn giá";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(54, 112);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Đơn vị tính";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(54, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên hàng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(54, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Mã hàng";
            // 
            // txtSoLuongCon
            // 
            // 
            // 
            // 
            this.txtSoLuongCon.Border.BorderGradientAngle = 50;
            this.txtSoLuongCon.Border.Class = "TextBoxBorder";
            this.txtSoLuongCon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuongCon.Border.PaddingTop = 8;
            this.txtSoLuongCon.Location = new System.Drawing.Point(150, 186);
            this.txtSoLuongCon.Multiline = true;
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Size = new System.Drawing.Size(165, 30);
            this.txtSoLuongCon.TabIndex = 2;
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.Border.BorderGradientAngle = 50;
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.Border.PaddingTop = 8;
            this.txtDonGia.Location = new System.Drawing.Point(150, 147);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(165, 30);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtDonViTinh
            // 
            // 
            // 
            // 
            this.txtDonViTinh.Border.BorderGradientAngle = 50;
            this.txtDonViTinh.Border.Class = "TextBoxBorder";
            this.txtDonViTinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonViTinh.Border.PaddingTop = 8;
            this.txtDonViTinh.Location = new System.Drawing.Point(150, 108);
            this.txtDonViTinh.Multiline = true;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(165, 30);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // txtTenHang
            // 
            // 
            // 
            // 
            this.txtTenHang.Border.BorderGradientAngle = 50;
            this.txtTenHang.Border.Class = "TextBoxBorder";
            this.txtTenHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHang.Border.PaddingTop = 8;
            this.txtTenHang.Location = new System.Drawing.Point(150, 69);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(165, 30);
            this.txtTenHang.TabIndex = 2;
            // 
            // txtMaHang
            // 
            // 
            // 
            // 
            this.txtMaHang.Border.BorderGradientAngle = 50;
            this.txtMaHang.Border.Class = "TextBoxBorder";
            this.txtMaHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHang.Border.PaddingTop = 8;
            this.txtMaHang.Location = new System.Drawing.Point(150, 30);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(165, 30);
            this.txtMaHang.TabIndex = 2;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // frmXoaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 392);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXoaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa hàng";
            this.Load += new System.EventHandler(this.frmXoaHang_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuongCon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonViTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNCC;
    }
}