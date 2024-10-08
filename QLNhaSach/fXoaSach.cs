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
    public partial class fXoaSach : Form
    {
        public fXoaSach()
        {
            InitializeComponent();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Xóa hàng đã chọn
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Kiểm tra nếu hàng không phải là hàng mới (nếu có)
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
