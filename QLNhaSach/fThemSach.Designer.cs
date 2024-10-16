namespace QLNhaSach
{
    partial class fThemSach
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
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.dtpNamXB = new System.Windows.Forms.DateTimePicker();
            this.dmGiaMua = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dmGiaBia = new System.Windows.Forms.DomainUpDown();
            this.dmLanTaiB = new System.Windows.Forms.DomainUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbTenTG = new System.Windows.Forms.ComboBox();
            this.cmbTenLoai = new System.Windows.Forms.ComboBox();
            this.cmbTenXB = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(168, 30);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(452, 27);
            this.txtTenSach.TabIndex = 1;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTENSACH_TextChanged);
            this.txtTenSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTENSACH_KeyPress);
            // 
            // dtpNamXB
            // 
            this.dtpNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamXB.Location = new System.Drawing.Point(209, 351);
            this.dtpNamXB.Name = "dtpNamXB";
            this.dtpNamXB.Size = new System.Drawing.Size(411, 27);
            this.dtpNamXB.TabIndex = 2;
            // 
            // dmGiaMua
            // 
            this.dmGiaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmGiaMua.Location = new System.Drawing.Point(168, 202);
            this.dmGiaMua.Name = "dmGiaMua";
            this.dmGiaMua.Size = new System.Drawing.Size(452, 27);
            this.dmGiaMua.TabIndex = 3;
            this.dmGiaMua.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TÊN SÁCH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TÁC GIẢ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "LOẠI SÁCH :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "TÊN NXB :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "GIÁ  MUA :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "GIÁ BÌA :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "LẦN TÁI BẢN :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "NĂM SẢN XUẤT :";
            // 
            // dmGiaBia
            // 
            this.dmGiaBia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmGiaBia.Location = new System.Drawing.Point(168, 250);
            this.dmGiaBia.Name = "dmGiaBia";
            this.dmGiaBia.Size = new System.Drawing.Size(452, 27);
            this.dmGiaBia.TabIndex = 15;
            // 
            // dmLanTaiB
            // 
            this.dmLanTaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmLanTaiB.Location = new System.Drawing.Point(168, 297);
            this.dmLanTaiB.Name = "dmLanTaiB";
            this.dmLanTaiB.Size = new System.Drawing.Size(452, 27);
            this.dmLanTaiB.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(631, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 44);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbTenTG
            // 
            this.cmbTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenTG.FormattingEnabled = true;
            this.cmbTenTG.Location = new System.Drawing.Point(168, 69);
            this.cmbTenTG.Name = "cmbTenTG";
            this.cmbTenTG.Size = new System.Drawing.Size(452, 28);
            this.cmbTenTG.TabIndex = 18;
            // 
            // cmbTenLoai
            // 
            this.cmbTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLoai.FormattingEnabled = true;
            this.cmbTenLoai.Location = new System.Drawing.Point(168, 112);
            this.cmbTenLoai.Name = "cmbTenLoai";
            this.cmbTenLoai.Size = new System.Drawing.Size(452, 28);
            this.cmbTenLoai.TabIndex = 19;
            // 
            // cmbTenXB
            // 
            this.cmbTenXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenXB.FormattingEnabled = true;
            this.cmbTenXB.Location = new System.Drawing.Point(168, 157);
            this.cmbTenXB.Name = "cmbTenXB";
            this.cmbTenXB.Size = new System.Drawing.Size(452, 28);
            this.cmbTenXB.TabIndex = 21;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // fThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTenXB);
            this.Controls.Add(this.cmbTenLoai);
            this.Controls.Add(this.cmbTenTG);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dmLanTaiB);
            this.Controls.Add(this.dmGiaBia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dmGiaMua);
            this.Controls.Add(this.dtpNamXB);
            this.Controls.Add(this.txtTenSach);
            this.Name = "fThemSach";
            this.Text = "THÊM SÁCH";
            this.Load += new System.EventHandler(this.fThemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.DateTimePicker dtpNamXB;
        private System.Windows.Forms.DomainUpDown dmGiaMua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown dmGiaBia;
        private System.Windows.Forms.DomainUpDown dmLanTaiB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbTenTG;
        private System.Windows.Forms.ComboBox cmbTenLoai;
        private System.Windows.Forms.ComboBox cmbTenXB;
        private System.Windows.Forms.ErrorProvider err;
    }
}

