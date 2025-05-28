using ClosedXML.Excel;
using CuaHangGamingGear.Data;
using CuaHangGamingGear.Help;
using CuaHangGamingGear.Main;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
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
using IOPath = System.IO.Path;

namespace CuaHangGamingGear
{
    public partial class frmKhachHang : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        private static readonly Random rand = new Random();
        string id;
        frmMain formMain;
        string tenDangDangNhap;

        public frmKhachHang(frmMain main, string tenDangNhap)
        {
            InitializeComponent();
            formMain = main;
            SetupDataGridView();
            tenDangDangNhap = tenDangDangNhap;
        }



        private void SetupDataGridView()
        {
            // Xóa cột mặc định (nếu có)
            dataGridView.Columns.Clear();

            // Thêm cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã khách hàng",
                DataPropertyName = "MaKH",
                Name = "MaKH",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            // Thêm cột Họ và tên
            DataGridViewTextBoxColumn colHoVaTen = new DataGridViewTextBoxColumn
            {
                HeaderText = "Họ và tên",
                DataPropertyName = "HoVaTen",
                Name = "HoVaTen",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            // Thêm cột Điện thoại
            DataGridViewTextBoxColumn colDienThoai = new DataGridViewTextBoxColumn
            {
                HeaderText = "Điện thoại",
                DataPropertyName = "DienThoai",
                Name = "DienThoai",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            // Thêm cột Địa chỉ
            DataGridViewTextBoxColumn colDiaChi = new DataGridViewTextBoxColumn
            {
                HeaderText = "Địa chỉ",
                DataPropertyName = "DiaChi",
                Name = "DiaChi",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            // Thêm các cột vào DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colDiaChi });
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            string searchQuery = txtSearch.Text.Trim().ToLower(); // Lấy nội dung cần tìm

            var kh = context.KhachHang
                .Where(k => string.IsNullOrEmpty(searchQuery) || k.HoVaTen.ToLower().Contains(searchQuery))
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = dataGridView.CurrentRow.Cells["MaKH"].Value.ToString();
        }

        private string GenerateID()
        {
            const string prefix = "KH"; // Tiền tố cố định
            StringBuilder idBuilder = new StringBuilder(prefix);

            // Lấy 4 số ngẫu nhiên từ GUID, đảm bảo có ít nhất 4 chữ số
            string numbers;
            do
            {
                numbers = new string(Guid.NewGuid().ToString("N").Where(char.IsDigit).Take(4).ToArray());
            } while (numbers.Length < 4);  // Đảm bảo đủ 4 chữ số

            idBuilder.Append(numbers);
            return idBuilder.ToString();
        }

        private string GenerateUniqueID()
        {
            string newID;
            do
            {
                newID = GenerateID();
            }
            while (context.KhachHang.AsNoTracking().Any(kh => kh.MaKH == newID));

            return newID;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = dataGridView.CurrentRow.Cells["MaKH"].Value.ToString();
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = GenerateUniqueID();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Add(kh);

                    context.SaveChanges();
                    DialogResult result = MessageBox.Show("Bạn có muốn lập hóa đơn luôn không?", "Lập hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        frmHoaDon hoaDonForm = new frmHoaDon(tenDangDangNhap);
                        formMain.ShowFormInPanel(hoaDonForm);
                    }
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHang.Update(kh);

                        context.SaveChanges();
                    }
                }

                frmKhachHang_Load(sender, e);
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
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
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
                                KhachHang kh = new KhachHang();
                                kh.MaKH = r["MaKH"].ToString();
                                kh.HoVaTen = r["HoVaTen"].ToString();
                                kh.DiaChi = r["DiaChi"].ToString();
                                kh.DienThoai = r["DienThoai"].ToString();
                                context.KhachHang.Add(kh);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhachHang_Load(sender, e);
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("MaKH", typeof(string));
                        table.Columns.Add("HoVaTen", typeof(string));
                        table.Columns.Add("DiaChi", typeof(string));
                        table.Columns.Add("DienThoai", typeof(string));

                        var khachHangList = context.KhachHang.ToList();
                        foreach (var kh in khachHangList)
                        {
                            table.Rows.Add(kh.MaKH, kh.HoVaTen, kh.DiaChi, kh.DienThoai);
                        }

                        wb.Worksheets.Add(table, "KhachHang");
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox2.SendToBack();
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();      // Ẩn ảnh đi
            pictureBox2.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void picGuideColored_MouseLeave(object sender, EventArgs e)
        {
            picGuide.BringToFront();
            picGuideColored.SendToBack();
        }

        private void picGuide_MouseEnter(object sender, EventArgs e)
        {
            picGuideColored.BringToFront();
            picGuide.SendToBack();
        }

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = IOPath.Combine(Application.StartupPath, "Help", "khachhang.html");
            frmGuide guide = new frmGuide(htmlPath);
            guide.ShowDialog();
        }
    }
}
