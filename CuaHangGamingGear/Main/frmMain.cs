using CuaHangGamingGear.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;
using System.Windows.Forms;
using System.Diagnostics;
using CuaHangGamingGear.Help;

namespace CuaHangGamingGear.Main
{
    public partial class frmMain : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        frmDangNhap dangNhap = null;
        frmKhachHang khachHang = null;
        frmQuanLyBanHang banHang = null;
        frmHoaDon hoaDon = null;
        string hoVaTenNhanVien = "";
        frmNhanVien nhanVien = null;
        private string tenDangNhap = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            dangNhap.txtTenDangNhap.Text = "";
            dangNhap.txtMatKhau.Text = "";
            dangNhap.txtTenDangNhap.Focus();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;
                            tenDangNhap = nhanVien.TenDangNhap;

                            btnLogin.Visible = false;
                            btnLogout.Visible = true;

                            if (nhanVien.QuyenHan == 0)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == 1)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
            else
            {
                btnLogout.Visible = false;
                btnLogin.Visible = true;
            }
        }

        public void ChuaDangNhap()
        {
            groupBoxNhanVien.Visible = false;
            groupBoxQuanLy.Visible = false;
            btnLogout.Visible = false;
            btnLogin.Visible = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Chưa đăng nhập.";

            hoVaTenNhanVien = null;

            // Nếu frmHoaDon, frmKhachHang, hoặc các form khác có sử dụng tên đăng nhập, hãy loại bỏ chúng
            if (hoaDon != null)
            {
                hoaDon.Dispose();
                hoaDon = null;
            }

            if (khachHang != null)
            {
                khachHang.Dispose();
                khachHang = null;
            }

            if (banHang != null)
            {
                banHang.Dispose();
                banHang = null;
            }

            if (nhanVien != null)
            {
                nhanVien.Dispose();
                nhanVien = null;
            }

            if (dangNhap != null)
            {
                dangNhap.txtTenDangNhap.Text = "";
                dangNhap.txtMatKhau.Text = "";
                dangNhap = null;
            }
        }

        public void QuyenQuanLy()
        {
            groupBoxNhanVien.Visible = true;
            groupBoxQuanLy.Visible = true;
            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            groupBoxNhanVien.Visible = true;
            groupBoxQuanLy.Visible = false;
            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
            panel2.SendToBack();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Visible = false;
            btnLogout.Visible = true;
            DangNhap();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                btnLogout.Visible = false;
                btnLogin.Visible = true;
                panelShow.Controls.Clear();
                ChuaDangNhap();

            }
        }

        public void ShowFormInPanel(Form frm)
        {
            panelShow.Controls.Clear(); // Xoá nội dung cũ trong panel

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelShow.Controls.Add(frm);
            frm.Show();
        }


        private void btnQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();

                nhanVien.TopLevel = false;
                nhanVien.FormBorderStyle = FormBorderStyle.None;
                nhanVien.Dock = DockStyle.Fill;

                panelShow.Controls.Clear(); // Xoá form cũ trong panel nếu có
                panelShow.Controls.Add(nhanVien); // Thêm vào panel
                nhanVien.Show(); // Hiển thị
            }
            else
            {
                ShowFormInPanel(nhanVien);
                nhanVien.BringToFront(); // Nếu đã có thì đưa lên trên
            }
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text.Trim();
                khachHang = new frmKhachHang(this,tenDangNhap);

                khachHang.TopLevel = false;
                khachHang.FormBorderStyle = FormBorderStyle.None;
                khachHang.Dock = DockStyle.Fill;

                panelShow.Controls.Clear(); // Xoá form cũ trong panel nếu có
                panelShow.Controls.Add(khachHang); // Thêm vào panel
                khachHang.Show(); // Hiển thị
            }
            else
            {
                ShowFormInPanel(khachHang);
                khachHang.BringToFront(); // Nếu đã có thì đưa lên trên
            }
        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            if (banHang == null || banHang.IsDisposed)
            {
                banHang = new frmQuanLyBanHang();

                banHang.TopLevel = false;
                banHang.FormBorderStyle = FormBorderStyle.None;
                banHang.Dock = DockStyle.Fill;

                panelShow.Controls.Clear(); // Xoá form cũ trong panel nếu có
                panelShow.Controls.Add(banHang); // Thêm vào panel
                banHang.Show(); // Hiển thị
            }
            else
            {
                ShowFormInPanel(banHang);
                banHang.BringToFront(); // Nếu đã có thì đưa lên trên
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text.Trim();
                hoaDon = new frmHoaDon(tenDangNhap);

                hoaDon.TopLevel = false;
                hoaDon.FormBorderStyle = FormBorderStyle.None;
                hoaDon.Dock = DockStyle.Fill;

                panelShow.Controls.Clear(); // Xoá form cũ trong panel nếu có
                panelShow.Controls.Add(hoaDon); // Thêm vào panel
                hoaDon.Show(); // Hiển thị
            }
            else
            {
                ShowFormInPanel(hoaDon);
                hoaDon.BringToFront(); // Nếu đã có thì đưa lên trên
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();      // Ẩn ảnh đi
            pictureBox2.SendToBack();      // Đảm bảo nằm trên
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();      // Ẩn ảnh đi
            pictureBox2.BringToFront();      // Đảm bảo nằm trên
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Color borderColor = Color.White; // Màu viền bạn muốn
            int borderWidth = 2; // Độ dày viền

            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void picGuide_MouseEnter(object sender, EventArgs e)
        {
            picGuide.SendToBack();
            picGuideColored.BringToFront();
        }

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "main.html");
            frmGuide guide = new frmGuide(htmlPath);
            guide.ShowDialog();
        }

        private void picGuideColored_MouseLeave(object sender, EventArgs e)
        {
            picGuide.BringToFront();
            picGuideColored.SendToBack();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SendToBack();
            pictureBox4.BringToFront();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox4.SendToBack();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }
    }
}
