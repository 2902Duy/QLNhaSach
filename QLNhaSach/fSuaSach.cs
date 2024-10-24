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
            using (dataBookStore db = new dataBookStore())
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

                FillTacGiaComboBox(db);
                FillTheLoaiComboBox(db);
                FillNXBComboBox(db);
            }
        }

        public void databinding()
        {
            txtMaS.DataBindings.Add(new Binding("Text", binding, "IDMASACH", true, DataSourceUpdateMode.Never));
            txtTenSach.DataBindings.Add(new Binding("Text", binding, "TENSACH", true, DataSourceUpdateMode.Never));
            cmbTenTacGia.DataBindings.Add(new Binding("Text", binding, "TENTACGIA", true, DataSourceUpdateMode.Never));
            cmbTenTheLoai.DataBindings.Add(new Binding("Text", binding, "TENTHELOAI", true, DataSourceUpdateMode.Never));
            cmbTenNXB.DataBindings.Add(new Binding("Text", binding, "TENNHAXUATBAN", true, DataSourceUpdateMode.Never));
            txtGiaBan.DataBindings.Add(new Binding("Text", binding, "GIABAN", true, DataSourceUpdateMode.Never));
            txtGiaMua.DataBindings.Add(new Binding("Text", binding, "GIANHAP", true, DataSourceUpdateMode.Never));
            txtNSX.DataBindings.Add(new Binding("Text", binding, "NAMXUATBAN", true, DataSourceUpdateMode.Never));

        }

        private void FillTacGiaComboBox(dataBookStore db)
        {
            var sql = from t in db.TACGIAs
                      select t;

            List<TACGIA> listTacGia = sql.ToList();
            listTacGia.Insert(0, new TACGIA());
            this.cmbTenTacGia.DataSource = listTacGia;
            this.cmbTenTacGia.DisplayMember = "TENTACGIA";
        }

        private void FillTheLoaiComboBox(dataBookStore db)
        {
            var sql = from t in db.THELOAIs
                      select t;

            List<THELOAI> listTheLoai = sql.ToList();
            listTheLoai.Insert(0, new THELOAI());
            this.cmbTenTheLoai.DataSource = listTheLoai;
            this.cmbTenTheLoai.DisplayMember = "TENTHELOAI";
        }

        private void FillNXBComboBox(dataBookStore db)
        {
            var sql = from n in db.NHAXUATBANs
                      select n;

            List<NHAXUATBAN> listNXB = sql.ToList();
            listNXB.Insert(0, new NHAXUATBAN());
            this.cmbTenNXB.DataSource = listNXB;
            this.cmbTenNXB.DisplayMember = "TENNHAXUATBAN";
        }
        private void UpdateDataGridView()
        {
            var dss = busSach.DSSACH();
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

            binding.DataSource = sachData.ToList();
            dgvSuaS.DataSource = binding;
        }
        private void btnThemS_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbTenTacGia.Text) || string.IsNullOrEmpty(cmbTenTheLoai.Text) || string.IsNullOrEmpty(cmbTenNXB.Text))
                    throw new InvalidOperationException("Vui lòng chọn đầy đủ thông tin Tác giả, Thể loại và Nhà xuất bản.");

                BUSSACH busSach = new BUSSACH();
                busSach.themSach(
                    txtTenSach.Text,
                    cmbTenTacGia.Text,
                    cmbTenTheLoai.Text,
                    cmbTenNXB.Text,
                    int.Parse(txtGiaMua.Text),
                    int.Parse(txtGiaBan.Text),
                    int.Parse(txtNSX.Text)
                );

                MessageBox.Show("Thêm sách thành công!");
                UpdateDataGridView();
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá bán, giá mua hoặc năm xuất bản không hợp lệ. Vui lòng nhập đúng định dạng số.");
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


        private void btnSuaS_Click_1(object sender, EventArgs e)
        {

            if (dgvSuaS.SelectedRows.Count > 0)
            {
                int idMaSach = Convert.ToInt32(dgvSuaS.SelectedRows[0].Cells["IDMASACH"].Value);

                try
                {
                    string tenSach = txtTenSach.Text;
                    string tacGia = cmbTenTacGia.Text;
                    string theLoai = cmbTenTheLoai.Text;
                    string tenNhaSX = cmbTenNXB.Text;
                    int giaNhap = int.Parse(txtGiaMua.Text);
                    int giaBan = int.Parse(txtGiaBan.Text);
                    int namXB = int.Parse(txtNSX.Text);

                    busSach.suaSach(idMaSach, tenSach, tacGia, theLoai, tenNhaSX, giaNhap, giaBan, namXB);
                    MessageBox.Show("Sửa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho giá mua, giá bán và năm xuất bản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi sửa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            if (dgvSuaS.SelectedRows.Count > 0)
            {
                int idMaSach = Convert.ToInt32(dgvSuaS.SelectedRows[0].Cells["IDMASACH"].Value);

                try
                {
                    busSach.xoaSach(idMaSach);

                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNSX.Text.Length > 3)
            {
                txtNSX.Text = txtNSX.Text.Substring(0, 3);
                txtNSX.SelectionStart = txtNSX.Text.Length;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

