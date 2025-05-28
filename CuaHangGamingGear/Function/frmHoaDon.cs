using ClosedXML.Excel;
using CuaHangGamingGear.Data;
using CuaHangGamingGear.Help;
using CuaHangGamingGear.Reports;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        String id;
        private static readonly Random rand = new Random();
        string tenDangDangNhap;

        public frmHoaDon(string tenDangNhap)
        {
            InitializeComponent();
            tenDangDangNhap = tenDangNhap;
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Xóa các cột hiện có (nếu có)
            dataGridView.Columns.Clear();

            // Thêm cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã HD",
                DataPropertyName = "MaHD",
                Name = "MaHD",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 120 // Giữ cố định độ rộng
            };
            dataGridView.Columns.Add(colID);

            // Thêm cột Nhân viên
            DataGridViewTextBoxColumn colNhanVien = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nhân viên",
                DataPropertyName = "HoVaTenNhanVien",
                Name = "HoVaTenNhanVien",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView.Columns.Add(colNhanVien);

            // Thêm cột Khách hàng
            DataGridViewTextBoxColumn colKhachHang = new DataGridViewTextBoxColumn
            {
                HeaderText = "Khách hàng",
                DataPropertyName = "HoVaTenKhachHang",
                Name = "HoVaTenKhachHang",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView.Columns.Add(colKhachHang);

            // Thêm cột Ngày lập (Căn giữa, định dạng dd/MM/yyyy)
            DataGridViewTextBoxColumn colNgayLap = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày lập",
                DataPropertyName = "NgayLap",
                Name = "NgayLap",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Format = "dd/MM/yyyy"
                }
            };
            dataGridView.Columns.Add(colNgayLap);

            // Thêm cột Tổng tiền (Căn phải, in đậm, xanh, phân cách hàng nghìn)
            DataGridViewTextBoxColumn colTongTien = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tổng tiền",
                DataPropertyName = "TongTienHoaDon",
                Name = "TongTienHoaDon",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0",
                    ForeColor = Color.Blue
                }
            };
            dataGridView.Columns.Add(colTongTien);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            // Capture the search query from the TextBox (trim and convert to lowercase)
            string searchQuery = txtSearch.Text.Trim().ToLower();

            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();

            // Filter HoaDon list based on search query (only KhachHang name)
            hd = context.HoaDon
                .Where(r => string.IsNullOrEmpty(searchQuery) || r.KhachHang.HoVaTen.ToLower().Contains(searchQuery))
                .Select(r => new DanhSachHoaDon
                {
                    MaHD = r.MaHD,
                    Manv = r.Manv,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    MaKH = r.MaKH,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Any() ? r.HoaDon_ChiTiet.Sum(ct => (double?)ct.SoLuongBan * ct.DonGiaBan) ?? 0 : 0,
                }).ToList();

            // Bind filtered data to the DataGridView
            dataGridView.DataSource = hd;

            // Update the total amount label (if any)
            double tongTienTatCa = hd.Sum(h => h.TongTienHoaDon) ?? 0;
            lblTongTienTatCa.Text = "Tổng tiền: " + tongTienTatCa.ToString("N0") + " VNĐ";
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDonChiTiet chiTiet = new frmHoaDonChiTiet(id, tenDangDangNhap))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = dataGridView.CurrentRow.Cells["MaHD"].Value.ToString();
            using (frmHoaDonChiTiet chiTiet = new frmHoaDonChiTiet(id, tenDangDangNhap))
            {
                chiTiet.ShowDialog();
            }
            id = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hóa đơn này ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            DialogResult.Yes)
            {
                id = dataGridView.CurrentRow.Cells["MaHD"].Value.ToString();
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();

                frmHoaDon_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy dữ liệu hóa đơn và chi tiết
                    var hoaDonData = context.HoaDon
                        .Include(h => h.NhanVien)
                        .Include(h => h.KhachHang)
                        .Include(h => h.HoaDon_ChiTiet)
                        .ThenInclude(ct => ct.SanPham)
                        .Select(h => new
                        {
                            HoaDonInfo = new
                            {
                                h.MaHD,
                                h.Manv,
                                NhanVien = h.NhanVien.HoVaTen,
                                h.MaKH,
                                KhachHang = h.KhachHang.HoVaTen,
                                h.NgayLap,
                                GhiChu = h.GhiChuHoaDon,
                                TongTien = h.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan)
                            },
                            ChiTiet = h.HoaDon_ChiTiet.Select(ct => new DanhSachHoaDon_ChiTiet
                            {
                                MaHD_CT = ct.MaHD_CT,
                                HoaDonID = ct.HoaDonID,
                                SanPhamID = ct.SanPhamID,
                                TenSanPham = ct.SanPham.TenSanPham ?? "Tên không xác định",
                                SoLuongBan = ct.SoLuongBan,
                                DonGiaBan = ct.DonGiaBan,
                                ThanhTien = ct.SoLuongBan * ct.DonGiaBan
                            }).ToList()
                        })
                        .ToList();

                    // Tạo workbook Excel
                    using (var workbook = new XLWorkbook())
                    {
                        // Worksheet cho hóa đơn
                        var wsHoaDon = workbook.Worksheets.Add("Hóa Đơn");

                        // Tạo bảng dữ liệu hóa đơn
                        var tableHoaDon = wsHoaDon.Cell(1, 1).InsertTable(
                            hoaDonData.Select(x => x.HoaDonInfo),
                            "TableHoaDon",
                            true
                        );

                        // Định dạng cột ngày tháng và tiền tệ
                        wsHoaDon.Column(6).Style.DateFormat.Format = "dd/MM/yyyy";
                        wsHoaDon.Column(8).Style.NumberFormat.Format = "#,##0";

                        // Worksheet cho chi tiết hóa đơn
                        var wsChiTiet = workbook.Worksheets.Add("Chi Tiết HĐ");

                        // Tạo bảng dữ liệu chi tiết
                        var tableChiTiet = wsChiTiet.Cell(1, 1).InsertTable(
                            hoaDonData.SelectMany(x => x.ChiTiet),
                            "TableChiTiet",
                            true
                        );

                        // Định dạng các cột chi tiết
                        wsChiTiet.Columns(5, 7).Style.NumberFormat.Format = "#,##0";

                        // Tự động điều chỉnh độ rộng cột
                        wsHoaDon.Columns().AdjustToContents();
                        wsChiTiet.Columns().AdjustToContents();

                        // Lưu file Excel
                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên) 
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo) 
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                HoaDon hd = new HoaDon();
                                hd.MaHD = r["MaHD"].ToString();
                                hd.Manv = r["Manv"].ToString();
                                hd.MaKH = r["MaKH"].ToString();
                                hd.NgayLap = Convert.ToDateTime(r["NgayLap"]);
                                hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();
                                context.HoaDon.Add(hd);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = dataGridView.CurrentRow.Cells["MaHD"].Value.ToString();
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
            id = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "hoadon.html");
            frmGuide guide = new frmGuide(htmlPath);
            guide.ShowDialog();
        }

        private void picGuideColored_MouseLeave(object sender, EventArgs e)
        {
            picGuide.BringToFront();
            picGuideColored.SendToBack();
        }

        private void picGuide_MouseEnter(object sender, EventArgs e)
        {
            picGuide.SendToBack();
            picGuideColored.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SendToBack();
            pictureBox1.BringToFront();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox1.SendToBack();
        }
    }
}
