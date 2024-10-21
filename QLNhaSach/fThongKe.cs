using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QLNhaSach
{
    public partial class fThongKe : Form
    {
        BUSHOADON bushoadon = new BUSHOADON();
        BindingSource binding = new BindingSource();
        public fThongKe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            fBaoCao frm2 = new fBaoCao();
            frm2.ShowDialog();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            var dscthd = bushoadon.dachSachHoaDon();
            var sql = from hd in dscthd
                      select new {
                      hd.MAHOADON,
                      hd.HOADON.KHACHHANG,
                      hd.HOADON.NGAYLAP,
                      hd.SACH.TENSACH,
                      hd.SOLUONG,
                      hd.THANHTIEN
                      };

            binding.DataSource = sql.ToList();
            dgvThongKe.DataSource = binding;
        }

        private void btnTkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBatDau = dtpTuNgay.Value;
                DateTime ngayKetThuc = dtpDenNgay.Value;
                var dshdtk = bushoadon.timkiemtheolich(ngayBatDau, ngayKetThuc);
                var sql = from hd in dshdtk
                          select new
                          {
                              hd.MAHOADON,
                              hd.HOADON.KHACHHANG,
                              hd.HOADON.NGAYLAP,
                              hd.SACH.TENSACH,
                              hd.SOLUONG,
                              hd.THANHTIEN
                          };
                binding.DataSource = sql.ToList();
                dgvThongKe.DataSource = binding;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
