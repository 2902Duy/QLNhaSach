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
            txtMatK.UseSystemPasswordChar = true;
        }
        private void btnDangNhap1_Click_1(object sender, EventArgs e)
        {
            try
            {
                BUSTAIKHOAN dn = new BUSTAIKHOAN();
                err.Clear();
                if (string.IsNullOrEmpty(txtTaiK.Text) || txtTaiK.Text.Length < 3)
                {
                    err.SetError(txtTaiK, "Tên tài khoản không được bỏ trống và phải có ít nhất 3 kí tự");
                }
                if (string.IsNullOrEmpty(txtMatK.Text) || txtMatK.Text.Length < 3)
                {
                    err.SetError(txtMatK, "Mật khẩu không được bỏ trống và phải có ít nhất 3 kí tự");
                }

                else
                {
                    if (dn.kiemTraDangNhap(txtTaiK.Text, txtMatK.Text))
                    {
                        MidForm midForm = new MidForm(txtTaiK.Text);
                        this.Hide();
                        midForm.Show();
                    }
                    else
                    {
                        err.SetError(txtTaiK, "Tên tài khoản hoặc mật khẩu sai");
                    }

                }
            }
            catch
            {

            }
        }
        private void chkHienMatKhau1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHienMatKhau1.CheckState == CheckState.Checked)
            {
                txtMatK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatK.UseSystemPasswordChar = true;
            }
        }
    }
}
