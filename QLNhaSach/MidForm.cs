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
            lblHome.Click += lblHome_Click;
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

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
          
            if (_username == _admin)
            {
                OpenChildForm(new fTaiKhoan());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Thông báo");
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
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
                };
                fSuaSach.Hide();
                OpenChildForm(fTheLoai);
            };

            fSuaSach.TacGiaClicked += (s, ev) =>
            {
                var fTacGia = new fThemTacGia();
                fTacGia.QuayLaiClicked += (ss, args) =>
                {
                    fTacGia.Close();
                    fSuaSach.Show();
                    OpenChildForm(fSuaSach);

                };
                fSuaSach.Hide();
                OpenChildForm(fTacGia);
            };

            fSuaSach.NXBClicked += (s, ev) =>
            {
                var fNXB = new fNhaXuatBan();
                fNXB.QuayLaiClicked += (ss, args) =>
                {
                    fNXB.Close();
                    fSuaSach.Show();
                    OpenChildForm(fSuaSach);

                };
                fSuaSach.Hide();
                OpenChildForm(fNXB);
            };


            OpenChildForm(fSuaSach);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            var fHoaDon = new fHoaDon();
            fHoaDon.ThongKeClicked += (s, ev) =>
            {
                var fThongKe = new fThongKe();
                fThongKe.QuayLaiClicked += (ss, args) =>
                {
                    fThongKe.Hide();
                    OpenChildForm(fHoaDon);
                };
                OpenChildForm(fThongKe);
                fHoaDon.Hide();
            };

            OpenChildForm(fHoaDon);

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fKho());

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTongHop(""));
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap fDangNhap = new fDangNhap();
            fDangNhap.Show();
        }
    }
}
