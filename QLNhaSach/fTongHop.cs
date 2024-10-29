using BUS;
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
        BindingSource BindingSource= new BindingSource();
        BUSSACH bussach = new BUSSACH();
        BUSKHO buskho = new BUSKHO();
        BUSHOADON bushoadon = new BUSHOADON();
        public fTongHop(string username)
        {
            InitializeComponent();
            lblTaiKhoan.Text = "TÀI KHOẢN: "+username;
            lblNgayThang.Text = DateTime.Now.ToString("dd-MM-yyyy");
            SetControlTextColor(Color.Black);

        }
        private void SetControlTextColor(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }

        private void tmiTaiKhoan_Click(object sender, EventArgs e)
        {
          
            
        }

        private void fTongHop_Load(object sender, EventArgs e)
        {
            
            var sqlsach = bussach.DSSACH();
            
            var sqlkho = buskho.DSKHOSACH();
            var dss = from sach in sqlsach
                      join kho in sqlkho on sach.SACH.MASACH equals kho.KHOSACH.MASACH   
                      select new {
                      sach.SACH.MASACH,
                      sach.SACH.TENSACH,
                      sach.TACGIA.TENTACGIA,
                      sach.SACH.GIANHAP,
                      sach.SACH.GIABAN,
                      sach.SACH.NHAXUATBAN.TENNHAXUATBAN,
                      sach.SACH.NAMXUATBAN,
                      kho.KHOSACH.SL
                      
                      };

            BindingSource.DataSource = dss.ToList();
            dgvSach.DataSource = BindingSource;
            lblDoanhThu.Text = "Doanh thu: " + bushoadon.tongDoanhThu()+" VNĐ";
            lblSoKhachHang.Text = "Số khách hàng: "+bushoadon.tongKhachHang();

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            var sqlsach = bussach.DSSACH();

            var sqlkho = buskho.DSKHOSACH();
            var dss = from sach in sqlsach
                      join kho in sqlkho on sach.SACH.MASACH equals kho.KHOSACH.MASACH
                      select new
                      {
                          sach.SACH.MASACH,
                          sach.SACH.TENSACH,
                          sach.TACGIA.TENTACGIA,
                          sach.SACH.GIANHAP,
                          sach.SACH.GIABAN,
                          sach.SACH.NHAXUATBAN.TENNHAXUATBAN,
                          sach.SACH.NAMXUATBAN,
                          kho.KHOSACH.SL

                      };
            
            BindingSource.DataSource = dss.Where(s => (s.MASACH + " " + s.TENSACH + " " + s.TENTACGIA + " " + s.TENNHAXUATBAN + " " + s.NAMXUATBAN).ToLower().ToString().Contains(txttim.Text)).ToList();
            dgvSach.DataSource = BindingSource;
        }
    }
}
