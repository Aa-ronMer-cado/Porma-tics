namespace Pormatics
{
    partial class MainMenuForm
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
            bottomPanel = new Panel();
            generateOutfitBtn = new Button();
            favBtn = new PictureBox();
            uploadClothesBtn = new Button();
            closetBtn = new Button();
            settingBtn = new Button();
            favoriteBtn = new Button();
            closetTitle = new Panel();
            minimizeBtn = new Button();
            maximizeBtn = new Button();
            closeBtn = new Button();
            label1 = new Label();
            clothesBtnPanel = new Panel();
            accesoriesBtn = new Button();
            shoesBtn = new Button();
            bottomBtn = new Button();
            topBtn = new Button();
            allClothesBtn = new Button();
            closetPanel = new Panel();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)favBtn).BeginInit();
            closetTitle.SuspendLayout();
            clothesBtnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(244, 233, 233);
            bottomPanel.Controls.Add(favoriteBtn);
            bottomPanel.Controls.Add(generateOutfitBtn);
            bottomPanel.Controls.Add(favBtn);
            bottomPanel.Controls.Add(uploadClothesBtn);
            bottomPanel.Controls.Add(closetBtn);
            bottomPanel.Controls.Add(settingBtn);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 564);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1164, 80);
            bottomPanel.TabIndex = 0;
            // 
            // generateOutfitBtn
            // 
            generateOutfitBtn.BackColor = Color.FromArgb(195, 180, 208);
            generateOutfitBtn.Dock = DockStyle.Left;
            generateOutfitBtn.FlatAppearance.BorderSize = 0;
            generateOutfitBtn.FlatStyle = FlatStyle.Flat;
            generateOutfitBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            generateOutfitBtn.ForeColor = SystemColors.ActiveCaptionText;
            generateOutfitBtn.Location = new Point(689, 0);
            generateOutfitBtn.Name = "generateOutfitBtn";
            generateOutfitBtn.Size = new Size(228, 80);
            generateOutfitBtn.TabIndex = 3;
            generateOutfitBtn.Text = "Generate Outfit";
            generateOutfitBtn.UseVisualStyleBackColor = false;
            generateOutfitBtn.Click += generateOutfitBtn_Click;
            // 
            // favBtn
            // 
            favBtn.BackColor = Color.FromArgb(195, 180, 208);
            favBtn.Dock = DockStyle.Right;
            favBtn.Image = Properties.Resources.faver;
            favBtn.Location = new Point(1049, 0);
            favBtn.Name = "favBtn";
            favBtn.Size = new Size(115, 80);
            favBtn.SizeMode = PictureBoxSizeMode.Zoom;
            favBtn.TabIndex = 0;
            favBtn.TabStop = false;
            favBtn.Click += favBtn_Click;
            // 
            // uploadClothesBtn
            // 
            uploadClothesBtn.BackColor = Color.FromArgb(195, 180, 208);
            uploadClothesBtn.Dock = DockStyle.Left;
            uploadClothesBtn.FlatAppearance.BorderSize = 0;
            uploadClothesBtn.FlatStyle = FlatStyle.Flat;
            uploadClothesBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            uploadClothesBtn.ForeColor = SystemColors.ActiveCaptionText;
            uploadClothesBtn.Location = new Point(461, 0);
            uploadClothesBtn.Name = "uploadClothesBtn";
            uploadClothesBtn.Size = new Size(228, 80);
            uploadClothesBtn.TabIndex = 2;
            uploadClothesBtn.Text = "Upload Clothes";
            uploadClothesBtn.UseVisualStyleBackColor = false;
            uploadClothesBtn.Click += uploadClothesBtn_Click;
            // 
            // closetBtn
            // 
            closetBtn.BackColor = Color.FromArgb(195, 180, 208);
            closetBtn.Dock = DockStyle.Left;
            closetBtn.FlatAppearance.BorderSize = 0;
            closetBtn.FlatStyle = FlatStyle.Flat;
            closetBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            closetBtn.ForeColor = SystemColors.ActiveCaptionText;
            closetBtn.Location = new Point(233, 0);
            closetBtn.Name = "closetBtn";
            closetBtn.Size = new Size(228, 80);
            closetBtn.TabIndex = 1;
            closetBtn.Text = "Closet";
            closetBtn.UseVisualStyleBackColor = false;
            closetBtn.Click += closetBtn_Click;
            // 
            // settingBtn
            // 
            settingBtn.BackColor = Color.FromArgb(195, 180, 208);
            settingBtn.Dock = DockStyle.Left;
            settingBtn.FlatAppearance.BorderSize = 0;
            settingBtn.FlatStyle = FlatStyle.Flat;
            settingBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            settingBtn.ForeColor = SystemColors.ActiveCaptionText;
            settingBtn.Location = new Point(0, 0);
            settingBtn.Name = "settingBtn";
            settingBtn.Size = new Size(233, 80);
            settingBtn.TabIndex = 0;
            settingBtn.Text = "Settings";
            settingBtn.UseVisualStyleBackColor = false;
            settingBtn.Click += settingBtn_Click;
            // 
            // favoriteBtn
            // 
            favoriteBtn.BackColor = Color.FromArgb(195, 180, 208);
            favoriteBtn.Dock = DockStyle.Right;
            favoriteBtn.FlatAppearance.BorderSize = 0;
            favoriteBtn.FlatStyle = FlatStyle.Flat;
            favoriteBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            favoriteBtn.ForeColor = SystemColors.ActiveCaptionText;
            favoriteBtn.Image = Properties.Resources.faver;
            favoriteBtn.Location = new Point(916, 0);
            favoriteBtn.Name = "favoriteBtn";
            favoriteBtn.Size = new Size(133, 80);
            favoriteBtn.TabIndex = 4;
            favoriteBtn.Text = "Favourites";
            favoriteBtn.UseVisualStyleBackColor = false;
            favoriteBtn.Click += favoriteBtn_Click;
            // 
            // closetTitle
            // 
            closetTitle.BackColor = Color.FromArgb(244, 233, 233);
            closetTitle.BorderStyle = BorderStyle.FixedSingle;
            closetTitle.Controls.Add(minimizeBtn);
            closetTitle.Controls.Add(maximizeBtn);
            closetTitle.Controls.Add(closeBtn);
            closetTitle.Controls.Add(label1);
            closetTitle.Dock = DockStyle.Top;
            closetTitle.Location = new Point(0, 0);
            closetTitle.Name = "closetTitle";
            closetTitle.Size = new Size(1164, 75);
            closetTitle.TabIndex = 1;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizeBtn.Location = new Point(1072, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(30, 73);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.Text = "O";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Dock = DockStyle.Right;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maximizeBtn.Location = new Point(1102, 0);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(30, 73);
            maximizeBtn.TabIndex = 1;
            maximizeBtn.Text = "O";
            maximizeBtn.UseVisualStyleBackColor = true;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(1132, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 73);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "O";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(59, 58, 90);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(200, 59);
            label1.TabIndex = 0;
            label1.Text = "CLOSET";
            label1.Click += label1_Click;
            // 
            // clothesBtnPanel
            // 
            clothesBtnPanel.BackColor = SystemColors.ControlLight;
            clothesBtnPanel.Controls.Add(accesoriesBtn);
            clothesBtnPanel.Controls.Add(shoesBtn);
            clothesBtnPanel.Controls.Add(bottomBtn);
            clothesBtnPanel.Controls.Add(topBtn);
            clothesBtnPanel.Controls.Add(allClothesBtn);
            clothesBtnPanel.Dock = DockStyle.Top;
            clothesBtnPanel.Location = new Point(0, 75);
            clothesBtnPanel.Name = "clothesBtnPanel";
            clothesBtnPanel.Size = new Size(1164, 70);
            clothesBtnPanel.TabIndex = 2;
            // 
            // accesoriesBtn
            // 
            accesoriesBtn.BackColor = SystemColors.ButtonHighlight;
            accesoriesBtn.Dock = DockStyle.Left;
            accesoriesBtn.FlatAppearance.BorderSize = 0;
            accesoriesBtn.FlatStyle = FlatStyle.Flat;
            accesoriesBtn.ForeColor = SystemColors.Desktop;
            accesoriesBtn.Location = new Point(932, 0);
            accesoriesBtn.Name = "accesoriesBtn";
            accesoriesBtn.Size = new Size(232, 70);
            accesoriesBtn.TabIndex = 4;
            accesoriesBtn.Text = "ACCESORIES";
            accesoriesBtn.UseVisualStyleBackColor = false;
            accesoriesBtn.Click += accesoriesBtn_Click;
            // 
            // shoesBtn
            // 
            shoesBtn.BackColor = SystemColors.ButtonHighlight;
            shoesBtn.Dock = DockStyle.Left;
            shoesBtn.FlatAppearance.BorderSize = 0;
            shoesBtn.FlatStyle = FlatStyle.Flat;
            shoesBtn.ForeColor = SystemColors.Desktop;
            shoesBtn.Location = new Point(699, 0);
            shoesBtn.Name = "shoesBtn";
            shoesBtn.Size = new Size(233, 70);
            shoesBtn.TabIndex = 3;
            shoesBtn.Text = "SHOES";
            shoesBtn.UseVisualStyleBackColor = false;
            shoesBtn.Click += shoesBtn_Click;
            // 
            // bottomBtn
            // 
            bottomBtn.BackColor = SystemColors.ButtonHighlight;
            bottomBtn.Dock = DockStyle.Left;
            bottomBtn.FlatAppearance.BorderSize = 0;
            bottomBtn.FlatStyle = FlatStyle.Flat;
            bottomBtn.ForeColor = SystemColors.Desktop;
            bottomBtn.Location = new Point(466, 0);
            bottomBtn.Name = "bottomBtn";
            bottomBtn.Size = new Size(233, 70);
            bottomBtn.TabIndex = 2;
            bottomBtn.Text = "BOTTOMS";
            bottomBtn.UseVisualStyleBackColor = false;
            bottomBtn.Click += bottomBtn_Click;
            // 
            // topBtn
            // 
            topBtn.BackColor = SystemColors.ButtonHighlight;
            topBtn.Dock = DockStyle.Left;
            topBtn.FlatAppearance.BorderSize = 0;
            topBtn.FlatStyle = FlatStyle.Flat;
            topBtn.ForeColor = SystemColors.Desktop;
            topBtn.Location = new Point(233, 0);
            topBtn.Name = "topBtn";
            topBtn.Size = new Size(233, 70);
            topBtn.TabIndex = 1;
            topBtn.Text = "TOPS";
            topBtn.UseVisualStyleBackColor = false;
            topBtn.Click += topBtn_Click;
            // 
            // allClothesBtn
            // 
            allClothesBtn.BackColor = SystemColors.ButtonHighlight;
            allClothesBtn.Dock = DockStyle.Left;
            allClothesBtn.FlatAppearance.BorderSize = 0;
            allClothesBtn.FlatStyle = FlatStyle.Flat;
            allClothesBtn.ForeColor = SystemColors.Desktop;
            allClothesBtn.Location = new Point(0, 0);
            allClothesBtn.Name = "allClothesBtn";
            allClothesBtn.Size = new Size(233, 70);
            allClothesBtn.TabIndex = 0;
            allClothesBtn.Text = "ALL";
            allClothesBtn.UseVisualStyleBackColor = false;
            allClothesBtn.Click += allClothesBtn_Click;
            // 
            // closetPanel
            // 
            closetPanel.BackColor = Color.FromArgb(244, 233, 233);
            closetPanel.Dock = DockStyle.Fill;
            closetPanel.Location = new Point(0, 145);
            closetPanel.Name = "closetPanel";
            closetPanel.Size = new Size(1164, 419);
            closetPanel.TabIndex = 3;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 644);
            Controls.Add(closetPanel);
            Controls.Add(clothesBtnPanel);
            Controls.Add(closetTitle);
            Controls.Add(bottomPanel);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)favBtn).EndInit();
            closetTitle.ResumeLayout(false);
            closetTitle.PerformLayout();
            clothesBtnPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private Panel closetTitle;
        private Panel clothesBtnPanel;
        private Button settingBtn;
        private Button favoriteBtn;
        private Button generateOutfitBtn;
        private Button uploadClothesBtn;
        private Button closetBtn;
        private Button accesoriesBtn;
        private Button shoesBtn;
        private Button bottomBtn;
        private Button topBtn;
        private Button allClothesBtn;
        private Panel closetPanel;
        private Label label1;
        private Button maximizeBtn;
        private Button closeBtn;
        private Button minimizeBtn;
        private PictureBox favBtn;
    }
}