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
            mainLayout = new TableLayoutPanel();
            headerLayout = new TableLayoutPanel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            outfitGrid = new TableLayoutPanel();
            picTop = new PictureBox();
            picBottom = new PictureBox();
            picShoes = new PictureBox();
            picAccessory = new PictureBox();
            lblTop = new Label();
            lblBottom = new Label();
            lblShoes = new Label();
            lblAccessory = new Label();
            buttonPanel = new FlowLayoutPanel();
            btnGenerateAgain = new Button();
            btnFavorite = new Button();
            btnBack = new Button();
            mainLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            outfitGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccessory).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.WhiteSmoke;
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(outfitGrid, 0, 1);
            mainLayout.Controls.Add(buttonPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(40, 25, 40, 25);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainLayout.Size = new Size(1197, 624);
            mainLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.ColumnCount = 1;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            headerLayout.Controls.Add(lblTitle, 0, 0);
            headerLayout.Controls.Add(lblSubtitle, 0, 1);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(43, 28);
            headerLayout.Name = "headerLayout";
            headerLayout.RowCount = 2;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            headerLayout.Size = new Size(1111, 97);
            headerLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Komikazoom", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1105, 63);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Generated Outfit";
            lblTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Dock = DockStyle.Fill;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Indigo;
            lblSubtitle.Location = new Point(3, 63);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(1105, 34);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your generated outfit below.";
            // 
            // outfitGrid
            // 
            outfitGrid.BackColor = Color.FromArgb(242, 235, 240);
            outfitGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            outfitGrid.ColumnCount = 4;
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outfitGrid.Controls.Add(picBottom, 1, 0);
            outfitGrid.Controls.Add(picShoes, 2, 0);
            outfitGrid.Controls.Add(picAccessory, 3, 0);
            outfitGrid.Controls.Add(lblTop, 0, 1);
            outfitGrid.Controls.Add(lblBottom, 1, 1);
            outfitGrid.Controls.Add(lblShoes, 2, 1);
            outfitGrid.Controls.Add(lblAccessory, 3, 1);
            outfitGrid.Controls.Add(picTop, 0, 0);
            outfitGrid.Dock = DockStyle.Fill;
            outfitGrid.Location = new Point(43, 131);
            outfitGrid.Name = "outfitGrid";
            outfitGrid.Padding = new Padding(25);
            outfitGrid.RowCount = 2;
            outfitGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            outfitGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            outfitGrid.Size = new Size(1111, 349);
            outfitGrid.TabIndex = 1;
            // 
            // picTop
            // 
            picTop.Location = new Point(29, 29);
            picTop.Name = "picTop";
            picTop.Size = new Size(100, 50);
            picTop.TabIndex = 0;
            picTop.TabStop = false;
            // 
            // picBottom
            // 
            picBottom.Location = new Point(294, 29);
            picBottom.Name = "picBottom";
            picBottom.Size = new Size(100, 50);
            picBottom.TabIndex = 1;
            picBottom.TabStop = false;
            // 
            // picShoes
            // 
            picShoes.Location = new Point(559, 29);
            picShoes.Name = "picShoes";
            picShoes.Size = new Size(100, 50);
            picShoes.TabIndex = 2;
            picShoes.TabStop = false;
            // 
            // picAccessory
            // 
            picAccessory.Location = new Point(824, 29);
            picAccessory.Name = "picAccessory";
            picAccessory.Size = new Size(100, 50);
            picAccessory.TabIndex = 3;
            picAccessory.TabStop = false;
            // 
            // lblTop
            // 
            lblTop.Location = new Point(29, 269);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(100, 23);
            lblTop.TabIndex = 4;
            // 
            // lblBottom
            // 
            lblBottom.Location = new Point(294, 269);
            lblBottom.Name = "lblBottom";
            lblBottom.Size = new Size(100, 23);
            lblBottom.TabIndex = 5;
            // 
            // lblShoes
            // 
            lblShoes.Location = new Point(559, 269);
            lblShoes.Name = "lblShoes";
            lblShoes.Size = new Size(100, 23);
            lblShoes.TabIndex = 6;
            // 
            // lblAccessory
            // 
            lblAccessory.Location = new Point(824, 269);
            lblAccessory.Name = "lblAccessory";
            lblAccessory.Size = new Size(100, 23);
            lblAccessory.TabIndex = 7;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.None;
            buttonPanel.AutoSize = true;
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(btnGenerateAgain);
            buttonPanel.Controls.Add(btnFavorite);
            buttonPanel.Controls.Add(btnBack);
            buttonPanel.Location = new Point(477, 526);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(243, 29);
            buttonPanel.TabIndex = 2;
            buttonPanel.WrapContents = false;
            // 
            // btnGenerateAgain
            // 
            btnGenerateAgain.Location = new Point(3, 3);
            btnGenerateAgain.Name = "btnGenerateAgain";
            btnGenerateAgain.Size = new Size(75, 23);
            btnGenerateAgain.TabIndex = 0;
            btnGenerateAgain.Click += btnGenerateAgain_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(84, 3);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(75, 23);
            btnFavorite.TabIndex = 1;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(165, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Click += btnBack_Click;
            // 
            // ConfirmGenerated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1197, 624);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmGenerated";
            Text = "Confirm Generated Outfit";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            outfitGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccessory).EndInit();
            buttonPanel.ResumeLayout(false);
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

        private void SetupActionButton(Button button, string text, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.Size = new Size(160, 45);
            button.Margin = new Padding(12);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }
    }
}