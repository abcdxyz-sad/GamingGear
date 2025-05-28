﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CuaHangGamingGear.Data;
using Microsoft.EntityFrameworkCore;

namespace CuaHangGamingGear.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLGGDataSet.DanhSachHoaDon_ChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLGGDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        string id; // Mã hóa đơn

        public frmInHoaDon(string maHoaDon)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.KhachHang).Include(r => r.HoaDon_ChiTiet)
               .Where(r => r.MaHD == id).SingleOrDefault();

            if (hoaDon != null)
            {
                var hoaDonChiTiet = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    MaHD_CT = r.MaHD_CT,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();

                danhSachHoaDon_ChiTietDataTable.Clear();
                foreach (var row in hoaDonChiTiet)
                {
                    danhSachHoaDon_ChiTietDataTable.AddDanhSachHoaDon_ChiTietRow(row.MaHD_CT,
                        row.HoaDonID,
                        row.SanPhamID,
                        row.TenSanPham,
                        row.SoLuongBan,
                        row.DonGiaBan,
                        row.ThanhTien);
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachHoaDon_ChiTiet";
                reportDataSource.Value = danhSachHoaDon_ChiTietDataTable;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports", "rptInHoaDon.rdlc");

                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}",
                        hoaDon.NgayLap.Day,
                        hoaDon.NgayLap.Month,
                        hoaDon.NgayLap.Year)),

                    new ReportParameter("NguoiBan_Ten", "CÔNG TY TNHH FREDDY FAZBEAR"),
                    new ReportParameter("NguoiBan_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiBan_MaSoThue", "1602162070"),

                    new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.HoVaTen),
                    new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChi),
                    new ReportParameter("NguoiMua_MaSoThue", ""),

                    new ReportParameter("TongTien", hoaDon.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan).ToString())
                };
                reportViewer1.LocalReport.SetParameters(param);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                reportViewer1.RefreshReport();
            }
        }
    }
}
