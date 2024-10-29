using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.Location = new System.Drawing.Point(32, 46);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 49;
            this.dgvSach.Size = new System.Drawing.Size(747, 304);
            this.dgvSach.TabIndex = 1;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaiKhoan.Location = new System.Drawing.Point(4, 13);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(127, 20);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "TÀI KHOẢN: duy";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(29, 363);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(115, 17);
            this.lblDoanhThu.TabIndex = 3;
            this.lblDoanhThu.Text = "DOANH THU: 00";
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoKhachHang.Location = new System.Drawing.Point(29, 400);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(139, 17);
            this.lblSoKhachHang.TabIndex = 4;
            this.lblSoKhachHang.Text = "SỐ KHÁCH HÀNG: 0";
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNgayThang.Location = new System.Drawing.Point(711, 17);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(84, 17);
            this.lblNgayThang.TabIndex = 5;
            this.lblNgayThang.Text = "dd-mm-yyyy";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(544, 363);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(159, 20);
            this.txttim.TabIndex = 6;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // fTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(796, 423);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.lblNgayThang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.dgvSach);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "fTongHop";
            this.Text = "VIEW";
            this.Load += new System.EventHandler(this.fTongHop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.Label lblNgayThang;
        private TextBox txttim;
    }
}