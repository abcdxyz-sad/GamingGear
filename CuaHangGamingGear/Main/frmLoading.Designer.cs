namespace CuaHangGamingGear.Main
{
    partial class frmLoading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            timerImage = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 515);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(785, 29);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(785, 515);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timerImage
            // 
            timerImage.Tick += timerImage_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 481);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 2;
            label1.Text = "Now Loading...";
            // 
            // frmLoading
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 544);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += frmLoading_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerImage;
        private Label label1;
    }
}