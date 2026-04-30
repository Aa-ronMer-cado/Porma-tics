using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    public partial class GenerateFilter : Form
    {
        public GenerateFilter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GenerateFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            // Create an instance of the next form
            ConfirmGenerated nextForm = new ConfirmGenerated();

            // Show the next form
            nextForm.Show();

            // Optionally hide or close the current form
            this.Hide();   // hides current form
                           // this.Close(); // closes current form completely
        

    }
}
}
