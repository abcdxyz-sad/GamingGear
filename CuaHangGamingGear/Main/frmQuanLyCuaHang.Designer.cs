namespace CuaHangGamingGear.Main
{
    partial class frmQuanLyBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBanHang));
            tabControl = new TabControl();
            tabPageLSP = new TabPage();
            tabPageHSX = new TabPage();
            tabPageSP = new TabPage();
            tabPageTK = new TabPage();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageLSP);
            tabControl.Controls.Add(tabPageHSX);
            tabControl.Controls.Add(tabPageSP);
            tabControl.Controls.Add(tabPageTK);
            tabControl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1100, 700);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPageLSP
            // 
            tabPageLSP.Location = new Point(4, 33);
            tabPageLSP.Name = "tabPageLSP";
            tabPageLSP.Padding = new Padding(3);
            tabPageLSP.Size = new Size(1092, 663);
            tabPageLSP.TabIndex = 0;
            tabPageLSP.Text = "Loại sản phẩm";
            tabPageLSP.UseVisualStyleBackColor = true;
            // 
            // tabPageHSX
            // 
            tabPageHSX.Location = new Point(4, 33);
            tabPageHSX.Name = "tabPageHSX";
            tabPageHSX.Padding = new Padding(3);
            tabPageHSX.Size = new Size(1092, 663);
            tabPageHSX.TabIndex = 1;
            tabPageHSX.Text = "Hãng sản xuất";
            tabPageHSX.UseVisualStyleBackColor = true;
            // 
            // tabPageSP
            // 
            tabPageSP.Location = new Point(4, 33);
            tabPageSP.Name = "tabPageSP";
            tabPageSP.Padding = new Padding(3);
            tabPageSP.Size = new Size(1092, 663);
            tabPageSP.TabIndex = 2;
            tabPageSP.Text = "Sản phẩm";
            tabPageSP.UseVisualStyleBackColor = true;
            // 
            // tabPageTK
            // 
            tabPageTK.Location = new Point(4, 33);
            tabPageTK.Name = "tabPageTK";
            tabPageTK.Padding = new Padding(3);
            tabPageTK.Size = new Size(1092, 663);
            tabPageTK.TabIndex = 3;
            tabPageTK.Text = "Thống kê doanh thu";
            tabPageTK.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyBanHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1102, 705);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmQuanLyBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán hàng";
            Load += frmQuanLyBanHang_Load;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageLSP;
        private TabPage tabPageHSX;
        private TabPage tabPageSP;
        private TabPage tabPageTK;
    }
}