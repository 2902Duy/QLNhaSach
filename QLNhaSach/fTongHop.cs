using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class fTongHop : Form
    {
        BindingSource BindingSource= new BindingSource();
        public fTongHop(string username)
        {
            InitializeComponent();
            lblTaiKhoan.Text = "TÀI KHOẢN: "+username;
            lblNgayThang.Text = DateTime.Now.ToString("dd-MM-yyyy");
            SetControlTextColor(Color.Black);

        }
        private void SetControlTextColor(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }

        private void tmiTaiKhoan_Click(object sender, EventArgs e)
        {
          
            
        }

        private void fTongHop_Load(object sender, EventArgs e)
        {
            BUSSACH bussach = new BUSSACH();
            var sqlsach = bussach.DSSACH();
            BUSKHO buskho = new BUSKHO();
            var sqlkho = buskho.DSKHOSACH();
            var dss = from sach in sqlsach
                      join kho in sqlkho on sach.SACH.MASACH equals kho.KHOSACH.MASACH   
                      select new {
                      sach.SACH.IDMASACH,
                      sach.SACH.TENSACH,
                      sach.TACGIA.TENTACGIA,
                      sach.SACH.GIANHAP,
                      sach.SACH.GIABAN,
                      sach.SACH.NHAXUATBAN.TENNHAXUATBAN,
                      sach.SACH.NAMXUATBAN,
                      kho.KHOSACH.SL
                      
                      };

            BindingSource.DataSource = dss.ToList();
            dgvSach.DataSource = BindingSource;

        }
    }
}
