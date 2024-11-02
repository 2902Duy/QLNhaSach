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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace QLNhaSach
{
    public partial class fThongKe : Form
    {
        BUSHOADON bushoadon = new BUSHOADON();
        BindingSource binding = new BindingSource();
        public fThongKe()
        {
            InitializeComponent();
            SetControlTextColor(Color.Black);

        }
        private void SetControlTextColor(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            toExcel toExcel = new toExcel();
            toExcel.ExportToExcel(dgvThongKe, dtpTuNgay.Value, dtpDenNgay.Value);
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
            dtpDenNgay.Value = DateTime.Now;
            
            dtpTuNgay.Value = new DateTime(2020, 1, 1);
        }

        public event EventHandler QuayLaiClicked;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuayLaiClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
