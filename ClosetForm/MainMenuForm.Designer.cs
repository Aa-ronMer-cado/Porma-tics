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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            bottomPanel = new Panel();
            favBtn = new PictureBox();
            generateOutfit = new PictureBox();
            uploadClothes = new PictureBox();
            mainCloset = new PictureBox();
            settings = new PictureBox();

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
            pictureBox1 = new PictureBox();

            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)favBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generateOutfit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uploadClothes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCloset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settings).BeginInit();
            closetTitle.SuspendLayout();
            clothesBtnPanel.SuspendLayout();
            closetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(244, 233, 233);
            bottomPanel.Controls.Add(favBtn);
            bottomPanel.Controls.Add(generateOutfit);
            bottomPanel.Controls.Add(uploadClothes);
            bottomPanel.Controls.Add(mainCloset);
            bottomPanel.Controls.Add(settings);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 564);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1164, 80);
            bottomPanel.TabIndex = 0;

            // 
            // settings
            // 
            settings.BackColor = Color.FromArgb(195, 180, 208);
            settings.Dock = DockStyle.Left;
            settings.Image = Properties.Resources.Settings;
            settings.Location = new Point(0, 0);
            settings.Name = "settings";
            settings.Size = new Size(233, 80);
            settings.SizeMode = PictureBoxSizeMode.Zoom;
            settings.TabIndex = 0;
            settings.TabStop = false;
            settings.Click += settings_Click;

            // 
            // mainCloset
            // 
            mainCloset.BackColor = Color.FromArgb(195, 180, 208);
            mainCloset.Dock = DockStyle.Left;
            mainCloset.Image = Properties.Resources.LogoRIl;
            mainCloset.Location = new Point(233, 0);
            mainCloset.Name = "mainCloset";
            mainCloset.Size = new Size(233, 80);
            mainCloset.SizeMode = PictureBoxSizeMode.Zoom;
            mainCloset.TabIndex = 1;
            mainCloset.TabStop = false;
            mainCloset.Click += mainCloset_Click;

            // 
            // uploadClothes
            // 
            uploadClothes.BackColor = Color.FromArgb(195, 180, 208);
            uploadClothes.Dock = DockStyle.Left;
            uploadClothes.Image = Properties.Resources.Add;
            uploadClothes.Location = new Point(466, 0);
            uploadClothes.Name = "uploadClothes";
            uploadClothes.Size = new Size(233, 80);
            uploadClothes.SizeMode = PictureBoxSizeMode.Zoom;
            uploadClothes.TabIndex = 2;
            uploadClothes.TabStop = false;
            uploadClothes.Click += uploadClothes_Click;

            // 
            // generateOutfit
            // 
            generateOutfit.BackColor = Color.FromArgb(195, 180, 208);
            generateOutfit.Dock = DockStyle.Left;
            generateOutfit.Image = Properties.Resources.closet;
            generateOutfit.Location = new Point(699, 0);
            generateOutfit.Name = "generateOutfit";
            generateOutfit.Size = new Size(233, 80);
            generateOutfit.SizeMode = PictureBoxSizeMode.Zoom;
            generateOutfit.TabIndex = 3;
            generateOutfit.TabStop = false;
            generateOutfit.Click += generateOutfit_Click;

            // 
            // favBtn
            // 
            favBtn.BackColor = Color.FromArgb(195, 180, 208);
            favBtn.Dock = DockStyle.Fill;
            favBtn.Image = Properties.Resources.faver;
            favBtn.Location = new Point(932, 0);
            favBtn.Name = "favBtn";
            favBtn.Size = new Size(232, 80);
            favBtn.SizeMode = PictureBoxSizeMode.Zoom;
            favBtn.TabIndex = 4;
            favBtn.TabStop = false;
            favBtn.Click += favBtn_Click;

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
            minimizeBtn.Font = new Font("Microsoft Sans Serif", 12F);
            minimizeBtn.Location = new Point(1072, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(30, 73);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.Text = "_";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;

            // 
            // maximizeBtn
            // 
            maximizeBtn.Dock = DockStyle.Right;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.Font = new Font("Microsoft Sans Serif", 12F);
            maximizeBtn.Location = new Point(1102, 0);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(30, 73);
            maximizeBtn.TabIndex = 1;
            maximizeBtn.Text = "□";
            maximizeBtn.UseVisualStyleBackColor = true;
            maximizeBtn.Click += maximizeBtn_Click;

            // 
            // closeBtn
            // 
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Microsoft Sans Serif", 12F);
            closeBtn.Location = new Point(1132, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 73);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 30F);
            label1.ForeColor = Color.FromArgb(59, 58, 90);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(200, 59);
            label1.TabIndex = 0;
            label1.Text = "CLOSET";

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
            // allClothesBtn
            // 
            allClothesBtn.BackColor = Color.White;
            allClothesBtn.Dock = DockStyle.Left;
            allClothesBtn.FlatAppearance.BorderSize = 0;
            allClothesBtn.FlatStyle = FlatStyle.Flat;
            allClothesBtn.Location = new Point(0, 0);
            allClothesBtn.Name = "allClothesBtn";
            allClothesBtn.Size = new Size(233, 70);
            allClothesBtn.TabIndex = 0;
            allClothesBtn.Text = "ALL";
            allClothesBtn.UseVisualStyleBackColor = false;
            allClothesBtn.Click += allClothesBtn_Click;

            // 
            // topBtn
            // 
            topBtn.BackColor = Color.White;
            topBtn.Dock = DockStyle.Left;
            topBtn.FlatAppearance.BorderSize = 0;
            topBtn.FlatStyle = FlatStyle.Flat;
            topBtn.Location = new Point(233, 0);
            topBtn.Name = "topBtn";
            topBtn.Size = new Size(233, 70);
            topBtn.TabIndex = 1;
            topBtn.Text = "TOPS";
            topBtn.UseVisualStyleBackColor = false;
            topBtn.Click += topBtn_Click;

            // 
            // bottomBtn
            // 
            bottomBtn.BackColor = Color.White;
            bottomBtn.Dock = DockStyle.Left;
            bottomBtn.FlatAppearance.BorderSize = 0;
            bottomBtn.FlatStyle = FlatStyle.Flat;
            bottomBtn.Location = new Point(466, 0);
            bottomBtn.Name = "bottomBtn";
            bottomBtn.Size = new Size(233, 70);
            bottomBtn.TabIndex = 2;
            bottomBtn.Text = "BOTTOMS";
            bottomBtn.UseVisualStyleBackColor = false;
            bottomBtn.Click += bottomBtn_Click;

            // 
            // shoesBtn
            // 
            shoesBtn.BackColor = Color.White;
            shoesBtn.Dock = DockStyle.Left;
            shoesBtn.FlatAppearance.BorderSize = 0;
            shoesBtn.FlatStyle = FlatStyle.Flat;
            shoesBtn.Location = new Point(699, 0);
            shoesBtn.Name = "shoesBtn";
            shoesBtn.Size = new Size(233, 70);
            shoesBtn.TabIndex = 3;
            shoesBtn.Text = "SHOES";
            shoesBtn.UseVisualStyleBackColor = false;
            shoesBtn.Click += shoesBtn_Click;

            // 
            // accesoriesBtn
            // 
            accesoriesBtn.BackColor = Color.White;
            accesoriesBtn.Dock = DockStyle.Left;
            accesoriesBtn.FlatAppearance.BorderSize = 0;
            accesoriesBtn.FlatStyle = FlatStyle.Flat;
            accesoriesBtn.Location = new Point(932, 0);
            accesoriesBtn.Name = "accesoriesBtn";
            accesoriesBtn.Size = new Size(232, 70);
            accesoriesBtn.TabIndex = 4;
            accesoriesBtn.Text = "ACCESSORIES";
            accesoriesBtn.UseVisualStyleBackColor = false;
            accesoriesBtn.Click += accesoriesBtn_Click;

            // 
            // closetPanel
            // 
            closetPanel.BackColor = Color.FromArgb(244, 233, 233);
            closetPanel.Controls.Add(pictureBox1);
            closetPanel.Dock = DockStyle.Fill;
            closetPanel.Location = new Point(0, 145);
            closetPanel.Name = "closetPanel";
            closetPanel.Size = new Size(1164, 419);
            closetPanel.TabIndex = 3;

            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

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
            ((System.ComponentModel.ISupportInitialize)generateOutfit).EndInit();
            ((System.ComponentModel.ISupportInitialize)uploadClothes).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCloset).EndInit();
            ((System.ComponentModel.ISupportInitialize)settings).EndInit();
            closetTitle.ResumeLayout(false);
            closetTitle.PerformLayout();
            clothesBtnPanel.ResumeLayout(false);
            closetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private Panel closetTitle;
        private Panel clothesBtnPanel;
        private Panel closetPanel;

        private Button accesoriesBtn;
        private Button shoesBtn;
        private Button bottomBtn;
        private Button topBtn;
        private Button allClothesBtn;

        private Button maximizeBtn;
        private Button minimizeBtn;
        private Button closeBtn;

        private Label label1;

        private PictureBox favBtn;
        private PictureBox generateOutfit;
        private PictureBox uploadClothes;
        private PictureBox mainCloset;
        private PictureBox settings;
        private PictureBox pictureBox1;
    }
}

