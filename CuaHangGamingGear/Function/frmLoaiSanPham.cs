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
using ClosedXML.Excel;
using SystemPath = System.IO.Path;
using OpenXmlPath = DocumentFormat.OpenXml.Drawing.Path;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using CuaHangGamingGear.Help;

namespace CuaHangGamingGear
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
            SetupDataGridView();

        }

        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        string id;
        private static readonly Random rand = new Random();

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void SetupDataGridView()
        {
            // Xóa các cột hiện có (nếu có)
            dataGridView.Columns.Clear();

            // Thêm cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã loại",
                DataPropertyName = "LoaiSanPhamID",
                Name = "LoaiSanPhamID"
            };
            dataGridView.Columns.Add(colID);

            // Thêm cột Tên loại sản phẩm
            DataGridViewTextBoxColumn colTenLoai = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên loại sản phẩm",
                DataPropertyName = "TenLoai",
                Name = "TenLoai",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView.Columns.Add(colTenLoai);
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<LoaiSanPham> lsp = new List<LoaiSanPham>();
            lsp = context.LoaiSanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu trong database, vui lòng nhập vào trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Load lại form hoặc làm mới dữ liệu
                frmLoaiSanPham_Load(sender, e);
                return;
            }
            xuLyThem = false;
            BatTatChucNang(true);
            id = dataGridView.CurrentRow.Cells["LoaiSanPhamID"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = dataGridView.CurrentRow.Cells["LoaiSanPhamID"].Value.ToString();
                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                }
                context.SaveChanges();

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private string GenerateID()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder idBuilder = new StringBuilder();

            // Tạo 3 chữ cái ngẫu nhiên
            for (int i = 0; i < 3; i++)
            {
                idBuilder.Append(letters[rand.Next(letters.Length)]);
            }

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
            while (context.LoaiSanPham.AsNoTracking().Any(lsp => lsp.LoaiSanPhamID == newID));

            return newID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.LoaiSanPhamID = GenerateUniqueID();  // Gán mã tự sinh
                    lsp.TenLoai = txtTenLoai.Text;
                    context.LoaiSanPham.Add(lsp);

                    context.SaveChanges();
                }
                else
                {
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                        context.LoaiSanPham.Update(lsp);

                        context.SaveChanges();
                    }
                }

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
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
                                LoaiSanPham lsp = new LoaiSanPham();
                                lsp.LoaiSanPhamID = r["LoaiSanPhamID"].ToString();
                                lsp.TenLoai = r["TenLoai"].ToString();
                                context.LoaiSanPham.Add(lsp);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmLoaiSanPham_Load(sender, e);
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
            saveFileDialog.FileName = "LoaiSanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[2] {
                        new DataColumn("LoaiSanPhamID", typeof(string)),
                        new DataColumn("TenLoai", typeof(string))
                   });

                    var loaiSanPham = context.LoaiSanPham.ToList();
                    if (loaiSanPham != null)
                    {
                        foreach (var p in loaiSanPham)
                            table.Rows.Add(p.LoaiSanPhamID, p.TenLoai);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "LoaiSanPham");
                        sheet.Columns().AdjustToContents();
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

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "loai.html");
            frmGuide guide = new frmGuide(htmlPath);
            guide.ShowDialog();
        }

        private void picGuideColored_MouseLeave(object sender, EventArgs e)
        {
            picGuide.BringToFront();
            picGuideColored.SendToBack();
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

        private void picGuide_MouseEnter(object sender, EventArgs e)
        {
            picGuide.SendToBack();
            picGuideColored.BringToFront();
        }
    }
}
