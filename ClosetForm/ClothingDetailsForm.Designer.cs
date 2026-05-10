using System.Drawing;
using System.Windows.Forms;

namespace Pormatics.ClosetForm
{
    partial class ClothingDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private PictureBox picturePreview;

        private Label lblSeason;
        private Label lblStyle;
        private Label lblColor;

        private Panel pnlSeason;
        private Panel pnlStyle;
        private Panel pnlColor;

        private Button btnSeasonDropdown;
        private Button btnStyleDropdown;
        private Button btnColorDropdown;

        private CheckedListBox clbSeason;
        private CheckedListBox clbStyle;
        private CheckedListBox clbColor;

        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                picturePreview?.Image?.Dispose();

                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            picturePreview = new PictureBox();

            lblSeason = new Label();
            lblStyle = new Label();
            lblColor = new Label();

            pnlSeason = new Panel();
            pnlStyle = new Panel();
            pnlColor = new Panel();

            btnSeasonDropdown = new Button();
            btnStyleDropdown = new Button();
            btnColorDropdown = new Button();

            clbSeason = new CheckedListBox();
            clbStyle = new CheckedListBox();
            clbColor = new CheckedListBox();

            btnSave = new Button();
            btnDelete = new Button();
            btnClose = new Button();

            ((System.ComponentModel.ISupportInitialize)picturePreview).BeginInit();
            pnlSeason.SuspendLayout();
            pnlStyle.SuspendLayout();
            pnlColor.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(65, 56, 97);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 37);
            lblTitle.Text = "Clothing Details";

            // picturePreview
            picturePreview.BackColor = Color.FromArgb(237, 230, 245);
            picturePreview.BorderStyle = BorderStyle.FixedSingle;
            picturePreview.Location = new Point(35, 75);
            picturePreview.Name = "picturePreview";
            picturePreview.Size = new Size(220, 250);
            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            picturePreview.TabStop = false;

            // lblSeason
            lblSeason.AutoSize = true;
            lblSeason.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeason.ForeColor = Color.FromArgb(99, 90, 131);
            lblSeason.Location = new Point(300, 75);
            lblSeason.Name = "lblSeason";
            lblSeason.Text = "Season";

            // pnlSeason
            pnlSeason.BackColor = Color.Transparent;
            pnlSeason.Controls.Add(btnSeasonDropdown);
            pnlSeason.Controls.Add(clbSeason);
            pnlSeason.Location = new Point(300, 105);
            pnlSeason.Name = "pnlSeason";
            pnlSeason.Size = new Size(250, 45);

            // btnSeasonDropdown
            btnSeasonDropdown.BackColor = Color.White;
            btnSeasonDropdown.FlatStyle = FlatStyle.Flat;
            btnSeasonDropdown.Font = new Font("Segoe UI", 9F);
            btnSeasonDropdown.ForeColor = Color.FromArgb(99, 90, 131);
            btnSeasonDropdown.Location = new Point(0, 0);
            btnSeasonDropdown.Name = "btnSeasonDropdown";
            btnSeasonDropdown.Size = new Size(250, 36);
            btnSeasonDropdown.Text = "Select Season ▼";
            btnSeasonDropdown.TextAlign = ContentAlignment.MiddleLeft;
            btnSeasonDropdown.UseVisualStyleBackColor = false;
            btnSeasonDropdown.Click += btnSeasonDropdown_Click;

            // clbSeason
            clbSeason.BackColor = Color.White;
            clbSeason.BorderStyle = BorderStyle.FixedSingle;
            clbSeason.CheckOnClick = true;
            clbSeason.Font = new Font("Segoe UI", 9F);
            clbSeason.FormattingEnabled = true;
            clbSeason.Items.AddRange(new object[]
            {
                "Summer",
                "Rainy"
            });
            clbSeason.Location = new Point(0, 38);
            clbSeason.Name = "clbSeason";
            clbSeason.Size = new Size(250, 70);
            clbSeason.Visible = false;
            clbSeason.ItemCheck += clbSeason_ItemCheck;

            // lblStyle
            lblStyle.AutoSize = true;
            lblStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStyle.ForeColor = Color.FromArgb(99, 90, 131);
            lblStyle.Location = new Point(300, 155);
            lblStyle.Name = "lblStyle";
            lblStyle.Text = "Style";

            // pnlStyle
            pnlStyle.BackColor = Color.Transparent;
            pnlStyle.Controls.Add(btnStyleDropdown);
            pnlStyle.Controls.Add(clbStyle);
            pnlStyle.Location = new Point(300, 185);
            pnlStyle.Name = "pnlStyle";
            pnlStyle.Size = new Size(250, 45);

            // btnStyleDropdown
            btnStyleDropdown.BackColor = Color.White;
            btnStyleDropdown.FlatStyle = FlatStyle.Flat;
            btnStyleDropdown.Font = new Font("Segoe UI", 9F);
            btnStyleDropdown.ForeColor = Color.FromArgb(99, 90, 131);
            btnStyleDropdown.Location = new Point(0, 0);
            btnStyleDropdown.Name = "btnStyleDropdown";
            btnStyleDropdown.Size = new Size(250, 36);
            btnStyleDropdown.Text = "Select Style ▼";
            btnStyleDropdown.TextAlign = ContentAlignment.MiddleLeft;
            btnStyleDropdown.UseVisualStyleBackColor = false;
            btnStyleDropdown.Click += btnStyleDropdown_Click;

            // clbStyle
            clbStyle.BackColor = Color.White;
            clbStyle.BorderStyle = BorderStyle.FixedSingle;
            clbStyle.CheckOnClick = true;
            clbStyle.Font = new Font("Segoe UI", 9F);
            clbStyle.FormattingEnabled = true;
            clbStyle.Items.AddRange(new object[]
            {
                "Casual",
                "Streetwear",
                "Minimalist",
                "Retro",
                "Business Casual",
                "Formal",
                "Vacation",
                "Romantic",
                "Sporty",
                "Smart Casual",
                "Athletic",
                "Business"
            });
            clbStyle.Location = new Point(0, 38);
            clbStyle.Name = "clbStyle";
            clbStyle.Size = new Size(250, 150);
            clbStyle.Visible = false;
            clbStyle.ItemCheck += clbStyle_ItemCheck;

            // lblColor
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColor.ForeColor = Color.FromArgb(99, 90, 131);
            lblColor.Location = new Point(300, 235);
            lblColor.Name = "lblColor";
            lblColor.Text = "Color";

            // pnlColor
            pnlColor.BackColor = Color.Transparent;
            pnlColor.Controls.Add(btnColorDropdown);
            pnlColor.Controls.Add(clbColor);
            pnlColor.Location = new Point(300, 265);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(250, 45);

            // btnColorDropdown
            btnColorDropdown.BackColor = Color.White;
            btnColorDropdown.FlatStyle = FlatStyle.Flat;
            btnColorDropdown.Font = new Font("Segoe UI", 9F);
            btnColorDropdown.ForeColor = Color.FromArgb(99, 90, 131);
            btnColorDropdown.Location = new Point(0, 0);
            btnColorDropdown.Name = "btnColorDropdown";
            btnColorDropdown.Size = new Size(250, 36);
            btnColorDropdown.Text = "Select Color ▼";
            btnColorDropdown.TextAlign = ContentAlignment.MiddleLeft;
            btnColorDropdown.UseVisualStyleBackColor = false;
            btnColorDropdown.Click += btnColorDropdown_Click;

            // clbColor
            clbColor.BackColor = Color.White;
            clbColor.BorderStyle = BorderStyle.FixedSingle;
            clbColor.CheckOnClick = true;
            clbColor.Font = new Font("Segoe UI", 9F);
            clbColor.FormattingEnabled = true;
            clbColor.Items.AddRange(new object[]
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
            clbColor.Location = new Point(0, 38);
            clbColor.Name = "clbColor";
            clbColor.Size = new Size(250, 130);
            clbColor.Visible = false;
            clbColor.ItemCheck += clbColor_ItemCheck;

            // btnSave
            btnSave.BackColor = Color.FromArgb(99, 90, 131);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(300, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 38);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // btnDelete
            btnDelete.BackColor = Color.FromArgb(220, 90, 90);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(435, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 38);
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // btnClose
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(99, 90, 131);
            btnClose.Location = new Point(35, 330);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 38);
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;

            // ClothingDetailsForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 235, 240);
            ClientSize = new Size(590, 400);
            Controls.Add(lblTitle);
            Controls.Add(picturePreview);
            Controls.Add(lblSeason);
            Controls.Add(pnlSeason);
            Controls.Add(lblStyle);
            Controls.Add(pnlStyle);
            Controls.Add(lblColor);
            Controls.Add(pnlColor);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClothingDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clothing Details";

            ((System.ComponentModel.ISupportInitialize)picturePreview).EndInit();
            pnlSeason.ResumeLayout(false);
            pnlStyle.ResumeLayout(false);
            pnlColor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}