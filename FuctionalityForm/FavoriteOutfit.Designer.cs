namespace Pormatics.FuctionalityForm
{
    partial class FavoriteOutfit
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel headerLayout;

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
            mainLayout = new TableLayoutPanel();
            headerLayout = new TableLayoutPanel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            flowFavorites = new FlowLayoutPanel();

            SuspendLayout();

            mainLayout.Dock = DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 2;
            mainLayout.BackColor = Color.WhiteSmoke;
            mainLayout.Padding = new Padding(35, 25, 35, 35);
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));

            headerLayout.Dock = DockStyle.Fill;
            headerLayout.ColumnCount = 1;
            headerLayout.RowCount = 2;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));

            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Komikazoom", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Text = "Favorite Outfits";
            lblTitle.TextAlign = ContentAlignment.BottomLeft;

            lblSubtitle.Dock = DockStyle.Fill;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Indigo;
            lblSubtitle.Text = "Saved outfits you liked will appear here.";
            lblSubtitle.TextAlign = ContentAlignment.TopLeft;

            headerLayout.Controls.Add(lblTitle, 0, 0);
            headerLayout.Controls.Add(lblSubtitle, 0, 1);

            flowFavorites.Dock = DockStyle.Fill;
            flowFavorites.AutoScroll = true;
            flowFavorites.BackColor = Color.FromArgb(242, 235, 240);
            flowFavorites.BorderStyle = BorderStyle.FixedSingle;
            flowFavorites.FlowDirection = FlowDirection.LeftToRight;
            flowFavorites.Padding = new Padding(15);
            flowFavorites.WrapContents = true;

            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(flowFavorites, 0, 1);

            Controls.Add(mainLayout);

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