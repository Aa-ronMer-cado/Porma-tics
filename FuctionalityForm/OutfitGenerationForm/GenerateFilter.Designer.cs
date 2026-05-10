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
            btnStWear = new Button();
            btnMinimal = new Button();
            btnRetro = new Button();
            btnBusCasual = new Button();
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
            colorDropdownPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(244, 233, 233);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(lblGSeason, 0, 1);
            mainLayout.Controls.Add(seasonPanel, 0, 2);
            mainLayout.Controls.Add(lblGStyle, 0, 3);
            mainLayout.Controls.Add(styleGrid, 0, 4);
            mainLayout.Controls.Add(lblGColor, 0, 5);
            mainLayout.Controls.Add(bottomColorPanel, 0, 6);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(30, 15, 30, 25);
            mainLayout.RowCount = 7;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8571434F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9890108F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4615383F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8.653846F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9615383F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.28021955F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6593409F));
            mainLayout.Size = new Size(1514, 768);
            mainLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.ColumnCount = 1;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerLayout.Controls.Add(lblGenerateFilter, 0, 0);
            headerLayout.Controls.Add(label1, 0, 1);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(33, 18);
            headerLayout.Name = "headerLayout";
            headerLayout.RowCount = 2;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            headerLayout.Size = new Size(1448, 124);
            headerLayout.TabIndex = 0;
            // 
            // lblGenerateFilter
            // 
            lblGenerateFilter.Dock = DockStyle.Fill;
            lblGenerateFilter.Font = new Font("Komikazoom", 36F, FontStyle.Bold);
            lblGenerateFilter.ForeColor = Color.Indigo;
            lblGenerateFilter.Location = new Point(3, 0);
            lblGenerateFilter.Name = "lblGenerateFilter";
            lblGenerateFilter.Size = new Size(1442, 80);
            lblGenerateFilter.TabIndex = 0;
            lblGenerateFilter.Text = "Generator";
            lblGenerateFilter.TextAlign = ContentAlignment.BottomLeft;
            lblGenerateFilter.Click += lblGenerateFilter_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(3, 80);
            label1.Name = "label1";
            label1.Size = new Size(1442, 44);
            label1.TabIndex = 1;
            label1.Text = "Pick multiple styles and colors to generate your outfit.";
            // 
            // lblGSeason
            // 
            lblGSeason.Dock = DockStyle.Fill;
            lblGSeason.Font = new Font("Komikazoom", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGSeason.ForeColor = Color.Indigo;
            lblGSeason.Location = new Point(33, 145);
            lblGSeason.Name = "lblGSeason";
            lblGSeason.Size = new Size(1448, 80);
            lblGSeason.TabIndex = 1;
            lblGSeason.Text = "SEASON";
            lblGSeason.TextAlign = ContentAlignment.MiddleCenter;
            lblGSeason.Click += lblGSeason_Click;
            // 
            // seasonPanel
            // 
            seasonPanel.Anchor = AnchorStyles.None;
            seasonPanel.AutoSize = true;
            seasonPanel.BackColor = Color.Transparent;
            seasonPanel.Controls.Add(btnSummer);
            seasonPanel.Controls.Add(btnRainy);
            seasonPanel.Location = new Point(676, 259);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(162, 29);
            seasonPanel.TabIndex = 2;
            seasonPanel.WrapContents = false;
            // 
            // btnSummer
            // 
            btnSummer.Location = new Point(3, 3);
            btnSummer.Name = "btnSummer";
            btnSummer.Size = new Size(75, 23);
            btnSummer.TabIndex = 0;
            btnSummer.Click += btnSummer_Click;
            // 
            // btnRainy
            // 
            btnRainy.Location = new Point(84, 3);
            btnRainy.Name = "btnRainy";
            btnRainy.Size = new Size(75, 23);
            btnRainy.TabIndex = 1;
            // 
            // lblGStyle
            // 
            lblGStyle.Dock = DockStyle.Fill;
            lblGStyle.Font = new Font("Komikazoom", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGStyle.ForeColor = Color.Indigo;
            lblGStyle.Location = new Point(33, 323);
            lblGStyle.Name = "lblGStyle";
            lblGStyle.Size = new Size(1448, 63);
            lblGStyle.TabIndex = 3;
            lblGStyle.Text = "STYLE";
            lblGStyle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // styleGrid
            // 
            styleGrid.BackColor = Color.Transparent;
            styleGrid.ColumnCount = 5;
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            styleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
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
            styleGrid.Dock = DockStyle.Fill;
            styleGrid.Location = new Point(33, 389);
            styleGrid.Name = "styleGrid";
            styleGrid.Padding = new Padding(80, 0, 80, 0);
            styleGrid.RowCount = 2;
            styleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            styleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            styleGrid.Size = new Size(1448, 183);
            styleGrid.TabIndex = 4;
            // 
            // btnStyleSummer
            // 
            btnStyleSummer.Location = new Point(83, 3);
            btnStyleSummer.Name = "btnStyleSummer";
            btnStyleSummer.Size = new Size(75, 23);
            btnStyleSummer.TabIndex = 0;
            // 
            // btnStWear
            // 
            btnStWear.Location = new Point(340, 3);
            btnStWear.Name = "btnStWear";
            btnStWear.Size = new Size(75, 23);
            btnStWear.TabIndex = 1;
            // 
            // btnMinimal
            // 
            btnMinimal.Location = new Point(597, 3);
            btnMinimal.Name = "btnMinimal";
            btnMinimal.Size = new Size(75, 23);
            btnMinimal.TabIndex = 2;
            // 
            // btnRetro
            // 
            btnRetro.Location = new Point(854, 3);
            btnRetro.Name = "btnRetro";
            btnRetro.Size = new Size(75, 23);
            btnRetro.TabIndex = 3;
            // 
            // btnBusCasual
            // 
            btnBusCasual.Location = new Point(1111, 3);
            btnBusCasual.Name = "btnBusCasual";
            btnBusCasual.Size = new Size(75, 23);
            btnBusCasual.TabIndex = 4;
            // 
            // btnFormal
            // 
            btnFormal.Location = new Point(83, 94);
            btnFormal.Name = "btnFormal";
            btnFormal.Size = new Size(75, 23);
            btnFormal.TabIndex = 5;
            // 
            // btnVaca
            // 
            btnVaca.Location = new Point(340, 94);
            btnVaca.Name = "btnVaca";
            btnVaca.Size = new Size(75, 23);
            btnVaca.TabIndex = 6;
            // 
            // btnRomantic
            // 
            btnRomantic.Location = new Point(597, 94);
            btnRomantic.Name = "btnRomantic";
            btnRomantic.Size = new Size(75, 23);
            btnRomantic.TabIndex = 7;
            // 
            // btnSporty
            // 
            btnSporty.Location = new Point(854, 94);
            btnSporty.Name = "btnSporty";
            btnSporty.Size = new Size(75, 23);
            btnSporty.TabIndex = 8;
            // 
            // btnSmtCasual
            // 
            btnSmtCasual.Location = new Point(1111, 94);
            btnSmtCasual.Name = "btnSmtCasual";
            btnSmtCasual.Size = new Size(75, 23);
            btnSmtCasual.TabIndex = 9;
            // 
            // lblGColor
            // 
            lblGColor.Dock = DockStyle.Fill;
            lblGColor.Font = new Font("Komikazoom", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGColor.ForeColor = Color.Indigo;
            lblGColor.Location = new Point(33, 575);
            lblGColor.Name = "lblGColor";
            lblGColor.Size = new Size(1448, 53);
            lblGColor.TabIndex = 5;
            lblGColor.Text = "COLOR";
            lblGColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottomColorPanel
            // 
            bottomColorPanel.Anchor = AnchorStyles.None;
            bottomColorPanel.AutoSize = true;
            bottomColorPanel.BackColor = Color.Transparent;
            bottomColorPanel.Controls.Add(colorDropdownPanel);
            bottomColorPanel.Controls.Add(btnNext);
            bottomColorPanel.Location = new Point(350, 650);
            bottomColorPanel.Name = "bottomColorPanel";
            bottomColorPanel.Size = new Size(814, 71);
            bottomColorPanel.TabIndex = 6;
            bottomColorPanel.WrapContents = false;
            bottomColorPanel.Paint += bottomColorPanel_Paint;
            // 
            // colorDropdownPanel
            // 
            colorDropdownPanel.BackColor = Color.Transparent;
            colorDropdownPanel.Controls.Add(btnColorDropdown);
            colorDropdownPanel.Controls.Add(clbColors);
            colorDropdownPanel.Location = new Point(8, 8);
            colorDropdownPanel.Margin = new Padding(8);
            colorDropdownPanel.Name = "colorDropdownPanel";
            colorDropdownPanel.Size = new Size(550, 45);
            colorDropdownPanel.TabIndex = 0;
            // 
            // btnColorDropdown
            // 
            btnColorDropdown.BackColor = Color.Thistle;
            btnColorDropdown.FlatAppearance.BorderSize = 0;
            btnColorDropdown.FlatStyle = FlatStyle.Flat;
            btnColorDropdown.Font = new Font("Segoe UI", 10F);
            btnColorDropdown.ForeColor = Color.Black;
            btnColorDropdown.Location = new Point(0, 0);
            btnColorDropdown.Name = "btnColorDropdown";
            btnColorDropdown.Size = new Size(550, 40);
            btnColorDropdown.TabIndex = 0;
            btnColorDropdown.Text = "Select Colors ▼";
            btnColorDropdown.TextAlign = ContentAlignment.MiddleLeft;
            btnColorDropdown.UseVisualStyleBackColor = false;
            // 
            // clbColors
            // 
            clbColors.BackColor = Color.Thistle;
            clbColors.BorderStyle = BorderStyle.None;
            clbColors.CheckOnClick = true;
            clbColors.Font = new Font("Segoe UI", 10F);
            clbColors.Items.AddRange(new object[] { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "Pink", "Black", "White" });
            clbColors.Location = new Point(0, 42);
            clbColors.Name = "clbColors";
            clbColors.Size = new Size(550, 100);
            clbColors.TabIndex = 1;
            clbColors.Visible = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SlateBlue;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(646, 8);
            btnNext.Margin = new Padding(80, 8, 8, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(160, 55);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // GenerateFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1514, 768);
            Controls.Add(mainLayout);
            ForeColor = Color.Indigo;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenerateFilter";
            Text = "GenerateFilter";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            seasonPanel.ResumeLayout(false);
            styleGrid.ResumeLayout(false);
            bottomColorPanel.ResumeLayout(false);
            colorDropdownPanel.ResumeLayout(false);
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