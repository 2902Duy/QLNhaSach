namespace QLNhaSach
{
    partial class fKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKho));
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSluong = new System.Windows.Forms.TextBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(24, 44);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 49;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(1010, 302);
            this.dgvKho.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(216, 507);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(229, 50);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "THÊM SỐ LƯỢNG SÁCH";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(576, 507);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(229, 50);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA SÁCH";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(212, 374);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(86, 20);
            this.lblTen.TabIndex = 19;
            this.lblTen.Text = "MÃ SÁCH ";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.BackColor = System.Drawing.Color.Transparent;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(529, 374);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(93, 20);
            this.lblSL.TabIndex = 21;
            this.lblSL.Text = "SỐ LƯỢNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "KHO SÁCH";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(311, 436);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(160, 22);
            this.txtMaKho.TabIndex = 31;
            this.txtMaKho.TextChanged += new System.EventHandler(this.txtMaKho_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "MÃ KHO";
            // 
            // txtSluong
            // 
            this.txtSluong.Location = new System.Drawing.Point(645, 372);
            this.txtSluong.Name = "txtSluong";
            this.txtSluong.Size = new System.Drawing.Size(160, 22);
            this.txtSluong.TabIndex = 33;
            // 
            // txtMaS
            // 
            this.txtMaS.Location = new System.Drawing.Point(311, 372);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(160, 22);
            this.txtMaS.TabIndex = 34;
            this.txtMaS.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "TÊN SÁCH";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(645, 440);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(160, 22);
            this.txtTenSach.TabIndex = 36;
            // 
            // fKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 585);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaS);
            this.Controls.Add(this.txtSluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvKho);
            this.DoubleBuffered = true;
            this.Name = "fKho";
            this.Text = "KHO";
            this.Load += new System.EventHandler(this.fKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSluong;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
    }
}