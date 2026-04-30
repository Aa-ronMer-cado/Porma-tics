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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnBrowse = new Button();
            btnReset = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(341, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 354);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 36);
            label1.Name = "label1";
            label1.Size = new Size(388, 23);
            label1.TabIndex = 1;
            label1.Text = "Upload your clothes here...";
            label1.Click += label1_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.MediumOrchid;
            btnBrowse.Font = new Font("Lucida Console", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(585, 450);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(269, 85);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Thistle;
            btnReset.Font = new Font("Lucida Console", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(265, 450);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(269, 85);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SlateBlue;
            btnNext.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(971, 569);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // UploadClothes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1099, 627);
            Controls.Add(btnNext);
            Controls.Add(btnReset);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UploadClothes";
            Text = "UploadClothes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnBrowse;
        private Button btnReset;
        private Button btnNext;
    }
}