using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangGamingGear.Help
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            btnInfo.FlatAppearance.BorderSize = 0;
            btnAnswer.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLoginInfo.FlatAppearance.BorderSize = 0;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Tạo WebBrowser control
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill; // Chiếm toàn bộ panel
            browser.ScriptErrorsSuppressed = true; // Ẩn lỗi script

            // Thêm vào Panel
            panel2.Controls.Add(browser);

            // Load file HTML
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "info.html");
            if (File.Exists(htmlPath))
            {
                browser.Navigate(htmlPath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file HTML!");
            }
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Tạo WebBrowser control
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill; // Chiếm toàn bộ panel
            browser.ScriptErrorsSuppressed = true; // Ẩn lỗi script

            // Thêm vào Panel
            panel2.Controls.Add(browser);

            // Load file HTML
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "answer.html");
            if (File.Exists(htmlPath))
            {
                browser.Navigate(htmlPath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file HTML!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Tạo WebBrowser control
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill; // Chiếm toàn bộ panel
            browser.ScriptErrorsSuppressed = true; // Ẩn lỗi script

            // Thêm vào Panel
            panel2.Controls.Add(browser);

            // Load file HTML
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "login.html");
            if (File.Exists(htmlPath))
            {
                browser.Navigate(htmlPath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file HTML!");
            }
        }

        private void btnLoginInfo_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Tạo WebBrowser control
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill; // Chiếm toàn bộ panel
            browser.ScriptErrorsSuppressed = true; // Ẩn lỗi script

            // Thêm vào Panel
            panel2.Controls.Add(browser);

            // Load file HTML
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "logininfo.html");
            if (File.Exists(htmlPath))
            {
                browser.Navigate(htmlPath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file HTML!");
            }
        }
    }
}
