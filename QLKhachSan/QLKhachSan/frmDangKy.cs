using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btThoatDangKy_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin f = new FrmLogin();
            f.Show();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {

        }
    }
}
