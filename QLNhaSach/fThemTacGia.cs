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
    public partial class fThemTacGia : Form
    {
       
        BindingSource binding = new BindingSource();
        BUSSACH busstacgia = new BUSSACH();
        public fThemTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

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

                err.SetError(txtTENTACGIA, "Tên sinh viên không hợp lệ, vui lòng nhập lại!");
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
            BUSSACH busstacgia = new BUSSACH();

            var dstg = busstacgia.DSSACH();

            var TacgiaData = dstg
                    .Select(TacGia => new
                    {
                    TacGia.TACGIA.MATACGIA,
                    TacGia.TACGIA.TENTACGIA,
                    TacGia.TACGIA.QUEQUAN
                    }).Distinct();
            binding.DataSource = TacgiaData.ToList();
            dgvTacGia.DataSource = binding;
            databinding();
       
        }
        public void databinding()
        {
            txtMATG.DataBindings.Add(new Binding("Text", binding, "MATACGIA", true, DataSourceUpdateMode.Never));
            txtTENTACGIA.DataBindings.Add(new Binding("Text", binding, "TENTACGIA", true, DataSourceUpdateMode.Never));
            txtQUEQUAN.DataBindings.Add(new Binding("Text", binding, "QUEQUAN", true, DataSourceUpdateMode.Never));

        }
    }
}
