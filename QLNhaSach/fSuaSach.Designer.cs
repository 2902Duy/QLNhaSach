namespace QLNhaSach
{
    partial class fSuaSach
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
            this.components = new System.ComponentModel.Container();
            this.dgvSuaS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cmbTenTacGia = new System.Windows.Forms.ComboBox();
            this.cmbTenTheLoai = new System.Windows.Forms.ComboBox();
            this.cmbTenNXB = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.btnThemS = new System.Windows.Forms.Button();
            this.btnSuaS = new System.Windows.Forms.Button();
            this.btnXoaS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuaS
            // 
            this.dgvSuaS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuaS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuaS.Location = new System.Drawing.Point(12, 12);
            this.dgvSuaS.Name = "dgvSuaS";
            this.dgvSuaS.RowHeadersWidth = 51;
            this.dgvSuaS.RowTemplate.Height = 24;
            this.dgvSuaS.Size = new System.Drawing.Size(856, 278);
            this.dgvSuaS.TabIndex = 0;
            this.dgvSuaS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuaS_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN SÁCH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÁC GIẢ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "LOẠI SÁCH :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "TÊN NXB :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "GIÁ MUA :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "GIÁ BÁN :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "NĂM SẢN XUẤT :";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(135, 360);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(273, 22);
            this.txtTenSach.TabIndex = 14;
            this.txtTenSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTENSACH_KeyPress);
            // 
            // cmbTenTacGia
            // 
            this.cmbTenTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenTacGia.FormattingEnabled = true;
            this.cmbTenTacGia.Location = new System.Drawing.Point(135, 412);
            this.cmbTenTacGia.Name = "cmbTenTacGia";
            this.cmbTenTacGia.Size = new System.Drawing.Size(273, 24);
            this.cmbTenTacGia.TabIndex = 15;
            // 
            // cmbTenTheLoai
            // 
            this.cmbTenTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenTheLoai.FormattingEnabled = true;
            this.cmbTenTheLoai.Location = new System.Drawing.Point(135, 471);
            this.cmbTenTheLoai.Name = "cmbTenTheLoai";
            this.cmbTenTheLoai.Size = new System.Drawing.Size(273, 24);
            this.cmbTenTheLoai.TabIndex = 17;
            // 
            // cmbTenNXB
            // 
            this.cmbTenNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenNXB.FormattingEnabled = true;
            this.cmbTenNXB.Location = new System.Drawing.Point(135, 523);
            this.cmbTenNXB.Name = "cmbTenNXB";
            this.cmbTenNXB.Size = new System.Drawing.Size(273, 24);
            this.cmbTenNXB.TabIndex = 18;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtMaS
            // 
            this.txtMaS.Location = new System.Drawing.Point(135, 309);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(100, 22);
            this.txtMaS.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Sách";
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(598, 357);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(270, 22);
            this.txtGiaMua.TabIndex = 25;
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(598, 412);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(270, 22);
            this.txtGiaBan.TabIndex = 26;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(600, 471);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(270, 22);
            this.txtNSX.TabIndex = 27;
            this.txtNSX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSX_KeyPress);
            // 
            // btnThemS
            // 
            this.btnThemS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemS.Location = new System.Drawing.Point(436, 567);
            this.btnThemS.Name = "btnThemS";
            this.btnThemS.Size = new System.Drawing.Size(100, 44);
            this.btnThemS.TabIndex = 28;
            this.btnThemS.Text = "Thêm sách";
            this.btnThemS.UseVisualStyleBackColor = true;
            this.btnThemS.Click += new System.EventHandler(this.btnThemS_Click);
            // 
            // btnSuaS
            // 
            this.btnSuaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaS.Location = new System.Drawing.Point(598, 567);
            this.btnSuaS.Name = "btnSuaS";
            this.btnSuaS.Size = new System.Drawing.Size(97, 44);
            this.btnSuaS.TabIndex = 29;
            this.btnSuaS.Text = "Sửa sách";
            this.btnSuaS.UseVisualStyleBackColor = true;
            this.btnSuaS.Click += new System.EventHandler(this.btnSuaS_Click_1);
            // 
            // btnXoaS
            // 
            this.btnXoaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaS.Location = new System.Drawing.Point(749, 568);
            this.btnXoaS.Name = "btnXoaS";
            this.btnXoaS.Size = new System.Drawing.Size(93, 43);
            this.btnXoaS.TabIndex = 30;
            this.btnXoaS.Text = "Xóa sách";
            this.btnXoaS.UseVisualStyleBackColor = true;
            this.btnXoaS.Click += new System.EventHandler(this.btnXoaS_Click);
            // 
            // fSuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 623);
            this.Controls.Add(this.btnXoaS);
            this.Controls.Add(this.btnSuaS);
            this.Controls.Add(this.btnThemS);
            this.Controls.Add(this.txtNSX);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaMua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaS);
            this.Controls.Add(this.cmbTenNXB);
            this.Controls.Add(this.cmbTenTheLoai);
            this.Controls.Add(this.cmbTenTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSuaS);
            this.Name = "fSuaSach";
            this.Text = "CÀI ĐẶT SÁCH";
            this.Load += new System.EventHandler(this.fSuaSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuaS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cmbTenTacGia;
        private System.Windows.Forms.ComboBox cmbTenTheLoai;
        private System.Windows.Forms.ComboBox cmbTenNXB;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.Button btnXoaS;
        private System.Windows.Forms.Button btnSuaS;
        private System.Windows.Forms.Button btnThemS;
    }
}