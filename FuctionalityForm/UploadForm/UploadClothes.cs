using Pormatics.FuctionalityForm.UploadForm;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm
{
    public partial class UploadClothes : Form
    {
        private string _selectedImagePath = string.Empty;

        public UploadClothes()
        {
            InitializeComponent();
            WireEvents();
            SetUploadState(false);
        }

        private void WireEvents()
        {
            pictureBoxPreview.AllowDrop = true;
            pictureBoxPreview.DragEnter += PictureBox_DragEnter;
            pictureBoxPreview.DragDrop += PictureBox_DragDrop;

            this.AllowDrop = true;
            this.DragEnter += PictureBox_DragEnter;
            this.DragDrop += PictureBox_DragDrop;

            picBrowse.MouseEnter += (s, e) =>
                picBrowse.BackColor = Color.FromArgb(220, 210, 235);

            picBrowse.MouseLeave += (s, e) =>
                picBrowse.BackColor = Color.Transparent;

            picReset.MouseEnter += (s, e) =>
                picReset.BackColor = Color.FromArgb(220, 210, 235);

            picReset.MouseLeave += (s, e) =>
                picReset.BackColor = Color.Transparent;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int previewW = Math.Max(260, ClientSize.Width / 3);
            int previewH = Math.Max(220, ClientSize.Height / 2);

            pictureBoxPreview.Size = new Size(previewW, previewH);

            int iconSize = Math.Max(60, Math.Min(ClientSize.Width / 10, 120));

            picReset.Size = new Size(iconSize, iconSize);
            picBrowse.Size = new Size(iconSize, iconSize);

            progressBar.Width = Math.Max(300, ClientSize.Width / 3);
        }

        private void SetUploadState(bool hasImage)
        {
            btnNext.Enabled = hasImage;

            picBrowse.Enabled = !hasImage;
            picBrowse.Visible = !hasImage;

            pictureBoxPreview.AllowDrop = !hasImage;
            AllowDrop = !hasImage;

            
        }

        private void btnBrowse_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select clothing image",
                Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp|All files|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadPreview(ofd.FileName);
            }
        }

        private void PictureBox_DragEnter(object? sender, DragEventArgs e)
        {
            e.Effect = e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        private void PictureBox_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                LoadPreview(files[0]);
            }
        }

        private async void LoadPreview(string path)
        {
            string[] validExtensions =
            {
            ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp"
            };

            string extension = Path.GetExtension(path).ToLowerInvariant();

            if (Array.IndexOf(validExtensions, extension) < 0)
            {
                MessageBox.Show(
                    "Please select a valid image file.",
                    "Invalid File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                btnNext.Enabled = false;

                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 0;

                progressBar.Value = 20;
                await Task.Delay(150);

                pictureBoxPreview.Image?.Dispose();

                progressBar.Value = 50;
                await Task.Delay(150);

                pictureBoxPreview.Image = Image.FromFile(path);
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;

                progressBar.Value = 80;
                await Task.Delay(150);

                _selectedImagePath = path;

                progressBar.Value = 100;
                await Task.Delay(300);

                SetUploadState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load image:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
                progressBar.Value = 0;
            }
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedImagePath))
                return;


            UploadFilter filterForm = new UploadFilter(_selectedImagePath, this);
            filterForm.ShowDialog();
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            pictureBoxPreview.Image?.Dispose();
            pictureBoxPreview.Image = null;

            _selectedImagePath = string.Empty;

            SetUploadState(false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            pictureBoxPreview.Image?.Dispose();
            base.OnFormClosing(e);
        }
    }
}