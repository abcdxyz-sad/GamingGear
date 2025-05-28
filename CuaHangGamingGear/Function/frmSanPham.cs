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
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using CuaHangGamingGear.Help;

namespace CuaHangGamingGear
{
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        private static readonly Random rand = new Random();
        string id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Images");

        public frmSanPham()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Xóa tất cả các cột cũ
            dataGridView.Columns.Clear();

            // Thiết lập chế độ co giãn cột

            dataGridView.RowTemplate.Height = 60; // Tăng chiều cao của mỗi hàng để hiển thị hình ảnh rõ hơn
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả hàng khi click


            // Cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã SP",
                DataPropertyName = "SanPhamID",
                Name = "SanPhamID",
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            dataGridView.Columns.Add(colID);

            // Cột Phân loại
            DataGridViewTextBoxColumn colPhanLoai = new DataGridViewTextBoxColumn
            {
                HeaderText = "Phân loại",
                DataPropertyName = "TenLoai",
                Name = "TenLoai",
                Width = 130
            };
            dataGridView.Columns.Add(colPhanLoai);

            // Cột Hãng sản xuất
            DataGridViewTextBoxColumn colHangSanXuat = new DataGridViewTextBoxColumn
            {
                HeaderText = "Hãng sản xuất",
                DataPropertyName = "TenHangSanXuat",
                Name = "TenHangSanXuat",
                Width = 150
            };
            dataGridView.Columns.Add(colHangSanXuat);

