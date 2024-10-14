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

namespace BookStore
{
    public partial class fDangNhap : Form
    {

        public fDangNhap()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DANGNHAPBUS dangnhap = new DANGNHAPBUS();
            if(dangnhap.kiemTraDangNhap(txtTaiKhoan.Text,txtMatKhau.Text))
            {
                this.Hide();
                fTongHop formView = new fTongHop();
                formView.Show();
            }    
            else
            {
                lblThongBao.Text = "Thông tin tài khoản hoặc mật khẩu sai";
            }    
            
        }

        

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.CheckState == CheckState.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar= true;
            }
        }
    }
}
