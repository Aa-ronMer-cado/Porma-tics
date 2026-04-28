using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    public partial class UploadFilter : Form
    {
        public UploadFilter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
            form.Show();

            this.Hide();
        }
    }
}
