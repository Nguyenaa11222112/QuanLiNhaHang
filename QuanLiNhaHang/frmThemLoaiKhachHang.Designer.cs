namespace QuanLiNhaHang
{
    partial class frmThemLoaiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiKhachHang));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
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
            this.panelEx1.Controls.Add(this.btnThem);
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
            this.panelEx1.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(165, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 38);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.txtMaLoaiKhachHang.Enabled = false;
            this.txtMaLoaiKhachHang.Location = new System.Drawing.Point(165, 32);
            this.txtMaLoaiKhachHang.Multiline = true;
            this.txtMaLoaiKhachHang.Name = "txtMaLoaiKhachHang";
            this.txtMaLoaiKhachHang.Size = new System.Drawing.Size(165, 30);
            this.txtMaLoaiKhachHang.TabIndex = 2;
            // 
            // frmThemLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 193);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại khách hàng";
            this.Load += new System.EventHandler(this.frmThemLoaiKhachHang_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiKhachHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiKhachHang;
    }
}