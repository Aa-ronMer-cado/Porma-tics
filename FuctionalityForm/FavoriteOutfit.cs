using Pormatics.Data;
using Pormatics.Models;
using Pormatics.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm
{
    public partial class FavoriteOutfit : Form
    {
        private List<FavoriteOutfitItem> favorites = new();


        public FavoriteOutfit()
        {
            InitializeComponent();

            CustomHeader.Create(
                this,
                "FAVORITES",
                "View and manage your saved outfits."
            );

            mainLayout.Padding = new Padding(30, 170, 30, 30);

            LoadFavorites();

            Shown += FavoriteOutfit_Shown;
        }

        private void FavoriteOutfit_Shown(object? sender, EventArgs e)
        {
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
            favorites = StorageService.LoadFavoriteOutfits();

            if (favorites.Count == 0)
            {
                flowFavorites.Controls.Add(new Label
                {
                    Text = "No favorite outfits yet.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray,
                    Margin = new Padding(20)
                });

                return;
            }

            foreach (FavoriteOutfitItem favorite in favorites)
            {
                flowFavorites.Controls.Add(BuildFavoriteCard(favorite));
            }

            ResizeFavoriteCards();
            flowFavorites.PerformLayout();
        }

        private Panel BuildFavoriteCard(FavoriteOutfitItem favorite)
        {
            Panel card = new Panel
            {
                Width = GetCardWidth(),
                Height = GetCardHeight(),
                BackColor = Color.White,
                Margin = new Padding(12),
                Padding = new Padding(12),
                BorderStyle = BorderStyle.FixedSingle
            };

            TableLayoutPanel cardLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                BackColor = Color.White
            };

            cardLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 45F));

            cardLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // =========================
            // TOP BAR
            // =========================

            Panel topPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label lblDate = new Label
            {
                AutoSize = false,
                Size = new Size(300, 35),
                Location = new Point(0, 5),
                Text = $"Saved: {favorite.DateSaved:MMMM dd, yyyy}",
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button btnDelete = new Button
            {
                Size = new Size(90, 30),
                Text = "Delete",
                BackColor = Color.FromArgb(190, 50, 50),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnDelete.FlatAppearance.BorderSize = 0;

            // FIXED POSITION
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnDelete.Location = new Point(
                topPanel.Width - btnDelete.Width - 10,
                5);

            topPanel.Resize += (s, e) =>
            {
                btnDelete.Location = new Point(
                    topPanel.Width - btnDelete.Width - 10,
                    5);
            };

            btnDelete.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show(
                    "Remove this outfit from favorites?",
                    "Delete Favorite",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                favorites.Remove(favorite);

                StorageService.SaveFavoriteOutfits(favorites);

                LoadFavorites();
            };

            topPanel.Controls.Add(lblDate);
            topPanel.Controls.Add(btnDelete);

            // =========================
            // OUTFIT PICTURES
            // =========================

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
                RowCount = 1,
                BackColor = Color.White,
                Padding = new Padding(0, 8, 0, 0)
            };

            for (int i = 0; i < 4; i++)
            {
                outfitLayout.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 25F));
            }

            outfitLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            outfitLayout.Controls.Add(CreatePictureBox(top), 0, 0);
            outfitLayout.Controls.Add(CreatePictureBox(bottom), 1, 0);
            outfitLayout.Controls.Add(CreatePictureBox(shoes), 2, 0);
            outfitLayout.Controls.Add(CreatePictureBox(accessory), 3, 0);

            cardLayout.Controls.Add(topPanel, 0, 0);
            cardLayout.Controls.Add(outfitLayout, 0, 1);

            card.Controls.Add(cardLayout);

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

        private void DeleteFavorite(FavoriteOutfitItem favorite)
        {
            DialogResult result = MessageBox.Show(
                "Remove this outfit from favorites?",
                "Delete Favorite",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            favorites.Remove(favorite);
            StorageService.SaveFavoriteOutfits(favorites);
            LoadFavorites();
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

            return Math.Max(460, width / 2 - 40);
        }

        private int GetCardHeight()
        {
            int height = flowFavorites.ClientSize.Height;

            if (height <= 0)
                return 260;

            return Math.Max(260, height / 2);
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
                    DisposeImages(control);
            }
        }
    }
}