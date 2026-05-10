namespace Pormatics.FuctionalityForm
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;

        private Label settingsLabel;
        private Label subtitleLabel;

        private Panel contentPanel;
        private Panel aboutPanel;
        private Panel creditsPanel;

        private Label lblAboutTitle;
        private Label lblAppName;
        private Label lblVersion;
        private Label lblReleaseDate;
        private Label lblDescription;

        private Label lblCreditsTitle;
        private Label lblTeamName;
        private Label lblMembers;
        private Label lblSchoolInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            settingsLabel = new Label();
            subtitleLabel = new Label();

            contentPanel = new Panel();
            aboutPanel = new Panel();
            creditsPanel = new Panel();

            lblAboutTitle = new Label();
            lblAppName = new Label();
            lblVersion = new Label();
            lblReleaseDate = new Label();
            lblDescription = new Label();

            lblCreditsTitle = new Label();
            lblTeamName = new Label();
            lblMembers = new Label();
            lblSchoolInfo = new Label();

            contentPanel.SuspendLayout();
            aboutPanel.SuspendLayout();
            creditsPanel.SuspendLayout();
            SuspendLayout();

            // settingsLabel
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Komikazoom", 36F, FontStyle.Bold);
            settingsLabel.ForeColor = Color.Indigo;
            settingsLabel.Location = new Point(30, 25);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(245, 78);
            settingsLabel.TabIndex = 0;
            settingsLabel.Text = "SETTINGS";

            // subtitleLabel
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 11F);
            subtitleLabel.ForeColor = Color.Indigo;
            subtitleLabel.Location = new Point(35, 105);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(315, 25);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "View app information and credits.";

            // contentPanel
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = Color.FromArgb(244, 233, 233);
            contentPanel.Controls.Add(aboutPanel);
            contentPanel.Controls.Add(creditsPanel);
            contentPanel.Location = new Point(30, 160);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1048, 390);
            contentPanel.TabIndex = 2;

            // aboutPanel
            aboutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aboutPanel.BackColor = Color.WhiteSmoke;
            aboutPanel.BorderStyle = BorderStyle.FixedSingle;
            aboutPanel.Controls.Add(lblAboutTitle);
            aboutPanel.Controls.Add(lblAppName);
            aboutPanel.Controls.Add(lblVersion);
            aboutPanel.Controls.Add(lblReleaseDate);
            aboutPanel.Controls.Add(lblDescription);
            aboutPanel.Location = new Point(0, 0);
            aboutPanel.Name = "aboutPanel";
            aboutPanel.Padding = new Padding(25);
            aboutPanel.Size = new Size(1048, 175);
            aboutPanel.TabIndex = 0;

            // lblAboutTitle
            lblAboutTitle.AutoSize = true;
            lblAboutTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAboutTitle.ForeColor = Color.Indigo;
            lblAboutTitle.Location = new Point(25, 20);
            lblAboutTitle.Name = "lblAboutTitle";
            lblAboutTitle.Size = new Size(134, 32);
            lblAboutTitle.TabIndex = 0;
            lblAboutTitle.Text = "About App";

            // lblAppName
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 10.5F);
            lblAppName.Location = new Point(30, 65);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(176, 25);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "App Name: Pormatics";

            // lblVersion
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 10.5F);
            lblVersion.Location = new Point(30, 95);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(107, 25);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Version: 1.0";

            // lblReleaseDate
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Segoe UI", 10.5F);
            lblReleaseDate.Location = new Point(30, 125);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(191, 25);
            lblReleaseDate.TabIndex = 3;
            lblReleaseDate.Text = "Release Date: May 2026";

            // lblDescription
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.Font = new Font("Segoe UI", 10.5F);
            lblDescription.Location = new Point(370, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(630, 85);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Pormatics is a digital closet and outfit generator system that helps users upload clothes, organize items, generate outfits, and save favorite outfit combinations.";
            lblDescription.TextAlign = ContentAlignment.TopLeft;

            // creditsPanel
            creditsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            creditsPanel.BackColor = Color.WhiteSmoke;
            creditsPanel.BorderStyle = BorderStyle.FixedSingle;
            creditsPanel.Controls.Add(lblCreditsTitle);
            creditsPanel.Controls.Add(lblTeamName);
            creditsPanel.Controls.Add(lblMembers);
            creditsPanel.Controls.Add(lblSchoolInfo);
            creditsPanel.Location = new Point(0, 200);
            creditsPanel.Name = "creditsPanel";
            creditsPanel.Padding = new Padding(25);
            creditsPanel.Size = new Size(1048, 190);
            creditsPanel.TabIndex = 1;

            // lblCreditsTitle
            lblCreditsTitle.AutoSize = true;
            lblCreditsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCreditsTitle.ForeColor = Color.Indigo;
            lblCreditsTitle.Location = new Point(25, 20);
            lblCreditsTitle.Name = "lblCreditsTitle";
            lblCreditsTitle.Size = new Size(94, 32);
            lblCreditsTitle.TabIndex = 0;
            lblCreditsTitle.Text = "Credits";

            // lblTeamName
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTeamName.Location = new Point(30, 65);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(146, 25);
            lblTeamName.TabIndex = 1;
            lblTeamName.Text = "Developed by:";

            // lblMembers
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI", 10.5F);
            lblMembers.Location = new Point(60, 98);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(542, 75);
            lblMembers.TabIndex = 2;
            lblMembers.Text =
                "• Mercado\n" +
                "• Carranceja\n" +
                "• Gupilan\n" +
                "• Bernardo";

            // lblSchoolInfo
            lblSchoolInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSchoolInfo.Font = new Font("Segoe UI", 10.5F);
            lblSchoolInfo.Location = new Point(690, 65);
            lblSchoolInfo.Name = "lblSchoolInfo";
            lblSchoolInfo.Size = new Size(320, 100);
            lblSchoolInfo.TabIndex = 3;
            lblSchoolInfo.Text =
                "Course Project\n" +
                "Computer Science\n" +
                "2026";
            lblSchoolInfo.TextAlign = ContentAlignment.TopRight;

            // Settings
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1108, 585);
            Controls.Add(contentPanel);
            Controls.Add(subtitleLabel);
            Controls.Add(settingsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";

            contentPanel.ResumeLayout(false);
            aboutPanel.ResumeLayout(false);
            aboutPanel.PerformLayout();
            creditsPanel.ResumeLayout(false);
            creditsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}