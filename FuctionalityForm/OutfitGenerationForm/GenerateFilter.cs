using Pormatics.Models;
using Pormatics.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    public partial class GenerateFilter : Form
    {
        public event Action<OutfitFilter, GeneratedOutfit>? OutfitGenerated;

        private string selectedSeason = string.Empty;
        private string selectedStyle = string.Empty;

        private readonly Color defaultButtonColor = Color.Thistle;
        private readonly Color selectedButtonColor = Color.SlateBlue;

        public GenerateFilter()
        {
            InitializeComponent();
            SetupEvents();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            int seasonButtonWidth = Math.Max(180, ClientSize.Width / 6);
            int seasonButtonHeight = Math.Max(45, ClientSize.Height / 13);

            btnSummer.Size = new Size(seasonButtonWidth, seasonButtonHeight);
            btnRainy.Size = new Size(seasonButtonWidth, seasonButtonHeight);

            btnNext.Size = new Size(
                Math.Max(120, ClientSize.Width / 10),
                Math.Max(40, ClientSize.Height / 14)
            );

            drpColor.Width = Math.Max(300, ClientSize.Width / 3);
        }

        private void SetupEvents()
        {
            btnSummer.Click += (s, e) => SelectSeason("Summer", btnSummer);
            btnRainy.Click += (s, e) => SelectSeason("Rainy", btnRainy);
            btnStyleSummer.Click += (s, e) => SelectStyle("Casual", btnStyleSummer);
            btnStWear.Click += (s, e) => SelectStyle("Streetwear", btnStWear);
            btnMinimal.Click += (s, e) => SelectStyle("Minimalist", btnMinimal);
            btnRetro.Click += (s, e) => SelectStyle("Retro", btnRetro);
            btnBusCasual.Click += (s, e) => SelectStyle("Business Casual", btnBusCasual);
            btnFormal.Click += (s, e) => SelectStyle("Formal", btnFormal);
            btnVaca.Click += (s, e) => SelectStyle("Vacation", btnVaca);
            btnRomantic.Click += (s, e) => SelectStyle("Romantic", btnRomantic);
            btnSporty.Click += (s, e) => SelectStyle("Sporty", btnSporty);
            btnSmtCasual.Click += (s, e) => SelectStyle("Smart Casual", btnSmtCasual);
        }

        private void SelectSeason(string season, Button selectedButton)
        {
            selectedSeason = season;

            ResetSeasonButtons();

            selectedButton.BackColor = selectedButtonColor;
            selectedButton.ForeColor = Color.White;
        }

        private void SelectStyle(string style, Button selectedButton)
        {
            selectedStyle = style;

            ResetStyleButtons();

            selectedButton.BackColor = selectedButtonColor;
            selectedButton.ForeColor = Color.White;
        }

        private void ResetSeasonButtons()
        {
            ResetButton(btnSummer);
            ResetButton(btnRainy);
        }

        private void ResetStyleButtons()
        {
            ResetButton(btnStyleSummer);
            ResetButton(btnStWear);
            ResetButton(btnMinimal);
            ResetButton(btnRetro);
            ResetButton(btnBusCasual);
            ResetButton(btnFormal);
            ResetButton(btnVaca);
            ResetButton(btnRomantic);
            ResetButton(btnSporty);
            ResetButton(btnSmtCasual);
        }

        private void ResetButton(Button button)
        {
            button.BackColor = defaultButtonColor;
            button.ForeColor = Color.Black;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string selectedColor = drpColor.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedSeason))
            {
                MessageBox.Show("Please select a season.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedStyle))
            {
                MessageBox.Show("Please select a style.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedColor))
            {
                MessageBox.Show("Please select a color.");
                return;
            }

            OutfitFilter filter = new OutfitFilter
            {
                Season = selectedSeason,
                Style = selectedStyle,
                Color = selectedColor
            };

            try
            {
                GeneratedOutfit outfit = OutfitGeneratorService.GenerateOutfit(filter);

                OutfitGenerated?.Invoke(filter, outfit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cannot Generate Outfit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void GenerateFilter_Load(object sender, EventArgs e)
        {
            drpColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void mainLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drpColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}