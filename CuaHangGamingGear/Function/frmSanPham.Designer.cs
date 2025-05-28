namespace CuaHangGamingGear
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtMoTa = new TextBox();
            label3 = new Label();
            txtTenSanPham = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            groupBox6 = new GroupBox();
            txtSearch = new TextBox();
            groupBox3 = new GroupBox();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Times New Roman", 12F);
            groupBox2.Location = new Point(4, 335);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1086, 369);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.Lavender;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1078, 340);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(29, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(649, 317);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepSkyBlue;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(532, 249);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 46);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.DeepSkyBlue;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.White;
            btnNhap.Location = new Point(432, 249);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 46);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(532, 64);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(106, 30);
            numDonGia.TabIndex = 22;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(532, 28);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(106, 30);
            numSoLuong.TabIndex = 21;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(170, 64);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(209, 30);
            cboHangSanXuat.TabIndex = 20;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(170, 28);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(209, 30);
            cboLoaiSanPham.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(10, 67);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 22);
            label6.TabIndex = 18;
            label6.Text = "Hãng sản xuất (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(8, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 22);
            label5.TabIndex = 16;
            label5.Text = "Tên sản phẩm (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(404, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 14;
            label4.Text = "Số lượng (*) :";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(170, 137);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(468, 30);
            txtMoTa.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(404, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 12;
            label3.Text = "Đơn giá (*):";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(170, 100);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(468, 30);
            txtTenSanPham.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(10, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 7;
            label2.Text = "Mô tả sản phẩm :";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(532, 185);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 46);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Silver;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(431, 185);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 46);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(331, 185);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 46);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(231, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepSkyBlue;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(131, 185);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DeepSkyBlue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(31, 185);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(10, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 22);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(263, 74);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 46);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(155, 75);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(105, 44);
            btnDoiAnh.TabIndex = 24;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(6, 19);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(143, 139);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 23;
            picHinhAnh.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtSearch);
            groupBox6.Controls.Add(btnTimKiem);
            groupBox6.Location = new Point(707, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(379, 126);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm sản phẩm/ hãng sản xuất";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(26, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(338, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDoiAnh);
            groupBox3.Controls.Add(picHinhAnh);
            groupBox3.Location = new Point(707, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 166);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(12, 86);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(68, 58);
            picGuide.TabIndex = 46;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(12, 86);
            picGuideColored.Name = "picGuideColored";
            picGuideColored.Size = new Size(68, 58);
            picGuideColored.TabIndex = 45;
            picGuideColored.TabStop = false;
            picGuideColored.Click += picGuideColored_Click;
            picGuideColored.MouseLeave += picGuideColored_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 58);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(picGuideColored);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(988, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(92, 154);
            panel1.TabIndex = 29;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 703);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private ComboBox cboLoaiSanPham;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMoTa;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private TextBox txtTenSanPham;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboHangSanXuat;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private GroupBox groupBox6;
        private TextBox txtSearch;
        private GroupBox groupBox3;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}