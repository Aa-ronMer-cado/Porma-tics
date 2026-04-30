namespace Pormatics.FuctionalityForm.UploadForm
{
    partial class UploadClothes
    {
        private System.ComponentModel.IContainer components = null;

        // ── Controls ─────────────────────────────────────────────────
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            pictureBoxPreview = new PictureBox();
            lblDrop = new Label();
            btnBrowse = new Button();
            btnReset = new Button();
            btnNext = new Button();
            topPanel = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            pictureBoxPreview.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxPreview.BackColor = Color.FromArgb(237, 230, 245);
            pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPreview.Controls.Add(lblDrop);
            pictureBoxPreview.Location = new Point(20, 74);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(478, 360);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 1;
            pictureBoxPreview.TabStop = false;
            // 
            // lblDrop
            // 
            lblDrop.Cursor = Cursors.Hand;
            lblDrop.Dock = DockStyle.Fill;
            lblDrop.Font = new Font("Microsoft Sans Serif", 11F);
            lblDrop.ForeColor = Color.FromArgb(139, 127, 163);
            lblDrop.Location = new Point(0, 0);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(476, 358);
            lblDrop.TabIndex = 0;
            lblDrop.Text = "Drop an image here\nor use Browse";
            lblDrop.TextAlign = ContentAlignment.MiddleCenter;
            lblDrop.Click += lblDrop_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.White;
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Microsoft Sans Serif", 10F);
            btnBrowse.Location = new Point(20, 450);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(140, 38);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse…";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(195, 180, 208);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Microsoft Sans Serif", 10F);
            btnReset.Location = new Point(170, 450);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 38);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(99, 90, 131);
            btnNext.Cursor = Cursors.Hand;
            btnNext.Enabled = false;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(358, 450);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 38);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(18, 0, 0, 0);
            topPanel.Size = new Size(502, 54);
            topPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(99, 90, 131);
            lblTitle.Location = new Point(18, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(484, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Upload Clothes";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UploadClothes
            // 
            BackColor = Color.FromArgb(242, 235, 240);
            ClientSize = new Size(502, 533);
            Controls.Add(topPanel);
            Controls.Add(pictureBoxPreview);
            Controls.Add(btnBrowse);
            Controls.Add(btnReset);
            Controls.Add(btnNext);
            MinimumSize = new Size(420, 480);
            Name = "UploadClothes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upload Clothes";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            pictureBoxPreview.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
    }
}