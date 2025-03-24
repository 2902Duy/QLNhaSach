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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoaDon));
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
            this.cmbTenS.Location = new System.Drawing.Point(288, 408);
            this.cmbTenS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenS.Name = "cmbTenS";
            this.cmbTenS.Size = new System.Drawing.Size(145, 24);
            this.cmbTenS.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "TÊN SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvChonS
            // 
            this.dgvChonS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChonS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChonS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonS.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChonS.Location = new System.Drawing.Point(29, 58);
            this.dgvChonS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChonS.Name = "dgvChonS";
            this.dgvChonS.RowHeadersWidth = 49;
            this.dgvChonS.RowTemplate.Height = 24;
            this.dgvChonS.Size = new System.Drawing.Size(1001, 331);
            this.dgvChonS.TabIndex = 35;
            this.dgvChonS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonS_CellContentClick);
            // 
            // btnHT
            // 
            this.btnHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHT.Location = new System.Drawing.Point(815, 507);
            this.btnHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(199, 46);
            this.btnHT.TabIndex = 34;
            this.btnHT.Text = "HOÀN THÀNH";
            this.btnHT.UseVisualStyleBackColor = true;
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // btnchon
            // 
            this.btnchon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnchon.BackgroundImage")));
            this.btnchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(349, 507);
            this.btnchon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(145, 40);
            this.btnchon.TabIndex = 33;
            this.btnchon.Text = "CHỌN";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "SỐ LƯỢNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "CHỌN SÁCH";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(636, 410);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(132, 22);
            this.txtsoluong.TabIndex = 38;
            this.txtsoluong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(859, 393);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(135, 38);
            this.btnThongKe.TabIndex = 39;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(557, 510);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 40);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 580);
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
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

