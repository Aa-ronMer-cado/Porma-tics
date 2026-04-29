namespace Pormatics.FuctionalityForm
{
    partial class GenerateOutfit
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
            topPanel = new Panel();
            titleLabel = new Label();
            titleLabel2 = new Label();
            seasonPanel = new Panel();
            stylePanel = new Panel();
            colorPanel = new Panel();
            generateBtn = new Button();
            seasonLabel = new Label();
            styleLabel = new Label();
            colorLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            bottomPanel.SuspendLayout();
            topPanel.SuspendLayout();
            seasonPanel.SuspendLayout();
            stylePanel.SuspendLayout();
            colorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.BorderStyle = BorderStyle.FixedSingle;
            bottomPanel.Controls.Add(generateBtn);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 545);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1163, 86);
            bottomPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(titleLabel2);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1163, 94);
            topPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Verdana", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(3, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(229, 45);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Generator";
            titleLabel.Click += label1_Click;
            // 
            // titleLabel2
            // 
            titleLabel2.AutoSize = true;
            titleLabel2.Font = new Font("Segoe UI", 10F);
            titleLabel2.Location = new Point(12, 54);
            titleLabel2.Name = "titleLabel2";
            titleLabel2.Size = new Size(287, 23);
            titleLabel2.TabIndex = 3;
            titleLabel2.Text = "Pick your style you want to generate";
            // 
            // seasonPanel
            // 
            seasonPanel.Controls.Add(button2);
            seasonPanel.Controls.Add(button1);
            seasonPanel.Controls.Add(seasonLabel);
            seasonPanel.Dock = DockStyle.Top;
            seasonPanel.Location = new Point(0, 94);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(1163, 156);
            seasonPanel.TabIndex = 2;
            // 
            // stylePanel
            // 
            stylePanel.Controls.Add(styleLabel);
            stylePanel.Dock = DockStyle.Top;
            stylePanel.Location = new Point(0, 250);
            stylePanel.Name = "stylePanel";
            stylePanel.Size = new Size(1163, 157);
            stylePanel.TabIndex = 3;
            // 
            // colorPanel
            // 
            colorPanel.Controls.Add(comboBox1);
            colorPanel.Controls.Add(colorLabel);
            colorPanel.Dock = DockStyle.Top;
            colorPanel.Location = new Point(0, 407);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(1163, 139);
            colorPanel.TabIndex = 4;
            // 
            // generateBtn
            // 
            generateBtn.Dock = DockStyle.Right;
            generateBtn.Location = new Point(1067, 0);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(94, 84);
            generateBtn.TabIndex = 0;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Location = new Point(535, 14);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(56, 20);
            seasonLabel.TabIndex = 0;
            seasonLabel.Text = "Season";
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Location = new Point(550, 14);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new Size(41, 20);
            styleLabel.TabIndex = 0;
            styleLabel.Text = "Style";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(546, 15);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(45, 20);
            colorLabel.TabIndex = 0;
            colorLabel.Text = "Color";
            // 
            // button1
            // 
            button1.Location = new Point(358, 80);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(710, 80);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(490, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // GenerateOutfit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1163, 631);
            Controls.Add(colorPanel);
            Controls.Add(stylePanel);
            Controls.Add(seasonPanel);
            Controls.Add(topPanel);
            Controls.Add(bottomPanel);
            Name = "GenerateOutfit";
            Text = "GenerateClothes";
            bottomPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            seasonPanel.ResumeLayout(false);
            seasonPanel.PerformLayout();
            stylePanel.ResumeLayout(false);
            stylePanel.PerformLayout();
            colorPanel.ResumeLayout(false);
            colorPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private Panel topPanel;
        private Label titleLabel;
        private Label titleLabel2;
        private Button generateBtn;
        private Panel seasonPanel;
        private Panel stylePanel;
        private Panel colorPanel;
        private Button button2;
        private Button button1;
        private Label seasonLabel;
        private Label styleLabel;
        private Label colorLabel;
        private ComboBox comboBox1;
    }
}