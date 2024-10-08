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
    public partial class fView : Form
    {
        public fView()
        {
            InitializeComponent();
            lblNgayThang.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void tmiTaiKhoan_Click(object sender, EventArgs e)
        {
            fTaiKhoan TaiKhoan = new fTaiKhoan();
            TaiKhoan.Show();
        }
    }
}
