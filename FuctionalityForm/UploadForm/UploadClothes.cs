using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Pormatics.Models;

namespace Pormatics.FuctionalityForm.UploadForm
{
    /// <summary>
    /// Step 1 of upload: user picks an image (file-browser or drag-drop).
    /// On "Next" opens UploadFilter, passing the selected image path.
    /// </summary>
    public partial class UploadClothes : Form
    {
        // ── Fields ───────────────────────────────────────────────────
        private string _selectedImagePath = string.Empty;

        // ── Constructor ──────────────────────────────────────────────
        public UploadClothes()
        {
            InitializeComponent();
            ConfigureForm();
            WireEvents();
        }

        // ── Setup ────────────────────────────────────────────────────
        private void ConfigureForm()
        {
            this.Text = "Upload Clothes — Step 1";
            this.BackColor = Color.FromArgb(242, 235, 240);   // blush
            this.AllowDrop = true;
        }

        private void WireEvents()
        {
            // Drag-drop on the picture box
            pictureBoxPreview.AllowDrop = true;
            pictureBoxPreview.DragEnter += PictureBox_DragEnter;
            pictureBoxPreview.DragDrop += PictureBox_DragDrop;

            // Drag-drop on the form itself as a fallback
            this.DragEnter += PictureBox_DragEnter;
            this.DragDrop += PictureBox_DragDrop;
        }

        // ── Browse button ────────────────────────────────────────────
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Select clothing image",
                Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp|All files|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                LoadPreview(ofd.FileName);
        }

        // ── Drag-drop ────────────────────────────────────────────────
        private void PictureBox_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PictureBox_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null) return;
            string[]? files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
                LoadPreview(files[0]);
        }

        // ── Load preview ─────────────────────────────────────────────
        private void LoadPreview(string path)
        {
            string ext = Path.GetExtension(path).ToLowerInvariant();
            string[] allowed = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp" };
            if (Array.IndexOf(allowed, ext) < 0)
            {
                MessageBox.Show("Please select a valid image file.", "Invalid file",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Dispose previous image to free file lock
                pictureBoxPreview.Image?.Dispose();
                pictureBoxPreview.Image = Image.FromFile(path);
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                _selectedImagePath = path;
                btnNext.Enabled = true;
                lblDrop.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load image:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Next button ──────────────────────────────────────────────
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedImagePath)) return;

            var filterForm = new UploadFilter(_selectedImagePath);
            filterForm.FormClosed += (s, args) =>
            {
                // Re-raise closure so MainMenuForm can react
                if (filterForm.UploadSuccessful)
                    this.Close();
            };
            filterForm.Show();
            this.Hide();
        }

        // ── Reset button ─────────────────────────────────────────────
        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.Image?.Dispose();
            pictureBoxPreview.Image = null;
            _selectedImagePath = string.Empty;
            btnNext.Enabled = false;
            lblDrop.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            pictureBoxPreview.Image?.Dispose();
            base.OnFormClosing(e);
        }

        private void lblDrop_Click(object sender, EventArgs e)
        {

        }
    }
}