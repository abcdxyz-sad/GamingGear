using ClosedXML.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using CuaHangGamingGear.Help;

namespace CuaHangGamingGear
{
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        private static readonly Random rand = new Random();
        string id;

        private void SetupDataGridView()
        {
            // Xóa các cột hiện có (nếu có)
            dataGridView.Columns.Clear();

            // Thiết lập chế độ co giãn cột
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã hãng",
                DataPropertyName = "MaHSX",
                Name = "MaHSX",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 120  // Giữ cột ID ở kích thước cố định
            };
            dataGridView.Columns.Add(colID);

            // Thêm cột Tên hãng sản xuất
            DataGridViewTextBoxColumn colTenHangSX = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên hãng sản xuất",
                DataPropertyName = "TenHangSanXuat",
                Name = "TenHangSanXuat",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill  // Cột này sẽ giãn hết phần còn lại
            };
            dataGridView.Columns.Add(colTenHangSX);
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<HangSanXuat> hsx = new List<HangSanXuat>();
            hsx = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

            bool coDuLieu = hsx.Count > 0;
            btnXuat.Enabled = coDuLieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu trong database, vui lòng nhập vào trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Load lại form hoặc làm mới dữ liệu
                frmHangSanXuat_Load(sender, e);
                return;
            }
            xuLyThem = false;
            BatTatChucNang(true);
            id = dataGridView.CurrentRow.Cells["MaHSX"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tên hãng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = dataGridView.CurrentRow.Cells["MaHSX"].Value.ToString();
                HangSanXuat lsp = context.HangSanXuat.Find(id);
                if (lsp != null)
                {
                    context.HangSanXuat.Remove(lsp);
                }
                context.SaveChanges();

                frmHangSanXuat_Load(sender, e);
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
            while (context.HangSanXuat.AsNoTracking().Any(hsx => hsx.MaHSX == newID));

            return newID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    HangSanXuat hsx = new HangSanXuat();
                    hsx.MaHSX = GenerateUniqueID();  // Gán mã tự sinh
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Add(hsx);

                    context.SaveChanges();
                }
                else
                {
                    HangSanXuat hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                        context.HangSanXuat.Update(hsx);

                        context.SaveChanges();
                    }
                }

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
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
                                HangSanXuat hsx = new HangSanXuat();
                                hsx.MaHSX = r["MaHSX"].ToString();
                                hsx.TenHangSanXuat = r["TenHangSanXuat"].ToString();
                                context.HangSanXuat.Add(hsx);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHangSanXuat_Load(sender, e);
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
            saveFileDialog.FileName = "HangSanXuat_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[2] {
                        new DataColumn("MaHSX", typeof(string)),
                        new DataColumn("TenHangSanXuat", typeof(string))
                   });

                    var HangSanXuat = context.HangSanXuat.ToList();
                    if (HangSanXuat != null)
                    {
                        foreach (var p in HangSanXuat)
                            table.Rows.Add(p.MaHSX, p.TenHangSanXuat);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HangSanXuat");
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
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "hang.html");
            frmGuide guide = new frmGuide(htmlPath);
            guide.ShowDialog();
        }

        private void picGuide_MouseEnter(object sender, EventArgs e)
        {
            picGuide.SendToBack();
            picGuideColored.BringToFront();
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
    }
}
