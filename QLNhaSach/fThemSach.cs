using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fThemSach : Form
    {
        public fThemSach()
        {
            InitializeComponent();
           // InitializeNumericUpDown();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Tên Sách";
            column1.Name = "TenSach";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Tác Giả";
            column2.Name = "TacGia";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Loại Sách";
            column3.Name = "LoaiSach";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Giá Mua";
            column4.Name = "GiaMua";

           // dataGridView1.Columns.Add(column1);
           // dataGridView1.Columns.Add(column2);
           // dataGridView1.Columns.Add(column3);
           // dataGridView1.Columns.Add(column4);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTENSACH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Length < 2 || txtTenSach.Text.Length > 100)
            {
                err.SetError(txtTenSach, "Tên sách không hợp lệ, vui lòng nhập lại!");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtTENSACH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void fThemSach_Load(object sender, EventArgs e)
        {

        }
    }
}
