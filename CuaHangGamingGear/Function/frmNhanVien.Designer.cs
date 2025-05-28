namespace CuaHangGamingGear
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            txtDiaChi = new TextBox();
            label3 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            txtDienThoai = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            dataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            label6 = new Label();
            txtTenDangNhap = new TextBox();
            label5 = new Label();
            txtMatKhau = new TextBox();
            label4 = new Label();
            groupBox6 = new GroupBox();
            txtSearch = new TextBox();
            btnTimKiem = new Button();
            groupBox3 = new GroupBox();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(135, 101);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(264, 30);
            txtDiaChi.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(425, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu (*):";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepSkyBlue;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(119, 98);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 34);
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
            btnNhap.Location = new Point(119, 21);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 34);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(136, 64);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(263, 30);
            txtDienThoai.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(9, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 7;
            label2.Text = "Điện thoại :";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(6, 98);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 34);
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
            btnHuyBo.Location = new Point(6, 58);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 34);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Lavender;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1112, 375);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Times New Roman", 12F);
            groupBox2.Location = new Point(8, 246);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1120, 404);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(6, 21);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 34);
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
            btnXoa.Location = new Point(775, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 34);
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
            btnSua.Location = new Point(775, 58);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(135, 29);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(264, 30);
            txtHoVaTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(9, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DeepSkyBlue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(775, 19);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(8, 98);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(879, 142);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý ", "Nhân viên" });
            cboQuyenHan.Location = new Point(590, 101);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(157, 30);
            cboQuyenHan.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(425, 104);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 22);
            label6.TabIndex = 18;
            label6.Text = "Quyền hạn (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(590, 24);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(157, 30);
            txtTenDangNhap.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(425, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 16;
            label5.Text = "Tên đăng nhập (*):";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(590, 64);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '•';
            txtMatKhau.Size = new Size(157, 30);
            txtMatKhau.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(9, 104);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 14;
            label4.Text = "Địa chỉ :";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtSearch);
            groupBox6.Controls.Add(btnTimKiem);
            groupBox6.Location = new Point(21, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(476, 80);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm nhân viên";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(352, 29);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 35);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Location = new Point(894, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 142);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(29, 15);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(68, 58);
            picGuide.TabIndex = 38;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(29, 15);
            picGuideColored.Name = "picGuideColored";
            picGuideColored.Size = new Size(68, 58);
            picGuideColored.TabIndex = 37;
            picGuideColored.TabStop = false;
            picGuideColored.Click += picGuideColored_Click;
            picGuideColored.MouseLeave += picGuideColored_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(130, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 58);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picGuideColored);
            panel1.Location = new Point(894, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 80);
            panel1.TabIndex = 39;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1133, 653);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtDiaChi;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private TextBox txtDienThoai;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtHoVaTen;
        private Label label1;
        private Button btnThem;
        private GroupBox groupBox1;
        private ComboBox cboQuyenHan;
        private Label label6;
        private TextBox txtTenDangNhap;
        private Label label5;
        private TextBox txtMatKhau;
        private Label label4;
        private GroupBox groupBox6;
        private TextBox txtSearch;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}