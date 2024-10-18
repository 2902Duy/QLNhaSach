using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fTongHop : Form
    {
        public fTongHop()
        {
            InitializeComponent();
            lblNgayThang.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void tmiTaiKhoan_Click(object sender, EventArgs e)
        {
           
            fTaiKhoan TaiKhoan = new fTaiKhoan();
            TaiKhoan.Show();
        }

        private void fTongHop_Load(object sender, EventArgs e)
        {
            dataBookStore db = new dataBookStore();
            var sql = from hd in db.CHITIETHOADONs
                      select hd;
            dgvSach.DataSource = sql.ToList();
        }
        private void tmiDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void tmiThongKe_Click(object sender, EventArgs e)
        {
            fThongKe fThongKe = new fThongKe(); 
            fThongKe.Show();
        }

        private void tmiHoaDon_Click_1(object sender, EventArgs e)
        {
            fHoaDon fHoaDon = new fHoaDon();
            fHoaDon.Show();
        }

        private void tsbKhoHang_Click_1(object sender, EventArgs e)
        {
            fKho fKho = new fKho();
            fKho.Show();
        }

        private void tmiLoaiSach_Click_1(object sender, EventArgs e)
        {
            fLoaiSach fLoaiSach = new fLoaiSach();
            fLoaiSach.Show();
        }

        private void tmiNhaXuatBan_Click(object sender, EventArgs e)
        {
            fNhaXuatBan fNhaXuatBan = new fNhaXuatBan();
            fNhaXuatBan.Show();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
