using Pormatics.Data;
using Pormatics.Models;
using Pormatics.Services;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    public partial class ConfirmGenerated : Form
    {
        private readonly OutfitFilter currentFilter;
        private GeneratedOutfit currentOutfit;

        public ConfirmGenerated(OutfitFilter filter, GeneratedOutfit outfit)
        {
            InitializeComponent();

            currentFilter = filter;
            currentOutfit = outfit;

            DisplayOutfit();
        }

        private void DisplayOutfit()
        {
            SetPicture(picTop, currentOutfit.Top);
            SetPicture(picBottom, currentOutfit.Bottom);
            SetPicture(picShoes, currentOutfit.Shoes);
            SetPicture(picAccessory, currentOutfit.Accessory);
        }

        private void SetPicture(PictureBox pictureBox, ClothingItem? item)
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = null;

            if (item == null)
                return;

            if (string.IsNullOrWhiteSpace(item.ImageFullPath))
                return;

            if (!File.Exists(item.ImageFullPath))
                return;

            try
            {
                using (Image tempImage = Image.FromFile(item.ImageFullPath))
                {
                    pictureBox.Image = new Bitmap(tempImage);
                }

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        private void btnGenerateAgain_Click(object sender, EventArgs e)
        {
            try
            {
                currentOutfit = OutfitGeneratorService.GenerateOutfit(currentFilter);

                DisplayOutfit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cannot Generate Again",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            try
            {
                StorageService.SaveFavoriteOutfit(currentOutfit);

                MessageBox.Show(
                    "Outfit saved to favorites.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Favorite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DisposePicture(picTop);
            DisposePicture(picBottom);
            DisposePicture(picShoes);
            DisposePicture(picAccessory);

            base.OnFormClosed(e);
        }

        private void DisposePicture(PictureBox pictureBox)
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = null;
        }
    }
}