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
        public fThemSuaHD()
        {
            InitializeComponent();
        }
        private ErrorProvider err = new ErrorProvider();
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKH.Text.Length < 3 || txtTenKH.Text.Length > 50)
                {
                    err.SetError(txtTenKH, "Độ dài tên ít nhất 3 kí tự!");
                }
                else
                {
                    err.Clear();
                }
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
    }
}
