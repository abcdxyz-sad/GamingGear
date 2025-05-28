namespace CuaHangGamingGear
{
    partial class frmHangSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangSanXuat));
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtTenHangSanXuat = new TextBox();
            label1 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuyBo = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenHangSanXuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Margin = new Padding(6, 3, 6, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 3, 6, 3);
            groupBox1.Size = new Size(699, 169);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hãng sản xuất";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(473, 99);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
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
            btnSua.Location = new Point(300, 99);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 46);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(8, 29);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(104, 46);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DeepSkyBlue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(127, 99);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(208, 45);
            txtTenHangSanXuat.Margin = new Padding(4, 3, 4, 3);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(463, 30);
            txtTenHangSanXuat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(24, 48);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên hãng sản xuất (*):";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.DeepSkyBlue;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.White;
            btnNhap.Location = new Point(125, 29);
            btnNhap.Margin = new Padding(4, 3, 4, 3);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(104, 46);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepSkyBlue;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(125, 99);
            btnXuat.Margin = new Padding(4, 3, 4, 3);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(104, 46);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DarkGray;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(8, 99);
            btnHuyBo.Margin = new Padding(4, 3, 4, 3);
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
            groupBox2.Location = new Point(5, 197);
            groupBox2.Margin = new Padding(6, 3, 6, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 3, 6, 3);
            groupBox2.Size = new Size(1088, 452);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Lavender;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(6, 26);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1076, 423);
            dataGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Location = new Point(729, 12);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(237, 169);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(picGuideColored);
            panel1.Location = new Point(980, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 169);
            panel1.TabIndex = 44;
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
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1097, 653);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHangSanXuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hãng sản xuất";
            Load += frmHangSanXuat_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenHangSanXuat;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnNhap;
        private Button btnXuat;
        private GroupBox groupBox3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
    }
}