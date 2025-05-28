namespace CuaHangGamingGear.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnQuanLyBanHang = new Button();
            btnQuanLyNhanSu = new Button();
            btnLap = new Button();
            btnKH = new Button();
            groupBoxQuanLy = new GroupBox();
            btnLogin = new Button();
            groupBoxNhanVien = new GroupBox();
            btnLogout = new Button();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            panel1 = new Panel();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelShow = new Panel();
            panel2 = new Panel();
            groupBoxQuanLy.SuspendLayout();
            groupBoxNhanVien.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnQuanLyBanHang
            // 
            btnQuanLyBanHang.BackColor = Color.LightCyan;
            btnQuanLyBanHang.FlatStyle = FlatStyle.Flat;
            btnQuanLyBanHang.ForeColor = Color.DarkSlateGray;
            btnQuanLyBanHang.Location = new Point(36, 38);
            btnQuanLyBanHang.Name = "btnQuanLyBanHang";
            btnQuanLyBanHang.Size = new Size(206, 49);
            btnQuanLyBanHang.TabIndex = 2;
            btnQuanLyBanHang.Text = "Quản lý bán hàng";
            btnQuanLyBanHang.UseVisualStyleBackColor = false;
            btnQuanLyBanHang.Click += btnQuanLyBanHang_Click;
            // 
            // btnQuanLyNhanSu
            // 
            btnQuanLyNhanSu.BackColor = Color.LightCyan;
            btnQuanLyNhanSu.FlatStyle = FlatStyle.Flat;
            btnQuanLyNhanSu.ForeColor = Color.DarkSlateGray;
            btnQuanLyNhanSu.Location = new Point(36, 120);
            btnQuanLyNhanSu.Name = "btnQuanLyNhanSu";
            btnQuanLyNhanSu.Size = new Size(206, 49);
            btnQuanLyNhanSu.TabIndex = 3;
            btnQuanLyNhanSu.Text = "Quản lý nhân sự";
            btnQuanLyNhanSu.UseVisualStyleBackColor = false;
            btnQuanLyNhanSu.Click += btnQuanLyNhanSu_Click;
            // 
            // btnLap
            // 
            btnLap.BackColor = Color.LightCyan;
            btnLap.FlatStyle = FlatStyle.Flat;
            btnLap.ForeColor = Color.DarkSlateGray;
            btnLap.Location = new Point(36, 38);
            btnLap.Name = "btnLap";
            btnLap.Size = new Size(206, 49);
            btnLap.TabIndex = 4;
            btnLap.Text = "Lập hóa đơn";
            btnLap.UseVisualStyleBackColor = false;
            btnLap.Click += btnLap_Click;
            // 
            // btnKH
            // 
            btnKH.BackColor = Color.LightCyan;
            btnKH.FlatStyle = FlatStyle.Flat;
            btnKH.ForeColor = Color.DarkSlateGray;
            btnKH.Location = new Point(36, 126);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(206, 49);
            btnKH.TabIndex = 5;
            btnKH.Text = "Tiếp nhận khách hàng";
            btnKH.UseVisualStyleBackColor = false;
            btnKH.Click += btnKH_Click;
            // 
            // groupBoxQuanLy
            // 
            groupBoxQuanLy.Anchor = AnchorStyles.Left;
            groupBoxQuanLy.Controls.Add(btnQuanLyBanHang);
            groupBoxQuanLy.Controls.Add(btnQuanLyNhanSu);
            groupBoxQuanLy.Location = new Point(12, 121);
            groupBoxQuanLy.Name = "groupBoxQuanLy";
            groupBoxQuanLy.Size = new Size(279, 199);
            groupBoxQuanLy.TabIndex = 6;
            groupBoxQuanLy.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogin.Location = new Point(1055, 23);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 40);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBoxNhanVien
            // 
            groupBoxNhanVien.Anchor = AnchorStyles.Left;
            groupBoxNhanVien.Controls.Add(btnLap);
            groupBoxNhanVien.Controls.Add(btnKH);
            groupBoxNhanVien.Location = new Point(12, 367);
            groupBoxNhanVien.Name = "groupBoxNhanVien";
            groupBoxNhanVien.Size = new Size(279, 199);
            groupBoxNhanVien.TabIndex = 7;
            groupBoxNhanVien.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(1055, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 40);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Black;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip1.Location = new Point(0, 597);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1200, 28);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.BackColor = SystemColors.Control;
            lblTrangThai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = SystemColors.ButtonFace;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(136, 22);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(picGuideColored);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 87);
            panel1.TabIndex = 13;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(130, 3);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(84, 81);
            picGuide.SizeMode = PictureBoxSizeMode.StretchImage;
            picGuide.TabIndex = 38;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(130, 3);
            picGuideColored.Name = "picGuideColored";
            picGuideColored.Size = new Size(84, 81);
            picGuideColored.SizeMode = PictureBoxSizeMode.StretchImage;
            picGuideColored.TabIndex = 37;
            picGuideColored.TabStop = false;
            picGuideColored.Click += picGuideColored_Click;
            picGuideColored.MouseLeave += picGuideColored_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(249, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(249, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 81);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // panelShow
            // 
            panelShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelShow.AutoSize = true;
            panelShow.Location = new Point(423, 168);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(400, 354);
            panelShow.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(409, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 372);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1200, 625);
            Controls.Add(panel2);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(groupBoxNhanVien);
            Controls.Add(groupBoxQuanLy);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            groupBoxQuanLy.ResumeLayout(false);
            groupBoxNhanVien.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnQuanLyBanHang;
        private Button btnQuanLyNhanSu;
        private Button btnLap;
        private Button btnKH;
        private GroupBox groupBoxQuanLy;
        private Button btnLogin;
        private GroupBox groupBoxNhanVien;
        private Button btnLogout;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panelShow;
        private Panel panel2;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}