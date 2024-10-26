using BUS;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportHD : Form
    {
        BUSHOADON bushoadon = new BUSHOADON();
        public string MAHD;
        public ReportHD(string mahd)
        {
            InitializeComponent();
            MAHD = mahd;
        }

        private void ReportHD_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            var dshd = bushoadon.dachSachHoaDon();
            var cthd = from sach in dshd
                       where sach.MAHOADON.Equals(MAHD)
                       select new
                       {
                           sach.MAHOADON,
                           sach.SACH.TENSACH,
                           sach.GIABAN,
                           sach.SOLUONG,
                           sach.THANHTIEN,
                           sach.HOADON.KHACHHANG,
                           sach.HOADON.NGAYLAP,
                           sach.HOADON.TONGTIEN
                       };



            reportViewer1.LocalReport.ReportPath = "ReportHoaDon.rdlc";
            var sourcecthd = new ReportDataSource("cthd", cthd);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(sourcecthd);

            reportViewer1.RefreshReport();
        }
    }
}
