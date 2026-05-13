namespace Pormatics.ClosetForm
{
    partial class BottomCloset
    {
        private System.ComponentModel.IContainer components = null;
        private Label addLabel;

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
            addLabel = new Label();

            SuspendLayout();

            // addLabel
            addLabel.AutoSize = true;
            addLabel.Dock = DockStyle.Top;
            addLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLabel.Location = new Point(14, 14);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(153, 25);
            addLabel.TabIndex = 0;
            addLabel.Text = "Add Clothes...";

            // BottomCloset
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            Controls.Add(addLabel);
            Name = "BottomCloset";
            Size = new Size(1565, 807);

            Controls.SetChildIndex(addLabel, 0);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}