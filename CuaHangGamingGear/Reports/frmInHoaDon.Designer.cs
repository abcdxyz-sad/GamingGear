namespace CuaHangGamingGear.Reports
{
    partial class frmInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHoaDon));
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1132, 553);
            reportViewer1.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 553);
            Controls.Add(reportViewer1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInHoaDon";
            Text = "In hóa đơn";
            Load += frmInHoaDon_Load;
            ResumeLayout(false);
        }

        #endregion
        //private QLBHDataSet qlbhDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}