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
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận hoàn thành hóa đơn này?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Close();
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            fChiTietHD frm2 = new fChiTietHD();
            frm2.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemSuaHD frm3 = new fThemSuaHD();
            frm3.ShowDialog();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
