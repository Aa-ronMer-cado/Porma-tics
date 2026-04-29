using Pormatics.ClosetForm;
using Pormatics.FuctionalityForm;
using Pormatics.FuctionalityForm.OutfitGenerationForm;
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

namespace Pormatics
{
    public partial class MainMenuForm : Form
    {
        // ── Fields 
        private Button currentBottomButton;
        private Button currentTopButton;
        private Form activeForm;

        // ── Constructor 
        public MainMenuForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            closetTitle.MouseDown += closetTitle_MouseDown;
        }

        // ── DLL Imports for Drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // ── Resize & Button Scaling 
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeBottomButtons();
            ResizeTopButtons();
        }

        private void ResizeBottomButtons()
        {
            var buttons = bottomPanel.Controls.OfType<Button>().OrderBy(b => b.Left).ToList();
            if (buttons.Count == 0) return;

            int totalWidth = bottomPanel.Width;
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

        // ── Open Child Form 
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            closetPanel.Controls.Add(childForm);
            closetPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        // Bottom Panel Logic
        private void ActivateBottomButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBottomButton != (Button)btnSender)
                {
                    DisableBottomButton();

                    Color color = ColorTranslator.FromHtml("#635A83");

                    currentBottomButton = (Button)btnSender;
                    currentBottomButton.BackColor = color;
                    currentBottomButton.ForeColor = Color.White;
                    currentBottomButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableBottomButton()
        {
            foreach (Control previousBtn in bottomPanel.Controls)
            {
                if (previousBtn is Button btn)
                {
                    btn.BackColor = Color.FromArgb(195, 180, 208);
                    btn.ForeColor = SystemColors.ActiveCaptionText;
                    btn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // ── Top Panel Logic 
        private void ActivateTopButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentTopButton != (Button)btnSender)
                {
                    DisableTopButton();

                    Color color = ColorTranslator.FromHtml("#C3B4D0");

                    currentTopButton = (Button)btnSender;
                    currentTopButton.BackColor = color;
                    currentTopButton.ForeColor = Color.White;
                    currentTopButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
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
                    btn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        //  Auto-Load from StartForm 
        public void LoadDefault()
        {
            closetBtn.PerformClick();
        }

        // Bottom Panel Buttons 
        private void settingBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            OpenChildForm(new Settings());
            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = true;
        }

        private void closetBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            OpenChildForm(new AllCloset());
            allClothesBtn.PerformClick();
            clothesBtnPanel.Visible = true;
            closetTitle.Visible = true;
            bottomPanel.Enabled = true;
        }

        private void uploadClothesBtn_Click(object sender, EventArgs e)
        {
            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = false;

            UploadClothes uploadForm = new UploadClothes();
            uploadForm.FormClosed += (s, args) =>
            {
                this.WindowState = FormWindowState.Maximized;
                bottomPanel.Enabled = true;
                closetBtn.PerformClick();
            };
            uploadForm.Show();
        }

        private void generateOutfitBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            OpenChildForm(new GenerateFilter());
            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = true;
        }

        private void favoriteBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            OpenChildForm(new FavoriteOutfit());
            clothesBtnPanel.Visible = false;
            closetTitle.Visible = false;
            bottomPanel.Enabled = true;
        }

        private void favBtn_Click(object sender, EventArgs e)
        {
            ActivateBottomButton(sender);
            OpenChildForm(new FavoriteOutfit());
            clothesBtnPanel.Visible = false;
            bottomPanel.Enabled = true;
        }
        // FOR TESTING PICTURE BOX METHOD


        // Top Category Buttons 
        private void allClothesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildForm(new AllCloset());
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildForm(new TopCloset());
        }

        private void bottomBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildForm(new BottomCloset());
        }

        private void shoesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildForm(new ShoesCloset());
        }

        private void accesoriesBtn_Click(object sender, EventArgs e)
        {
            ActivateTopButton(sender);
            OpenChildForm(new AccessoriesCloset());
        }

        // Window Controls
        private void closetTitle_MouseDown(object sender, MouseEventArgs e)
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

        private void closetPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}