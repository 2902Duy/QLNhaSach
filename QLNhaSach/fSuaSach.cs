using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fSuaSach : Form
    {
        public fSuaSach()
        {
            InitializeComponent();
            //InitializeNumericUpDown();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTENSACH_TextChanged(object sender, EventArgs e)
        {
            if (txtTENSACH.Text.Length < 3 || txtTENSACH.Text.Length > 100)
            {

                err.SetError(txtTENSACH, "Tên sinh viên không hợp lệ, vui lòng nhập lại!");
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
        private void InitializeNumericUpDown()
        {   
            // Set properties for NumericUpDown
            //numericUpDown1.Minimum = 0;
           // numericUpDown1.Maximum = 10000; // Giá trị tối đa
           // numericUpDown1.DecimalPlaces = 2; // Số chữ số sau dấu thập phân
           // numericUpDown1.Increment = 0.01m; // Giá trị tăng giảm
            //numericUpDown1.ValueChanged += numericUpDown1_ValueChanged; // Đăng ký sự kiện
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Cập nhật Label để hiển thị giá trị hiện tại
           // label7.Text = $"Giá tiền: {numericUpDown1.Value:C}";
        }
    }
}
