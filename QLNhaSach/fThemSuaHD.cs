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
    public partial class fThemSuaHD : Form
    {
        BUSHOADON bushoadon = new BUSHOADON();
        public fThemSuaHD()
        {
            InitializeComponent();
        }
        private ErrorProvider err = new ErrorProvider();
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                bushoadon.themHD(txtTenKH.Text, dtpNgayLap.Value);
            }
            catch (Exception)
            {

            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fThemSuaHD_Load(object sender, EventArgs e)
        {

        }
    }
}
