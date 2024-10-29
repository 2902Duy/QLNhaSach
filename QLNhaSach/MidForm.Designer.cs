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
            this.panel_header = new System.Windows.Forms.Panel();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKho = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_header.Controls.Add(this.lblDangXuat);
            this.panel_header.Controls.Add(this.lblHome);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(200, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1080, 100);
            this.panel_header.TabIndex = 1;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.Location = new System.Drawing.Point(165, 45);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(121, 24);
            this.lblDangXuat.TabIndex = 2;
            this.lblDangXuat.Text = "ĐĂNG XUẤT";
            this.lblDangXuat.Click += new System.EventHandler(this.lblDangXuat_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(59, 45);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(68, 24);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "HOME";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(353, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÀ SÁCH";
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.Color.White;
            this.btnKho.Location = new System.Drawing.Point(0, 393);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(200, 66);
            this.btnKho.TabIndex = 1;
            this.btnKho.Text = "KHO";
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_menu.Controls.Add(this.btnExit);
            this.panel_menu.Controls.Add(this.btnHoaDon);
            this.panel_menu.Controls.Add(this.btnTaiKhoan);
            this.panel_menu.Controls.Add(this.btnSach);
            this.panel_menu.Controls.Add(this.btnKho);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 658);
            this.panel_menu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepPink;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 541);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 66);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 321);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 66);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.DeepPink;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 177);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(200, 66);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "TÀI KHOẢN";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.White;
            this.btnSach.Location = new System.Drawing.Point(0, 249);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(200, 66);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "SÁCH";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(200, 100);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1080, 558);
            this.panel_body.TabIndex = 2;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // MidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 658);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MidForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnExit;
    }
}