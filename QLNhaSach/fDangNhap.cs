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
    public partial class fDangNhap : Form
    {

        public fDangNhap()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            try
            {
                DANGNHAPBUS dn = new DANGNHAPBUS();
                err.Clear();
                if (string.IsNullOrEmpty(txtTaiKhoan.Text) || txtTaiKhoan.Text.Length < 3)
                {
                    err.SetError(txtTaiKhoan, "Tên tài khoản không được bỏ trống và phải có ít nhất 3 kí tự");
                }

                else
                {
                    if (dn.kiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        fTongHop fTongHop = new fTongHop();
                        this.Hide();
                        fTongHop.Show();
                    }
                    else 
                    {
                        err.SetError(txtTaiKhoan, "Tên tài khoản hoặc mật khẩu sai");
                    }

                }
            }
            catch 
            {
                
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

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
