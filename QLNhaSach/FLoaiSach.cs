﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fLoaiSach : Form
    {
        public fLoaiSach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MATG", typeof(string));

            table.Rows.Add("DANH SÁCH CÁC LOẠI SÁCH");

            table.Rows.Add("DANH SÁCH LOẠI SÁCH TIẾNG VIỆT");

            table.Rows.Add("DANH SÁCH LOẠI SÁCH TIẾNG ANH");


            // Liên kết DataTable với DataGridView
            dgvLoaiS.DataSource = table;
            dgvLoaiS.ColumnHeadersVisible = false;
        }
    }
}
