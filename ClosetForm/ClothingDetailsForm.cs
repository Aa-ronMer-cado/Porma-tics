using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pormatics.ClosetForm
{
    public partial class ClothingDetailsForm : Form
    {
        private ClothingItem _item;

        public bool ItemChanged { get; private set; } = false;

        public ClothingDetailsForm(ClothingItem item)
        {
            InitializeComponent();

            _item = item;

            LoadItem();
        }

        private void LoadItem()
        {
            lblTitle.Text = _item.ClothingType;
            cmbColor.Text = _item.Color;
            cmbStyle.Text = _item.Style;
            cmbSeason.Text = _item.Season;

            if (File.Exists(_item.ImageFullPath))
            {
                using (Image temp = Image.FromFile(_item.ImageFullPath))
                {
                    picturePreview.Image = new Bitmap(temp);
                }
            }

            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _item.Color = cmbColor.Text.Trim();
            _item.Style = cmbStyle.Text.Trim();
            _item.Season = cmbSeason.Text.Trim();

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