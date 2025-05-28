namespace CuaHangGamingGear
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            btnXoa = new Button();
            btnInHoaDon = new Button();
            btnLapHoaDon = new Button();
            btnSua = new Button();
            btnXuat = new Button();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            lblTongTienTatCa = new Label();
            groupBox6 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Times New Roman", 12F);
            groupBox2.Location = new Point(8, 112);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(887, 435);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
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
            dataGridView.Size = new Size(879, 406);
            dataGridView.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(24, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(147, 39);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(24, 51);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(147, 43);
            btnInHoaDon.TabIndex = 12;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Location = new Point(24, 200);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(147, 43);
            btnLapHoaDon.TabIndex = 14;
            btnLapHoaDon.Text = "Lập hóa đơn";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepSkyBlue;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(24, 52);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(147, 39);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(24, 126);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(147, 43);
            btnXuat.TabIndex = 19;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(24, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(147, 39);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLapHoaDon);
            groupBox1.Controls.Add(btnInHoaDon);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Location = new Point(902, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 273);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xử lý hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnRefresh);
            groupBox3.Location = new Point(902, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(188, 242);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit hóa đơn";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTongTienTatCa);
            groupBox5.Location = new Point(485, 550);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(406, 90);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giá trị bán ra";
            // 
            // lblTongTienTatCa
            // 
            lblTongTienTatCa.AutoSize = true;
            lblTongTienTatCa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTienTatCa.ForeColor = Color.DeepPink;
            lblTongTienTatCa.Location = new Point(46, 40);
            lblTongTienTatCa.Name = "lblTongTienTatCa";
            lblTongTienTatCa.Size = new Size(56, 26);
            lblTongTienTatCa.TabIndex = 0;
            lblTongTienTatCa.Text = "label";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnSearch);
            groupBox6.Controls.Add(txtSearch);
            groupBox6.Location = new Point(39, 550);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(383, 94);
            groupBox6.TabIndex = 26;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm khách hàng";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(270, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 44);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(18, 12);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(68, 58);
            picGuide.TabIndex = 46;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(18, 12);
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
            pictureBox1.Location = new Point(100, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 12);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(picGuideColored);
            panel1.Location = new Point(21, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 84);
            panel1.TabIndex = 47;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(309, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(582, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 652);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private NumericUpDown numSoLuongBan;
        private DataGridView dataGridView;
        private Label label4;
        private Label label3;
        private NumericUpDown numDonGiaBan;
        private Button btnXoa;
        private ComboBox cboSanPham;
        private Label label6;
        private Button btnInHoaDon;
        private Button btnLapHoaDon;
        private Button btnSua;
        private Button btnXuat;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label lblTongTienTatCa;
        private GroupBox groupBox6;
        private Button btnSearch;
        private TextBox txtSearch;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}