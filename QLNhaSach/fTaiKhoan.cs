using BUS;
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
    public partial class fTaiKhoan : Form
    {
        BUSTAIKHOAN bustk = new BUSTAIKHOAN();
        BindingSource binding = new BindingSource();
        public fTaiKhoan()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.CheckState == CheckState.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
            databinding();
        }

        public void loaddata()
        {
            var dstk = bustk.DSTAIKHOAN();
            
            binding.DataSource = dstk.ToList();
            dgvTaiKhoan.DataSource = binding;
        }

        public void databinding()
        {
            txtTaiKhoan.DataBindings.Add(new Binding("Text", binding, "USERNAME",true));
            txtMatKhau.DataBindings.Add(new Binding("Text", binding, "PASSWORD",true));
        }

        private void lblTaiKhoanThemXoaSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm tài khoản", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    string username = txtTaiKhoan.Text;
                    string password = txtTaiKhoan.Text.Trim();
                    bustk.themTaiKhoan(txtTaiKhoan.Text, password);
                    binding.ResetBindings(false);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
