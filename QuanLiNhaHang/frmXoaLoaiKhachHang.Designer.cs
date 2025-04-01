namespace QuanLiNhaHang
{
    partial class frmXoaLoaiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaLoaiKhachHang));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenLoaiKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLoaiKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnXoa);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.txtTenLoaiKhachHang);
            this.panelEx1.Controls.Add(this.txtMaLoaiKhachHang);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(366, 193);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(165, 126);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 38);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(37, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(122, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên loại khách hàng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Mã loại khách hàng";
            // 
            // txtTenLoaiKhachHang
            // 
            // 
            // 
            // 
            this.txtTenLoaiKhachHang.Border.BorderGradientAngle = 50;
            this.txtTenLoaiKhachHang.Border.Class = "TextBoxBorder";
            this.txtTenLoaiKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiKhachHang.Border.PaddingTop = 8;
            this.txtTenLoaiKhachHang.Location = new System.Drawing.Point(165, 71);
            this.txtTenLoaiKhachHang.Multiline = true;
            this.txtTenLoaiKhachHang.Name = "txtTenLoaiKhachHang";
            this.txtTenLoaiKhachHang.Size = new System.Drawing.Size(165, 30);
            this.txtTenLoaiKhachHang.TabIndex = 2;
            // 
            // txtMaLoaiKhachHang
            // 
            // 
            // 
            // 
            this.txtMaLoaiKhachHang.Border.BorderGradientAngle = 50;
            this.txtMaLoaiKhachHang.Border.Class = "TextBoxBorder";
            this.txtMaLoaiKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLoaiKhachHang.Border.PaddingTop = 8;
            this.txtMaLoaiKhachHang.Location = new System.Drawing.Point(165, 32);
            this.txtMaLoaiKhachHang.Multiline = true;
            this.txtMaLoaiKhachHang.Name = "txtMaLoaiKhachHang";
            this.txtMaLoaiKhachHang.Size = new System.Drawing.Size(165, 30);
            this.txtMaLoaiKhachHang.TabIndex = 2;
            this.txtMaLoaiKhachHang.TextChanged += new System.EventHandler(this.txtMaLoaiKhachHang_TextChanged);
            // 
            // frmXoaLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 193);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXoaLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa loại khách hàng";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiKhachHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiKhachHang;
    }
}