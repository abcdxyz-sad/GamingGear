using CuaHangGamingGear.Data;
using CuaHangGamingGear.Help;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangGamingGear
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            frmHelp helpForm = new frmHelp();
            helpForm.ShowDialog(this);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '•')
            {
                btnHide.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
