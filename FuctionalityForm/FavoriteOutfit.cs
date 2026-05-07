using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm
{
    public partial class FavoriteOutfit : Form
    {
        public FavoriteOutfit()
        {
            InitializeComponent();

            LoadFavorites();
        }

        private void LoadFavorites()
        {
            flowFavorites.Controls.Clear();

            List<FavoriteOutfitItem> favorites = StorageService.LoadFavoriteOutfits();

            if (favorites.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "No favorite outfits yet.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray,
                    Margin = new Padding(20)
                };

                flowFavorites.Controls.Add(emptyLabel);
                return;
            }

            foreach (FavoriteOutfitItem favorite in favorites)
            {
                flowFavorites.Controls.Add(BuildFavoriteCard(favorite));
            }
        }

        private Panel BuildFavoriteCard(FavoriteOutfitItem favorite)
        {
            Panel card = new Panel
            {
                Width = 520,
                Height = 180,
                BackColor = Color.White,
                Margin = new Padding(12),
                Padding = new Padding(10)
            };

            ClothingItem? top = StorageService.FindClothingById(favorite.TopId);
            ClothingItem? bottom = StorageService.FindClothingById(favorite.BottomId);
            ClothingItem? shoes = StorageService.FindClothingById(favorite.ShoesId);
            ClothingItem? accessory = StorageService.FindClothingById(favorite.AccessoryId);

            PictureBox picTop = CreatePictureBox(top, 10, 10);
            PictureBox picBottom = CreatePictureBox(bottom, 135, 10);
            PictureBox picShoes = CreatePictureBox(shoes, 260, 10);
            PictureBox picAccessory = CreatePictureBox(accessory, 385, 10);

            card.Controls.Add(picTop);
            card.Controls.Add(picBottom);
            card.Controls.Add(picShoes);
            card.Controls.Add(picAccessory);

            return card;
        }

        private PictureBox CreatePictureBox(ClothingItem? item, int x, int y)
        {
            PictureBox pictureBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(110, 150),
                BackColor = Color.FromArgb(237, 230, 245),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (item == null)
                return pictureBox;

            if (!File.Exists(item.ImageFullPath))
                return pictureBox;

            try
            {
                using (Image tempImage = Image.FromFile(item.ImageFullPath))
                {
                    pictureBox.Image = new Bitmap(tempImage);
                }
            }
            catch
            {
                pictureBox.Image = null;
            }

            return pictureBox;
        }
    }
}