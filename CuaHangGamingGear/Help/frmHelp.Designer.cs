namespace CuaHangGamingGear.Help
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            panel1 = new Panel();
            btnInfo = new Button();
            btnAnswer = new Button();
            btnLogin = new Button();
            btnLoginInfo = new Button();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(276, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 555);
            panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Lavender;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Location = new Point(0, 0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(276, 60);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Thông tin phần mềm";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.BackColor = Color.Lavender;
            btnAnswer.FlatStyle = FlatStyle.Flat;
            btnAnswer.Location = new Point(0, 60);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(276, 60);
            btnAnswer.TabIndex = 2;
            btnAnswer.Text = "Các lưu ý khi sử dụng phần mềm";
            btnAnswer.UseVisualStyleBackColor = false;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lavender;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(0, 120);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(276, 60);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Cách đăng nhập tài khoản";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLoginInfo
            // 
            btnLoginInfo.BackColor = Color.Lavender;
            btnLoginInfo.FlatStyle = FlatStyle.Flat;
            btnLoginInfo.Location = new Point(0, 180);
            btnLoginInfo.Name = "btnLoginInfo";
            btnLoginInfo.Size = new Size(276, 60);
            btnLoginInfo.TabIndex = 4;
            btnLoginInfo.Text = "Về thông tin đăng nhập";
            btnLoginInfo.UseVisualStyleBackColor = false;
            btnLoginInfo.Click += btnLoginInfo_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(282, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 554);
            panel2.TabIndex = 5;
            // 
            // frmHelp
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 553);
            Controls.Add(panel2);
            Controls.Add(btnLoginInfo);
            Controls.Add(btnLogin);
            Controls.Add(btnAnswer);
            Controls.Add(btnInfo);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAQ";
            Load += frmHelp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInfo;
        private Button btnAnswer;
        private Button btnLogin;
        private Button btnLoginInfo;
        private Panel panel2;
    }
}