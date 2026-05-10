using Pormatics.Models;
using Pormatics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    public partial class GenerateFilter : Form
    {
        public event Action<OutfitFilter, GeneratedOutfit>? OutfitGenerated;

        private string selectedSeason = string.Empty;
        private readonly List<string> selectedStyles = new();
        private readonly List<string> selectedColors = new();

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

            colorDropdownPanel.Width = Math.Max(300, ClientSize.Width / 3);
            btnColorDropdown.Width = colorDropdownPanel.Width;
            clbColors.Width = colorDropdownPanel.Width;
        }

        private void SetupEvents()
        {
            btnSummer.Click += (s, e) => SelectSeason("Summer", btnSummer);
            btnRainy.Click += (s, e) => SelectSeason("Rainy", btnRainy);

            btnStyleSummer.Click += (s, e) => ToggleStyle("Casual", btnStyleSummer);
            btnStWear.Click += (s, e) => ToggleStyle("Streetwear", btnStWear);
            btnMinimal.Click += (s, e) => ToggleStyle("Minimalist", btnMinimal);
            btnRetro.Click += (s, e) => ToggleStyle("Retro", btnRetro);
            btnBusCasual.Click += (s, e) => ToggleStyle("Business Casual", btnBusCasual);
            btnFormal.Click += (s, e) => ToggleStyle("Formal", btnFormal);
            btnVaca.Click += (s, e) => ToggleStyle("Vacation", btnVaca);
            btnRomantic.Click += (s, e) => ToggleStyle("Romantic", btnRomantic);
            btnSporty.Click += (s, e) => ToggleStyle("Sporty", btnSporty);
            btnSmtCasual.Click += (s, e) => ToggleStyle("Smart Casual", btnSmtCasual);

            btnColorDropdown.Click += btnColorDropdown_Click;
            clbColors.ItemCheck += clbColors_ItemCheck;
        }

        private void SelectSeason(string season, Button selectedButton)
        {
            selectedSeason = season;

            ResetButton(btnSummer);
            ResetButton(btnRainy);

            selectedButton.BackColor = selectedButtonColor;
            selectedButton.ForeColor = Color.White;
        }

        private void ToggleStyle(string style, Button button)
        {
            if (selectedStyles.Contains(style))
            {
                selectedStyles.Remove(style);
                ResetButton(button);
            }
            else
            {
                selectedStyles.Add(style);
                button.BackColor = selectedButtonColor;
                button.ForeColor = Color.White;
            }
        }

        private void ResetButton(Button button)
        {
            button.BackColor = defaultButtonColor;
            button.ForeColor = Color.Black;
        }

        private void btnColorDropdown_Click(object sender, EventArgs e)
        {
            clbColors.Visible = !clbColors.Visible;

            colorDropdownPanel.Height = clbColors.Visible ? 170 : 45;
        }

        private void clbColors_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                selectedColors.Clear();

                foreach (object item in clbColors.CheckedItems)
                {
                    if (item != null)
                        selectedColors.Add(item.ToString()!);
                }

                btnColorDropdown.Text =
                    selectedColors.Count == 0
                    ? "Select Colors ▼"
                    : string.Join(", ", selectedColors) + " ▼";
            });
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            selectedColors.Clear();

            foreach (object item in clbColors.CheckedItems)
            {
                if (item != null)
                    selectedColors.Add(item.ToString()!);
            }

            if (string.IsNullOrWhiteSpace(selectedSeason))
            {
                MessageBox.Show("Please select a season.");
                return;
            }

            if (selectedStyles.Count == 0)
            {
                MessageBox.Show("Please select at least one style.");
                return;
            }

            if (selectedColors.Count == 0)
            {
                MessageBox.Show("Please select at least one color.");
                return;
            }

            OutfitFilter filter = new OutfitFilter
            {
                Season = selectedSeason,
                Styles = new List<string>(selectedStyles),
                Colors = new List<string>(selectedColors)
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

        private void lblGenerateFilter_Click(object sender, EventArgs e)
        {

        }

        private void lblGSeason_Click(object sender, EventArgs e)
        {

        }

        private void bottomColorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSummer_Click(object sender, EventArgs e)
        {

        }

        private void clbColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}