namespace QLNhaSach
{
    partial class fHoaDon
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
            this.cmbTenS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChonS = new System.Windows.Forms.DataGridView();
            this.btnHT = new System.Windows.Forms.Button();
            this.btnchon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonS)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTenS
            // 
            this.cmbTenS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTenS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTenS.FormattingEnabled = true;
            this.cmbTenS.Location = new System.Drawing.Point(243, 305);
            this.cmbTenS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTenS.Name = "cmbTenS";
            this.cmbTenS.Size = new System.Drawing.Size(110, 21);
            this.cmbTenS.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "TÊN SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvChonS
            // 
            this.dgvChonS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChonS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonS.Location = new System.Drawing.Point(22, 47);
            this.dgvChonS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChonS.Name = "dgvChonS";
            this.dgvChonS.RowHeadersWidth = 49;
            this.dgvChonS.RowTemplate.Height = 24;
            this.dgvChonS.Size = new System.Drawing.Size(751, 240);
            this.dgvChonS.TabIndex = 35;
            this.dgvChonS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonS_CellContentClick);
            // 
            // btnHT
            // 
            this.btnHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHT.Location = new System.Drawing.Point(638, 385);
            this.btnHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(149, 37);
            this.btnHT.TabIndex = 34;
            this.btnHT.Text = "HOÀN THÀNH";
            this.btnHT.UseVisualStyleBackColor = true;
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // btnchon
            // 
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(163, 383);
            this.btnchon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(116, 37);
            this.btnchon.TabIndex = 33;
            this.btnchon.Text = "CHỌN";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "SỐ LƯỢNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "CHỌN SÁCH";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(504, 306);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 38;
            this.txtsoluong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(672, 305);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(101, 31);
            this.btnThongKe.TabIndex = 39;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(383, 383);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 37);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(796, 431);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.cmbTenS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChonS);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fHoaDon";
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.fHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTenS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChonS;
        private System.Windows.Forms.Button btnHT;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnXoa;
    }
}

