using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Pormatics.ClosetForm
{
    public partial class ClothingDetailsForm : Form
    {
        private readonly ClothingItem _item;
        private bool isLoading = false;

        public bool ItemChanged { get; private set; } = false;

        public ClothingDetailsForm(ClothingItem item)
        {
            InitializeComponent();

            _item = item;

            LoadItem();
        }

        private void LoadItem()
        {
            isLoading = true;

            lblTitle.Text = _item.ClothingType;

            LoadCheckedValues(clbSeason, _item.Season);
            LoadCheckedValues(clbStyle, _item.Style);
            LoadCheckedValues(clbColor, _item.Color);

            UpdateDropdownText(btnSeasonDropdown, clbSeason, "Select Season");
            UpdateDropdownText(btnStyleDropdown, clbStyle, "Select Style");
            UpdateDropdownText(btnColorDropdown, clbColor, "Select Color");

            if (File.Exists(_item.ImageFullPath))
            {
                using Image temp = Image.FromFile(_item.ImageFullPath);
                picturePreview.Image = new Bitmap(temp);
            }

            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;

            isLoading = false;
        }

        private void LoadCheckedValues(CheckedListBox list, string savedValues)
        {
            string[] values = savedValues
                .Split(',')
                .Select(v => v.Trim())
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .ToArray();

            for (int i = 0; i < list.Items.Count; i++)
            {
                string itemText = list.Items[i].ToString()!;

                if (values.Contains(itemText, StringComparer.OrdinalIgnoreCase))
                    list.SetItemChecked(i, true);
            }
        }

        private void ToggleDropdown(Panel panel, CheckedListBox list)
        {
            list.Visible = !list.Visible;
            panel.Height = list.Visible ? 175 : 45;
        }

        private void UpdateDropdownText(Button button, CheckedListBox list, string defaultText)
        {
            string selectedText = string.Join(", ",
                list.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString()));

            button.Text = string.IsNullOrWhiteSpace(selectedText)
                ? $"{defaultText} ▼"
                : $"{selectedText} ▼";
        }

        private string GetCheckedValues(CheckedListBox list)
        {
            return string.Join(", ",
                list.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString()));
        }

        private void btnSeasonDropdown_Click(object sender, EventArgs e)
        {
            ToggleDropdown(pnlSeason, clbSeason);
        }

        private void btnStyleDropdown_Click(object sender, EventArgs e)
        {
            ToggleDropdown(pnlStyle, clbStyle);
        }

        private void btnColorDropdown_Click(object sender, EventArgs e)
        {
            ToggleDropdown(pnlColor, clbColor);
        }

        private void clbSeason_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isLoading)
                return;

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();
                UpdateDropdownText(btnSeasonDropdown, clbSeason, "Select Season");
            };
            timer.Start();
        }

        private void clbStyle_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isLoading)
                return;

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();
                UpdateDropdownText(btnStyleDropdown, clbStyle, "Select Style");
            };
            timer.Start();
        }

        private void clbColor_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isLoading)
                return;

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();
                UpdateDropdownText(btnColorDropdown, clbColor, "Select Color");
            };
            timer.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _item.Season = GetCheckedValues(clbSeason);
            _item.Style = GetCheckedValues(clbStyle);
            _item.Color = GetCheckedValues(clbColor);

            if (string.IsNullOrWhiteSpace(_item.Season))
            {
                MessageBox.Show("Please select at least one season.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_item.Style))
            {
                MessageBox.Show("Please select at least one style.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_item.Color))
            {
                MessageBox.Show("Please select at least one color.");
                return;
            }

            StorageService.UpdateItem(_item);

            ItemChanged = true;

            MessageBox.Show("Clothing details updated.");

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Delete this clothing item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            picturePreview.Image?.Dispose();
            picturePreview.Image = null;

            StorageService.DeleteItem(_item.Id);

            ItemChanged = true;

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}