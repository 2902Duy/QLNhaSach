using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class MidForm : Form
    {
        string _username;
        string _admin = "hutech@123";
        public MidForm(string username)
        {
            InitializeComponent();
            _username = username;
            OpenChildForm(new fTongHop(""));
            lblHome.Click += lblHome_Click_1;
        }

        private Form currentFormChild;

        public void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Hide();
            }

            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panel_body.Controls.Clear();
            panel_body.Controls.Add(ChildForm); 
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap fDangNhap = new fDangNhap();
            fDangNhap.Show();
        }

        private void lblHome_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fTongHop(""));
            lblTitle.Text = "Home";
        }

        private void btnKho_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fKho());
            lblTitle.Text = "Kho";

        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            var fHoaDon = new fHoaDon();
            fHoaDon.ThongKeClicked += (s, ev) =>
            {
                var fThongKe = new fThongKe();
                fThongKe.QuayLaiClicked += (ss, args) =>
                {
                    fThongKe.Hide();
                    OpenChildForm(fHoaDon);
                    lblTitle.Text = "Hóa đơn";
                };
                lblTitle.Text = "Thống kê";
                OpenChildForm(fThongKe);
                fHoaDon.Hide();
            };

            OpenChildForm(fHoaDon);
            lblTitle.Text = "Hóa đơn";
        }

        private void btnSach_Click_1(object sender, EventArgs e)
        {
             var fSuaSach = new fSuaSach();

            fSuaSach.TheLoaiClicked += (s, ev) =>
            {
                var fTheLoai = new fLoaiSach();
                fTheLoai.QuayLaiClicked += (ss, args) =>
                {
                    fTheLoai.Close();
                    fSuaSach.Show();
                    OpenChildForm(fSuaSach);
                    lblTitle.Text = "Sách";
                };
                fSuaSach.Hide();
                OpenChildForm(fTheLoai);
                lblTitle.Text = "Thể loại";
            };

            fSuaSach.TacGiaClicked += (s, ev) =>
            {
                var fTacGia = new fThemTacGia();
                fTacGia.QuayLaiClicked += (ss, args) =>
                {
                    fTacGia.Close();
                    fSuaSach.Show();
                    OpenChildForm(fSuaSach);
                    lblTitle.Text = "Sách";

                };
                fSuaSach.Hide();
                OpenChildForm(fTacGia);
                lblTitle.Text = "Tác giả";
            };

            fSuaSach.NXBClicked += (s, ev) =>
            {
                var fNXB = new fNhaXuatBan();
                fNXB.QuayLaiClicked += (ss, args) =>
                {
                    fNXB.Close();
                    fSuaSach.Show();
                    OpenChildForm(fSuaSach);
                    lblTitle.Text = "Sách";

                };
                fSuaSach.Hide();
                OpenChildForm(fNXB);
                lblTitle.Text = "Nhà xuất bản";
            };

            lblTitle.Text = "Sách";
            OpenChildForm(fSuaSach);
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (_username == _admin)
            {
                OpenChildForm(new fTaiKhoan());
                lblTitle.Text = "Tài Khoản";
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pb_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_PhongTo_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Phóng to
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Trở về bình thường
            }
        }

        private void pb_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
