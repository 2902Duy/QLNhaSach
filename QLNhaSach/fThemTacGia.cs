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
    public partial class fThemTacGia : Form
    {
       
        BindingSource binding = new BindingSource();
        BUSSACH busstacgia = new BUSSACH();
        public fThemTacGia()
        {
            InitializeComponent();
        }
        private void UpdateDataGridView()
        {
            var dstg = busstacgia.DSSACH_TACGIA();
            var tacgiaData = from TacGia in dstg
                             select new
                             {
                                 TacGia.IDTACGIA,
                                 TacGia.TENTACGIA,
                                 TacGia.QUEQUAN
                             };

            binding.DataSource = tacgiaData.ToList();
            dgvTacGia.DataSource = binding;
            binding.ResetBindings(false);

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTENTACGIA.Text) )
                    throw new InvalidOperationException("Vui lòng chọn đầy đủ thông tin Tác giả, quê quán.");

                BUSSACH busstacgia = new BUSSACH();
                busstacgia.themTacGia(

                    txtTENTACGIA.Text,
                    txtQUEQUAN.Text
                );

                MessageBox.Show("Thêm tác giả thành công!");
                UpdateDataGridView();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void txtMATG_TextChanged(object sender, EventArgs e)
        {
            if (txtMATG.Text.Length < 10)
            {
                err.SetError(txtMATG, "Mã số sinh viên không hợp lệ, vui lòng nhập lại!");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtMATG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTENTACGIA_TextChanged(object sender, EventArgs e)
        {
            if (txtTENTACGIA.Text.Length < 3 || txtTENTACGIA.Text.Length > 100)
            {

                err.SetError(txtTENTACGIA, "Tên tác giả không hợp lệ, vui lòng nhập lại!");
            }
            else
            {
                err.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemTacGia_Load(object sender, EventArgs e)
        {
            
            using (dataBookStore db = new dataBookStore())
            {
                BUSSACH busstacgia = new BUSSACH();

                var dstg = busstacgia.DSSACH_TACGIA();

                var TacgiaData = dstg
                        .Select(TacGia => new
                        {
                            TacGia.IDTACGIA,
                            TacGia.TENTACGIA,
                            TacGia.QUEQUAN
                        }).Distinct();
                txtMATG.ReadOnly = true;
                binding.DataSource = TacgiaData.ToList();
                databinding();
                dgvTacGia.DataSource = binding;
            }


        }
        public void databinding()
        {
            txtMATG.DataBindings.Add(new Binding("Text", binding, "IDTACGIA", true, DataSourceUpdateMode.Never));
            txtTENTACGIA.DataBindings.Add(new Binding("Text", binding, "TENTACGIA", true, DataSourceUpdateMode.Never));
            txtQUEQUAN.DataBindings.Add(new Binding("Text", binding, "QUEQUAN", true, DataSourceUpdateMode.Never));

        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                int idTacGia = Convert.ToInt32(dgvTacGia.SelectedRows[0].Cells["IDTACGIA"].Value);

                try
                {
                    string tenTG = txtTENTACGIA.Text;
                    string quequan = txtQUEQUAN.Text;

                    busstacgia.suaTacGia(idTacGia, tenTG, quequan);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi sửa tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                int idTacGia = Convert.ToInt32(dgvTacGia.SelectedRows[0].Cells["IDTACGIA"].Value);

                try
                {
                    busstacgia.xoaTacGia(idTacGia);

                    MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
