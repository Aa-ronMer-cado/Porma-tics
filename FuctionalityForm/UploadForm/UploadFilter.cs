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
            cmbTops.Tag = "TOPS";
            cmbBottoms.Tag = "BOTTOMS";
            cmbShoes.Tag = "SHOES";
            cmbAccesories.Tag = "ACCESSORIES";

            foreach (ComboBox cb in GetCategoryComboBoxes())
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private string GetSelectedClothingType()
        {
            foreach (ComboBox cb in GetCategoryComboBoxes())
            {
                if (cb.SelectedIndex >= 0 && cb.SelectedItem != null)
                    return cb.SelectedItem.ToString()!.Trim();
            }

            return string.Empty;
        }

        private string GetCategoryFromClothingType(string clothingType)
        {
            clothingType = clothingType.Trim().ToLower();

            switch (clothingType)
            {
                // TOPS
                case "t-shirt":
                case "t - shirt":
                case "polo shirt":
                case "blouse":
                case "tank top":
                case "cardigan":
                case "coat":
                case "hoodie":
                case "crop top":
                    return "TOPS";

                // BOTTOMS
                case "jeans":
                case "shorts":
                case "skirt":
                case "trousers":
                case "leggings":
                case "sweatpants":
                    return "BOTTOMS";

                // SHOES
                case "sneakers":
                case "boots":
                case "sandals":
                case "loafers":
                case "heels":
                case "flats":
                    return "SHOES";

                // ACCESSORIES
                case "hats":
                case "belts":
                case "bags":
                case "jewelry":
                case "sunglass":
                case "sunglasses":
                case "watches":
                    return "ACCESSORIES";

                default:
                    return string.Empty;
            }
        }

        private void LoadImagePreview()
        {
            try
            {
                picturePreview.Image?.Dispose();

                using (Image tempImage = Image.FromFile(_sourceImagePath))
                {
                    picturePreview.Image = new Bitmap(tempImage);
                }

                picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                picturePreview.Image = null;
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

        private void BuildTagGroup(
            FlowLayoutPanel panel,
            string[] labels,
            TagType tagType)
        {
            panel.Controls.Clear();

            foreach (string label in labels)
            {
                Button btn = new Button
                {
                    Text = label,
                    Size = new Size(100, 32),
                    Margin = new Padding(4),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(99, 90, 131),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    Font = new Font("Microsoft Sans Serif", 9F),
                    Tag = tagType
                };

                btn.FlatAppearance.BorderColor =
                    Color.FromArgb(195, 180, 208);

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
            string selectedClothingType = GetSelectedClothingType();
            string mainCategory =
                GetCategoryFromClothingType(selectedClothingType);

            if (string.IsNullOrWhiteSpace(selectedClothingType))
            {
                ShowError("Please select a clothing type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(mainCategory))
            {
                ShowError("Invalid clothing type selected.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_selectedColor))
            {
                ShowError("Please select a color.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_selectedStyle))
            {
                ShowError("Please select a style.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_selectedSeason))
            {
                ShowError("Please select a season.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_sourceImagePath))
            {
                ShowError("Please select an image.");
                return;
            }

            ClothingItem item = new ClothingItem
            {
                Category = mainCategory,
                ClothingType = selectedClothingType,
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

                _previousForm.Close();
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

            if (!UploadSuccessful && _previousForm != null && !_previousForm.IsDisposed)
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