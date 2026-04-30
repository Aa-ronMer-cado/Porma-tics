using Pormatics.ClosetForm;
using Pormatics.FuctionalityForm;
using Pormatics.FuctionalityForm.OutfitGenerationForm;
using Pormatics.FuctionalityForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pormatics.FuctionalityForm.UploadForm;

namespace Pormatics
{
    public partial class MainMenuForm : Form
    {
        // ── Fields ───────────────────────────────────────────────────
        private PictureBox? currentBottomButton;
        private Button? currentTopButton;

        // ── CHANGED: activeForm → activeControl ─────────────────────
        // ClosetBase is now a UserControl, not a Form.
        // We track it as a UserControl so we can remove it from
        // closetPanel before loading the next view.
        private UserControl? activeControl;

        // ── Constructor ──────────────────────────────────────────────
        public MainMenuForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            closetTitle.MouseDown += closetTitle_MouseDown;
        }

        // ── DLL Imports for Drag ─────────────────────────────────────
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // ── Resize & Scaling ─────────────────────────────────────────
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeBottomButtons();
            ResizeTopButtons();
        }

        private void ResizeBottomButtons()
        {
            var pictureBoxes = bottomPanel.Controls.OfType<PictureBox>().OrderBy(b => b.Left).ToList();
            if (pictureBoxes.Count == 0) return;

            int totalWidth = bottomPanel.Width;
            int btnWidth = totalWidth / pictureBoxes.Count;
            int remainder = totalWidth % pictureBoxes.Count;

            int xPos = 0;
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                int width = (i == pictureBoxes.Count - 1) ? btnWidth + remainder : btnWidth;
                pictureBoxes[i].Width = width;
                pictureBoxes[i].Location = new Point(xPos, 0);
                xPos += width;
            }
        }

        private void ResizeTopButtons()
        {
            var buttons = clothesBtnPanel.Controls.OfType<Button>().OrderBy(b => b.Left).ToList();
            if (buttons.Count == 0) return;

            int totalWidth = clothesBtnPanel.Width;
            int btnWidth = totalWidth / buttons.Count;
            int remainder = totalWidth % buttons.Count;

            int xPos = 0;
            for (int i = 0; i < buttons.Count; i++)
            {
                int width = (i == buttons.Count - 1) ? btnWidth + remainder : btnWidth;
                buttons[i].Width = width;
                buttons[i].Location = new Point(xPos, 0);
                xPos += width;
            }
        }

        // ── CHANGED: OpenChildControl ────────────────────────────────
        // Replaces the old OpenChildForm(Form).
        // Accepts a UserControl (ClosetBase subclass), removes the
        // previous control, docks the new one, and shows it.
        private void OpenChildControl(UserControl childControl)
        {
            // Remove & dispose the previous control
            if (activeControl != null)
            {
                closetPanel.Controls.Remove(activeControl);
                activeControl.Dispose();
                activeControl = null;
            }

            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;

            closetPanel.Controls.Add(childControl);
            childControl.BringToFront();
        }

        // ── Bottom Panel Logic ───────────────────────────────────────
        private void ActivateBottomButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBottomButton != (PictureBox)btnSender)
                {
                    DisableBottomButton();
                    currentBottomButton = (PictureBox)btnSender;
                    currentBottomButton.BackColor = ColorTranslator.FromHtml("#635A83");
                }
            }
        }

        private void DisableBottomButton()
        {
            foreach (Control previousBtn in bottomPanel.Controls)
            {
                if (previousBtn is PictureBox pb)
                    pb.BackColor = Color.FromArgb(195, 180, 208);
            }
        }

        // ── Top Panel Logic ──────────────────────────────────────────
        private void ActivateTopButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentTopButton != (Button)btnSender)
                {
                    DisableTopButton();
                    currentTopButton = (Button)btnSender;
                    currentTopButton.BackColor = ColorTranslator.FromHtml("#C3B4D0");
                    currentTopButton.ForeColor = Color.White;
                    currentTopButton.Font = new Font("Microsoft Sans Serif", 12.5F,
                        FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableTopButton()
        {
            foreach (Control previousBtn in clothesBtnPanel.Controls)
            {
                if (previousBtn is Button btn)
                {
                    btn.BackColor = SystemColors.ButtonHighlight;
                    btn.ForeColor = SystemColors.Desktop;
                    btn.Font = new Font("Microsoft Sans Serif", 10.2F,
                        FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // ── Auto-Load from StartForm ─────────────────────────────────
        public void LoadDefault()
        {
            mainCloset_Click(mainCloset, EventArgs.Empty);
        }

        // ── Bottom Panel PictureBox Clicks ───────────────────────────
        private void settings_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);

            // Settings is still a Form — keep the old behaviour for it
            if (activeControl != null)
            {
                closetPanel.Controls.Remove(activeControl);
                activeControl.Dispose();
                activeControl = null;
            }

            var settingsCtrl = new Settings();
            settingsCtrl.TopLevel = false;
            settingsCtrl.FormBorderStyle = FormBorderStyle.None;
            settingsCtrl.Dock = DockStyle.Fill;
            closetPanel.Controls.Add(settingsCtrl);
            settingsCtrl.BringToFront();
            settingsCtrl.Show();

            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = true;
        }

        private void mainCloset_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);

            // CHANGED: OpenChildControl instead of OpenChildForm
            OpenChildControl(new AllCloset());

            allClothesBtn.PerformClick();
            clothesBtnPanel.Visible = true;
            closetTitle.Visible = true;
            bottomPanel.Enabled = true;
        }

        private void uploadClothes_Click(object sender, EventArgs e)
        {
            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = false;

            UploadClothes uploadForm = new UploadClothes();
            uploadForm.FormClosed += (s, args) =>
            {
                this.WindowState = FormWindowState.Maximized;
                bottomPanel.Enabled = true;
                // CHANGED: this now calls mainCloset_Click which uses
                // OpenChildControl — the closet auto-refreshes with
                // the newly uploaded item already in clothes.json
                mainCloset_Click(mainCloset, EventArgs.Empty);
            };
            uploadForm.Show();
        }

        private void generateOutfit_Click(object sender, EventArgs e)
        {
            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = false;

            GenerateOutfit generateForm = new GenerateOutfit();
            generateForm.FormClosed += (s, args) =>
            {
                this.WindowState = FormWindowState.Maximized;
                bottomPanel.Enabled = true;
                mainCloset_Click(mainCloset, EventArgs.Empty);
            };
            generateForm.Show();
        }

        private void favBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);

            // FavoriteOutfit is still a Form — embed it the same way as Settings
            if (activeControl != null)
            {
                closetPanel.Controls.Remove(activeControl);
                activeControl.Dispose();
                activeControl = null;
            }

            var favForm = new FavoriteOutfit();
            favForm.TopLevel = false;
            favForm.FormBorderStyle = FormBorderStyle.None;
            favForm.Dock = DockStyle.Fill;
            closetPanel.Controls.Add(favForm);
            favForm.BringToFront();
            favForm.Show();

            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = true;
        }

        // ── Top Category Buttons ─────────────────────────────────────
        // CHANGED: all five now call OpenChildControl instead of OpenChildForm

        private void allClothesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildControl(new AllCloset());
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildControl(new TopCloset());
        }

        private void bottomBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildControl(new BottomCloset());
        }

        private void shoesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildControl(new ShoesCloset());
        }

        private void accesoriesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildControl(new AccessoriesCloset());
        }

        // ── Window Controls ──────────────────────────────────────────
        private void closetTitle_MouseDown(object? sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}