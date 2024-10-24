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
        string _username;
        string _admin = "hutech@123";
        public fTongHop(string username)
        {
            InitializeComponent();
            lblTaiKhoan.Text = "TÀI KHOẢN: "+username;
            _username = username;
            lblNgayThang.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void tmiTaiKhoan_Click(object sender, EventArgs e)
        {
            if (_username == _admin) 
            {
                fTaiKhoan TaiKhoan = new fTaiKhoan();
                TaiKhoan.Show();
            }
            else
            {
                MessageBox.Show( "Bạn không có quyền truy cập chức năng này","Thông báo");
            }
            
        }

        private void fTongHop_Load(object sender, EventArgs e)
        {
            BUSSACH bussach = new BUSSACH();
            var sqlsach = bussach.DSSACH();
            BUSKHO buskho = new BUSKHO();
            var sqlkho = buskho.DSKHOSACH();
            var dss = from sach in sqlsach
                      join kho in sqlkho on sach.SACH.MASACH equals kho.KHOSACH.MASACH   
                      select new {
                      sach.SACH.IDMASACH,
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
        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void tmiTacGia_Click(object sender, EventArgs e)
        {
            fThemTacGia fThemTacGia = new fThemTacGia();
            fThemTacGia.Show();
        }

        private void tmiSach_Click(object sender, EventArgs e)
        {
            fSuaSach fSuaSach = new fSuaSach();
            fSuaSach.Show();
        }

        private void tmiTheLoaiS_Click(object sender, EventArgs e)
        {
            fLoaiSach fLoaiSach = new fLoaiSach();
            fLoaiSach.Show();
        }
    }
}
