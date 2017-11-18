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
    public partial class frmQuestion : Form
    {
        public frmQuestion()
        {
            InitializeComponent();
        }

        private void btReloadLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin f = new FrmLogin();
            f.Show();

        }

        private void btThoatQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hy vọng sớm gặp lại!!");
            Application.Exit();
        }
    }
}
