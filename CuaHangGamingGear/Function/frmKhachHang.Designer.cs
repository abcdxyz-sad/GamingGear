namespace CuaHangGamingGear
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            groupBox1 = new GroupBox();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label2 = new Label();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox6 = new GroupBox();
            txtSearch = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(755, 142);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(135, 85);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(602, 30);
            txtDiaChi.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(8, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 12;
            label3.Text = "Địa chỉ :";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(553, 29);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(184, 30);
            txtDienThoai.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(443, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 7;
            label2.Text = "Điện thoại :";
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
            label1.Location = new Point(8, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepSkyBlue;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(138, 26);
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
            btnNhap.Location = new Point(20, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 34);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(353, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 34);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(181, 102);
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
            btnHuyBo.Location = new Point(181, 67);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DeepSkyBlue;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(40, 102);
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
            btnXoa.Location = new Point(181, 27);
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
            btnSua.Location = new Point(40, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
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
            btnThem.Location = new Point(40, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Times New Roman", 12F);
            groupBox2.Location = new Point(11, 242);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1099, 445);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
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
            dataGridView.Size = new Size(1091, 416);
            dataGridView.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtSearch);
            groupBox6.Controls.Add(btnTimKiem);
            groupBox6.Location = new Point(21, 8);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(476, 80);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm khách hàng";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Location = new Point(517, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 76);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnHuyBo);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Location = new Point(774, 94);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(318, 142);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 58);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter_1;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(150, 3);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(68, 58);
            picGuide.TabIndex = 34;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(150, 3);
            picGuideColored.Name = "picGuideColored";
            picGuideColored.Size = new Size(68, 58);
            picGuideColored.TabIndex = 33;
            picGuideColored.TabStop = false;
            picGuideColored.Click += picGuideColored_Click;
            picGuideColored.MouseLeave += picGuideColored_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(picGuideColored);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(842, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 65);
            panel1.TabIndex = 35;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 688);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private TextBox txtDienThoai;
        private Label label2;
        private TextBox txtDiaChi;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private GroupBox groupBox6;
        private TextBox txtSearch;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private Panel panel1;
    }
}