using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pormatics.FuctionalityForm.UploadForm
{
    /// <summary>
    /// Step 2 of upload: user fills in Name, Category, Color, Style, Season
    /// then clicks Upload.  Calls StorageService.AddItem() which copies the
    /// image and writes clothes.json.
    /// </summary>
    public partial class UploadFilter : Form
    {
        // ── Fields ───────────────────────────────────────────────────
        private readonly string _sourceImagePath;
        public bool UploadSuccessful { get; private set; } = false;

        // Tag selections
        private string _selectedColor = string.Empty;
        private string _selectedStyle = string.Empty;
        private string _selectedSeason = string.Empty;

        // ── Constructor ──────────────────────────────────────────────
        public UploadFilter(string sourceImagePath)
        {
            _sourceImagePath = sourceImagePath;
            InitializeComponent();
            LoadImagePreview();
            BuildTagButtons();
        }

        // ── Image preview ────────────────────────────────────────────
        private void LoadImagePreview()
        {
            try
            {
                picturePreview.Image = Image.FromFile(_sourceImagePath);
                picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { /* preview is cosmetic — continue silently */ }
        }

        // ── Tag button factories ─────────────────────────────────────
        private void BuildTagButtons()
        {
            BuildTagGroup(panelColors, new[]
            {
                "White", "Black", "Blue", "Brown", "Pink",
                "Green", "Red", "Gray", "Yellow", "Multi"
            }, TagType.Color);

            BuildTagGroup(panelStyles, new[]
            {
                "Casual", "Formal", "Streetwear", "Preppy",
                "Boho", "Vintage", "Athletic", "Business"
            }, TagType.Style);

            BuildTagGroup(panelSeasons, new[]
            {
                "Spring", "Summer", "Fall", "Winter", "All-season"
            }, TagType.Season);
        }

        private enum TagType { Color, Style, Season }

        private void BuildTagGroup(FlowLayoutPanel panel, string[] labels, TagType tagType)
        {
            panel.Controls.Clear();
            foreach (string lbl in labels)
            {
                var btn = new System.Windows.Forms.Button
                {
                    Text = lbl,
                    AutoSize = false,
                    Size = new Size(90, 30),
                    Margin = new Padding(4),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(99, 90, 131),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 9F),
                    Cursor = Cursors.Hand,
                    Tag = tagType
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);
                btn.Click += TagButton_Click;
                panel.Controls.Add(btn);
            }
        }

        private void TagButton_Click(object? sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button clicked) return;
            TagType type = (TagType)clicked.Tag!;

            // Reset siblings in the same panel
            FlowLayoutPanel parent = type switch
            {
                TagType.Color => panelColors,
                TagType.Style => panelStyles,
                _ => panelSeasons
            };

            foreach (Control c in parent.Controls)
            {
                if (c is System.Windows.Forms.Button b)
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.FromArgb(99, 90, 131);
                }
            }

            // Activate clicked
            clicked.BackColor = Color.FromArgb(99, 90, 131);
            clicked.ForeColor = Color.White;

            // Record selection
            switch (type)
            {
                case TagType.Color: _selectedColor = clicked.Text; break;
                case TagType.Style: _selectedStyle = clicked.Text; break;
                case TagType.Season: _selectedSeason = clicked.Text; break;
            }
        }

        // ── Upload button ────────────────────────────────────────────
        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { ShowError("Please enter a clothing name."); txtName.Focus(); return; }

            if (cmbCategory.SelectedIndex < 0)
            { ShowError("Please select a category."); cmbCategory.Focus(); return; }

            if (string.IsNullOrEmpty(_selectedColor))
            { ShowError("Please select a color tag."); return; }

            if (string.IsNullOrEmpty(_selectedStyle))
            { ShowError("Please select a style tag."); return; }

            if (string.IsNullOrEmpty(_selectedSeason))
            { ShowError("Please select a season tag."); return; }

            // Build item
            var item = new ClothingItem
            {
                Name = txtName.Text.Trim(),
                Category = cmbCategory.SelectedItem!.ToString()!,
                Color = _selectedColor,
                Style = _selectedStyle,
                Season = _selectedSeason
            };

            // Show progress
            btnUpload.Enabled = false;
            btnUpload.Text = "Saving…";
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            // Run on background thread so UI stays responsive
            System.Threading.Tasks.Task.Run(() =>
            {
                StorageService.AddItem(item, _sourceImagePath);
            }).ContinueWith(_ =>
            {
                this.Invoke(() =>
                {
                    progressBar.Visible = false;
                    UploadSuccessful = true;
                    MessageBox.Show(
                        $"\"{item.Name}\" has been saved to your closet!",
                        "Upload successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                });
            });
        }

        // ── Back button ──────────────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Re-open step 1 with the same image pre-loaded
            var step1 = new UploadClothes();
            step1.Show();
            this.Close();
        }

        // ── Helpers ──────────────────────────────────────────────────
        private static void ShowError(string msg) =>
            MessageBox.Show(msg, "Required field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}