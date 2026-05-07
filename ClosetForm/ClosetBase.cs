using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Pormatics.Data;
using Pormatics.Models;

namespace Pormatics.ClosetForm
{
    /// <summary>
    /// Base class shared by AllCloset, TopCloset, BottomCloset, ShoesCloset,
    /// AccessoriesCloset.  Subclasses just set CategoryFilter and call
    /// LoadItems() — all rendering lives here.
    /// </summary>
    public class ClosetBase : UserControl
    {
        // ── Configuration ────────────────────────────────────────────
        /// <summary>null = show all categories</summary>
        protected string? CategoryFilter { get; set; } = null;

        // ── Controls ─────────────────────────────────────────────────
        private FlowLayoutPanel _flowPanel = null!;
        private Label _emptyLabel = null!;

        // ── Card dimensions ──────────────────────────────────────────
        private const int CardW = 160;
        private const int CardH = 210;
        private const int CardImgH = 140;
        private const int CardPad = 12;

        // ── Constructor ──────────────────────────────────────────────
        public ClosetBase()
        {
            InitControls();
        }

        private void InitControls()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(242, 235, 240);
            this.Padding = new Padding(14);

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

            this.Controls.Add(_flowPanel);
            this.Controls.Add(_emptyLabel);
        }

        // ── Public API ───────────────────────────────────────────────
        /// <summary>
        /// Reads storage and rebuilds the card grid.
        /// Call this after uploading a new item so the view refreshes.
        /// </summary>
        public void LoadItems()
        {
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
                _flowPanel.Controls.Add(BuildCard(item));
        }

        // ── Card builder ─────────────────────────────────────────────
        private Panel BuildCard(ClothingItem item)
        {
            var card = new Panel
            {
                Size = new Size(CardW, CardH),
                BackColor = Color.White,
                Margin = new Padding(CardPad),
                Cursor = Cursors.Hand
            };
            card.Paint += (s, e) => DrawCardBorder(e.Graphics, card);

            // ── Image area ────────────────────────────────────────
            var imgBox = new PictureBox
            {
                Size = new Size(CardW, CardImgH),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(237, 230, 245)
            };

            if (!string.IsNullOrEmpty(item.ImageFileName) && File.Exists(item.ImageFullPath))
            {
                try { imgBox.Image = Image.FromFile(item.ImageFullPath); }
                catch { /* show placeholder color on error */ }
            }

            // ── Category badge ────────────────────────────────────
            var badge = new Label
            {
                Text = item.Category.Length > 3 ? item.Category[..3] : item.Category,
                Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(99, 90, 131),
                AutoSize = false,
                Size = new Size(36, 18),
                Location = new Point(CardW - 42, 6),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Name label ────────────────────────────────────────
            var lblName = new Label
            {
                Text = item.Name,
                Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 38, 64),
                Location = new Point(8, CardImgH + 6),
                Size = new Size(CardW - 16, 20),
                AutoEllipsis = true
            };

            // ── Meta label ────────────────────────────────────────
            var lblMeta = new Label
            {
                Text = $"{item.Color}  ·  {item.Style}",
                Font = new Font("Microsoft Sans Serif", 8F),
                ForeColor = Color.FromArgb(139, 127, 163),
                Location = new Point(8, CardImgH + 28),
                Size = new Size(CardW - 16, 18),
                AutoEllipsis = true
            };

            // ── Season label ──────────────────────────────────────
            var lblSeason = new Label
            {
                Text = item.Season,
                Font = new Font("Microsoft Sans Serif", 7.5F),
                ForeColor = Color.FromArgb(195, 180, 208),
                Location = new Point(8, CardImgH + 46),
                Size = new Size(CardW - 16, 16)
            };

            // ── Delete button (shown on hover) ────────────────────
            var btnDelete = new Button
            {
                Text = "✕",
                Size = new Size(22, 22),
                Location = new Point(6, 6),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(240, 149, 149),
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Visible = false
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += (s, e) => DeleteItem(item.Id, card);

            // ── Hover show/hide delete ────────────────────────────
            void ShowDelete(object? s, EventArgs e) { btnDelete.Visible = true; card.Invalidate(); }
            void HideDelete(object? s, EventArgs e) { btnDelete.Visible = false; card.Invalidate(); }

            foreach (Control c in new Control[] { card, imgBox, lblName, lblMeta, lblSeason })
            {
                c.MouseEnter += ShowDelete;
                c.MouseLeave += HideDelete;
            }

            // ── Assemble ──────────────────────────────────────────
            imgBox.Controls.Add(badge);
            imgBox.Controls.Add(btnDelete);
            card.Controls.Add(imgBox);
            card.Controls.Add(lblName);
            card.Controls.Add(lblMeta);
            card.Controls.Add(lblSeason);

            return card;
        }

        // ── Delete ───────────────────────────────────────────────────
        private void DeleteItem(string id, Panel card)
        {
            var result = MessageBox.Show(
                "Remove this item from your closet?",
                "Delete item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                // Dispose all PictureBox images recursively
                DisposeImages(card);

                // Delete from storage
                StorageService.DeleteItem(id);

                // Remove UI card
                _flowPanel.Controls.Remove(card);

                card.Dispose();

                // Show empty label if no more items
                if (_flowPanel.Controls.Count == 0)
                {
                    _emptyLabel.Visible = true;
                    _flowPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to delete item.\n{ex.Message}",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

                // Recursively check child controls
                if (control.HasChildren)
                {
                    DisposeImages(control);
                }
            }
        }

        // ── Card border ───────────────────────────────────────────────
        private static void DrawCardBorder(Graphics g, Panel card)
        {
            using var pen = new Pen(Color.FromArgb(40, 99, 90, 131), 1f);
            g.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
        }

        // ── Cleanup ───────────────────────────────────────────────────
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (Control c in _flowPanel.Controls)
                    if (c is Panel card)
                        foreach (Control inner in card.Controls)
                            if (inner is PictureBox pb)
                                pb.Image?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}