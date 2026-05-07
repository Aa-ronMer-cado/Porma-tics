namespace Pormatics.FuctionalityForm
{
    partial class FavoriteOutfit
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private FlowLayoutPanel flowFavorites;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            flowFavorites = new FlowLayoutPanel();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Komikazoom", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(395, 70);
            lblTitle.Text = "Favorite Outfits";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Indigo;
            lblSubtitle.Location = new Point(34, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(330, 28);
            lblSubtitle.Text = "Saved outfits you liked will appear here.";

            // flowFavorites
            flowFavorites.AutoScroll = true;
            flowFavorites.BackColor = Color.FromArgb(242, 235, 240);
            flowFavorites.BorderStyle = BorderStyle.FixedSingle;
            flowFavorites.FlowDirection = FlowDirection.LeftToRight;
            flowFavorites.Location = new Point(35, 145);
            flowFavorites.Name = "flowFavorites";
            flowFavorites.Padding = new Padding(15);
            flowFavorites.Size = new Size(1125, 435);
            flowFavorites.TabIndex = 2;
            flowFavorites.WrapContents = true;

            // FavoriteOutfit
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1197, 624);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(flowFavorites);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FavoriteOutfit";
            Text = "FavoriteOutfit";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}