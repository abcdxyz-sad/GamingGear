namespace CuaHangGamingGear
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            btnHide = new Button();
            btnShow = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(349, 19);
            label1.Name = "label1";
            label1.Size = new Size(118, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(264, 77);
            label2.Name = "label2";
            label2.Size = new Size(135, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(264, 160);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu :";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.White;
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(264, 102);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(292, 34);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(264, 185);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '•';
            txtMatKhau.Size = new Size(292, 34);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Black;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(264, 244);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(135, 57);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DarkBlue;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(421, 244);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(135, 57);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.White;
            btnHide.FlatStyle = FlatStyle.Popup;
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.Location = new Point(511, 185);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(45, 34);
            btnHide.TabIndex = 7;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnShow_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.ForeColor = SystemColors.ControlText;
            btnShow.Image = (Image)resources.GetObject("btnShow.Image");
            btnShow.Location = new Point(511, 185);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(45, 34);
            btnShow.TabIndex = 8;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnHide_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(588, 329);
            Controls.Add(pictureBox1);
            Controls.Add(btnShow);
            Controls.Add(btnHide);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private Button btnHide;
        private Button btnShow;
        private PictureBox pictureBox1;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
    }
}