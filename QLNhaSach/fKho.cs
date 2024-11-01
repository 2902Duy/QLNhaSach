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
    public partial class fKho : Form
    {

        BUSKHO buskho = new BUSKHO();
        BindingSource binding = new BindingSource();
        public fKho()
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

        private void fKho_Load(object sender, EventArgs e)
        {
            using (dataBookStore db = new dataBookStore())
            {
                BUSKHO buskho = new BUSKHO();
                var dskho = buskho.DSKHOSACH();
                var KhoData = dskho
                    .Select(Kho => new
                    {
                        Kho.KHOSACH.ID,
                        Kho.KHOSACH.MASACH,
                        Kho.SACH.TENSACH,
                        Kho.KHOSACH.SL
                    });
                txtMaKho.ReadOnly = true;
                txtMaS.ReadOnly = true;
                binding.DataSource = KhoData.ToList();
                databinding();
                dgvKho.DataSource = binding;
            }
        }
        public void databinding()
        {
            txtMaKho.DataBindings.Add(new Binding("Text", binding, "ID", true, DataSourceUpdateMode.Never));
            txtMaS.DataBindings.Add(new Binding("Text", binding, "MASACH", true, DataSourceUpdateMode.Never));
            txtTenSach.DataBindings.Add(new Binding("Text", binding, "TENSACH", true, DataSourceUpdateMode.Never));
            txtSluong.DataBindings.Add(new Binding("Text", binding, "SL", true, DataSourceUpdateMode.Never));

        }

        private void UpdateDataGridView()
        {
            var dsk = buskho.DSKHOSACH();
            var khoData = from Kho in dsk
                             select new
                             {
                                 Kho.KHOSACH.ID,
                                 Kho.KHOSACH.MASACH,
                                 Kho.SACH.TENSACH,
                                 Kho.KHOSACH.SL
                             };

            binding.DataSource = khoData.ToList();
            dgvKho.DataSource = binding;
            binding.ResetBindings(false);

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {
                int idkho = Convert.ToInt32(dgvKho.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    buskho.xoaSachKho(idkho);

                    MessageBox.Show("Xóa sách trong kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKho.SelectedRows[0].Cells["ID"].Value);
                try
                {
                    string MaSach = txtMaS.Text;
                    string Tensach = txtTenSach.Text;
                    byte soluong = byte.Parse(txtSluong.Text);

                    if (soluong < 0)
                    {
                        MessageBox.Show("Số lượng không được âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    buskho.SuaSachKho(id, MaSach, Tensach, soluong);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi sửa sách trong kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
