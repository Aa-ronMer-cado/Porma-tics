using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pormatics
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            logoPic.Paint += logoPic_Paint;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            mainMenu.LoadDefault();
            Hide();
        }

        private void startBtn_MouseEnter(object sender, EventArgs e)
        {
            startBtn.BackColor = Color.FromArgb(170, 150, 190);
        }

        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.BackColor = Color.FromArgb(195, 180, 208);
        }

        private void logoPic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(244, 233, 233));

            e.Graphics.SmoothingMode = SmoothingMode.None;
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            Image logo = Properties.Resources.LogoRIl;

            e.Graphics.TranslateTransform(
                logoPic.Width / 2f,
                logoPic.Height / 2f);

            e.Graphics.RotateTransform(12f);

            int size = Math.Min(logoPic.Width, logoPic.Height);

            int logoWidth = (int)(size * 0.95);
            int logoHeight = (int)(size * 0.95);

            e.Graphics.DrawImage(
                logo,
                -logoWidth / 2,
                -logoHeight / 2,
                logoWidth,
                logoHeight);

            e.Graphics.ResetTransform();
        }
    }
}