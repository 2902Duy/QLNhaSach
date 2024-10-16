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
        public fKho()
        {
            InitializeComponent();
        }

        private void fKho_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fXoaSach fXoaSach = new fXoaSach();
            fXoaSach.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemSach fThemSach = new fThemSach();
            fThemSach.Show();
        }
    }
}
