namespace QLNhaSach
{
    partial class Fxoatacgia
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
            this.dgvXoaTG = new System.Windows.Forms.DataGridView();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaTG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXoaTG
            // 
            this.dgvXoaTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXoaTG.Location = new System.Drawing.Point(13, 13);
            this.dgvXoaTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvXoaTG.Name = "dgvXoaTG";
            this.dgvXoaTG.RowHeadersWidth = 51;
            this.dgvXoaTG.Size = new System.Drawing.Size(671, 378);
            this.dgvXoaTG.TabIndex = 0;
            this.dgvXoaTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnXoaTG
            // 
            this.btnXoaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTG.Location = new System.Drawing.Point(13, 398);
            this.btnXoaTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaTG.Name = "btnXoaTG";
            this.btnXoaTG.Size = new System.Drawing.Size(114, 41);
            this.btnXoaTG.TabIndex = 1;
            this.btnXoaTG.Text = "Xóa Tác Giả";
            this.btnXoaTG.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(577, 399);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 39);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fxoatacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 452);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTG);
            this.Controls.Add(this.dgvXoaTG);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fxoatacgia";
            this.Text = " XÓA TÁC GIẢ";
            this.Load += new System.EventHandler(this.Fxoatacgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXoaTG;
        private System.Windows.Forms.Button btnXoaTG;
        private System.Windows.Forms.Button btnThoat;
    }
}

