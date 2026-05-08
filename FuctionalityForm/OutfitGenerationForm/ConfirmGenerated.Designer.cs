namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    partial class ConfirmGenerated
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel headerLayout;
        private TableLayoutPanel outfitGrid;
        private FlowLayoutPanel buttonPanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private PictureBox picTop;
        private PictureBox picBottom;
        private PictureBox picShoes;
        private PictureBox picAccessory;

        private Label lblTop;
        private Label lblBottom;
        private Label lblShoes;
        private Label lblAccessory;

        private PictureBox btnGenerateAgain;
        private PictureBox btnFavorite;
        private PictureBox btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            headerLayout = new TableLayoutPanel();
            outfitGrid = new TableLayoutPanel();
            buttonPanel = new FlowLayoutPanel();

            lblTitle = new Label();
            lblSubtitle = new Label();

            picTop = new PictureBox();
            picBottom = new PictureBox();
            picShoes = new PictureBox();
            picAccessory = new PictureBox();

            lblTop = new Label();
            lblBottom = new Label();
            lblShoes = new Label();
            lblAccessory = new Label();

            btnGenerateAgain = new PictureBox();
            btnFavorite = new PictureBox();
            btnBack = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)picTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccessory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGenerateAgain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFavorite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();

            SuspendLayout();

            mainLayout.Dock = DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 3;
            mainLayout.BackColor = Color.WhiteSmoke;
            mainLayout.Padding = new Padding(40, 25, 40, 25);
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            headerLayout.Dock = DockStyle.Fill;
            headerLayout.ColumnCount = 1;
            headerLayout.RowCount = 2;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));

            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Komikazoom", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Text = "Generated Outfit";
            lblTitle.TextAlign = ContentAlignment.BottomLeft;

            lblSubtitle.Dock = DockStyle.Fill;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Indigo;
            lblSubtitle.Text = "Review your generated outfit below.";
            lblSubtitle.TextAlign = ContentAlignment.TopLeft;

            headerLayout.Controls.Add(lblTitle, 0, 0);
            headerLayout.Controls.Add(lblSubtitle, 0, 1);

            outfitGrid.Dock = DockStyle.Fill;
            outfitGrid.BackColor = Color.FromArgb(242, 235, 240);
            outfitGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            outfitGrid.ColumnCount = 4;
            outfitGrid.RowCount = 2;
            outfitGrid.Padding = new Padding(25);

            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            outfitGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            outfitGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));

            SetupPictureBox(picTop);
            SetupPictureBox(picBottom);
            SetupPictureBox(picShoes);
            SetupPictureBox(picAccessory);

            SetupItemLabel(lblTop, "Top");
            SetupItemLabel(lblBottom, "Bottom");
            SetupItemLabel(lblShoes, "Shoes");
            SetupItemLabel(lblAccessory, "Accessory");

            outfitGrid.Controls.Add(picTop, 0, 0);
            outfitGrid.Controls.Add(picBottom, 1, 0);
            outfitGrid.Controls.Add(picShoes, 2, 0);
            outfitGrid.Controls.Add(picAccessory, 3, 0);

            outfitGrid.Controls.Add(lblTop, 0, 1);
            outfitGrid.Controls.Add(lblBottom, 1, 1);
            outfitGrid.Controls.Add(lblShoes, 2, 1);
            outfitGrid.Controls.Add(lblAccessory, 3, 1);

            buttonPanel.Anchor = AnchorStyles.None;
            buttonPanel.AutoSize = true;
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.FlowDirection = FlowDirection.LeftToRight;
            buttonPanel.WrapContents = false;

            SetupActionPicture(btnGenerateAgain, Properties.Resources.Restart);
            btnGenerateAgain.Click += btnGenerateAgain_Click;

            SetupActionPicture(btnFavorite, Properties.Resources.Heart);
            btnFavorite.Click += btnFavorite_Click;

            SetupActionPicture(btnBack, Properties.Resources.Back);
            btnBack.Click += btnBack_Click;

            buttonPanel.Controls.Add(btnGenerateAgain);
            buttonPanel.Controls.Add(btnFavorite);
            buttonPanel.Controls.Add(btnBack);

            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(outfitGrid, 0, 1);
            mainLayout.Controls.Add(buttonPanel, 0, 2);

            Controls.Add(mainLayout);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1197, 624);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmGenerated";
            Text = "Confirm Generated Outfit";

            ((System.ComponentModel.ISupportInitialize)picTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccessory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGenerateAgain).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFavorite).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();

            ResumeLayout(false);
        }

        private void SetupPictureBox(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.FromArgb(237, 230, 245);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Margin = new Padding(20);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabStop = false;
        }

        private void SetupItemLabel(Label label, string text)
        {
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label.ForeColor = Color.Indigo;
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void SetupActionPicture(PictureBox pictureBox, Image image)
        {
            pictureBox.Size = new Size(70, 70);
            pictureBox.Margin = new Padding(25, 10, 25, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Image = image;
            pictureBox.Padding = new Padding(0);

            pictureBox.MouseEnter += ActionHoverEnter;
            pictureBox.MouseLeave += ActionHoverLeave;
        }

        private void ActionHoverEnter(object? sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(225, 215, 240);
                pb.Padding = new Padding(5);
            }
        }

        private void ActionHoverLeave(object? sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.Transparent;
                pb.Padding = new Padding(0);
            }
        }
    }
}