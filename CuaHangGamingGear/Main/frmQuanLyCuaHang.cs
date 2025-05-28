using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangGamingGear.Reports;

namespace CuaHangGamingGear.Main
{
    public partial class frmQuanLyBanHang : Form
    {
        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }

        private void LoadFormToTabPage(Form frm, TabPage tabPage)
        {
            tabPage.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabPage.Controls.Add(frm);
            frm.Show();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageLSP)
            {
                LoadFormToTabPage(new frmLoaiSanPham(), tabPageLSP);
            }
            else if (tabControl.SelectedTab == tabPageHSX)
            {
                LoadFormToTabPage(new frmHangSanXuat(), tabPageHSX);
            }
            else if (tabControl.SelectedTab == tabPageSP)
            {
                LoadFormToTabPage(new frmSanPham(), tabPageSP);
            }
            else if (tabControl.SelectedTab == tabPageTK)
            {
                LoadFormToTabPage(new frmThongKeDoanhThu(), tabPageTK);
            }
        }

        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            LoadFormToTabPage(new frmLoaiSanPham(), tabPageLSP);
        }
    }
}
