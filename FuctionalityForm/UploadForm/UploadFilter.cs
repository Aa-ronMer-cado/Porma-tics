using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.UploadForm
{
    public partial class UploadFilter : Form
    {
        private readonly string _sourceImagePath;
        private readonly UploadClothes _previousForm;

        private string _selectedColor = string.Empty;
        private string _selectedStyle = string.Empty;
        private string _selectedSeason = string.Empty;

        public bool UploadSuccessful { get; private set; } = false;

        public UploadFilter(string sourceImagePath, UploadClothes previousForm)
        {
            _sourceImagePath = sourceImagePath;
            _previousForm = previousForm;

            InitializeComponent();

            SetupComboBoxes();
            LoadImagePreview();
            BuildTagButtons();
        }

        private void SetupComboBoxes()
        {
            cmbTops.Tag = "Tops";
            cmbBottoms.Tag = "Bottoms";
            cmbShoes.Tag = "Shoes";
            cmbAccesories.Tag = "Accessories";

            foreach (ComboBox cb in GetCategoryComboBoxes())
            {
                cb.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            }
        }

        private ComboBox[] GetCategoryComboBoxes()
        {
            return new ComboBox[]
            {
                cmbTops,
                cmbBottoms,
                cmbShoes,
                cmbAccesories
            };
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is not ComboBox selectedComboBox)
                return;

            if (selectedComboBox.SelectedIndex < 0)
                return;

            foreach (ComboBox cb in GetCategoryComboBoxes())
            {
                cb.Enabled = cb == selectedComboBox;
            }
        }

        private string GetSelectedCategory()
        {
            foreach (ComboBox cb in GetCategoryComboBoxes())
            {
                if (cb.SelectedIndex >= 0)
                    return cb.SelectedItem.ToString()!;
            }

            return string.Empty;
        }

        private void LoadImagePreview()
        {
            try
            {
                picturePreview.Image = Image.FromFile(_sourceImagePath);
                picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                // Preview is optional
            }
        }

        private enum TagType
        {
            Color,
            Style,
            Season
        }

        private void BuildTagButtons()
        {
            BuildTagGroup(panelColors, new[]
            {
                "White", "Black", "Blue", "Brown", "Pink",
                "Green", "Red", "Gray", "Yellow", "Multi"
            }, TagType.Color);

            BuildTagGroup(panelStyles, new[]
            {
                "Summer", "Formal", "Streetwear", "Minimalist",
                "Retro", "Smart Casual", "Athletic", "Business"
            }, TagType.Style);

            BuildTagGroup(panelSeasons, new[]
            {
                "Sunny", "Rainy"
            }, TagType.Season);
        }

        private void BuildTagGroup(FlowLayoutPanel panel, string[] labels, TagType tagType)
        {
            panel.Controls.Clear();

            foreach (string lbl in labels)
            {
                Button btn = new Button
                {
                    Text = lbl,
                    Size = new Size(90, 30),
                    Margin = new Padding(4),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(99, 90, 131),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    Font = new Font("Microsoft Sans Serif", 9F),
                    Tag = tagType
                };

                btn.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);
                btn.Click += TagButton_Click;

                panel.Controls.Add(btn);
            }
        }

        private void TagButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clicked)
                return;

            TagType type = (TagType)clicked.Tag;

            FlowLayoutPanel parentPanel = type switch
            {
                TagType.Color => panelColors,
                TagType.Style => panelStyles,
                _ => panelSeasons
            };

            foreach (Control control in parentPanel.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(99, 90, 131);
                }
            }

            clicked.BackColor = Color.FromArgb(99, 90, 131);
            clicked.ForeColor = Color.White;

            switch (type)
            {
                case TagType.Color:
                    _selectedColor = clicked.Text;
                    break;

                case TagType.Style:
                    _selectedStyle = clicked.Text;
                    break;

                case TagType.Season:
                    _selectedSeason = clicked.Text;
                    break;
            }
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            string selectedCategory = GetSelectedCategory();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                ShowError("Please select a clothing type.");
                return;
            }

            if (string.IsNullOrEmpty(_selectedColor))
            {
                ShowError("Please select a color.");
                return;
            }

            if (string.IsNullOrEmpty(_selectedStyle))
            {
                ShowError("Please select a style.");
                return;
            }

            if (string.IsNullOrEmpty(_selectedSeason))
            {
                ShowError("Please select a season.");
                return;
            }

            ClothingItem item = new ClothingItem
            {
                Category = selectedCategory,
                Color = _selectedColor,
                Style = _selectedStyle,
                Season = _selectedSeason
            };

            btnUpload.Enabled = false;
            btnUpload.Text = "Uploading...";

            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            try
            {
                for (int i = 0; i <= 70; i += 10)
                {
                    progressBar.Value = i;
                    await Task.Delay(80);
                }

                await Task.Run(() =>
                {
                    StorageService.AddItem(item, _sourceImagePath);
                });

                for (int i = 80; i <= 100; i += 10)
                {
                    progressBar.Value = i;
                    await Task.Delay(50);
                }

                UploadSuccessful = true;

                MessageBox.Show(
                    "Clothing item saved successfully!",
                    "Upload Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Upload failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
                progressBar.Value = 0;

                btnUpload.Enabled = true;
                btnUpload.Text = "Upload to Closet";
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            foreach (ComboBox cb in GetCategoryComboBoxes())
            {
                cb.SelectedIndex = -1;
                cb.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!UploadSuccessful && _previousForm != null)
            {
                _previousForm.Show();
            }
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Required Field",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}