using BUS;
using DAL;
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
    public partial class fLoaiSach : Form
    {
        BUSSACH bussach = new BUSSACH();
        BindingSource binding = new BindingSource();
        public fLoaiSach()
        {
            InitializeComponent();
            SetControlTextColor(Color.Black);

        }
        private void SetControlTextColor(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }
        private void fLoaiSach_Load(object sender, EventArgs e)
        {
            LoadDSTheLoai();
        }

        private void LoadDSTheLoai()
        {
            var dss = bussach.DSTHELOAI();
            var dataList = dss.Select(t => new { t.TENTHELOAI }).ToList();
            binding.DataSource = dataList;
            dgvLoaiS.DataSource = binding;

            txtThemS.DataBindings.Clear();
            txtThemS.DataBindings.Add(new Binding("Text", binding, "TENTHELOAI", true, DataSourceUpdateMode.Never));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bussach.ThemTheLoai(txtThemS.Text.Trim());
                MessageBox.Show("Thêm thể loại sách thành công!", "Thông báo");

                LoadDSTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTheLoai = txtThemS.Text.Trim();

                bussach.XoaTheLoai(tenTheLoai);

                MessageBox.Show("Xóa thể loại sách thành công!", "Thông báo");

                LoadDSTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        public event EventHandler QuayLaiClicked;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuayLaiClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
