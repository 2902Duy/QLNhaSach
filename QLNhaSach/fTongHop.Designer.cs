namespace QLNhaSach
{
    partial class fTongHop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTongHop));
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tssTaiKhoan = new System.Windows.Forms.ToolStripSplitButton();
            this.tmiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSach = new System.Windows.Forms.ToolStripSplitButton();
            this.tmiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiNhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tssHoaDon = new System.Windows.Forms.ToolStripSplitButton();
            this.tmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbKhoHang = new System.Windows.Forms.ToolStripButton();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.tlsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsMenu
            // 
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTaiKhoan,
            this.tssSach,
            this.tssHoaDon,
            this.tsbKhoHang});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(953, 26);
            this.tlsMenu.TabIndex = 0;
            this.tlsMenu.Text = "Menu";
            // 
            // tssTaiKhoan
            // 
            this.tssTaiKhoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiTaiKhoan,
            this.tmiDangXuat});
            this.tssTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("tssTaiKhoan.Image")));
            this.tssTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssTaiKhoan.Name = "tssTaiKhoan";
            this.tssTaiKhoan.Size = new System.Drawing.Size(37, 23);
            this.tssTaiKhoan.Text = "Tài Khoản";
            // 
            // tmiTaiKhoan
            // 
            this.tmiTaiKhoan.Name = "tmiTaiKhoan";
            this.tmiTaiKhoan.Size = new System.Drawing.Size(159, 26);
            this.tmiTaiKhoan.Text = "Tài khoản";
            this.tmiTaiKhoan.Click += new System.EventHandler(this.tmiTaiKhoan_Click);
            // 
            // tmiDangXuat
            // 
            this.tmiDangXuat.Name = "tmiDangXuat";
            this.tmiDangXuat.Size = new System.Drawing.Size(159, 26);
            this.tmiDangXuat.Text = "Đăng xuất";
            // 
            // tssSach
            // 
            this.tssSach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiSach,
            this.tmiLoaiSach,
            this.tmiTacGia,
            this.tmiNhaXuatBan});
            this.tssSach.Image = ((System.Drawing.Image)(resources.GetObject("tssSach.Image")));
            this.tssSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssSach.Name = "tssSach";
            this.tssSach.Size = new System.Drawing.Size(37, 23);
            this.tssSach.Text = "L";
            // 
            // tmiSach
            // 
            this.tmiSach.Name = "tmiSach";
            this.tmiSach.Size = new System.Drawing.Size(179, 26);
            this.tmiSach.Text = "Sách";
            // 
            // tmiLoaiSach
            // 
            this.tmiLoaiSach.Name = "tmiLoaiSach";
            this.tmiLoaiSach.Size = new System.Drawing.Size(179, 26);
            this.tmiLoaiSach.Text = "Loại sách";
            // 
            // tmiTacGia
            // 
            this.tmiTacGia.Name = "tmiTacGia";
            this.tmiTacGia.Size = new System.Drawing.Size(179, 26);
            this.tmiTacGia.Text = "Tác giả";
            // 
            // tmiNhaXuatBan
            // 
            this.tmiNhaXuatBan.Name = "tmiNhaXuatBan";
            this.tmiNhaXuatBan.Size = new System.Drawing.Size(179, 26);
            this.tmiNhaXuatBan.Text = "Nhà xuất bản";
            // 
            // tssHoaDon
            // 
            this.tssHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiHoaDon,
            this.tmiThongKe});
            this.tssHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tssHoaDon.Image")));
            this.tssHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssHoaDon.Name = "tssHoaDon";
            this.tssHoaDon.Size = new System.Drawing.Size(37, 23);
            this.tssHoaDon.Text = "toolStripSplitButton3";
            // 
            // tmiHoaDon
            // 
            this.tmiHoaDon.Name = "tmiHoaDon";
            this.tmiHoaDon.Size = new System.Drawing.Size(152, 26);
            this.tmiHoaDon.Text = "Hóa đơn";
            // 
            // tmiThongKe
            // 
            this.tmiThongKe.Name = "tmiThongKe";
            this.tmiThongKe.Size = new System.Drawing.Size(152, 26);
            this.tmiThongKe.Text = "Thống kê";
            // 
            // tsbKhoHang
            // 
            this.tsbKhoHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbKhoHang.Image")));
            this.tsbKhoHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKhoHang.Name = "tsbKhoHang";
            this.tsbKhoHang.Size = new System.Drawing.Size(28, 23);
            this.tsbKhoHang.Text = "Kho hàng";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(33, 66);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 49;
            this.dgvSach.Size = new System.Drawing.Size(884, 347);
            this.dgvSach.TabIndex = 1;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaiKhoan.Location = new System.Drawing.Point(631, 31);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(164, 25);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "TÀI KHOẢN: duy";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDoanhThu.Location = new System.Drawing.Point(29, 441);
            this.lblDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(130, 20);
            this.lblDoanhThu.TabIndex = 3;
            this.lblDoanhThu.Text = "DOANH THU: 00";
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoKhachHang.Location = new System.Drawing.Point(29, 475);
            this.lblSoKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(160, 20);
            this.lblSoKhachHang.TabIndex = 4;
            this.lblSoKhachHang.Text = "SỐ KHÁCH HÀNG: 0";
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNgayThang.Location = new System.Drawing.Point(825, 502);
            this.lblNgayThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(91, 20);
            this.lblNgayThang.TabIndex = 5;
            this.lblNgayThang.Text = "dd-mm-yyyy";
            // 
            // fTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 534);
            this.Controls.Add(this.lblNgayThang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.tlsMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fTongHop";
            this.Text = "fView";
            this.Load += new System.EventHandler(this.fTongHop_Load);
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripSplitButton tssTaiKhoan;
        private System.Windows.Forms.ToolStripSplitButton tssSach;
        private System.Windows.Forms.ToolStripSplitButton tssHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tmiTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tmiSach;
        private System.Windows.Forms.ToolStripMenuItem tmiLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem tmiTacGia;
        private System.Windows.Forms.ToolStripMenuItem tmiNhaXuatBan;
        private System.Windows.Forms.ToolStripMenuItem tmiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tmiThongKe;
        private System.Windows.Forms.ToolStripButton tsbKhoHang;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.Label lblNgayThang;
    }
}