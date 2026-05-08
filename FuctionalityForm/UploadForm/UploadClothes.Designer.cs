namespace Pormatics.FuctionalityForm
{
    partial class UploadClothes
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBoxPreview;
        private Label lblTitle;
        private Button btnNext;
        private PictureBox picBrowse;
        private PictureBox picReset;
        private ProgressBar progressBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxPreview = new PictureBox();
            lblTitle = new Label();
            btnNext = new Button();
            picBrowse = new PictureBox();
            picReset = new PictureBox();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBrowse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReset).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.BackColor = Color.Transparent;
            pictureBoxPreview.Location = new Point(349, 86);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(423, 354);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(363, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(399, 36);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Upload your clothes here...";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SlateBlue;
            btnNext.Enabled = false;
            btnNext.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(970, 568);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 30);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // picBrowse
            // 
            picBrowse.Cursor = Cursors.Hand;
            picBrowse.Image = Properties.Resources.Upload;
            picBrowse.Location = new Point(578, 479);
            picBrowse.Name = "picBrowse";
            picBrowse.Size = new Size(216, 119);
            picBrowse.SizeMode = PictureBoxSizeMode.Zoom;
            picBrowse.TabIndex = 5;
            picBrowse.TabStop = false;
            picBrowse.Click += btnBrowse_Click;
            // 
            // picReset
            // 
            picReset.Cursor = Cursors.Hand;
            picReset.Image = Properties.Resources.Restart;
            picReset.Location = new Point(326, 479);
            picReset.Name = "picReset";
            picReset.Size = new Size(160, 126);
            picReset.SizeMode = PictureBoxSizeMode.Zoom;
            picReset.TabIndex = 6;
            picReset.TabStop = false;
            picReset.Click += btnReset_Click;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.PaleVioletRed;
            progressBar.Location = new Point(326, 451);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(468, 22);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 7;
            progressBar.Visible = false;
            // 
            // UploadClothes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1099, 627);
            Controls.Add(progressBar);
            Controls.Add(picReset);
            Controls.Add(picBrowse);
            Controls.Add(btnNext);
            Controls.Add(lblTitle);
            Controls.Add(pictureBoxPreview);
            Name = "UploadClothes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UploadClothes";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBrowse).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}