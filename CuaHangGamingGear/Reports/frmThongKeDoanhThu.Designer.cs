namespace CuaHangGamingGear.Reports
{
    partial class frmThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDoanhThu));
            btnLocKetQua = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            picGuide = new PictureBox();
            picGuideColored = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(749, 53);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(151, 35);
            btnLocKetQua.TabIndex = 10;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 44);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 7;
            label2.Text = "Đến ngày :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 6;
            label1.Text = "Từ ngày :";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(105, 38);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 30);
            dtpTuNgay.TabIndex = 11;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(484, 38);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 30);
            dtpDenNgay.TabIndex = 12;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(749, 12);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(151, 35);
            btnHienTatCa.TabIndex = 13;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(3, 95);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1077, 555);
            reportViewer.TabIndex = 14;
            // 
            // picGuide
            // 
            picGuide.Image = (Image)resources.GetObject("picGuide.Image");
            picGuide.Location = new Point(14, 8);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(68, 58);
            picGuide.TabIndex = 42;
            picGuide.TabStop = false;
            picGuide.MouseEnter += picGuide_MouseEnter;
            // 
            // picGuideColored
            // 
            picGuideColored.Image = (Image)resources.GetObject("picGuideColored.Image");
            picGuideColored.Location = new Point(14, 8);
            picGuideColored.Name = "picGuideColored";
            picGuideColored.Size = new Size(68, 58);
            picGuideColored.TabIndex = 41;
            picGuideColored.TabStop = false;
            picGuideColored.Click += picGuideColored_Click;
            picGuideColored.MouseLeave += picGuideColored_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(88, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 58);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(picGuide);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picGuideColored);
            panel1.Location = new Point(915, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 77);
            panel1.TabIndex = 43;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1085, 653);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Controls.Add(btnHienTatCa);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnLocKetQua);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuideColored).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLocKetQua;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnHienTatCa;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private PictureBox picGuide;
        private PictureBox picGuideColored;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}