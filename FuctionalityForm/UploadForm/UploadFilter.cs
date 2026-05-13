using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.UploadForm
{
    public partial class UploadFilter : Form
    {
        private readonly string _sourceImagePath;
        private readonly UploadClothes _previousForm;

        private readonly List<string> _selectedColors = new();
        private readonly List<string> _selectedStyles = new();
        private readonly List<string> _selectedSeasons = new();

        private Panel colorDropdownPanel = null!;
        private Button btnColorDropdown = null!;
        private CheckedListBox clbColors = null!;

        public bool UploadSuccessful { get; private set; } = false;

        public UploadFilter(string sourceImagePath, UploadClothes previousForm)
        {
            _sourceImagePath = sourceImagePath;
            _previousForm = previousForm;

            InitializeComponent();

            SetupComboBoxes();
            LoadImagePreview();
            BuildTagButtons();
            BuildColorDropdown();
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

                case "jeans":
                case "shorts":
                case "skirt":
                case "trousers":
                case "leggings":
                case "sweatpants":
                    return "BOTTOMS";

                case "sneakers":
                case "boots":
                case "sandals":
                case "loafers":
                case "heels":
                case "flats":
                    return "SHOES";

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

                using Image tempImage = Image.FromFile(_sourceImagePath);
                picturePreview.Image = new Bitmap(tempImage);
                picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                picturePreview.Image = null;
            }
        }

        private enum TagType
        {
            Style,
            Season
        }

        private void BuildTagButtons()
        {
            panelColors.Controls.Clear();

            BuildTagGroup(panelStyles, new[]
            {
                "Casual", "Formal", "Streetwear", "Minimalist", "Romantic",
                "Retro", "Smart Casual", "Athletic", "Business", "Vacation"
            }, TagType.Style);

            BuildTagGroup(panelSeasons, new[]
            {
                "Summer", "Rainy"
            }, TagType.Season);
        }

        private void BuildColorDropdown()
        {
            panelColors.Controls.Clear();

            colorDropdownPanel = new Panel
            {
                Size = new Size(260, 45),
                BackColor = Color.Transparent,
                Margin = new Padding(4)
            };

            btnColorDropdown = new Button
            {
                Text = "Select Colors ▼",
                Size = new Size(260, 38),
                Location = new Point(0, 0),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(99, 90, 131),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 9F),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };

            btnColorDropdown.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);

            clbColors = new CheckedListBox
            {
                Size = new Size(260, 130),
                Location = new Point(0, 40),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(99, 90, 131),
                BorderStyle = BorderStyle.FixedSingle,
                CheckOnClick = true,
                Font = new Font("Microsoft Sans Serif", 9F),
                Visible = false
            };

            clbColors.Items.AddRange(new object[]
            {
                "White",
                "Black",
                "Blue",
                "Brown",
                "Pink",
                "Green",
                "Red",
                "Gray",
                "Yellow",
                "Multi"
            });

            btnColorDropdown.Click += btnColorDropdown_Click;
            clbColors.ItemCheck += clbColors_ItemCheck;

            colorDropdownPanel.Controls.Add(btnColorDropdown);
            colorDropdownPanel.Controls.Add(clbColors);

            panelColors.Controls.Add(colorDropdownPanel);
        }

        private void btnColorDropdown_Click(object? sender, EventArgs e)
        {
            clbColors.Visible = !clbColors.Visible;
            colorDropdownPanel.Height = clbColors.Visible ? 175 : 45;
        }

        private void clbColors_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                RefreshSelectedColors();
                UpdateColorDropdownText();
            });
        }

        private void RefreshSelectedColors()
        {
            _selectedColors.Clear();

            foreach (object item in clbColors.CheckedItems)
            {
                if (item != null)
                    _selectedColors.Add(item.ToString()!);
            }
        }

        private void UpdateColorDropdownText()
        {
            btnColorDropdown.Text =
                _selectedColors.Count == 0
                    ? "Select Colors ▼"
                    : string.Join(", ", _selectedColors) + " ▼";
        }

        private void BuildTagGroup(FlowLayoutPanel panel, string[] labels, TagType tagType)
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

                btn.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);
                btn.Click += TagButton_Click;

                panel.Controls.Add(btn);
            }
        }

        private void TagButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button clicked)
                return;

            TagType type = (TagType)clicked.Tag;
            string value = clicked.Text.Trim();

            if (type == TagType.Style)
            {
                ToggleMultiSelect(clicked, value, _selectedStyles);
            }
            else if (type == TagType.Season)
            {
                ToggleMultiSelect(clicked, value, _selectedSeasons);
            }
        }

        private void ToggleMultiSelect(Button clicked, string value, List<string> selectedList)
        {
            if (selectedList.Contains(value))
            {
                selectedList.Remove(value);
                SetButtonUnselected(clicked);
            }
            else
            {
                selectedList.Add(value);
                SetButtonSelected(clicked);
            }
        }

        private void SetButtonSelected(Button btn)
        {
            btn.BackColor = Color.FromArgb(99, 90, 131);
            btn.ForeColor = Color.White;
        }

        private void SetButtonUnselected(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(99, 90, 131);
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            RefreshSelectedColors();

            string selectedClothingType = GetSelectedClothingType();
            string mainCategory = GetCategoryFromClothingType(selectedClothingType);

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

            if (_selectedColors.Count == 0)
            {
                ShowError("Please select at least one color.");
                return;
            }

            if (_selectedStyles.Count == 0)
            {
                ShowError("Please select at least one style.");
                return;
            }

            if (_selectedSeasons.Count == 0)
            {
                ShowError("Please select at least one season.");
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
                Color = string.Join(", ", _selectedColors),
                Style = string.Join(", ", _selectedStyles),
                Season = string.Join(", ", _selectedSeasons)
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

            _selectedColors.Clear();
            _selectedStyles.Clear();
            _selectedSeasons.Clear();

            ResetButtons(panelStyles);
            ResetButtons(panelSeasons);

            if (clbColors != null)
            {
                for (int i = 0; i < clbColors.Items.Count; i++)
                {
                    clbColors.SetItemChecked(i, false);
                }

                clbColors.Visible = false;
                colorDropdownPanel.Height = 45;
                btnColorDropdown.Text = "Select Colors ▼";
            }
        }

        private void ResetButtons(FlowLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button btn)
                    SetButtonUnselected(btn);
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