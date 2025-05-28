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
using BCrypt.Net;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Drawing;
using CuaHangGamingGear.Help;
using IOPath = System.IO.Path;

namespace CuaHangGamingGear
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        string id;
        private static readonly Random rand = new Random();

        private void SetupDataGridView()
        {
            // Xóa cột mặc định (nếu có)
            dataGridView.Columns.Clear();

            // Thêm cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã nhân viên",
                DataPropertyName = "Manv",
                Name = "Manv",
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

            // Thêm cột Tên đăng nhập
            DataGridViewTextBoxColumn colTenDangNhap = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên đăng nhập",
                DataPropertyName = "TenDangNhap",
                Name = "TenDangNhap",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            // Thêm cột Quyền hạn
            DataGridViewTextBoxColumn colQuyenHan = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quyền hạn",
                DataPropertyName = "QuyenHan",
                Name = "QuyenHan",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            // Thêm các cột vào DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colDiaChi, colTenDangNhap, colQuyenHan });
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            string searchQuery = txtSearch.Text.Trim().ToLower(); // Lấy nội dung cần tìm

            var nv = context.NhanVien
                .Where(nv => string.IsNullOrEmpty(searchQuery) || nv.HoVaTen.ToLower().Contains(searchQuery))
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = dataGridView.CurrentRow.Cells["Manv"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = dataGridView.CurrentRow.Cells["Manv"].Value.ToString();
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();

                frmNhanVien_Load(sender, e);
            }
        }

        private string GenerateID()
        {
            const string prefix = "NV"; // Tiền tố cố định
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
            while (context.NhanVien.AsNoTracking().Any(nv => nv.Manv == newID));

            return newID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.Manv = GenerateUniqueID();  // Gán mã tự sinh
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                        nv.QuyenHan = cboQuyenHan.SelectedIndex; // Lưu giá trị 0 hoặc 1
                        context.NhanVien.Add(nv);

                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHan = nv.QuyenHan = cboQuyenHan.SelectedIndex; // Lưu giá trị 0 hoặc 1
                        context.NhanVien.Update(nv);

                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ 
                        else
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới 

                        context.SaveChanges();
                    }
                }

                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                NhanVien nv = new NhanVien();
                                nv.Manv = r["Manv"].ToString();
                                nv.HoVaTen = r["HoVaTen"].ToString();
                                nv.DiaChi = r["DiaChi"].ToString();
                                nv.DienThoai = r["DienThoai"].ToString();
                                nv.TenDangNhap = r["TenDangNhap"].ToString();
                                nv.MatKhau = r["MatKhau"].ToString();
                                nv.QuyenHan = Convert.ToInt32(r["QuyenHan"]);
                                context.NhanVien.Add(nv);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
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
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("Manv", typeof(string));
                        table.Columns.Add("HoVaTen", typeof(string));
                        table.Columns.Add("DiaChi", typeof(string));
                        table.Columns.Add("DienThoai", typeof(string));
                        table.Columns.Add("TenDangNhap", typeof(string));
                        table.Columns.Add("MatKhau", typeof(string));
                        table.Columns.Add("QuyenHan", typeof(int));

                        var nhanVienList = context.NhanVien.ToList();
                        foreach (var nv in nhanVienList)
                        {
                            table.Rows.Add(nv.Manv, nv.HoVaTen, nv.DiaChi, nv.DienThoai, nv.TenDangNhap, nv.MatKhau, nv.QuyenHan);
                        }

                        wb.Worksheets.Add(table, "NhanVien");
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

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "QuyenHan" && e.Value != null)
            {
                int quyenHan = Convert.ToInt32(e.Value);
                e.Value = quyenHan == 0 ? "Quản lý" : "Nhân viên";
                e.FormattingApplied = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = IOPath.Combine(Application.StartupPath, "Help", "nhanvien.html");
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
    }
}
