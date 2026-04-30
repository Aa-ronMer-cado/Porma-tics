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

        private void label1_Click(object sender, EventArgs e) { }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
            form.Show();
            this.Hide();
        }

        private void filterLabel_Click(object sender, EventArgs e) { }
        private void seasonLabel_Click(object sender, EventArgs e) { }
        private void stylePanel_Paint(object sender, PaintEventArgs e) { }
        private void UploadFilter_Load(object sender, EventArgs e)
        {
            // Enable owner draw mode
            //comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            // Attach the DrawItem event
            //comboBox1.DrawItem += comboBox1_DrawItem;
        }

        private void lblGenerateFilter_Click(object sender, EventArgs e) { }
        private void lblGenerateFilter_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        // 🔹 Custom DrawItem handler to center text
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox combo = (ComboBox)sender;
            string text = combo.Items[e.Index].ToString();

            // Draw background (handles highlight when selected)
            e.DrawBackground();

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;       // Horizontal center
                sf.LineAlignment = StringAlignment.Center;   // Vertical center

                e.Graphics.DrawString(text, combo.Font, new SolidBrush(combo.ForeColor),
                                      e.Bounds, sf);
            }

            // Draw focus rectangle if needed
            e.DrawFocusRectangle();
        }

        private void btnSummer_Click(object sender, EventArgs e)
        {

        }
    }
}
