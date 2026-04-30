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

        // Fields
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;

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
        private System.Windows.Forms.ProgressBar progressBar;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();

            this.lblColors = new System.Windows.Forms.Label();
            this.panelColors = new System.Windows.Forms.FlowLayoutPanel();

            this.lblStyles = new System.Windows.Forms.Label();
            this.panelStyles = new System.Windows.Forms.FlowLayoutPanel();

            this.lblSeasons = new System.Windows.Forms.Label();
            this.panelSeasons = new System.Windows.Forms.FlowLayoutPanel();

            this.progressBar = new System.Windows.Forms.ProgressBar();

            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 235, 240);
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.MinimumSize = new System.Drawing.Size(720, 540);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Clothes - Step 2";

            // topPanel
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 54;
            this.topPanel.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);

            // lblTitle
            this.lblTitle.Text = "Upload Clothes - Add Details";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(99, 90, 131);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.topPanel.Controls.Add(this.lblTitle);

            // picturePreview
            this.picturePreview.BackColor = System.Drawing.Color.FromArgb(237, 230, 245);
            this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePreview.Location = new System.Drawing.Point(18, 68);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(240, 500);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.Anchor = System.Windows.Forms.AnchorStyles.Top
                                        | System.Windows.Forms.AnchorStyles.Left
                                        | System.Windows.Forms.AnchorStyles.Bottom;

            // mainPanel
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(242, 235, 240);
            this.mainPanel.Location = new System.Drawing.Point(272, 68);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(524, 500);
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
                                    | System.Windows.Forms.AnchorStyles.Left
                                    | System.Windows.Forms.AnchorStyles.Right
                                    | System.Windows.Forms.AnchorStyles.Bottom;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(139, 127, 163);
            this.lblName.Location = new System.Drawing.Point(0, 10);
            this.lblName.Text = "CLOTHING NAME";

            // txtName
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtName.Location = new System.Drawing.Point(0, 35);
            this.txtName.Size = new System.Drawing.Size(504, 28);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(139, 127, 163);
            this.lblCategory.Location = new System.Drawing.Point(0, 80);
            this.lblCategory.Text = "CATEGORY";

            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCategory.Location = new System.Drawing.Point(0, 105);
            this.cmbCategory.Size = new System.Drawing.Size(250, 30);

            this.cmbCategory.Items.AddRange(new object[]
            {
                "TOPS",
                "BOTTOMS",
                "SHOES",
                "ACCESSORIES"
            });

            // lblColors
            this.lblColors.AutoSize = true;
            this.lblColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblColors.ForeColor = System.Drawing.Color.FromArgb(139, 127, 163);
            this.lblColors.Location = new System.Drawing.Point(0, 155);
            this.lblColors.Text = "COLOR";

            // panelColors
            this.panelColors.Location = new System.Drawing.Point(0, 180);
            this.panelColors.Size = new System.Drawing.Size(504, 80);
            this.panelColors.WrapContents = true;
            this.panelColors.BackColor = System.Drawing.Color.Transparent;

            // lblStyles
            this.lblStyles.AutoSize = true;
            this.lblStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStyles.ForeColor = System.Drawing.Color.FromArgb(139, 127, 163);
            this.lblStyles.Location = new System.Drawing.Point(0, 275);
            this.lblStyles.Text = "STYLE";

            // panelStyles
            this.panelStyles.Location = new System.Drawing.Point(0, 300);
            this.panelStyles.Size = new System.Drawing.Size(504, 80);
            this.panelStyles.WrapContents = true;
            this.panelStyles.BackColor = System.Drawing.Color.Transparent;

            // lblSeasons
            this.lblSeasons.AutoSize = true;
            this.lblSeasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSeasons.ForeColor = System.Drawing.Color.FromArgb(139, 127, 163);
            this.lblSeasons.Location = new System.Drawing.Point(0, 395);
            this.lblSeasons.Text = "SEASON";

            // panelSeasons
            this.panelSeasons.Location = new System.Drawing.Point(0, 420);
            this.panelSeasons.Size = new System.Drawing.Size(504, 60);
            this.panelSeasons.WrapContents = true;
            this.panelSeasons.BackColor = System.Drawing.Color.Transparent;

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(0, 495);
            this.progressBar.Size = new System.Drawing.Size(504, 6);
            this.progressBar.Visible = false;

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(195, 180, 208);
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.Location = new System.Drawing.Point(0, 520);
            this.btnBack.Size = new System.Drawing.Size(100, 38);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // btnUpload
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(99, 90, 131);
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(334, 520);
            this.btnUpload.Size = new System.Drawing.Size(170, 38);
            this.btnUpload.Text = "Upload to Closet";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            // Add controls to mainPanel
            this.mainPanel.Controls.Add(this.lblName);
            this.mainPanel.Controls.Add(this.txtName);

            this.mainPanel.Controls.Add(this.lblCategory);
            this.mainPanel.Controls.Add(this.cmbCategory);

            this.mainPanel.Controls.Add(this.lblColors);
            this.mainPanel.Controls.Add(this.panelColors);

            this.mainPanel.Controls.Add(this.lblStyles);
            this.mainPanel.Controls.Add(this.panelStyles);

            this.mainPanel.Controls.Add(this.lblSeasons);
            this.mainPanel.Controls.Add(this.panelSeasons);

            this.mainPanel.Controls.Add(this.progressBar);

            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Controls.Add(this.btnUpload);

            // Add controls to form
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.picturePreview);
            this.Controls.Add(this.mainPanel);

            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
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
    }
}
