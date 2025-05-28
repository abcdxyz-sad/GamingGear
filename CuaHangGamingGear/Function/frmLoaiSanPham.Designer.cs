namespace CuaHangGamingGear
{
    partial class frmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            label1 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuyBo = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox3 = new GroupBox();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(699, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(550, 92);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(104, 46);
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
            btnXoa.Location = new Point(390, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 46);
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
            btnSua.Location = new Point(219, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 46);
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
            btnThem.Location = new Point(48, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(219, 43);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(463, 30);
            txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(24, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên loại sản phẩm (*):";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.DeepSkyBlue;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.White;
            btnNhap.Location = new Point(137, 34);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(104, 46);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepSkyBlue;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(137, 92);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(104, 46);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DarkGray;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(9, 92);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(104, 46);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Times New Roman", 12F);
            groupBox2.Location = new Point(10, 187);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1074, 454);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
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
            dataGridView.Size = new Size(1066, 425);
            dataGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Location = new Point(726, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(247, 169);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(19, 22);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(68, 58);
            picGuide.TabIndex = 42;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(19, 22);
            picGuideColored.Name = "picGuideColored";
            picGuideColored.Size = new Size(68, 58);
            picGuideColored.TabIndex = 41;
            picGuideColored.TabStop = false;
            picGuideColored.Click += picGuideColored_Click;
            picGuideColored.MouseLeave += picGuideColored_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(picGuideColored);
            panel1.Location = new Point(979, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 169);
            panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 58);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1097, 653);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLoaiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại Sản Phẩm";
            Load += frmLoaiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoai;
        private DataGridView dataGridView;
        private Button btnNhap;
        private Button btnXuat;
        private GroupBox groupBox3;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}