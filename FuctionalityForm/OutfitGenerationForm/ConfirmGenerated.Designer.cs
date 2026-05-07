namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    partial class ConfirmGenerated
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel outfitPanel;

        private PictureBox picTop;
        private PictureBox picBottom;
        private PictureBox picShoes;
        private PictureBox picAccessory;

        private Label lblTop;
        private Label lblBottom;
        private Label lblShoes;
        private Label lblAccessory;

        private Button btnGenerateAgain;
        private Button btnFavorite;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            outfitPanel = new Panel();

            picTop = new PictureBox();
            picBottom = new PictureBox();
            picShoes = new PictureBox();
            picAccessory = new PictureBox();

            lblTop = new Label();
            lblBottom = new Label();
            lblShoes = new Label();
            lblAccessory = new Label();

            btnGenerateAgain = new Button();
            btnFavorite = new Button();
            btnBack = new Button();

            outfitPanel.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)picTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccessory).BeginInit();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Komikazoom", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 70);
            lblTitle.Text = "Generated Outfit";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Indigo;
            lblSubtitle.Location = new Point(34, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(343, 28);
            lblSubtitle.Text = "Review your generated outfit below.";

            // outfitPanel
            outfitPanel.BackColor = Color.FromArgb(242, 235, 240);
            outfitPanel.BorderStyle = BorderStyle.FixedSingle;
            outfitPanel.Controls.Add(picTop);
            outfitPanel.Controls.Add(picBottom);
            outfitPanel.Controls.Add(picShoes);
            outfitPanel.Controls.Add(picAccessory);
            outfitPanel.Controls.Add(lblTop);
            outfitPanel.Controls.Add(lblBottom);
            outfitPanel.Controls.Add(lblShoes);
            outfitPanel.Controls.Add(lblAccessory);
            outfitPanel.Location = new Point(70, 150);
            outfitPanel.Name = "outfitPanel";
            outfitPanel.Size = new Size(1050, 330);

            // picTop
            picTop.BackColor = Color.FromArgb(237, 230, 245);
            picTop.BorderStyle = BorderStyle.FixedSingle;
            picTop.Location = new Point(45, 40);
            picTop.Name = "picTop";
            picTop.Size = new Size(210, 220);
            picTop.SizeMode = PictureBoxSizeMode.Zoom;
            picTop.TabStop = false;

            // picBottom
            picBottom.BackColor = Color.FromArgb(237, 230, 245);
            picBottom.BorderStyle = BorderStyle.FixedSingle;
            picBottom.Location = new Point(295, 40);
            picBottom.Name = "picBottom";
            picBottom.Size = new Size(210, 220);
            picBottom.SizeMode = PictureBoxSizeMode.Zoom;
            picBottom.TabStop = false;

            // picShoes
            picShoes.BackColor = Color.FromArgb(237, 230, 245);
            picShoes.BorderStyle = BorderStyle.FixedSingle;
            picShoes.Location = new Point(545, 40);
            picShoes.Name = "picShoes";
            picShoes.Size = new Size(210, 220);
            picShoes.SizeMode = PictureBoxSizeMode.Zoom;
            picShoes.TabStop = false;

            // picAccessory
            picAccessory.BackColor = Color.FromArgb(237, 230, 245);
            picAccessory.BorderStyle = BorderStyle.FixedSingle;
            picAccessory.Location = new Point(795, 40);
            picAccessory.Name = "picAccessory";
            picAccessory.Size = new Size(210, 220);
            picAccessory.SizeMode = PictureBoxSizeMode.Zoom;
            picAccessory.TabStop = false;

            // lblTop
            lblTop.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTop.ForeColor = Color.Indigo;
            lblTop.Location = new Point(45, 270);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(210, 35);
            lblTop.Text = "Top";
            lblTop.TextAlign = ContentAlignment.MiddleCenter;

            // lblBottom
            lblBottom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBottom.ForeColor = Color.Indigo;
            lblBottom.Location = new Point(295, 270);
            lblBottom.Name = "lblBottom";
            lblBottom.Size = new Size(210, 35);
            lblBottom.Text = "Bottom";
            lblBottom.TextAlign = ContentAlignment.MiddleCenter;

            // lblShoes
            lblShoes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblShoes.ForeColor = Color.Indigo;
            lblShoes.Location = new Point(545, 270);
            lblShoes.Name = "lblShoes";
            lblShoes.Size = new Size(210, 35);
            lblShoes.Text = "Shoes";
            lblShoes.TextAlign = ContentAlignment.MiddleCenter;

            // lblAccessory
            lblAccessory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAccessory.ForeColor = Color.Indigo;
            lblAccessory.Location = new Point(795, 270);
            lblAccessory.Name = "lblAccessory";
            lblAccessory.Size = new Size(210, 35);
            lblAccessory.Text = "Accessory";
            lblAccessory.TextAlign = ContentAlignment.MiddleCenter;

            // btnGenerateAgain
            btnGenerateAgain.BackColor = Color.Thistle;
            btnGenerateAgain.FlatStyle = FlatStyle.Flat;
            btnGenerateAgain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateAgain.ForeColor = Color.Black;
            btnGenerateAgain.Location = new Point(625, 525);
            btnGenerateAgain.Name = "btnGenerateAgain";
            btnGenerateAgain.Size = new Size(160, 42);
            btnGenerateAgain.Text = "Generate Again";
            btnGenerateAgain.UseVisualStyleBackColor = false;

            // btnFavorite
            btnFavorite.BackColor = Color.SlateBlue;
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFavorite.ForeColor = Color.White;
            btnFavorite.Location = new Point(805, 525);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(140, 42);
            btnFavorite.Text = "Favorite";
            btnFavorite.UseVisualStyleBackColor = false;

            // btnBack
            btnBack.BackColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.Indigo;
            btnBack.Location = new Point(965, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 42);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;

            // ConfirmGenerated
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1197, 624);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(outfitPanel);
            Controls.Add(btnGenerateAgain);
            Controls.Add(btnFavorite);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConfirmGenerated";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm Generated Outfit";

            outfitPanel.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)picTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccessory).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}