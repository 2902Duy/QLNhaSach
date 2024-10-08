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
    public partial class Fxoatacgia : Form
    {
        public Fxoatacgia()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MATG", typeof(string));
            table.Columns.Add("TENTG", typeof(string));
            table.Columns.Add("QUEQUAN", typeof(string));

            table.Rows.Add("TG054", "Nguyen Van Nam", "Binh Dinh");

            table.Rows.Add("TG057", "Nguyen Van Dung", "Binh Dinh");

            table.Rows.Add("TG058", "Nguyen Van Van", "Binh Dinh");


            // Liên kết DataTable với DataGridView
            dataGridView1.DataSource = table;
        }

        private void Fxoatacgia_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MATG", typeof(string));
            table.Columns.Add("TENTG", typeof(string));
            table.Columns.Add("QUEQUAN", typeof(string));

            table.Rows.Add("TG054", "Nguyen Van Nam", "Binh Dinh");

            table.Rows.Add("TG057", "Nguyen Van Dung", "Binh Dinh");

            table.Rows.Add("TG058", "Nguyen Van Van", "Binh Dinh");


            // Liên kết DataTable với DataGridView
            dataGridView1.DataSource = table;
        }
    }
}
