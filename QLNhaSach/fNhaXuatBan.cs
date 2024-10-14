using System;
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
    public partial class fNhaXuatBan : Form
    {
        public fNhaXuatBan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MATG", typeof(string));

            table.Rows.Add("DANH SÁCH CÁC NHÀ XUẤT BẢN HIỆN CÓ");

            table.Rows.Add("NXB KIM DONG");

            table.Rows.Add("NXB TUOI TRE");
            table.Rows.Add("NXB GIAO DUC");


            // Liên kết DataTable với DataGridView
            dgvNXB.DataSource = table;
            dgvNXB.ColumnHeadersVisible = false;
        }
    }
    }

