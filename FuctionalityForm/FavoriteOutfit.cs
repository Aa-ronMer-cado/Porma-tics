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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeFavoriteCards();
        }

        private void LoadFavorites()
        {
            flowFavorites.Controls.Clear();

            List<FavoriteOutfitItem> favorites =
                StorageService.LoadFavoriteOutfits();

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

            ResizeFavoriteCards();
        }

        private Panel BuildFavoriteCard(FavoriteOutfitItem favorite)
        {
            Panel card = new Panel
            {
                Width = GetCardWidth(),
                Height = GetCardHeight(),
                BackColor = Color.White,
                Margin = new Padding(12),
                Padding = new Padding(10)
            };

            ClothingItem? top =
                StorageService.FindClothingById(favorite.TopId);

            ClothingItem? bottom =
                StorageService.FindClothingById(favorite.BottomId);

            ClothingItem? shoes =
                StorageService.FindClothingById(favorite.ShoesId);

            ClothingItem? accessory =
                StorageService.FindClothingById(favorite.AccessoryId);

            TableLayoutPanel outfitLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 2,
                BackColor = Color.White
            };

            outfitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            outfitLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            outfitLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));

            outfitLayout.Controls.Add(CreatePictureBox(top), 0, 0);
            outfitLayout.Controls.Add(CreatePictureBox(bottom), 1, 0);
            outfitLayout.Controls.Add(CreatePictureBox(shoes), 2, 0);
            outfitLayout.Controls.Add(CreatePictureBox(accessory), 3, 0);

            outfitLayout.Controls.Add(CreateLabel("Top"), 0, 1);
            outfitLayout.Controls.Add(CreateLabel("Bottom"), 1, 1);
            outfitLayout.Controls.Add(CreateLabel("Shoes"), 2, 1);
            outfitLayout.Controls.Add(CreateLabel("Accessory"), 3, 1);

            card.Controls.Add(outfitLayout);

            return card;
        }

        private PictureBox CreatePictureBox(ClothingItem? item)
        {
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                BackColor = Color.FromArgb(237, 230, 245),
                BorderStyle = BorderStyle.FixedSingle,
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

        private Label CreateLabel(string text)
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.Indigo
            };
        }

        private void ResizeFavoriteCards()
        {
            foreach (Control control in flowFavorites.Controls)
            {
                if (control is Panel card)
                {
                    card.Width = GetCardWidth();
                    card.Height = GetCardHeight();
                }
            }
        }

        private int GetCardWidth()
        {
            int width = flowFavorites.ClientSize.Width;

            if (width <= 0)
                return 520;

            return Math.Max(420, width / 2 - 40);
        }

        private int GetCardHeight()
        {
            int height = flowFavorites.ClientSize.Height;

            if (height <= 0)
                return 200;

            return Math.Max(180, height / 3);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DisposeImages(flowFavorites);
            base.OnFormClosed(e);
        }

        private void DisposeImages(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is PictureBox pb)
                {
                    pb.Image?.Dispose();
                    pb.Image = null;
                }

                if (control.HasChildren)
                {
                    DisposeImages(control);
                }
            }
        }
    }
}