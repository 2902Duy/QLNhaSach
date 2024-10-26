using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fHoaDon : Form
    {
        BUSSACH bussach = new BUSSACH();
        BindingSource bindingSach = new BindingSource();
        List<CHITIETHOADONSACH> listSach = new List<CHITIETHOADONSACH>(); 
        BUSKHO buskho = new BUSKHO();
        BUSHOADON bushd = new BUSHOADON();
        public fHoaDon()
        {
            InitializeComponent();
            fillTenSach();
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận hoàn thành hóa đơn này?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            themHDMoi();
        }

        public void themHDMoi()
        {
            try
            {
                var hd = bushd.themHD(DateTime.Now);
                int sumMoney =0;
                foreach (var ch in listSach)
                {
                    CHITIETHOADON ct = new CHITIETHOADON
                    {
                        MAHOADON = hd.MAHOADON,
                        MASACH = ch.MASACH,
                        GIABAN = ch.GIABAN,
                        SOLUONG = ch.SOLUONG,
                        THANHTIEN = ch.THANHTIEN,
                    };
                    string masach = ct.MASACH;
                    int sl = ct.SOLUONG.Value;
                    sumMoney =sumMoney+ ct.THANHTIEN.Value;
                    bushd.themcthd(ct);
                    buskho.capNhapSoLuongSach(sl, masach);

                }
                bushd.tongtienhd(sumMoney, hd.MAHOADON);
                using (ReportHD report = new ReportHD(hd.MAHOADON))
                {
                    report.ShowDialog();
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        {
         


        }

        public void fillTenSach()
        {
            var dssach = bussach.DSSACH();
            var sach = from s in dssach
                       select new { 
                           s.SACH.MASACH,
                           s.SACH.TENSACH};
            cmbTenS.DataSource = sach.ToList();
            cmbTenS.DisplayMember = "TENSACH";
            cmbTenS.ValueMember = "MASACH";

        }

        private void dgvChonS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text == "0")
            {
                txtsoluong.Text = ""; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txtsoluong.Text);
                string masach = cmbTenS.SelectedValue.ToString();
                if (!buskho.KiemtraSLSach(sl, masach))
                {

                    MessageBox.Show("Số lượng sách trong kho không đủ");
                }
                else
                {
                    SACH sach = bussach.timSachTheoMa(masach);

                    var sql = new
                    {
                        sach.MASACH,
                        sach.TENSACH,
                        sach.GIABAN,
                        SL = sl,
                        THANHTIEN = sl * sach.GIABAN

                    };
                    CHITIETHOADONSACH ct = new CHITIETHOADONSACH();
                    ct.MASACH= sach.MASACH;
                    ct.GIABAN=int.Parse(sach.GIABAN.ToString());
                    ct.SOLUONG = sl;
                    ct.THANHTIEN = sl * ct.GIABAN;

                    listSach.Add(ct);
                    bindingSach.Add(sql);
                    dgvChonS.DataSource = bindingSach;
                }
            }
            catch (Exception ex) { 
            MessageBox.Show( ex.Message);
            }
        }
    }
}
