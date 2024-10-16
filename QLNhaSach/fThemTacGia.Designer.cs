namespace QLNhaSach
{
    partial class fThemTacGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMATG = new System.Windows.Forms.TextBox();
            this.txtTENTACGIA = new System.Windows.Forms.TextBox();
            this.txtQUEQUAN = new System.Windows.Forms.TextBox();
            this.dtpNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.dtpNGAYMAT = new System.Windows.Forms.DateTimePicker();
            this.chkQUEQUAN = new System.Windows.Forms.CheckBox();
            this.chkNGAYSINH = new System.Windows.Forms.CheckBox();
            this.chkNGAYMAT = new System.Windows.Forms.CheckBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ TÁC GIẢ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN TÁC GIẢ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUÊ QUÁN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGÀY SINH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NGÀY MẤT";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(172, 363);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 53);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(500, 363);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 53);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMATG
            // 
            this.txtMATG.Location = new System.Drawing.Point(181, 63);
            this.txtMATG.Name = "txtMATG";
            this.txtMATG.Size = new System.Drawing.Size(486, 22);
            this.txtMATG.TabIndex = 7;
            this.txtMATG.TextChanged += new System.EventHandler(this.txtMATG_TextChanged);
            this.txtMATG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMATG_KeyPress);
            // 
            // txtTENTACGIA
            // 
            this.txtTENTACGIA.Location = new System.Drawing.Point(181, 117);
            this.txtTENTACGIA.Name = "txtTENTACGIA";
            this.txtTENTACGIA.Size = new System.Drawing.Size(486, 22);
            this.txtTENTACGIA.TabIndex = 8;
            this.txtTENTACGIA.TextChanged += new System.EventHandler(this.txtTENTACGIA_TextChanged);
            // 
            // txtQUEQUAN
            // 
            this.txtQUEQUAN.Location = new System.Drawing.Point(181, 174);
            this.txtQUEQUAN.Name = "txtQUEQUAN";
            this.txtQUEQUAN.Size = new System.Drawing.Size(329, 22);
            this.txtQUEQUAN.TabIndex = 9;
            // 
            // dtpNGAYSINH
            // 
            this.dtpNGAYSINH.Location = new System.Drawing.Point(181, 238);
            this.dtpNGAYSINH.Name = "dtpNGAYSINH";
            this.dtpNGAYSINH.Size = new System.Drawing.Size(329, 22);
            this.dtpNGAYSINH.TabIndex = 10;
            // 
            // dtpNGAYMAT
            // 
            this.dtpNGAYMAT.Location = new System.Drawing.Point(181, 300);
            this.dtpNGAYMAT.Name = "dtpNGAYMAT";
            this.dtpNGAYMAT.Size = new System.Drawing.Size(329, 22);
            this.dtpNGAYMAT.TabIndex = 11;
            // 
            // chkQUEQUAN
            // 
            this.chkQUEQUAN.AutoSize = true;
            this.chkQUEQUAN.Location = new System.Drawing.Point(554, 176);
            this.chkQUEQUAN.Name = "chkQUEQUAN";
            this.chkQUEQUAN.Size = new System.Drawing.Size(75, 20);
            this.chkQUEQUAN.TabIndex = 12;
            this.chkQUEQUAN.Text = "Chưa rõ";
            this.chkQUEQUAN.UseVisualStyleBackColor = true;
            // 
            // chkNGAYSINH
            // 
            this.chkNGAYSINH.AutoSize = true;
            this.chkNGAYSINH.Location = new System.Drawing.Point(554, 240);
            this.chkNGAYSINH.Name = "chkNGAYSINH";
            this.chkNGAYSINH.Size = new System.Drawing.Size(75, 20);
            this.chkNGAYSINH.TabIndex = 13;
            this.chkNGAYSINH.Text = "Chưa rõ";
            this.chkNGAYSINH.UseVisualStyleBackColor = true;
            // 
            // chkNGAYMAT
            // 
            this.chkNGAYMAT.AutoSize = true;
            this.chkNGAYMAT.Location = new System.Drawing.Point(554, 300);
            this.chkNGAYMAT.Name = "chkNGAYMAT";
            this.chkNGAYMAT.Size = new System.Drawing.Size(75, 20);
            this.chkNGAYMAT.TabIndex = 14;
            this.chkNGAYMAT.Text = "Chưa rõ";
            this.chkNGAYMAT.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // fThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkNGAYMAT);
            this.Controls.Add(this.chkNGAYSINH);
            this.Controls.Add(this.chkQUEQUAN);
            this.Controls.Add(this.dtpNGAYMAT);
            this.Controls.Add(this.dtpNGAYSINH);
            this.Controls.Add(this.txtQUEQUAN);
            this.Controls.Add(this.txtTENTACGIA);
            this.Controls.Add(this.txtMATG);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fThemTacGia";
            this.Text = "THÊM TÁC GIẢ";
            this.Load += new System.EventHandler(this.fThemTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMATG;
        private System.Windows.Forms.TextBox txtTENTACGIA;
        private System.Windows.Forms.TextBox txtQUEQUAN;
        private System.Windows.Forms.DateTimePicker dtpNGAYSINH;
        private System.Windows.Forms.DateTimePicker dtpNGAYMAT;
        private System.Windows.Forms.CheckBox chkQUEQUAN;
        private System.Windows.Forms.CheckBox chkNGAYSINH;
        private System.Windows.Forms.CheckBox chkNGAYMAT;
        private System.Windows.Forms.ErrorProvider err;
    }
}