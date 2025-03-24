namespace QLNhaSach
{
    partial class fTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTaiKhoan));
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.lblTaiKhoanThemXoaSua = new System.Windows.Forms.Label();
            this.lblMatKhauThemXoaSua = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Rockwell", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(13, 9);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(335, 32);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(79, 57);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 49;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(918, 320);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // lblTaiKhoanThemXoaSua
            // 
            this.lblTaiKhoanThemXoaSua.AutoSize = true;
            this.lblTaiKhoanThemXoaSua.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoanThemXoaSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTaiKhoanThemXoaSua.Location = new System.Drawing.Point(324, 400);
            this.lblTaiKhoanThemXoaSua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoanThemXoaSua.Name = "lblTaiKhoanThemXoaSua";
            this.lblTaiKhoanThemXoaSua.Size = new System.Drawing.Size(98, 20);
            this.lblTaiKhoanThemXoaSua.TabIndex = 2;
            this.lblTaiKhoanThemXoaSua.Text = "TÀI KHOẢN:";
            this.lblTaiKhoanThemXoaSua.Click += new System.EventHandler(this.lblTaiKhoanThemXoaSua_Click);
            // 
            // lblMatKhauThemXoaSua
            // 
            this.lblMatKhauThemXoaSua.AutoSize = true;
            this.lblMatKhauThemXoaSua.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauThemXoaSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMatKhauThemXoaSua.Location = new System.Drawing.Point(324, 451);
            this.lblMatKhauThemXoaSua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhauThemXoaSua.Name = "lblMatKhauThemXoaSua";
            this.lblMatKhauThemXoaSua.Size = new System.Drawing.Size(95, 20);
            this.lblMatKhauThemXoaSua.TabIndex = 3;
            this.lblMatKhauThemXoaSua.Text = "MẬT KHẨU:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(430, 400);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(269, 22);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(430, 451);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(269, 22);
            this.txtMatKhau.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(294, 512);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 41);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(463, 512);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.BackgroundImage")));
            this.btnCapNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhap.Location = new System.Drawing.Point(630, 512);
            this.btnCapNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(134, 41);
            this.btnCapNhap.TabIndex = 8;
            this.btnCapNhap.Text = "ĐỔi MK";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.chkHienMatKhau.Location = new System.Drawing.Point(720, 451);
            this.chkHienMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(111, 20);
            this.chkHienMatKhau.TabIndex = 9;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = false;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            // 
            // fTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 599);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblMatKhauThemXoaSua);
            this.Controls.Add(this.lblTaiKhoanThemXoaSua);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.lblTaiKhoan);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTaiKhoan";
            this.Text = "TÀI KHOẢN";
            this.Load += new System.EventHandler(this.fTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoanThemXoaSua;
        private System.Windows.Forms.Label lblMatKhauThemXoaSua;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
    }
}