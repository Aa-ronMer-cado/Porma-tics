namespace Pormatics.FuctionalityForm
{
    partial class FavoriteOutfit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            favLabel = new Label();
            outfitFavPanel = new Panel();
            vScrollBar1 = new VScrollBar();
            outfitFavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // favLabel
            // 
            favLabel.AutoSize = true;
            favLabel.BorderStyle = BorderStyle.Fixed3D;
            favLabel.Dock = DockStyle.Top;
            favLabel.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            favLabel.Location = new Point(0, 0);
            favLabel.Name = "favLabel";
            favLabel.Size = new Size(344, 61);
            favLabel.TabIndex = 0;
            favLabel.Text = "Collections";
            // 
            // outfitFavPanel
            // 
            outfitFavPanel.Controls.Add(vScrollBar1);
            outfitFavPanel.Dock = DockStyle.Fill;
            outfitFavPanel.Location = new Point(0, 61);
            outfitFavPanel.Name = "outfitFavPanel";
            outfitFavPanel.Size = new Size(1159, 582);
            outfitFavPanel.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(1133, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 582);
            vScrollBar1.TabIndex = 0;
            // 
            // FavoriteOutfit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1159, 643);
            Controls.Add(outfitFavPanel);
            Controls.Add(favLabel);
            Name = "FavoriteOutfit";
            Text = "FavoriteClothes";
            outfitFavPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label favLabel;
        private Panel outfitFavPanel;
        private VScrollBar vScrollBar1;
    }
}