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
            uploadBtn = new Button();
            removeBtn = new Button();
            mainPanel = new Panel();
            pictureBox1 = new PictureBox();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uploadBtn
            // 
            uploadBtn.Location = new Point(727, 401);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(120, 106);
            uploadBtn.TabIndex = 1;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(342, 401);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(121, 106);
            removeBtn.TabIndex = 0;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(removeBtn);
            mainPanel.Controls.Add(uploadBtn);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1099, 627);
            mainPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1099, 627);
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
            Name = "UploadClothes";
            Text = "UploadClothes";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button uploadBtn;
        private Button removeBtn;
        private Panel mainPanel;
        private PictureBox pictureBox1;
    }
}