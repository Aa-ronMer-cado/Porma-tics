using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Pormatics.Data;
using Pormatics.Models;

namespace Pormatics.ClosetForm
{
    public class ClosetBase : UserControl
    {
        protected string? CategoryFilter { get; set; } = null;

        private FlowLayoutPanel _flowPanel = null!;
        private Label _emptyLabel = null!;

        private const int CardW = 160;
        private const int CardH = 210;
        private const int CardImgH = 140;
        private const int CardPad = 12;

        public ClosetBase()
        {
            InitControls();
        }

        private void InitControls()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(242, 235, 240);
            Padding = new Padding(14);

            _flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                BackColor = Color.Transparent
            };

            _emptyLabel = new Label
            {
                Text = "Your closet is empty.\nUpload some clothes to get started!",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12F),
                ForeColor = Color.FromArgb(195, 180, 208),
                Dock = DockStyle.Fill,
                Visible = false
            };

            Controls.Add(_flowPanel);
            Controls.Add(_emptyLabel);
        }

        public void LoadItems()
        {
            DisposeFlowPanelImages();

            List<ClothingItem> items = string.IsNullOrEmpty(CategoryFilter)
                ? StorageService.LoadAll()
                : StorageService.LoadByCategory(CategoryFilter);

            _flowPanel.Controls.Clear();

            if (items.Count == 0)
            {
                _emptyLabel.Visible = true;
                _flowPanel.Visible = false;
                return;
            }

            _emptyLabel.Visible = false;
            _flowPanel.Visible = true;

            foreach (ClothingItem item in items)
            {
                _flowPanel.Controls.Add(BuildCard(item));
            }
        }

        private Panel BuildCard(ClothingItem item)
        {
            Panel card = new Panel
            {
                Size = new Size(CardW, CardH),
                BackColor = Color.White,
                Margin = new Padding(CardPad),
                Cursor = Cursors.Hand
            };

            card.Paint += (s, e) => DrawCardBorder(e.Graphics, card);

            PictureBox imgBox = new PictureBox
            {
                Size = new Size(CardW, CardImgH),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(237, 230, 245),
                Cursor = Cursors.Hand
            };

            LoadImageToPictureBox(imgBox, item);

            Label badge = new Label
            {
                Text = GetBadgeText(item),
                Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(99, 90, 131),
                AutoSize = false,
                Size = new Size(42, 18),
                Location = new Point(CardW - 48, 6),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };

            Label lblName = new Label
            {
                Text = string.IsNullOrWhiteSpace(item.ClothingType)
                    ? item.Category
                    : item.ClothingType,
                Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 38, 64),
                Location = new Point(8, CardImgH + 6),
                Size = new Size(CardW - 16, 20),
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            Label lblMeta = new Label
            {
                Text = $"{item.Color}  ·  {item.Style}",
                Font = new Font("Microsoft Sans Serif", 8F),
                ForeColor = Color.FromArgb(139, 127, 163),
                Location = new Point(8, CardImgH + 28),
                Size = new Size(CardW - 16, 18),
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            Label lblSeason = new Label
            {
                Text = item.Season,
                Font = new Font("Microsoft Sans Serif", 7.5F),
                ForeColor = Color.FromArgb(195, 180, 208),
                Location = new Point(8, CardImgH + 46),
                Size = new Size(CardW - 16, 16),
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            void OpenItemDetails(object? sender, EventArgs e)
            {
                OpenDetails(item);
            }

            card.Click += OpenItemDetails;
            imgBox.Click += OpenItemDetails;
            badge.Click += OpenItemDetails;
            lblName.Click += OpenItemDetails;
            lblMeta.Click += OpenItemDetails;
            lblSeason.Click += OpenItemDetails;

            card.MouseEnter += (s, e) =>
            {
                card.BackColor = Color.FromArgb(250, 247, 252);
                card.Invalidate();
            };

            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
                card.Invalidate();
            };

            imgBox.Controls.Add(badge);

            card.Controls.Add(imgBox);
            card.Controls.Add(lblName);
            card.Controls.Add(lblMeta);
            card.Controls.Add(lblSeason);

            return card;
        }

        private void OpenDetails(ClothingItem item)
        {
            using ClothingDetailsForm detailsForm = new ClothingDetailsForm(item);

            detailsForm.ShowDialog();

            if (detailsForm.ItemChanged)
            {
                LoadItems();
            }
        }

        private static string GetBadgeText(ClothingItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Category))
                return "";

            return item.Category.Length > 3
                ? item.Category[..3]
                : item.Category;
        }

        private static void LoadImageToPictureBox(PictureBox pictureBox, ClothingItem item)
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = null;

            if (string.IsNullOrWhiteSpace(item.ImageFileName))
                return;

            if (!File.Exists(item.ImageFullPath))
                return;

            try
            {
                using Image tempImage = Image.FromFile(item.ImageFullPath);
                pictureBox.Image = new Bitmap(tempImage);
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        private void DisposeFlowPanelImages()
        {
            foreach (Control control in _flowPanel.Controls)
            {
                DisposeImages(control);
            }
        }

        private static void DisposeImages(Control parent)
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

        private static void DrawCardBorder(Graphics g, Panel card)
        {
            using Pen pen = new Pen(Color.FromArgb(40, 99, 90, 131), 1f);
            g.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeFlowPanelImages();
            }

            base.Dispose(disposing);
        }
    }
}