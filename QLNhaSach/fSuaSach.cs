using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fSuaSach : Form
    {
        BUSSACH busSach = new BUSSACH();
        BindingSource binding = new BindingSource();
        public fSuaSach()
        {
            InitializeComponent();
            //InitializeNumericUpDown();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTENSACH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Length < 3 || txtTenSach.Text.Length > 100)
            {

                err.SetError(txtTenSach, "Tên sinh viên không hợp lệ, vui lòng nhập lại!");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtTENSACH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InitializeNumericUpDown()
        {   
            // Set properties for NumericUpDown
            //numericUpDown1.Minimum = 0;
           // numericUpDown1.Maximum = 10000; // Giá trị tối đa
           // numericUpDown1.DecimalPlaces = 2; // Số chữ số sau dấu thập phân
           // numericUpDown1.Increment = 0.01m; // Giá trị tăng giảm
            //numericUpDown1.ValueChanged += numericUpDown1_ValueChanged; // Đăng ký sự kiện
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Cập nhật Label để hiển thị giá trị hiện tại
           // label7.Text = $"Giá tiền: {numericUpDown1.Value:C}";
        }

        private void fSuaSach_Load(object sender, EventArgs e)
        {
            
            BUSSACH bussach = new BUSSACH();
            var dss = bussach.DSSACH();
            var sachData = from sach in dss
                           select new
                           {
                               sach.SACH.IDMASACH,
                               sach.SACH.TENSACH,
                               sach.TACGIA.TENTACGIA,
                               sach.NHAXUATBAN.TENNHAXUATBAN,
                               sach.SACH.GIANHAP,
                               sach.SACH.GIABAN,
                               sach.SACH.NAMXUATBAN,
                               sach.SACH.THELOAI.TENTHELOAI
                               
                           };
            txtMaS.ReadOnly = true;
            binding.DataSource = sachData.ToList();
            databinding();
            dgvSuaS.DataSource = binding;
        }

        public void databinding()
        {
            txtMaS.DataBindings.Add(new Binding("Text", binding, "IDMASACH", true, DataSourceUpdateMode.Never));
            txtTenSach.DataBindings.Add(new Binding("Text", binding, "TENSACH", true, DataSourceUpdateMode.Never));
            cmbTenTacGia.DataBindings.Add(new Binding("Text", binding, "TENTACGIA", true, DataSourceUpdateMode.Never));
            cmbTenTheLoai.DataBindings.Add(new Binding("Text", binding, "TENTHELOAI", true, DataSourceUpdateMode.Never));
            cmbTenNXB.DataBindings.Add(new Binding("Text", binding, "NAMXUATBAN", true, DataSourceUpdateMode.Never));
            txtGiaBan.DataBindings.Add(new Binding("Text", binding, "GIABAN", true, DataSourceUpdateMode.Never));
            txtGiaMua.DataBindings.Add(new Binding("Text", binding, "GIANHAP", true, DataSourceUpdateMode.Never));
            txtNSX.DataBindings.Add(new Binding("Text", binding, "NAMXUATBAN", true, DataSourceUpdateMode.Never));



        }

        private void txtGiaMua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNSX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
