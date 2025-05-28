using Microsoft.Reporting.WinForms;
using CuaHangGamingGear.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CuaHangGamingGear.Reports.QLGGDataSet;
using CuaHangGamingGear.Help;

namespace CuaHangGamingGear.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLGGDataSet.DanhSachHoaDonDataTable danhSachHoaDonTable = new QLGGDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                MaHD = r.MaHD,
                Manv = r.Manv,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                MaKH = r.MaKH,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            danhSachHoaDonTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonTable.AddDanhSachHoaDonRow(row.MaHD,
                 row.Manv,
                 row.HoVaTenNhanVien,
                 row.MaKH,
                 row.HoVaTenKhachHang,
                 row.NgayLap,
                 row.GhiChuHoaDon,
                 Convert.ToDouble(row.TongTienHoaDon ?? 0.0));
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports", "rptThongKeDoanhThuGG.rdlc");

            ReportParameter reportParameter = new ReportParameter("ReportParameter", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                MaHD = r.MaHD,
                Manv = r.Manv,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                MaKH = r.MaKH,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            });

            danhSachHoaDon = danhSachHoaDon.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value);

            danhSachHoaDonTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonTable.AddDanhSachHoaDonRow(row.MaHD,
                 row.Manv,
                 row.HoVaTenNhanVien,
                 row.MaKH,
                 row.HoVaTenKhachHang,
                 row.NgayLap,
                 row.GhiChuHoaDon,
                 Convert.ToDouble(row.TongTienHoaDon ?? 0.0));
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports", "rptThongKeDoanhThuGG.rdlc");

            ReportParameter reportParameter = new ReportParameter("ReportParameter", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "thongke.html");
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
