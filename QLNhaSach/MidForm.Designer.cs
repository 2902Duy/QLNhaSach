namespace QLNhaSach
{
    partial class MidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MidForm));
            this.reporthdTableAdapter1 = new QLNhaSach.QLSACHDataSetTableAdapters.REPORTHDTableAdapter();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1_left = new System.Windows.Forms.Panel();
            this.pb_PhongTo = new System.Windows.Forms.PictureBox();
            this.pb_Thoat = new System.Windows.Forms.PictureBox();
            this.pb_ThuNho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PhongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Thoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ThuNho)).BeginInit();
            this.SuspendLayout();
            // 
            // reporthdTableAdapter1
            // 
            this.reporthdTableAdapter1.ClearBeforeFill = true;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Tai Le", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHome.Location = new System.Drawing.Point(22, 28);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(164, 40);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "BookStore";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click_1);
            // 
            // btnSach
            // 
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSach.Image = ((System.Drawing.Image)(resources.GetObject("btnSach.Image")));
            this.btnSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.Location = new System.Drawing.Point(0, 202);
            this.btnSach.Name = "btnSach";
            this.btnSach.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSach.Size = new System.Drawing.Size(206, 65);
            this.btnSach.TabIndex = 3;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click_1);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 283);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(206, 65);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "   Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click_1);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 120);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(206, 64);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "   Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnKho
            // 
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKho.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.Image")));
            this.btnKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.Location = new System.Drawing.Point(0, 367);
            this.btnKho.Name = "btnKho";
            this.btnKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKho.Size = new System.Drawing.Size(206, 65);
            this.btnKho.TabIndex = 4;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(-2, 473);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(206, 65);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "    Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel_body
            // 
            this.panel_body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_body.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_body.Location = new System.Drawing.Point(207, 94);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1073, 564);
            this.panel_body.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1073, 94);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.Location = new System.Drawing.Point(686, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 32);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Home";
            // 
            // panel1_left
            // 
            this.panel1_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1_left.Controls.Add(this.lblHome);
            this.panel1_left.Controls.Add(this.btnDangXuat);
            this.panel1_left.Controls.Add(this.btnKho);
            this.panel1_left.Controls.Add(this.btnSach);
            this.panel1_left.Controls.Add(this.btnHoaDon);
            this.panel1_left.Controls.Add(this.btnTaiKhoan);
            this.panel1_left.ForeColor = System.Drawing.Color.White;
            this.panel1_left.Location = new System.Drawing.Point(0, 0);
            this.panel1_left.Name = "panel1_left";
            this.panel1_left.Size = new System.Drawing.Size(207, 658);
            this.panel1_left.TabIndex = 5;
            // 
            // pb_PhongTo
            // 
            this.pb_PhongTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_PhongTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.pb_PhongTo.Image = ((System.Drawing.Image)(resources.GetObject("pb_PhongTo.Image")));
            this.pb_PhongTo.Location = new System.Drawing.Point(1212, 12);
            this.pb_PhongTo.Name = "pb_PhongTo";
            this.pb_PhongTo.Size = new System.Drawing.Size(16, 16);
            this.pb_PhongTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PhongTo.TabIndex = 0;
            this.pb_PhongTo.TabStop = false;
            this.pb_PhongTo.Click += new System.EventHandler(this.pb_PhongTo_Click);
            // 
            // pb_Thoat
            // 
            this.pb_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.pb_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("pb_Thoat.Image")));
            this.pb_Thoat.Location = new System.Drawing.Point(1243, 12);
            this.pb_Thoat.Name = "pb_Thoat";
            this.pb_Thoat.Size = new System.Drawing.Size(16, 16);
            this.pb_Thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Thoat.TabIndex = 12;
            this.pb_Thoat.TabStop = false;
            this.pb_Thoat.Click += new System.EventHandler(this.pb_Thoat_Click);
            // 
            // pb_ThuNho
            // 
            this.pb_ThuNho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_ThuNho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.pb_ThuNho.Image = ((System.Drawing.Image)(resources.GetObject("pb_ThuNho.Image")));
            this.pb_ThuNho.Location = new System.Drawing.Point(1181, 12);
            this.pb_ThuNho.Name = "pb_ThuNho";
            this.pb_ThuNho.Size = new System.Drawing.Size(16, 16);
            this.pb_ThuNho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ThuNho.TabIndex = 13;
            this.pb_ThuNho.TabStop = false;
            this.pb_ThuNho.Click += new System.EventHandler(this.pb_ThuNho_Click);
            // 
            // MidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 658);
            this.Controls.Add(this.pb_ThuNho);
            this.Controls.Add(this.pb_Thoat);
            this.Controls.Add(this.pb_PhongTo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1_left);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1_left.ResumeLayout(false);
            this.panel1_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PhongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Thoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ThuNho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLSACHDataSetTableAdapters.REPORTHDTableAdapter reporthdTableAdapter1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1_left;
        private System.Windows.Forms.PictureBox pb_PhongTo;
        private System.Windows.Forms.PictureBox pb_Thoat;
        private System.Windows.Forms.PictureBox pb_ThuNho;
    }
}