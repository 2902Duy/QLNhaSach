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
    public partial class fNhaXuatBan : Form
    {
        BUSNXB busnxb = new BUSNXB();
        BindingSource binding = new BindingSource();
        public fNhaXuatBan()
        {
            InitializeComponent();
        }

        

        private void fNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadDSNhaXuatBan();
        }

        private void LoadDSNhaXuatBan()
        {
            var sql = busnxb.DSNHAXUATBAN();
            var dsnxb = from nxb in sql
                        select new { 
                            nxb.TENNHAXUATBAN 
                        };
            binding.DataSource = dsnxb.ToList();
            dgvNXB.DataSource = binding;
            txtThemNXB.DataBindings.Clear();
            txtThemNXB.DataBindings.Add(new Binding("Text", binding, "TENNHAXUATBAN", true, DataSourceUpdateMode.Never));
        }


        private void dgvNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                busnxb.ThemNhaXuatBan(txtThemNXB.Text.Trim());
                MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo");

                LoadDSNhaXuatBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNXB = txtThemNXB.Text.Trim();

                busnxb.XoaNhaXuatBan(tenNXB);
                MessageBox.Show("Xóa nhà xuất bản thành công!", "Thông báo");

                LoadDSNhaXuatBan();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}