            // Cột Tên sản phẩm
            DataGridViewTextBoxColumn colTenSanPham = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "TenSanPham",
                Name = "TenSanPham",
                Width = 330
            };
            dataGridView.Columns.Add(colTenSanPham);

            // Cột Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lượng",
                DataPropertyName = "SoLuong",
                Name = "SoLuong",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            dataGridView.Columns.Add(colSoLuong);

            // Cột Đơn giá
            DataGridViewTextBoxColumn colDonGia = new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                Name = "DonGia",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N0" }
            };
            dataGridView.Columns.Add(colDonGia);

            // Cột Hình ảnh
            DataGridViewImageColumn colHinhAnh = new DataGridViewImageColumn
            {
                HeaderText = "Hình ảnh",
                DataPropertyName = "HinhAnh",
                Name = "HinhAnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 120
            };
            dataGridView.Columns.Add(colHinhAnh);
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "LoaiSanPhamID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "MaHSX";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            dataGridView.AutoGenerateColumns = false;

            string searchQuery = txtSearch.Text.Trim().ToLower();

            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham
                .Where(r => string.IsNullOrEmpty(searchQuery) ||
                            r.TenSanPham.ToLower().Contains(searchQuery) ||  // Tìm kiếm theo tên sản phẩm
                            r.HangSanXuat.TenHangSanXuat.ToLower().Contains(searchQuery)) // Tìm kiếm theo tên hãng sản xuất
                .Select(r => new DanhSachSanPham
                {
                    SanPhamID = r.SanPhamID,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoai = r.LoaiSanPham.TenLoai,
                    HangSanXuatID = r.HangSanXuatID,
                    TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                    TenSanPham = r.TenSanPham,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    HinhAnh = r.HinhAnh
                }).ToList();


            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            picHinhAnh.DataBindings.Clear();

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;

            picHinhAnh.DataBindings.Clear();
            picHinhAnh.Image = null;
            picHinhAnh.ImageLocation = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            DialogResult.Yes)
            {
                id = dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString();
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();

                frmSanPham_Load(sender, e);
            }
        }

        private string GenerateID()
        {
            const string prefix = "SP"; // Tiền tố cố định
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
            while (context.SanPham.AsNoTracking().Any(sp => sp.SanPhamID == newID));

            return newID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    sp.SanPhamID = GenerateUniqueID();  // Gán mã tự sinh
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.LoaiSanPhamID = cboLoaiSanPham.SelectedValue?.ToString();
                    sp.HangSanXuatID = cboHangSanXuat.SelectedValue?.ToString();
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.DonGia = (int)numDonGia.Value;
                    sp.HinhAnh = string.IsNullOrEmpty(picHinhAnh.ImageLocation) ? "" : Path.GetFileName(picHinhAnh.ImageLocation);
                    context.SanPham.Add(sp);

                    context.SaveChanges();
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.LoaiSanPhamID = cboLoaiSanPham.SelectedValue?.ToString();
                        sp.HangSanXuatID = cboHangSanXuat.SelectedValue?.ToString();
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.DonGia = (int)numDonGia.Value;
                        sp.HinhAnh = string.IsNullOrEmpty(picHinhAnh.ImageLocation) ? "" : Path.GetFileName(picHinhAnh.ImageLocation);
                        context.SanPham.Update(sp);

                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, GenerateSlug(fileName) + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                id = dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString();
                SanPham sp = context.SanPham.Find(id);
                sp.HinhAnh = GenerateSlug(fileName) + ext;
                context.SanPham.Update(sp);

                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private string GenerateSlug(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            // Chuyển thành chữ thường
            string slug = input.ToLower();

            // Loại bỏ ký tự không hợp lệ (giữ lại chữ cái, số và dấu '-')
            slug = Regex.Replace(slug, @"[^a-z0-9\s-]", "");

            // Thay khoảng trắng bằng dấu '-'
            slug = Regex.Replace(slug, @"\s+", "-").Trim('-');

            return slug;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    string imagePath = Path.Combine(imagesFolder, e.Value.ToString());

                    if (File.Exists(imagePath)) // Kiểm tra xem file có tồn tại không
                    {
                        try
                        {
                            using (Image image = Image.FromFile(imagePath)) // Đọc ảnh từ file
                            {
                                e.Value = new Bitmap(image, 24, 24); // Resize ảnh
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Value = new Bitmap(24, 24); // Ảnh trống nếu lỗi
                        }
                    }
                    else
                    {
                        e.Value = new Bitmap(24, 24); // Ảnh trống nếu file không tồn tại
                    }
                }
                else
                {
                    e.Value = new Bitmap(24, 24); // Ảnh trống nếu không có đường dẫn
                }
            }
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
                                SanPham sp = new SanPham();
                                sp.SanPhamID = r["SanPhamID"].ToString();
                                sp.TenSanPham = r["TenSanPham"].ToString();
                                sp.HangSanXuatID = r["HangSanXuatID"].ToString();
                                sp.LoaiSanPhamID = r["LoaiSanPhamID"].ToString();
                                sp.DonGia = Convert.ToInt32(r["DonGia"]);
                                sp.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                sp.HinhAnh = r["HinhAnh"].ToString();
                                sp.MoTa = r["MoTa"].ToString();
                                context.SanPham.Add(sp);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSanPham_Load(sender, e);
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
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("SanPhamID", typeof(string));
                        table.Columns.Add("TenSanPham", typeof(string));
                        table.Columns.Add("HangSanXuatID", typeof(string));
                        table.Columns.Add("LoaiSanPhamID", typeof(string));
                        table.Columns.Add("DonGia", typeof(int));
                        table.Columns.Add("SoLuong", typeof(int));
                        table.Columns.Add("HinhAnh", typeof(string));
                        table.Columns.Add("MoTa", typeof(string));

                        var sanPhamList = context.SanPham.ToList();
                        foreach (var sp in sanPhamList)
                        {
                            table.Rows.Add(sp.SanPhamID, sp.TenSanPham, sp.HangSanXuatID, sp.LoaiSanPhamID, sp.DonGia, sp.SoLuong, sp.HinhAnh, sp.MoTa);
                        }

                        wb.Worksheets.Add(table, "SanPham");
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
            frmSanPham_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void txtHangSearch_TextChanged(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
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

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "sanpham.html");
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
