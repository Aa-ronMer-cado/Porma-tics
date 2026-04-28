using Pormatics.FuctionalityForm.OutfitGenerationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm
{
    public partial class UploadClothes : Form
    {
        public UploadClothes()
        {
            InitializeComponent();
            this.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            UploadFilter filter = new UploadFilter();
            filter.Show();

            this.Hide();
        }
    }
}
