namespace QuanLiNhaHang
{
    partial class frmXoaLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaLoaiHang));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenLoaiHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLoaiHang = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.panelEx1.Controls.Add(this.txtTenLoaiHang);
            this.panelEx1.Controls.Add(this.txtMaLoaiHang);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(371, 185);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(161, 126);
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
            this.labelX2.Location = new System.Drawing.Point(45, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên loại hàng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(45, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Mã loại hàng";
            // 
            // txtTenLoaiHang
            // 
            // 
            // 
            // 
            this.txtTenLoaiHang.Border.BorderGradientAngle = 50;
            this.txtTenLoaiHang.Border.Class = "TextBoxBorder";
            this.txtTenLoaiHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiHang.Border.PaddingTop = 8;
            this.txtTenLoaiHang.Location = new System.Drawing.Point(161, 71);
            this.txtTenLoaiHang.Multiline = true;
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(165, 30);
            this.txtTenLoaiHang.TabIndex = 2;
            // 
            // txtMaLoaiHang
            // 
            // 
            // 
            // 
            this.txtMaLoaiHang.Border.BorderGradientAngle = 50;
            this.txtMaLoaiHang.Border.Class = "TextBoxBorder";
            this.txtMaLoaiHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLoaiHang.Border.PaddingTop = 8;
            this.txtMaLoaiHang.Location = new System.Drawing.Point(161, 32);
            this.txtMaLoaiHang.Multiline = true;
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(165, 30);
            this.txtMaLoaiHang.TabIndex = 2;
            this.txtMaLoaiHang.TextChanged += new System.EventHandler(this.txtMaLoaiHang_TextChanged);
            // 
            // frmXoaLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 185);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXoaLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa loại hàng";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiHang;
    }
}