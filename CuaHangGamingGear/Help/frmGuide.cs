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
    public partial class frmGuide : Form
    {
        private string htmlPath; // Biến lưu đường dẫn HTML
        private WebBrowser webBrowser;

        public frmGuide(string pathToHtml)
        {
            InitializeComponent();
            htmlPath = pathToHtml;
        }

        private void frmGuide_Load(object sender, EventArgs e)
        {
            // Khởi tạo WebBrowser
            webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill,
                AllowWebBrowserDrop = false,
                IsWebBrowserContextMenuEnabled = false,
                WebBrowserShortcutsEnabled = false,
                ScriptErrorsSuppressed = true
            };

            panel1.Controls.Add(webBrowser);

            LoadHtmlFile();
        }

        private void LoadHtmlFile()
        {
            try
            {
                if (File.Exists(htmlPath))
                {
                    // Đọc nội dung HTML và chỉnh sửa encoding
                    string htmlContent = File.ReadAllText(htmlPath, Encoding.UTF8);

                    // Thêm meta charset nếu chưa có
                    if (!htmlContent.Contains("<meta charset="))
                    {
                        htmlContent = htmlContent.Replace("<head>", "<head>\n<meta charset=\"UTF-8\">");
                    }

                    // Hiển thị HTML
                    webBrowser.DocumentText = htmlContent;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy file hướng dẫn:\n{htmlPath}",
                                  "Lỗi",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải file hướng dẫn:\n{ex.Message}",
                              "Lỗi",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
