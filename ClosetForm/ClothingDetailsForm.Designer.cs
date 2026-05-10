namespace Pormatics.ClosetForm
{
    partial class ClothingDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private PictureBox picturePreview;
        private Label lblSeason;
        private Label lblStyle;
        private Label lblColor;
        private ComboBox cmbSeason;
        private ComboBox cmbStyle;
        private ComboBox cmbColor;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                picturePreview?.Image?.Dispose();

                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            picturePreview = new PictureBox();
            lblSeason = new Label();
            lblStyle = new Label();
            lblColor = new Label();
            cmbSeason = new ComboBox();
            cmbStyle = new ComboBox();
            cmbColor = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePreview).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(65, 56, 97);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Clothing Details";
            // 
            // picturePreview
            // 
            picturePreview.BackColor = Color.FromArgb(237, 230, 245);
            picturePreview.BorderStyle = BorderStyle.FixedSingle;
            picturePreview.Location = new Point(35, 75);
            picturePreview.Name = "picturePreview";
            picturePreview.Size = new Size(220, 250);
            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            picturePreview.TabIndex = 1;
            picturePreview.TabStop = false;
            // 
            // lblSeason
            // 
            lblSeason.AutoSize = true;
            lblSeason.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeason.ForeColor = Color.FromArgb(99, 90, 131);
            lblSeason.Location = new Point(300, 85);
            lblSeason.Name = "lblSeason";
            lblSeason.Size = new Size(65, 23);
            lblSeason.TabIndex = 2;
            lblSeason.Text = "Season";
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStyle.ForeColor = Color.FromArgb(99, 90, 131);
            lblStyle.Location = new Point(300, 160);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(50, 23);
            lblStyle.TabIndex = 4;
            lblStyle.Text = "Style";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColor.ForeColor = Color.FromArgb(99, 90, 131);
            lblColor.Location = new Point(300, 235);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(53, 23);
            lblColor.TabIndex = 6;
            lblColor.Text = "Color";
            // 
            // cmbSeason
            // 
            cmbSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeason.Items.AddRange(new object[] { "Summer", "Rainy" });
            cmbSeason.Location = new Point(300, 115);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(250, 28);
            cmbSeason.TabIndex = 3;
            // 
            // cmbStyle
            // 
            cmbStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStyle.Items.AddRange(new object[] { "Casual", "Streetwear", "Minimalist", "Retro", "Business Casual", "Formal", "Vacation", "Romantic", "Sporty", "Smart Casual" });
            cmbStyle.Location = new Point(300, 190);
            cmbStyle.Name = "cmbStyle";
            cmbStyle.Size = new Size(250, 28);
            cmbStyle.TabIndex = 5;
            // 
            // cmbColor
            // 
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.Items.AddRange(new object[] { "White", "Black", "Blue", "Brown", "Pink", "Green", "Red", "Gray", "Yellow", "Multi" });
            cmbColor.Location = new Point(300, 265);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(250, 28);
            cmbColor.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(99, 90, 131);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(300, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 38);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 90, 90);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(435, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 38);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(99, 90, 131);
            btnClose.Location = new Point(35, 330);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 38);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ClothingDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 235, 240);
            ClientSize = new Size(590, 400);
            Controls.Add(lblTitle);
            Controls.Add(picturePreview);
            Controls.Add(lblSeason);
            Controls.Add(cmbSeason);
            Controls.Add(lblStyle);
            Controls.Add(cmbStyle);
            Controls.Add(lblColor);
            Controls.Add(cmbColor);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClothingDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clothing Details";
            ((System.ComponentModel.ISupportInitialize)picturePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}