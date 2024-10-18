using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QLNhaSach
{
    public partial class fNhaXuatBan : Form
    {
        BUSNXB busnxb = new BUSNXB();
        BindingSource binding = new BindingSource();
        public fNhaXuatBan()
        {
            InitializeComponent();
        }

        

        private void fNhaXuatBan_Load(object sender, EventArgs e)
        {
            var sql = busnxb.DSNHAXUATBAN();
            var dsnxb = from nxb in sql
                        select new { nxb.TENNHAXUATBAN };
            binding.DataSource = dsnxb.ToList();
            dgvNXB.DataSource = binding;
            txtThemNXB.DataBindings.Add(new Binding("Text",binding,"TENNHAXUATBAN",true,DataSourceUpdateMode.Never));
        }
    }
    }

