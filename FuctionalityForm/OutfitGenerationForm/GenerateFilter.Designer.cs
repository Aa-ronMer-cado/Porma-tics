namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    partial class GenerateFilter
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel headerLayout;
        private FlowLayoutPanel seasonPanel;
        private TableLayoutPanel styleGrid;
        private FlowLayoutPanel bottomColorPanel;

        private Label lblGenerateFilter;
        private Label label1;
        private Label lblGSeason;
        private Label lblGStyle;
        private Label lblGColor;

        private Button btnSummer;
        private Button btnRainy;

        private Button btnStyleSummer;
        private Button btnMinimal;
        private Button btnStWear;
        private Button btnBusCasual;
        private Button btnRetro;
        private Button btnFormal;
        private Button btnVaca;
        private Button btnRomantic;
        private Button btnSporty;
        private Button btnSmtCasual;

        private Panel colorDropdownPanel;
        private Button btnColorDropdown;
        private CheckedListBox clbColors;

        private Button btnNext;

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

            lblGenerateFilter = new Label();
            label1 = new Label();

            lblGSeason = new Label();
            seasonPanel = new FlowLayoutPanel();

            btnSummer = new Button();
            btnRainy = new Button();

            lblGStyle = new Label();
            styleGrid = new TableLayoutPanel();

            btnStyleSummer = new Button();
            btnMinimal = new Button();
            btnStWear = new Button();
            btnBusCasual = new Button();
            btnRetro = new Button();
            btnFormal = new Button();
            btnVaca = new Button();
            btnRomantic = new Button();
            btnSporty = new Button();
            btnSmtCasual = new Button();

            lblGColor = new Label();

            bottomColorPanel = new FlowLayoutPanel();

            colorDropdownPanel = new Panel();
            btnColorDropdown = new Button();
            clbColors = new CheckedListBox();

            btnNext = new Button();

            mainLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            seasonPanel.SuspendLayout();
            styleGrid.SuspendLayout();
            bottomColorPanel.SuspendLayout();

            SuspendLayout();

            // =========================
            // FORM
            // =========================

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1514, 768);
            ForeColor = Color.Indigo;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenerateFilter";
            Text = "GenerateFilter";

            // =========================
            // MAIN LAYOUT
            // =========================

            mainLayout.BackColor = Color.FromArgb(244, 233, 233);
            mainLayout.ColumnCount = 1;

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            mainLayout.Dock = DockStyle.Fill;

            mainLayout.Padding = new Padding(30, 15, 30, 25);

            mainLayout.RowCount = 7;

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));

            Controls.Add(mainLayout);

            // =========================
            // HEADER
            // =========================

            headerLayout.ColumnCount = 1;

            headerLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            headerLayout.Dock = DockStyle.Fill;

            headerLayout.RowCount = 2;

            headerLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 65F));

            headerLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 35F));

            mainLayout.Controls.Add(headerLayout, 0, 0);

            // TITLE

            lblGenerateFilter.Dock = DockStyle.Fill;
            lblGenerateFilter.Font = new Font("Komikazoom", 36F, FontStyle.Bold);
            lblGenerateFilter.ForeColor = Color.Indigo;
            lblGenerateFilter.Text = "Generator";
            lblGenerateFilter.TextAlign = ContentAlignment.BottomLeft;

            headerLayout.Controls.Add(lblGenerateFilter, 0, 0);

            // SUBTITLE

            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Indigo;
            label1.Text = "Pick multiple styles and colors to generate your outfit.";

            headerLayout.Controls.Add(label1, 0, 1);

            // =========================
            // SEASON LABEL
            // =========================

            lblGSeason.Dock = DockStyle.Fill;
            lblGSeason.Font = new Font("Komikazoom", 25.8F, FontStyle.Bold);
            lblGSeason.ForeColor = Color.Indigo;
            lblGSeason.Text = "SEASON";
            lblGSeason.TextAlign = ContentAlignment.MiddleCenter;

            mainLayout.Controls.Add(lblGSeason, 0, 1);

            // =========================
            // SEASON PANEL
            // =========================

            seasonPanel.Anchor = AnchorStyles.None;
            seasonPanel.AutoSize = true;
            seasonPanel.BackColor = Color.Transparent;
            seasonPanel.WrapContents = false;

            mainLayout.Controls.Add(seasonPanel, 0, 2);

            SetupSeasonButton(btnSummer, "Summer");
            SetupSeasonButton(btnRainy, "Rainy");

            seasonPanel.Controls.Add(btnSummer);
            seasonPanel.Controls.Add(btnRainy);

            // =========================
            // STYLE LABEL
            // =========================

            lblGStyle.Dock = DockStyle.Fill;
            lblGStyle.Font = new Font("Komikazoom", 25.8F, FontStyle.Bold);
            lblGStyle.ForeColor = Color.Indigo;
            lblGStyle.Text = "STYLE";
            lblGStyle.TextAlign = ContentAlignment.MiddleCenter;

            mainLayout.Controls.Add(lblGStyle, 0, 3);

            // =========================
            // STYLE GRID
            // =========================

            styleGrid.BackColor = Color.Transparent;

            styleGrid.ColumnCount = 5;
            styleGrid.RowCount = 2;

            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            styleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            styleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            styleGrid.Dock = DockStyle.Fill;

            styleGrid.Padding = new Padding(80, 0, 80, 0);

            mainLayout.Controls.Add(styleGrid, 0, 4);

            SetupStyleButton(btnStyleSummer, "Casual");
            SetupStyleButton(btnStWear, "Streetwear");
            SetupStyleButton(btnMinimal, "Minimalist");
            SetupStyleButton(btnRetro, "Retro");
            SetupStyleButton(btnBusCasual, "Business Casual");
            SetupStyleButton(btnFormal, "Formal");
            SetupStyleButton(btnVaca, "Vacation");
            SetupStyleButton(btnRomantic, "Romantic");
            SetupStyleButton(btnSporty, "Sporty");
            SetupStyleButton(btnSmtCasual, "Smart Casual");

            styleGrid.Controls.Add(btnStyleSummer, 0, 0);
            styleGrid.Controls.Add(btnStWear, 1, 0);
            styleGrid.Controls.Add(btnMinimal, 2, 0);
            styleGrid.Controls.Add(btnRetro, 3, 0);
            styleGrid.Controls.Add(btnBusCasual, 4, 0);

            styleGrid.Controls.Add(btnFormal, 0, 1);
            styleGrid.Controls.Add(btnVaca, 1, 1);
            styleGrid.Controls.Add(btnRomantic, 2, 1);
            styleGrid.Controls.Add(btnSporty, 3, 1);
            styleGrid.Controls.Add(btnSmtCasual, 4, 1);

            // =========================
            // COLOR LABEL
            // =========================

            lblGColor.Dock = DockStyle.Fill;
            lblGColor.Font = new Font("Komikazoom", 25.8F, FontStyle.Bold);
            lblGColor.ForeColor = Color.Indigo;
            lblGColor.Text = "COLOR";
            lblGColor.TextAlign = ContentAlignment.MiddleCenter;

            mainLayout.Controls.Add(lblGColor, 0, 5);

            // =========================
            // BOTTOM PANEL
            // =========================

            bottomColorPanel.Anchor = AnchorStyles.None;
            bottomColorPanel.AutoSize = true;
            bottomColorPanel.BackColor = Color.Transparent;
            bottomColorPanel.WrapContents = false;

            mainLayout.Controls.Add(bottomColorPanel, 0, 6);

            // =========================
            // COLOR DROPDOWN PANEL
            // =========================

            colorDropdownPanel.BackColor = Color.Transparent;
            colorDropdownPanel.Size = new Size(550, 45);
            colorDropdownPanel.Margin = new Padding(8);

            bottomColorPanel.Controls.Add(colorDropdownPanel);

            // =========================
            // DROPDOWN BUTTON
            // =========================

            btnColorDropdown.BackColor = Color.Thistle;
            btnColorDropdown.FlatStyle = FlatStyle.Flat;
            btnColorDropdown.FlatAppearance.BorderSize = 0;
            btnColorDropdown.Font = new Font("Segoe UI", 10F);
            btnColorDropdown.ForeColor = Color.Black;

            btnColorDropdown.Location = new Point(0, 0);

            btnColorDropdown.Size = new Size(550, 40);

            btnColorDropdown.Text = "Select Colors ▼";

            btnColorDropdown.TextAlign = ContentAlignment.MiddleLeft;

            btnColorDropdown.UseVisualStyleBackColor = false;

            colorDropdownPanel.Controls.Add(btnColorDropdown);

            // =========================
            // CHECKED LIST BOX
            // =========================

            clbColors.BackColor = Color.Thistle;
            clbColors.BorderStyle = BorderStyle.None;
            clbColors.CheckOnClick = true;
            clbColors.Font = new Font("Segoe UI", 10F);

            clbColors.Location = new Point(0, 42);

            clbColors.Size = new Size(550, 120);

            clbColors.Visible = false;

            clbColors.Items.AddRange(new object[]
            {
                "Red",
                "Orange",
                "Yellow",
                "Green",
                "Blue",
                "Indigo",
                "Violet",
                "Pink",
                "Black",
                "White"
            });

            colorDropdownPanel.Controls.Add(clbColors);

            // =========================
            // NEXT BUTTON
            // =========================

            btnNext.BackColor = Color.SlateBlue;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;

            btnNext.Margin = new Padding(80, 8, 8, 8);

            btnNext.Size = new Size(160, 55);

            btnNext.Text = "Next";

            btnNext.UseVisualStyleBackColor = false;

            btnNext.Click += btnNext_Click;

            bottomColorPanel.Controls.Add(btnNext);

            // =========================
            // RESUME
            // =========================

            mainLayout.ResumeLayout(false);
            headerLayout.ResumeLayout(false);
            seasonPanel.ResumeLayout(false);
            styleGrid.ResumeLayout(false);
            bottomColorPanel.ResumeLayout(false);

            ResumeLayout(false);
        }

        private void SetupSeasonButton(Button button, string text)
        {
            button.BackColor = Color.Thistle;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10F);
            button.ForeColor = Color.Black;
            button.Margin = new Padding(8);
            button.Size = new Size(260, 65);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        private void SetupStyleButton(Button button, string text)
        {
            button.BackColor = Color.Thistle;
            button.Dock = DockStyle.Fill;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10F);
            button.ForeColor = Color.Black;
            button.Margin = new Padding(4);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }
    }
}