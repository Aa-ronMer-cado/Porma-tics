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
            closetBtnCtrl = new Panel();
            panelTitle = new Panel();
            title = new Label();
            MiniBtn = new PictureBox();
            MaxiBtn = new PictureBox();
            EkisBtn = new PictureBox();
            clothesBtnPanel = new Panel();
            accesoriesBtn = new Button();
            shoesBtn = new Button();
            bottomBtn = new Button();
            topBtn = new Button();
            allClothesBtn = new Button();
            closetPanel = new Panel();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)favBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generateOutfit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uploadClothes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCloset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settings).BeginInit();
            closetBtnCtrl.SuspendLayout();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxiBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EkisBtn).BeginInit();
            clothesBtnPanel.SuspendLayout();
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
            // closetBtnCtrl
            // 
            closetBtnCtrl.BackColor = Color.FromArgb(244, 233, 233);
            closetBtnCtrl.BorderStyle = BorderStyle.FixedSingle;
            closetBtnCtrl.Controls.Add(panelTitle);
            closetBtnCtrl.Controls.Add(MiniBtn);
            closetBtnCtrl.Controls.Add(MaxiBtn);
            closetBtnCtrl.Controls.Add(EkisBtn);
            closetBtnCtrl.Dock = DockStyle.Top;
            closetBtnCtrl.Location = new Point(0, 0);
            closetBtnCtrl.Name = "closetBtnCtrl";
            closetBtnCtrl.Size = new Size(1164, 102);
            closetBtnCtrl.TabIndex = 1;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(title);
            panelTitle.Dock = DockStyle.Left;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(260, 100);
            panelTitle.TabIndex = 4;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Left;
            title.Font = new Font("Komikazoom", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(59, 58, 90);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(266, 105);
            title.TabIndex = 0;
            title.Text = "CLOSET";
            title.Click += label1_Click;
            // 
            // MiniBtn
            // 
            MiniBtn.Dock = DockStyle.Right;
            MiniBtn.Image = Properties.Resources.mini;
            MiniBtn.Location = new Point(1011, 0);
            MiniBtn.Name = "MiniBtn";
            MiniBtn.Size = new Size(50, 100);
            MiniBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MiniBtn.TabIndex = 3;
            MiniBtn.TabStop = false;
            MiniBtn.Click += MiniBtn_Click;
            // 
            // MaxiBtn
            // 
            MaxiBtn.Dock = DockStyle.Right;
            MaxiBtn.Image = Properties.Resources.maxi;
            MaxiBtn.Location = new Point(1061, 0);
            MaxiBtn.Name = "MaxiBtn";
            MaxiBtn.Size = new Size(51, 100);
            MaxiBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MaxiBtn.TabIndex = 1;
            MaxiBtn.TabStop = false;
            MaxiBtn.Click += MaxiBtn_Click;
            // 
            // EkisBtn
            // 
            EkisBtn.Dock = DockStyle.Right;
            EkisBtn.Image = Properties.Resources.close;
            EkisBtn.Location = new Point(1112, 0);
            EkisBtn.Name = "EkisBtn";
            EkisBtn.Size = new Size(50, 100);
            EkisBtn.SizeMode = PictureBoxSizeMode.Zoom;
            EkisBtn.TabIndex = 2;
            EkisBtn.TabStop = false;
            EkisBtn.Click += EkisBtn_Click;
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
            clothesBtnPanel.Location = new Point(0, 102);
            clothesBtnPanel.Name = "clothesBtnPanel";
            clothesBtnPanel.Size = new Size(1164, 70);
            clothesBtnPanel.TabIndex = 2;
            // 
            // accesoriesBtn
            // 
            accesoriesBtn.BackColor = Color.White;
            accesoriesBtn.Dock = DockStyle.Left;
            accesoriesBtn.FlatAppearance.BorderSize = 0;
            accesoriesBtn.FlatStyle = FlatStyle.Flat;
            accesoriesBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            accesoriesBtn.ForeColor = Color.Indigo;
            accesoriesBtn.Location = new Point(932, 0);
            accesoriesBtn.Name = "accesoriesBtn";
            accesoriesBtn.Size = new Size(232, 70);
            accesoriesBtn.TabIndex = 4;
            accesoriesBtn.Text = "ACCESSORIES";
            accesoriesBtn.UseVisualStyleBackColor = false;
            accesoriesBtn.Click += accesoriesBtn_Click;
            // 
            // shoesBtn
            // 
            shoesBtn.BackColor = Color.White;
            shoesBtn.Dock = DockStyle.Left;
            shoesBtn.FlatAppearance.BorderSize = 0;
            shoesBtn.FlatStyle = FlatStyle.Flat;
            shoesBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            shoesBtn.ForeColor = Color.Indigo;
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
            bottomBtn.BackColor = Color.White;
            bottomBtn.Dock = DockStyle.Left;
            bottomBtn.FlatAppearance.BorderSize = 0;
            bottomBtn.FlatStyle = FlatStyle.Flat;
            bottomBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            bottomBtn.ForeColor = Color.Indigo;
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
            topBtn.BackColor = Color.White;
            topBtn.Dock = DockStyle.Left;
            topBtn.FlatAppearance.BorderSize = 0;
            topBtn.FlatStyle = FlatStyle.Flat;
            topBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            topBtn.ForeColor = Color.Indigo;
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
            allClothesBtn.BackColor = Color.White;
            allClothesBtn.Dock = DockStyle.Left;
            allClothesBtn.FlatAppearance.BorderSize = 0;
            allClothesBtn.FlatStyle = FlatStyle.Flat;
            allClothesBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            allClothesBtn.ForeColor = Color.Indigo;
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
            closetPanel.Location = new Point(0, 172);
            closetPanel.Name = "closetPanel";
            closetPanel.Size = new Size(1164, 392);
            closetPanel.TabIndex = 3;
            closetPanel.Paint += closetPanel_Paint;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 644);
            Controls.Add(closetPanel);
            Controls.Add(clothesBtnPanel);
            Controls.Add(closetBtnCtrl);
            Controls.Add(bottomPanel);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)favBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)generateOutfit).EndInit();
            ((System.ComponentModel.ISupportInitialize)uploadClothes).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCloset).EndInit();
            ((System.ComponentModel.ISupportInitialize)settings).EndInit();
            closetBtnCtrl.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxiBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)EkisBtn).EndInit();
            clothesBtnPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private Panel closetBtnCtrl;
        private Panel clothesBtnPanel;
        private Panel closetPanel;

        private Button accesoriesBtn;
        private Button shoesBtn;
        private Button bottomBtn;
        private Button topBtn;
        private Button allClothesBtn;

        private Label title;

        private PictureBox favBtn;
        private PictureBox generateOutfit;
        private PictureBox uploadClothes;
        private PictureBox mainCloset;
        private PictureBox settings;
        private PictureBox MiniBtn;
        private PictureBox EkisBtn;
        private PictureBox MaxiBtn;
        private Panel panelTitle;
    }
}

