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
                        Kho.KHOSACH.SL
                    });
                txtMaKho.ReadOnly = true;
                binding.DataSource = KhoData.ToList();
                databinding();
                dgvKho.DataSource = binding;
            }
        }
        public void databinding()
        {
            txtMaKho.DataBindings.Add(new Binding("Text", binding, "ID", true, DataSourceUpdateMode.Never));
            txtMaS.DataBindings.Add(new Binding("Text", binding, "MASACH", true, DataSourceUpdateMode.Never));
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaS.Text) || string.IsNullOrEmpty(txtSluong.Text))
                    throw new InvalidOperationException("Vui lòng chọn đầy đủ thông tin Mã sách và số lượng.");

                // Chuyển đổi số lượng từ txtSluong
                byte soluong = byte.Parse(txtSluong.Text);

                buskho.themSachKho(
                    txtMaS.Text,  // Mã sách dưới dạng chuỗi
                    soluong       // Số lượng dưới dạng byte
                );

                MessageBox.Show("Thêm sách vào kho thành công!");
                UpdateDataGridView();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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
                    byte soluong = byte.Parse(txtSluong.Text);
                    buskho.SuaSachKho(id, MaSach, soluong);
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
    }
}
