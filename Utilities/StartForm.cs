using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pormatics
{
    public partial class StartForm : Form
    {
        private readonly Image logoImage = Properties.Resources.LogoRIl;

        private bool isOpeningMainMenu;

        public StartForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            logoPic.Paint += logoPic_Paint;
            logoPic.Resize += LogoPic_Resize;
        }

        private void LogoPic_Resize(object? sender, EventArgs e)
        {
            logoPic.Invalidate();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (isOpeningMainMenu)
                return;

            isOpeningMainMenu = true;

            startBtn.Enabled = false;

            MainMenuForm mainMenu = new MainMenuForm();

            mainMenu.LoadDefault();

            mainMenu.FormClosed += MainMenu_FormClosed;

            mainMenu.Show();

            Hide();
        }

        private void MainMenu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void startBtn_MouseEnter(object sender, EventArgs e)
        {
            startBtn.BackColor = Color.FromArgb(170, 150, 190);
        }

        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.BackColor = Color.FromArgb(195, 180, 208);
        }

        private void logoPic_Paint(object? sender, PaintEventArgs e)
        {
            if (logoImage == null)
                return;

            Graphics graphics = e.Graphics;

            graphics.Clear(Color.FromArgb(244, 233, 233));

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            int size = Math.Min(logoPic.Width, logoPic.Height);

            int logoSize = (int)(size * 0.95);

            graphics.TranslateTransform(
                logoPic.Width / 2f,
                logoPic.Height / 2f);

            graphics.RotateTransform(12f);

            graphics.DrawImage(
                logoImage,
                -logoSize / 2,
                -logoSize / 2,
                logoSize,
                logoSize);

            graphics.ResetTransform();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            logoImage?.Dispose();

            base.OnFormClosing(e);
        }
    }
}