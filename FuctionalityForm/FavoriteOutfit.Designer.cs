namespace Pormatics.FuctionalityForm
{
    partial class FavoriteOutfit
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private FlowLayoutPanel flowFavorites;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            flowFavorites = new FlowLayoutPanel();

            SuspendLayout();

            // mainLayout
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 1;
            mainLayout.BackColor = Color.WhiteSmoke;
            mainLayout.Padding = new Padding(30, 20, 30, 30);
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // flowFavorites
            flowFavorites.Dock = DockStyle.Fill;
            flowFavorites.AutoScroll = true;
            flowFavorites.BackColor = Color.FromArgb(242, 235, 240);
            flowFavorites.BorderStyle = BorderStyle.FixedSingle;
            flowFavorites.FlowDirection = FlowDirection.LeftToRight;
            flowFavorites.WrapContents = true;
            flowFavorites.Padding = new Padding(15);

            mainLayout.Controls.Add(flowFavorites, 0, 0);

            Controls.Add(mainLayout);

            // FavoriteOutfit
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1197, 624);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FavoriteOutfit";
            Text = "FavoriteOutfit";

            ResumeLayout(false);
        }
    }
}