using ClosedXML.Excel;
using CuaHangGamingGear.Data;
using CuaHangGamingGear.Help;
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
    public partial class frmHoaDonChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        string id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa) 
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        private string tenDangNhapHienTai;
        public frmHoaDonChiTiet(string maHoaDon, string tenDangNhap)
        {
            InitializeComponent();
            SetupDataGridView();
            id = maHoaDon;
            tenDangNhapHienTai = tenDangNhap;
        }

        private void SetupDataGridView()
        {
            // Xóa các cột hiện có (nếu có)
            dataGridView.Columns.Clear();

            // Thêm cột ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "SanPhamID",
                Name = "SanPhamID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100 // Giữ cố định độ rộng
            };
            dataGridView.Columns.Add(colID);

            // Thêm cột Tên sản phẩm
            DataGridViewTextBoxColumn colTenSanPham = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "TenSanPham",
                Name = "TenSanPham",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView.Columns.Add(colTenSanPham);

            // Thêm cột Đơn giá bán (căn phải, có phân cách hàng nghìn)
            DataGridViewTextBoxColumn colDonGiaBan = new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn giá bán",
                DataPropertyName = "DonGiaBan",
                Name = "DonGiaBan",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0" // Hiển thị số có dấu phân cách hàng nghìn
                }
            };
            dataGridView.Columns.Add(colDonGiaBan);

            // Thêm cột Số lượng bán (căn phải, có phân cách hàng nghìn)
            DataGridViewTextBoxColumn colSoLuongBan = new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lượng bán",
                DataPropertyName = "SoLuongBan",
                Name = "SoLuongBan",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0"
                }
            };
            dataGridView.Columns.Add(colSoLuongBan);

            // Thêm cột Thành tiền (căn phải, có phân cách hàng nghìn, chữ đậm, màu xanh)
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn
            {
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                Name = "ThanhTien",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0",
                    ForeColor = Color.Blue
                }
            };
            dataGridView.Columns.Add(colThanhTien);
        }

        public void LayNhanVienVaoComboBox(string tenDangNhap)
        {
            using (var db = new QLBHDbContext())
            {
                var nhanVienList = db.NhanVien
                                     .Where(nv => nv.TenDangNhap == tenDangNhap)
                                     .ToList();

                cboNhanVien.DataSource = nhanVienList;
                cboNhanVien.ValueMember = "Manv";
                cboNhanVien.DisplayMember = "HoVaTen";
            }
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "SanPhamID";
            cboSanPham.DisplayMember = "TenSanPham";
        }

        public void BatTatChucNang()
        {
            if (string.IsNullOrEmpty(id) && dataGridView.Rows.Count == 0) // Thêm 
            {
                // Xóa trắng các trường 
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }

            // Nút lưu và xóa chỉ sáng khi có sản phẩm 
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            XoaTruongNhapLieu();
            // Nạp dữ liệu cho ComboBox
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            LayNhanVienVaoComboBox(tenDangNhapHienTai);


            dataGridView.AutoGenerateColumns = false;

            if (!string.IsNullOrEmpty(id)) // Đã tồn tại chi tiết 
            {
                var hoaDon = context.HoaDon.Where(r => r.MaHD == id).SingleOrDefault();
                cboNhanVien.SelectedValue = hoaDon.Manv;
                cboKhachHang.SelectedValue = hoaDon.MaKH;
                txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

                var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    MaHD_CT = r.MaHD_CT,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();

                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }

            using (var db = new QLBHDbContext())
            {
                var nhanVien = db.NhanVien
                                 .FirstOrDefault(nv => nv.TenDangNhap == tenDangNhapHienTai);

                if (nhanVien != null)
                {
                    LayNhanVienVaoComboBox(tenDangNhapHienTai); // Gọi hàm truyền tham số
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên.");
                }
            }

            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private string GenerateID()
        {
            const string prefix = "HD"; // Tiền tố cố định
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
            while (context.HoaDon.AsNoTracking().Any(hd => hd.MaHD == newID));

            return newID;
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                string maSanPham = cboSanPham.SelectedValue?.ToString();
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin  
                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào 
                {
                    // Nếu chưa có sản phẩm nào 
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        MaHD_CT = Guid.NewGuid().ToString(),
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSanPham = dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString();
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private string GenerateHDCT()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString(); // Sinh số ngẫu nhiên 4 chữ số
        }

        private string KiemTraMaCT()
        {
            string newID;
            do
            {
                newID = GenerateHDCT();
            }
            while (context.HoaDon_ChiTiet.AsNoTracking().Any(chitiet => chitiet.MaHD_CT == newID));

            return newID;
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(id)) // Cập nhật hóa đơn đã tồn tại
            {
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    hd.Manv = cboNhanVien.SelectedValue?.ToString();
                    hd.MaKH = cboKhachHang.SelectedValue?.ToString();
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Update(hd); hoaDonChiTiet.Clear();

                    // Xóa chi tiết cũ 
                    var old = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                    foreach (var oldItem in old)
                    {
                        var sp = context.SanPham.Find(oldItem.SanPhamID);
                        if (sp != null)
                        {
                            sp.SoLuong += oldItem.SoLuongBan;
                        }
                    }
                    context.HoaDon_ChiTiet.RemoveRange(old);

                    // Thêm lại chi tiết mới 
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                        {
                            MaHD_CT = KiemTraMaCT(),
                            HoaDonID = id,  //Gán đúng mã hóa đơn
                            SanPhamID = item.SanPhamID,
                            SoLuongBan = item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan
                        };
                        context.HoaDon_ChiTiet.Add(ct);

                        var sanPham = context.SanPham.Find(item.SanPhamID);
                        if (sanPham.SoLuong < item.SoLuongBan)
                        {
                            MessageBox.Show($"Sản phẩm {sanPham.TenSanPham} không đủ số lượng tồn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        sanPham.SoLuong -= item.SoLuongBan;
                        context.SanPham.Update(sanPham);
                    }
                    context.SaveChanges();
                }
            }
            else // Thêm mới hóa đơn
            {
                HoaDon hd = new HoaDon
                {
                    MaHD = GenerateUniqueID(),  //Tạo mã hóa đơn mới
                    Manv = cboNhanVien.SelectedValue?.ToString(),
                    MaKH = cboKhachHang.SelectedValue?.ToString(),
                    NgayLap = DateTime.Now,
                    GhiChuHoaDon = txtGhiChuHoaDon.Text
                };

                context.HoaDon.Add(hd);
                context.SaveChanges(); //Lưu hóa đơn trước

                id = hd.MaHD;

                // Thêm chi tiết hóa đơn
                foreach (var item in hoaDonChiTiet.ToList())
                {
                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                    {
                        MaHD_CT = KiemTraMaCT(),  //Sinh mã chi tiết hóa đơn
                        HoaDonID = hd.MaHD,  //Đúng: Gán mã hóa đơn mới tạo
                        SanPhamID = item.SanPhamID,
                        SoLuongBan = item.SoLuongBan,
                        DonGiaBan = item.DonGiaBan
                    };
                    context.HoaDon_ChiTiet.Add(ct);

                    var sanPham = context.SanPham.Find(item.SanPhamID);
                    if (sanPham != null)
                    {
                        if (sanPham.SoLuong < item.SoLuongBan)
                        {
                            MessageBox.Show($"Sản phẩm {sanPham.TenSanPham} không đủ số lượng tồn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        sanPham.SoLuong -= item.SoLuongBan;
                        context.SanPham.Update(sanPham);
                    }
                }
                context.SaveChanges(); //Lưu chi tiết hóa đơn sau khi hóa đơn đã có
            }
            frmHoaDonChiTiet_Load(sender, e);
            MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaTruongNhapLieu();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            XoaTruongNhapLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                string selectedSanPhamId = cboSanPham.SelectedValue.ToString();
                var sanPham = context.SanPham.FirstOrDefault(sp => sp.SanPhamID == selectedSanPhamId);
                if (sanPham != null)
                {
                    numDonGiaBan.Text = sanPham.DonGia.ToString();
                    try
                    {
                        if (!string.IsNullOrEmpty(sanPham.HinhAnh))
                        {
                            // Nếu là đường dẫn tương đối, có thể cần bổ sung thư mục base path:
                            string imagePath = Path.Combine(Application.StartupPath, sanPham.HinhAnh);
                            if (File.Exists(imagePath))
                            {
                                pictureBoxSanPham.Image = Image.FromFile(imagePath);
                                pictureBoxSanPham.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc Zoom
                            }
                            else
                            {
                                pictureBoxSanPham.Image = null;
                            }
                        }
                        else
                        {
                            pictureBoxSanPham.Image = null;
                        }
                    }
                    catch
                    {
                        pictureBoxSanPham.Image = null;
                    }
                }
            }
        }


        private void XoaTruongNhapLieu()
        {
            // Thông tin hóa đơn
            cboKhachHang.SelectedIndex = -1;
            txtGhiChuHoaDon.Clear();

            // Thông tin sản phẩm
            cboSanPham.SelectedIndex = -1;
            numDonGiaBan.Value = 0;
            numSoLuongBan.Value = 0;

            // Xóa danh sách sản phẩm đã thêm
            dataGridView.Rows.Clear();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells["SanPhamID"].Value != null)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy mã sản phẩm
                string maSP = row.Cells["SanPhamID"].Value?.ToString();
                int soLuong = Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                double donGia = Convert.ToDouble(row.Cells["DonGiaBan"].Value);

                // Gán vào combobox sản phẩm
                cboSanPham.SelectedValue = maSP;

                // Gán số lượng vào numeric updown
                numSoLuongBan.Value = soLuong;

                // Gán đơn giá nếu có textbox đơn giá
                numDonGiaBan.Text = donGia.ToString("#,##0");
            }
        }

        private void picGuideColored_MouseLeave(object sender, EventArgs e)
        {
            picGuide.BringToFront();
            picGuideColored.SendToBack();
        }

        private void picGuideColored_Click(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Help", "hoadon_chitiet.html");
            frmGuide guide = new frmGuide(htmlPath);
            guide.ShowDialog();
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
