using Pormatics.ClosetForm;
using Pormatics.FuctionalityForm;
using Pormatics.FuctionalityForm.OutfitGenerationForm;
using Pormatics.FuctionalityForm.UploadForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pormatics
{
    public partial class MainMenuForm : Form
    {
        private PictureBox? currentBottomButton;
        private Button? currentTopButton;

        private Control? activePage;

        private readonly Dictionary<string, UserControl> cachedControls = new();
        private readonly Dictionary<string, Form> cachedForms = new();

        public MainMenuForm()
        {
            InitializeComponent();

            Text = string.Empty;
            ControlBox = false;
            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            DoubleBuffered = true;
            EnableDoubleBuffering(closetPanel);
            EnableDoubleBuffering(bottomPanel);
            EnableDoubleBuffering(clothesBtnPanel);

            foreach (PictureBox pb in bottomPanel.Controls.OfType<PictureBox>())
            {
                pb.MouseEnter += BottomButton_MouseEnter;
                pb.MouseLeave += BottomButton_MouseLeave;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            ResizeBottomButtons();
            ResizeTopButtons();
        }

        private static void EnableDoubleBuffering(Control control)
        {
            typeof(Control)
                .GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance)
                ?.SetValue(control, true);
        }

        private void ResizeBottomButtons()
        {
            var pictureBoxes = bottomPanel.Controls
                .OfType<PictureBox>()
                .OrderBy(b => b.Left)
                .ToList();

            if (pictureBoxes.Count == 0)
                return;

            int btnWidth = bottomPanel.Width / pictureBoxes.Count;
            int remainder = bottomPanel.Width % pictureBoxes.Count;
            int x = 0;

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                int width = i == pictureBoxes.Count - 1
                    ? btnWidth + remainder
                    : btnWidth;

                pictureBoxes[i].Bounds = new Rectangle(x, 0, width, bottomPanel.Height);
                x += width;
            }
        }

        private void ResizeTopButtons()
        {
            var buttons = clothesBtnPanel.Controls
                .OfType<Button>()
                .OrderBy(b => b.Left)
                .ToList();

            if (buttons.Count == 0)
                return;

            int btnWidth = clothesBtnPanel.Width / buttons.Count;
            int remainder = clothesBtnPanel.Width % buttons.Count;
            int x = 0;

            for (int i = 0; i < buttons.Count; i++)
            {
                int width = i == buttons.Count - 1
                    ? btnWidth + remainder
                    : btnWidth;

                buttons[i].Bounds = new Rectangle(x, 0, width, clothesBtnPanel.Height);
                x += width;
            }
        }

        private void BottomButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is PictureBox hovered && hovered != currentBottomButton)
                hovered.BackColor = ColorTranslator.FromHtml("#A89ABF");
        }

        private void BottomButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is PictureBox hovered && hovered != currentBottomButton)
                hovered.BackColor = Color.FromArgb(195, 180, 208);
        }

        private void ShowCachedControl(string key, Func<UserControl> createControl)
        {
            closetPanel.SuspendLayout();

            if (!cachedControls.ContainsKey(key))
            {
                UserControl control = createControl();
                control.Dock = DockStyle.Fill;
                cachedControls[key] = control;
            }

            ShowPage(cachedControls[key]);

            closetPanel.ResumeLayout();
        }

        private void ShowCachedForm(string key, Func<Form> createForm)
        {
            closetPanel.SuspendLayout();

            if (!cachedForms.ContainsKey(key) || cachedForms[key].IsDisposed)
            {
                Form form = createForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                cachedForms[key] = form;
            }

            Form page = cachedForms[key];

            if (!closetPanel.Controls.Contains(page))
                closetPanel.Controls.Add(page);

            ShowPage(page);

            if (!page.Visible)
                page.Show();

            closetPanel.ResumeLayout();
        }

        private void ShowTemporaryForm(Form form)
        {
            closetPanel.SuspendLayout();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            ShowPage(form);

            form.Show();

            closetPanel.ResumeLayout();
        }

        private void ShowPage(Control page)
        {
            if (activePage == page)
                return;

            foreach (Control control in closetPanel.Controls)
                control.Visible = false;

            if (!closetPanel.Controls.Contains(page))
                closetPanel.Controls.Add(page);

            page.Dock = DockStyle.Fill;
            page.Visible = true;
            page.BringToFront();

            activePage = page;
        }

        private void ActivateBottomButton(object sender)
        {
            if (sender is not PictureBox selected)
                return;

            DisableBottomButton();

            currentBottomButton = selected;
            currentBottomButton.BackColor = ColorTranslator.FromHtml("#635A83");
        }

        private void DisableBottomButton()
        {
            foreach (PictureBox pb in bottomPanel.Controls.OfType<PictureBox>())
                pb.BackColor = Color.FromArgb(195, 180, 208);
        }

        private void ActivateTopButton(object sender)
        {
            if (sender is not Button selected)
                return;

            DisableTopButton();

            currentTopButton = selected;
            currentTopButton.BackColor = ColorTranslator.FromHtml("#C3B4D0");
            currentTopButton.ForeColor = Color.White;
            currentTopButton.Font = new Font("Microsoft Sans Serif", 12.5F);
        }

        private void DisableTopButton()
        {
            foreach (Button btn in clothesBtnPanel.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.ButtonHighlight;
                btn.ForeColor = SystemColors.Desktop;
                btn.Font = new Font("Microsoft Sans Serif", 10.2F);
            }
        }

        private void SetClosetHeader(bool show)
        {
            clothesBtnPanel.Visible = show;
            closetBtnCtrl.Visible = true;
            bottomPanel.Enabled = true;
            title.Visible = show;
        }

        public void LoadDefault()
        {
            ActivateBottomButton(mainCloset);

            SetClosetHeader(true);

            ActivateTopButton(allClothesBtn);

            ShowCachedControl(
                "AllCloset",
                () => new AllCloset());
        }

        private void settings_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            SetClosetHeader(false);

            ShowCachedForm("Settings", () => new Settings());
        }

        private void mainCloset_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            SetClosetHeader(true);

            allClothesBtn.PerformClick();
        }

        private void uploadClothes_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            SetClosetHeader(false);

            UploadClothes uploadForm = new UploadClothes();

            uploadForm.FormClosed += (s, args) =>
            {
                cachedControls.Remove("AllCloset");
                mainCloset_Click(mainCloset, EventArgs.Empty);
            };

            ShowTemporaryForm(uploadForm);
        }

        private void generateOutfit_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);

            clothesBtnPanel.Visible = false;
            closetBtnCtrl.Visible = false;
            bottomPanel.Enabled = true;
            title.Visible = false;

            OpenGenerateFilter();
        }

        private void OpenGenerateFilter()
        {
            GenerateFilter generateForm = new GenerateFilter();

            generateForm.OutfitGenerated += (filter, outfit) =>
            {
                ConfirmGenerated confirmForm = new ConfirmGenerated(filter, outfit);

                confirmForm.BackRequested += OpenGenerateFilter;

                ShowTemporaryForm(confirmForm);
            };

            ShowTemporaryForm(generateForm);
        }

        private void favBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            SetClosetHeader(false);

            ShowCachedForm("FavoriteOutfit", () => new FavoriteOutfit());
        }

        private void allClothesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            ShowCachedControl("AllCloset", () => new AllCloset());
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            ShowCachedControl("TopCloset", () => new TopCloset());
        }

        private void bottomBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            ShowCachedControl("BottomCloset", () => new BottomCloset());
        }

        private void shoesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            ShowCachedControl("ShoesCloset", () => new ShoesCloset());
        }

        private void accesoriesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            ShowCachedControl("AccessoriesCloset", () => new AccessoriesCloset());
        }

        private void EkisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxiBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}