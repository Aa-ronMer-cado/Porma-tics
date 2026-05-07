namespace Pormatics.FuctionalityForm.UploadForm
{
    partial class UploadFilter
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbTops;

        // Tag panels
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.FlowLayoutPanel panelColors;
        private System.Windows.Forms.Label lblStyles;
        private System.Windows.Forms.FlowLayoutPanel panelStyles;
        private System.Windows.Forms.Label lblSeasons;
        private System.Windows.Forms.FlowLayoutPanel panelSeasons;

        // Buttons / progress
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpload;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private void InitializeComponent()
        {
            picturePreview = new PictureBox();
            topPanel = new Panel();
            lblTitle = new Label();
            mainPanel = new Panel();
            progressBar = new ProgressBar();
            clrButton = new Button();
            cmbAccesories = new ComboBox();
            cmbShoes = new ComboBox();
            cmbBottoms = new ComboBox();
            lblColors = new Label();
            lblCategory = new Label();
            cmbTops = new ComboBox();
            panelColors = new FlowLayoutPanel();
            lblStyles = new Label();
            panelStyles = new FlowLayoutPanel();
            lblSeasons = new Label();
            panelSeasons = new FlowLayoutPanel();
            btnBack = new Button();
            btnUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePreview).BeginInit();
            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // picturePreview
            // 
            picturePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picturePreview.BackColor = Color.FromArgb(237, 230, 245);
            picturePreview.BorderStyle = BorderStyle.FixedSingle;
            picturePreview.Location = new Point(18, 85);
            picturePreview.Margin = new Padding(3, 4, 3, 4);
            picturePreview.Name = "picturePreview";
            picturePreview.Size = new Size(289, 776);
            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            picturePreview.TabIndex = 1;
            picturePreview.TabStop = false;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(18, 0, 0, 0);
            topPanel.Size = new Size(1082, 68);
            topPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Komikazoom", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(18, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1064, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " Add Details";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.FromArgb(242, 235, 240);
            mainPanel.Controls.Add(progressBar);
            mainPanel.Controls.Add(clrButton);
            mainPanel.Controls.Add(cmbAccesories);
            mainPanel.Controls.Add(cmbShoes);
            mainPanel.Controls.Add(cmbBottoms);
            mainPanel.Controls.Add(lblColors);
            mainPanel.Controls.Add(lblCategory);
            mainPanel.Controls.Add(cmbTops);
            mainPanel.Controls.Add(panelColors);
            mainPanel.Controls.Add(lblStyles);
            mainPanel.Controls.Add(panelStyles);
            mainPanel.Controls.Add(lblSeasons);
            mainPanel.Controls.Add(panelSeasons);
            mainPanel.Controls.Add(btnBack);
            mainPanel.Controls.Add(btnUpload);
            mainPanel.Location = new Point(323, 85);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(721, 776);
            mainPanel.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(80, 629);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(504, 28);
            progressBar.TabIndex = 17;
            // 
            // clrButton
            // 
            clrButton.Location = new Point(596, 377);
            clrButton.Name = "clrButton";
            clrButton.Size = new Size(94, 29);
            clrButton.TabIndex = 16;
            clrButton.Text = "Clear";
            clrButton.UseVisualStyleBackColor = true;
            clrButton.Click += clrButton_Click;
            // 
            // cmbAccesories
            // 
            cmbAccesories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccesories.Font = new Font("Microsoft Sans Serif", 11F);
            cmbAccesories.Items.AddRange(new object[] { "Hats", "Belts", "Bags", "Jewelry", "Sunglass", "Watches" });
            cmbAccesories.Location = new Point(307, 409);
            cmbAccesories.Margin = new Padding(3, 4, 3, 4);
            cmbAccesories.Name = "cmbAccesories";
            cmbAccesories.Size = new Size(250, 30);
            cmbAccesories.TabIndex = 15;
            // 
            // cmbShoes
            // 
            cmbShoes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShoes.Font = new Font("Microsoft Sans Serif", 11F);
            cmbShoes.Items.AddRange(new object[] { "Sneakers", "Boots", "Sandals", "Loafers", "Heels", "Flats" });
            cmbShoes.Location = new Point(307, 353);
            cmbShoes.Margin = new Padding(3, 4, 3, 4);
            cmbShoes.Name = "cmbShoes";
            cmbShoes.Size = new Size(250, 30);
            cmbShoes.TabIndex = 14;
            // 
            // cmbBottoms
            // 
            cmbBottoms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBottoms.Font = new Font("Microsoft Sans Serif", 11F);
            cmbBottoms.Items.AddRange(new object[] { "Jeans", "Shorts", "Skirt", "Trousers", "Leggings", "Sweatpants" });
            cmbBottoms.Location = new Point(12, 409);
            cmbBottoms.Margin = new Padding(3, 4, 3, 4);
            cmbBottoms.Name = "cmbBottoms";
            cmbBottoms.Size = new Size(250, 30);
            cmbBottoms.TabIndex = 13;
            // 
            // lblColors
            // 
            lblColors.AutoSize = true;
            lblColors.Font = new Font("Pontano Sans", 10.2F, FontStyle.Bold);
            lblColors.ForeColor = Color.Indigo;
            lblColors.Location = new Point(12, 470);
            lblColors.Name = "lblColors";
            lblColors.Size = new Size(69, 22);
            lblColors.TabIndex = 4;
            lblColors.Text = "COLOR";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Pontano Sans", 10.2F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Indigo;
            lblCategory.Location = new Point(12, 317);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(52, 22);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "TYPE";
            // 
            // cmbTops
            // 
            cmbTops.AccessibleDescription = "";
            cmbTops.AccessibleName = "";
            cmbTops.AccessibleRole = AccessibleRole.None;
            cmbTops.BackColor = SystemColors.HighlightText;
            cmbTops.Font = new Font("Microsoft Sans Serif", 11F);
            cmbTops.Items.AddRange(new object[] { "T - shirt", "Polo shirt", "Blouse", "Tank top", "Cardigan", "Coat", "Hoodie", "Crop top" });
            cmbTops.Location = new Point(12, 353);
            cmbTops.Margin = new Padding(3, 4, 3, 4);
            cmbTops.Name = "cmbTops";
            cmbTops.Size = new Size(250, 30);
            cmbTops.TabIndex = 3;
            cmbTops.Text = "Tops";
            // 
            // panelColors
            // 
            panelColors.BackColor = Color.Transparent;
            panelColors.Location = new Point(12, 506);
            panelColors.Margin = new Padding(3, 4, 3, 4);
            panelColors.Name = "panelColors";
            panelColors.Size = new Size(504, 100);
            panelColors.TabIndex = 5;
            // 
            // lblStyles
            // 
            lblStyles.AutoSize = true;
            lblStyles.Font = new Font("Pontano Sans", 10.2F, FontStyle.Bold);
            lblStyles.ForeColor = Color.Indigo;
            lblStyles.Location = new Point(12, 153);
            lblStyles.Name = "lblStyles";
            lblStyles.Size = new Size(61, 22);
            lblStyles.TabIndex = 6;
            lblStyles.Text = "STYLE";
            // 
            // panelStyles
            // 
            panelStyles.BackColor = Color.Transparent;
            panelStyles.Location = new Point(12, 187);
            panelStyles.Margin = new Padding(3, 4, 3, 4);
            panelStyles.Name = "panelStyles";
            panelStyles.Size = new Size(504, 100);
            panelStyles.TabIndex = 7;
            // 
            // lblSeasons
            // 
            lblSeasons.AutoSize = true;
            lblSeasons.Font = new Font("Pontano Sans", 10.2F, FontStyle.Bold);
            lblSeasons.ForeColor = Color.Indigo;
            lblSeasons.Location = new Point(12, 13);
            lblSeasons.Name = "lblSeasons";
            lblSeasons.Size = new Size(79, 22);
            lblSeasons.TabIndex = 8;
            lblSeasons.Text = "SEASON";
            // 
            // panelSeasons
            // 
            panelSeasons.BackColor = Color.Transparent;
            panelSeasons.Location = new Point(12, 50);
            panelSeasons.Margin = new Padding(3, 4, 3, 4);
            panelSeasons.Name = "panelSeasons";
            panelSeasons.Size = new Size(504, 75);
            panelSeasons.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Pontano Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(30, 686);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 48);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(99, 90, 131);
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Pontano Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(207, 686);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(170, 48);
            btnUpload.TabIndex = 12;
            btnUpload.Text = "Upload to Closet";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // UploadFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 235, 240);
            ClientSize = new Size(1082, 952);
            Controls.Add(topPanel);
            Controls.Add(picturePreview);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(720, 663);
            Name = "UploadFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upload Clothes - Step 2";
            ((System.ComponentModel.ISupportInitialize)picturePreview).EndInit();
            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private ComboBox cmbShoes;
        private ComboBox cmbBottoms;
        private ComboBox cmbAccesories;
        private Button clrButton;
        private ProgressBar progressBar;
    }
}