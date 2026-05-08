namespace Pormatics.FuctionalityForm
{
    partial class UploadClothes
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private FlowLayoutPanel buttonPanel;

        private PictureBox pictureBoxPreview;
        private Label lblTitle;
        private Button btnNext;
        private PictureBox picBrowse;
        private PictureBox picReset;
        private ProgressBar progressBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            lblTitle = new Label();
            pictureBoxPreview = new PictureBox();
            buttonPanel = new FlowLayoutPanel();
            picReset = new PictureBox();
            picBrowse = new PictureBox();
            progressBar = new ProgressBar();
            btnNext = new Button();
            mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBrowse).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(244, 233, 233);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainLayout.Controls.Add(lblTitle, 0, 0);
            mainLayout.Controls.Add(pictureBoxPreview, 0, 1);
            mainLayout.Controls.Add(buttonPanel, 0, 2);
            mainLayout.Controls.Add(btnNext, 0, 4);
            mainLayout.Controls.Add(progressBar, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(40, 25, 40, 25);
            mainLayout.RowCount = 5;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.6516466F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2651644F));
            mainLayout.Size = new Size(1099, 627);
            mainLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(43, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1013, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Upload your clothes here...";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Anchor = AnchorStyles.None;
            pictureBoxPreview.BackColor = Color.White;
            pictureBoxPreview.Location = new Point(339, 96);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(420, 268);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 1;
            pictureBoxPreview.TabStop = false;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.None;
            buttonPanel.AutoSize = true;
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(picReset);
            buttonPanel.Controls.Add(picBrowse);
            buttonPanel.Location = new Point(359, 370);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(380, 91);
            buttonPanel.TabIndex = 2;
            buttonPanel.WrapContents = false;
            // 
            // picReset
            // 
            picReset.Cursor = Cursors.Hand;
            picReset.Image = Properties.Resources.Restart;
            picReset.Location = new Point(35, 10);
            picReset.Margin = new Padding(35, 10, 35, 10);
            picReset.Name = "picReset";
            picReset.Size = new Size(120, 80);
            picReset.SizeMode = PictureBoxSizeMode.Zoom;
            picReset.TabIndex = 0;
            picReset.TabStop = false;
            picReset.Click += btnReset_Click;
            // 
            // picBrowse
            // 
            picBrowse.Cursor = Cursors.Hand;
            picBrowse.Image = Properties.Resources.Upload;
            picBrowse.Location = new Point(225, 10);
            picBrowse.Margin = new Padding(35, 10, 35, 10);
            picBrowse.Name = "picBrowse";
            picBrowse.Size = new Size(120, 80);
            picBrowse.SizeMode = PictureBoxSizeMode.Zoom;
            picBrowse.TabIndex = 1;
            picBrowse.TabStop = false;
            picBrowse.Click += btnBrowse_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.None;
            progressBar.ForeColor = Color.PaleVioletRed;
            progressBar.Location = new Point(324, 489);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(450, 22);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 4;
            progressBar.Visible = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.SlateBlue;
            btnNext.Enabled = false;
            btnNext.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(478, 551);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(142, 35);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // UploadClothes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1099, 627);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UploadClothes";
            Text = "UploadClothes";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBrowse).EndInit();
            ResumeLayout(false);
        }
    }
}