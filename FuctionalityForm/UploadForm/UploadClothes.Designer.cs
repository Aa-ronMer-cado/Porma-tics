namespace Pormatics.FuctionalityForm
{
    partial class UploadClothes
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
            nextButton = new Button();
            leftPanel = new Panel();
            rightPanel = new Panel();
            buttonPanel = new Panel();
            uploadBtn = new Button();
            removeBtn = new Button();
            mainPanel = new Panel();
            pictureBox1 = new PictureBox();
            bottomPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(nextButton);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 523);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1099, 104);
            bottomPanel.TabIndex = 0;
            // 
            // nextButton
            // 
            nextButton.Dock = DockStyle.Right;
            nextButton.Location = new Point(919, 0);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(180, 104);
            nextButton.TabIndex = 0;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(362, 523);
            leftPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(815, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(284, 523);
            rightPanel.TabIndex = 2;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(uploadBtn);
            buttonPanel.Controls.Add(removeBtn);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(362, 417);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(453, 106);
            buttonPanel.TabIndex = 3;
            // 
            // uploadBtn
            // 
            uploadBtn.Dock = DockStyle.Right;
            uploadBtn.Location = new Point(333, 0);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(120, 106);
            uploadBtn.TabIndex = 1;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            removeBtn.Dock = DockStyle.Left;
            removeBtn.Location = new Point(0, 0);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(121, 106);
            removeBtn.TabIndex = 0;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(362, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(453, 417);
            mainPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 417);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UploadClothes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1099, 627);
            Controls.Add(mainPanel);
            Controls.Add(buttonPanel);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Controls.Add(bottomPanel);
            Name = "UploadClothes";
            Text = "UploadClothes";
            bottomPanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private Button nextButton;
        private Panel leftPanel;
        private Panel rightPanel;
        private Panel buttonPanel;
        private Button uploadBtn;
        private Button removeBtn;
        private Panel mainPanel;
        private PictureBox pictureBox1;
    }
}