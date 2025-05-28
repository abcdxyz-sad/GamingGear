using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangGamingGear.Main
{
    public partial class frmLoading : Form
    {
        int stage = 0;
        int delayCounter = 0;
        string[] imageFiles;
        Random rnd = new Random();
        private DateTime startTime;

        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            LoadImageList();      // load danh sách ảnh sẵn
            ShowRandomImage();    // hiển thị ảnh đầu tiên
            timerImage.Start();   // bắt đầu đổi ảnh theo thời gian

            progressBar1.Value = 0;
            timer1.Start();
            timerImage.Interval = 3000;
            startTime = DateTime.Now;

        }

        private void LoadImageList()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images");
            if (Directory.Exists(imagePath))
            {
                imageFiles = Directory.GetFiles(imagePath, "*.*")
                    .Where(f => f.EndsWith("rog.jpg") || f.EndsWith("RazerChroma_3200x1800.png") || f.EndsWith("wp11068690-victus-wallpapers.jpg"))
                    .ToArray();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (stage)
            {
                case 0:
                    if (progressBar1.Value < 25)
                        progressBar1.Value += 1;
                    else
                    {
                        stage = 1;
                        delayCounter = 0;
                    }
                    break;

                case 1:
                    delayCounter++;
                    if (delayCounter >= 20)
                        stage = 2;
                    break;

                case 2:
                    if (progressBar1.Value < 50)
                        progressBar1.Value += 1;
                    else
                    {
                        stage = 3;
                        delayCounter = 0;
                    }
                    break;

                case 3:
                    delayCounter++;
                    if (delayCounter >= 20)
                        stage = 4;
                    break;

                case 4:
                    if (progressBar1.Value < 75)
                        progressBar1.Value += 1;
                    else
                    {
                        stage = 5;
                        delayCounter = 0;
                    }
                    break;

                case 5:
                    delayCounter++;
                    if (delayCounter >= 20)
                        stage = 6;
                    break;

                case 6:
                    if (progressBar1.Value < 100)
                        progressBar1.Value += 1;
                    else
                    {
                        timer1.Stop();
                        timerImage.Stop();
                        this.Hide();
                        frmMain main = new frmMain();
                        main.Show();
                    }
                    break;
            }
        }

        private void ShowRandomImage()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                string randomImage = imageFiles[rnd.Next(imageFiles.Length)];
                pictureBox1.Image = System.Drawing.Image.FromFile(randomImage);
            }
        }

        private void timerImage_Tick(object sender, EventArgs e)
        {
            ShowRandomImage();
        }
    }
}
