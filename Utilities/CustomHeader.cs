using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pormatics.Utility
{
    public static class CustomHeader
    {
        public static void Create(
            Form form,
            string title,
            string subtitle)
        {
            Panel titleBar = new Panel();

            Label titleLabel = new Label();
            Label subtitleLabel = new Label();

            PictureBox miniBtn = new PictureBox();
            PictureBox maxiBtn = new PictureBox();
            PictureBox closeBtn = new PictureBox();

            // =========================
            // TITLE BAR
            // =========================

            titleBar.Dock = DockStyle.Top;
            titleBar.Height = 150;
            titleBar.BackColor = Color.FromArgb(244, 233, 233);
            titleBar.Padding = new Padding(40, 25, 35, 10);

            // =========================
            // TITLE
            // =========================

            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Komikazoom", 32F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Indigo;
            titleLabel.Location = new Point(40, 35);
            titleLabel.Text = title;

            // =========================
            // SUBTITLE
            // =========================

            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 11F);
            subtitleLabel.ForeColor = Color.Indigo;
            subtitleLabel.Location = new Point(40, 110);
            subtitleLabel.Text = subtitle;

            // =========================
            // CLOSE BUTTON
            // =========================

            closeBtn.Dock = DockStyle.Right;
            closeBtn.Width = 60;
            closeBtn.Image = Properties.Resources.close;
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Padding = new Padding(10);

            closeBtn.Click += (s, e) =>
            {
                Application.Exit();
            };

            // =========================
            // MAXIMIZE BUTTON
            // =========================

            maxiBtn.Dock = DockStyle.Right;
            maxiBtn.Width = 60;
            maxiBtn.Image = Properties.Resources.maxi;
            maxiBtn.SizeMode = PictureBoxSizeMode.Zoom;
            maxiBtn.Cursor = Cursors.Hand;
            maxiBtn.Padding = new Padding(10);

            maxiBtn.Click += (s, e) =>
            {
                if (form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                    maxiBtn.Image = Properties.Resources.maxi;
                }
                else
                {
                    form.WindowState = FormWindowState.Maximized;
                    maxiBtn.Image = Properties.Resources.maxi;
                }
            };

            // =========================
            // MINIMIZE BUTTON
            // =========================

            miniBtn.Dock = DockStyle.Right;
            miniBtn.Width = 60;
            miniBtn.Image = Properties.Resources.mini;
            miniBtn.SizeMode = PictureBoxSizeMode.Zoom;
            miniBtn.Cursor = Cursors.Hand;
            miniBtn.Padding = new Padding(10);

            miniBtn.Click += (s, e) =>
            {
                form.WindowState = FormWindowState.Minimized;
            };

            // =========================
            // ADD CONTROLS
            // =========================

            // IMPORTANT ORDER
            titleBar.Controls.Add(miniBtn);
            titleBar.Controls.Add(maxiBtn);
            titleBar.Controls.Add(closeBtn);

            titleBar.Controls.Add(titleLabel);
            titleBar.Controls.Add(subtitleLabel);

            form.Controls.Add(titleBar);

            titleBar.BringToFront();
        }
    }
}