using System.Drawing;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    partial class GenerateFilter
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel headerLayout;
        private TableLayoutPanel titleLayout;
        private FlowLayoutPanel windowButtonPanel;
        private FlowLayoutPanel seasonPanel;
        private TableLayoutPanel styleGrid;
        private FlowLayoutPanel bottomColorPanel;

        private PictureBox MiniBtn;
        private PictureBox MaxiBtn;
        private PictureBox EkisBtn;

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
            titleLayout = new TableLayoutPanel();
            lblGenerateFilter = new Label();
            label1 = new Label();
            windowButtonPanel = new FlowLayoutPanel();
            EkisBtn = new PictureBox();
            MaxiBtn = new PictureBox();
            MiniBtn = new PictureBox();
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
            titleLayout.SuspendLayout();
            windowButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EkisBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxiBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiniBtn).BeginInit();
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
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 29F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            mainLayout.Size = new Size(1514, 768);
            mainLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.ColumnCount = 2;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            headerLayout.Controls.Add(titleLayout, 0, 0);
            headerLayout.Controls.Add(windowButtonPanel, 1, 0);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(33, 18);
            headerLayout.Name = "headerLayout";
            headerLayout.RowCount = 1;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerLayout.Size = new Size(1448, 110);
            headerLayout.TabIndex = 0;
            // 
            // titleLayout
            // 
            titleLayout.ColumnCount = 1;
            titleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            titleLayout.Controls.Add(lblGenerateFilter, 0, 0);
            titleLayout.Controls.Add(label1, 0, 1);
            titleLayout.Dock = DockStyle.Fill;
            titleLayout.Location = new Point(3, 3);
            titleLayout.Name = "titleLayout";
            titleLayout.RowCount = 2;
            titleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            titleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            titleLayout.Size = new Size(1262, 104);
            titleLayout.TabIndex = 0;
            // 
            // lblGenerateFilter
            // 
            lblGenerateFilter.Dock = DockStyle.Fill;
            lblGenerateFilter.Font = new Font("Komikazoom", 36F, FontStyle.Bold);
            lblGenerateFilter.ForeColor = Color.Indigo;
            lblGenerateFilter.Location = new Point(3, 0);
            lblGenerateFilter.Name = "lblGenerateFilter";
            lblGenerateFilter.Size = new Size(1256, 67);
            lblGenerateFilter.TabIndex = 0;
            lblGenerateFilter.Text = "Generator";
            lblGenerateFilter.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(3, 67);
            label1.Name = "label1";
            label1.Size = new Size(1256, 37);
            label1.TabIndex = 1;
            label1.Text = "Pick multiple styles and colors to generate your outfit.";
            // 
            // windowButtonPanel
            // 
            windowButtonPanel.BackColor = Color.Transparent;
            windowButtonPanel.Controls.Add(EkisBtn);
            windowButtonPanel.Controls.Add(MaxiBtn);
            windowButtonPanel.Controls.Add(MiniBtn);
            windowButtonPanel.Dock = DockStyle.Top;
            windowButtonPanel.FlowDirection = FlowDirection.RightToLeft;
            windowButtonPanel.Location = new Point(1271, 3);
            windowButtonPanel.Name = "windowButtonPanel";
            windowButtonPanel.Size = new Size(174, 104);
            windowButtonPanel.TabIndex = 1;
            windowButtonPanel.WrapContents = false;
            // 
            // EkisBtn
            // 
            EkisBtn.Cursor = Cursors.Hand;
            EkisBtn.Image = Properties.Resources.close;
            EkisBtn.Location = new Point(119, 5);
            EkisBtn.Margin = new Padding(5);
            EkisBtn.Name = "EkisBtn";
            EkisBtn.Size = new Size(50, 62);
            EkisBtn.SizeMode = PictureBoxSizeMode.Zoom;
            EkisBtn.TabIndex = 0;
            EkisBtn.TabStop = false;
            // 
            // MaxiBtn
            // 
            MaxiBtn.Cursor = Cursors.Hand;
            MaxiBtn.Image = Properties.Resources.maxi;
            MaxiBtn.Location = new Point(59, 5);
            MaxiBtn.Margin = new Padding(5);
            MaxiBtn.Name = "MaxiBtn";
            MaxiBtn.Size = new Size(50, 62);
            MaxiBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MaxiBtn.TabIndex = 1;
            MaxiBtn.TabStop = false;
            // 
            // MiniBtn
            // 
            MiniBtn.Cursor = Cursors.Hand;
            MiniBtn.Image = Properties.Resources.mini;
            MiniBtn.Location = new Point(-1, 5);
            MiniBtn.Margin = new Padding(5);
            MiniBtn.Name = "MiniBtn";
            MiniBtn.Size = new Size(50, 62);
            MiniBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MiniBtn.TabIndex = 2;
            MiniBtn.TabStop = false;
            // 
            // lblGSeason
            // 
            lblGSeason.Dock = DockStyle.Fill;
            lblGSeason.Font = new Font("Komikazoom", 24F, FontStyle.Bold);
            lblGSeason.ForeColor = Color.Indigo;
            lblGSeason.Location = new Point(33, 131);
            lblGSeason.Name = "lblGSeason";
            lblGSeason.Size = new Size(1448, 65);
            lblGSeason.TabIndex = 1;
            lblGSeason.Text = "SEASON";
            lblGSeason.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // seasonPanel
            // 
            seasonPanel.Anchor = AnchorStyles.None;
            seasonPanel.AutoSize = true;
            seasonPanel.BackColor = Color.Transparent;
            seasonPanel.Controls.Add(btnSummer);
            seasonPanel.Controls.Add(btnRainy);
            seasonPanel.Location = new Point(481, 206);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(552, 81);
            seasonPanel.TabIndex = 2;
            seasonPanel.WrapContents = false;
            // 
            // btnSummer
            // 
            btnSummer.BackColor = Color.Thistle;
            btnSummer.FlatAppearance.BorderSize = 0;
            btnSummer.FlatStyle = FlatStyle.Flat;
            btnSummer.Font = new Font("Segoe UI", 10F);
            btnSummer.ForeColor = Color.Black;
            btnSummer.Location = new Point(8, 8);
            btnSummer.Margin = new Padding(8);
            btnSummer.Name = "btnSummer";
            btnSummer.Size = new Size(260, 65);
            btnSummer.TabIndex = 0;
            btnSummer.Text = "Summer";
            btnSummer.UseVisualStyleBackColor = false;
            // 
            // btnRainy
            // 
            btnRainy.BackColor = Color.Thistle;
            btnRainy.FlatAppearance.BorderSize = 0;
            btnRainy.FlatStyle = FlatStyle.Flat;
            btnRainy.Font = new Font("Segoe UI", 10F);
            btnRainy.ForeColor = Color.Black;
            btnRainy.Location = new Point(284, 8);
            btnRainy.Margin = new Padding(8);
            btnRainy.Name = "btnRainy";
            btnRainy.Size = new Size(260, 65);
            btnRainy.TabIndex = 1;
            btnRainy.Text = "Rainy";
            btnRainy.UseVisualStyleBackColor = false;
            // 
            // lblGStyle
            // 
            lblGStyle.Dock = DockStyle.Fill;
            lblGStyle.Font = new Font("Komikazoom", 24F, FontStyle.Bold);
            lblGStyle.ForeColor = Color.Indigo;
            lblGStyle.Location = new Point(33, 297);
            lblGStyle.Name = "lblGStyle";
            lblGStyle.Size = new Size(1448, 58);
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
            styleGrid.Location = new Point(33, 358);
            styleGrid.Name = "styleGrid";
            styleGrid.Padding = new Padding(80, 0, 80, 0);
            styleGrid.RowCount = 2;
            styleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            styleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            styleGrid.Size = new Size(1448, 205);
            styleGrid.TabIndex = 4;
            // 
            // btnStyleSummer
            // 
            btnStyleSummer.BackColor = Color.Thistle;
            btnStyleSummer.Dock = DockStyle.Fill;
            btnStyleSummer.FlatAppearance.BorderSize = 0;
            btnStyleSummer.FlatStyle = FlatStyle.Flat;
            btnStyleSummer.Font = new Font("Segoe UI", 10F);
            btnStyleSummer.ForeColor = Color.Black;
            btnStyleSummer.Location = new Point(84, 4);
            btnStyleSummer.Margin = new Padding(4);
            btnStyleSummer.Name = "btnStyleSummer";
            btnStyleSummer.Size = new Size(249, 94);
            btnStyleSummer.TabIndex = 0;
            btnStyleSummer.Text = "Casual";
            btnStyleSummer.UseVisualStyleBackColor = false;
            // 
            // btnStWear
            // 
            btnStWear.BackColor = Color.Thistle;
            btnStWear.Dock = DockStyle.Fill;
            btnStWear.FlatAppearance.BorderSize = 0;
            btnStWear.FlatStyle = FlatStyle.Flat;
            btnStWear.Font = new Font("Segoe UI", 10F);
            btnStWear.ForeColor = Color.Black;
            btnStWear.Location = new Point(341, 4);
            btnStWear.Margin = new Padding(4);
            btnStWear.Name = "btnStWear";
            btnStWear.Size = new Size(249, 94);
            btnStWear.TabIndex = 1;
            btnStWear.Text = "Streetwear";
            btnStWear.UseVisualStyleBackColor = false;
            // 
            // btnMinimal
            // 
            btnMinimal.BackColor = Color.Thistle;
            btnMinimal.Dock = DockStyle.Fill;
            btnMinimal.FlatAppearance.BorderSize = 0;
            btnMinimal.FlatStyle = FlatStyle.Flat;
            btnMinimal.Font = new Font("Segoe UI", 10F);
            btnMinimal.ForeColor = Color.Black;
            btnMinimal.Location = new Point(598, 4);
            btnMinimal.Margin = new Padding(4);
            btnMinimal.Name = "btnMinimal";
            btnMinimal.Size = new Size(249, 94);
            btnMinimal.TabIndex = 2;
            btnMinimal.Text = "Minimalist";
            btnMinimal.UseVisualStyleBackColor = false;
            // 
            // btnRetro
            // 
            btnRetro.BackColor = Color.Thistle;
            btnRetro.Dock = DockStyle.Fill;
            btnRetro.FlatAppearance.BorderSize = 0;
            btnRetro.FlatStyle = FlatStyle.Flat;
            btnRetro.Font = new Font("Segoe UI", 10F);
            btnRetro.ForeColor = Color.Black;
            btnRetro.Location = new Point(855, 4);
            btnRetro.Margin = new Padding(4);
            btnRetro.Name = "btnRetro";
            btnRetro.Size = new Size(249, 94);
            btnRetro.TabIndex = 3;
            btnRetro.Text = "Retro";
            btnRetro.UseVisualStyleBackColor = false;
            // 
            // btnBusCasual
            // 
            btnBusCasual.BackColor = Color.Thistle;
            btnBusCasual.Dock = DockStyle.Fill;
            btnBusCasual.FlatAppearance.BorderSize = 0;
            btnBusCasual.FlatStyle = FlatStyle.Flat;
            btnBusCasual.Font = new Font("Segoe UI", 10F);
            btnBusCasual.ForeColor = Color.Black;
            btnBusCasual.Location = new Point(1112, 4);
            btnBusCasual.Margin = new Padding(4);
            btnBusCasual.Name = "btnBusCasual";
            btnBusCasual.Size = new Size(252, 94);
            btnBusCasual.TabIndex = 4;
            btnBusCasual.Text = "Business Casual";
            btnBusCasual.UseVisualStyleBackColor = false;
            // 
            // btnFormal
            // 
            btnFormal.BackColor = Color.Thistle;
            btnFormal.Dock = DockStyle.Fill;
            btnFormal.FlatAppearance.BorderSize = 0;
            btnFormal.FlatStyle = FlatStyle.Flat;
            btnFormal.Font = new Font("Segoe UI", 10F);
            btnFormal.ForeColor = Color.Black;
            btnFormal.Location = new Point(84, 106);
            btnFormal.Margin = new Padding(4);
            btnFormal.Name = "btnFormal";
            btnFormal.Size = new Size(249, 95);
            btnFormal.TabIndex = 5;
            btnFormal.Text = "Formal";
            btnFormal.UseVisualStyleBackColor = false;
            // 
            // btnVaca
            // 
            btnVaca.BackColor = Color.Thistle;
            btnVaca.Dock = DockStyle.Fill;
            btnVaca.FlatAppearance.BorderSize = 0;
            btnVaca.FlatStyle = FlatStyle.Flat;
            btnVaca.Font = new Font("Segoe UI", 10F);
            btnVaca.ForeColor = Color.Black;
            btnVaca.Location = new Point(341, 106);
            btnVaca.Margin = new Padding(4);
            btnVaca.Name = "btnVaca";
            btnVaca.Size = new Size(249, 95);
            btnVaca.TabIndex = 6;
            btnVaca.Text = "Vacation";
            btnVaca.UseVisualStyleBackColor = false;
            // 
            // btnRomantic
            // 
            btnRomantic.BackColor = Color.Thistle;
            btnRomantic.Dock = DockStyle.Fill;
            btnRomantic.FlatAppearance.BorderSize = 0;
            btnRomantic.FlatStyle = FlatStyle.Flat;
            btnRomantic.Font = new Font("Segoe UI", 10F);
            btnRomantic.ForeColor = Color.Black;
            btnRomantic.Location = new Point(598, 106);
            btnRomantic.Margin = new Padding(4);
            btnRomantic.Name = "btnRomantic";
            btnRomantic.Size = new Size(249, 95);
            btnRomantic.TabIndex = 7;
            btnRomantic.Text = "Romantic";
            btnRomantic.UseVisualStyleBackColor = false;
            // 
            // btnSporty
            // 
            btnSporty.BackColor = Color.Thistle;
            btnSporty.Dock = DockStyle.Fill;
            btnSporty.FlatAppearance.BorderSize = 0;
            btnSporty.FlatStyle = FlatStyle.Flat;
            btnSporty.Font = new Font("Segoe UI", 10F);
            btnSporty.ForeColor = Color.Black;
            btnSporty.Location = new Point(855, 106);
            btnSporty.Margin = new Padding(4);
            btnSporty.Name = "btnSporty";
            btnSporty.Size = new Size(249, 95);
            btnSporty.TabIndex = 8;
            btnSporty.Text = "Sporty";
            btnSporty.UseVisualStyleBackColor = false;
            // 
            // btnSmtCasual
            // 
            btnSmtCasual.BackColor = Color.Thistle;
            btnSmtCasual.Dock = DockStyle.Fill;
            btnSmtCasual.FlatAppearance.BorderSize = 0;
            btnSmtCasual.FlatStyle = FlatStyle.Flat;
            btnSmtCasual.Font = new Font("Segoe UI", 10F);
            btnSmtCasual.ForeColor = Color.Black;
            btnSmtCasual.Location = new Point(1112, 106);
            btnSmtCasual.Margin = new Padding(4);
            btnSmtCasual.Name = "btnSmtCasual";
            btnSmtCasual.Size = new Size(252, 95);
            btnSmtCasual.TabIndex = 9;
            btnSmtCasual.Text = "Smart Casual";
            btnSmtCasual.UseVisualStyleBackColor = false;
            // 
            // lblGColor
            // 
            lblGColor.Dock = DockStyle.Fill;
            lblGColor.Font = new Font("Komikazoom", 24F, FontStyle.Bold);
            lblGColor.ForeColor = Color.Indigo;
            lblGColor.Location = new Point(33, 566);
            lblGColor.Name = "lblGColor";
            lblGColor.Size = new Size(1448, 58);
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
            bottomColorPanel.Location = new Point(350, 648);
            bottomColorPanel.Name = "bottomColorPanel";
            bottomColorPanel.Size = new Size(814, 71);
            bottomColorPanel.TabIndex = 6;
            bottomColorPanel.WrapContents = false;
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
            clbColors.FormattingEnabled = true;
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
            titleLayout.ResumeLayout(false);
            windowButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EkisBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxiBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiniBtn).EndInit();
            seasonPanel.ResumeLayout(false);
            styleGrid.ResumeLayout(false);
            bottomColorPanel.ResumeLayout(false);
            colorDropdownPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}