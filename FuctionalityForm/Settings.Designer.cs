namespace Pormatics.FuctionalityForm
{
    partial class Settings
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
            settingsLabel = new Label();
            panel1 = new Panel();
            ReleaseDate = new Label();
            vScrollBar1 = new VScrollBar();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.BorderStyle = BorderStyle.Fixed3D;
            settingsLabel.Dock = DockStyle.Top;
            settingsLabel.FlatStyle = FlatStyle.Flat;
            settingsLabel.Font = new Font("Komikazoom", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsLabel.ForeColor = Color.Indigo;
            settingsLabel.Location = new Point(0, 0);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(249, 81);
            settingsLabel.TabIndex = 0;
            settingsLabel.Text = "SETTINGS";
            // 
            // panel1
            // 
            panel1.Controls.Add(ReleaseDate);
            panel1.Controls.Add(vScrollBar1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 413);
            panel1.TabIndex = 1;
            // 
            // ReleaseDate
            // 
            ReleaseDate.AutoSize = true;
            ReleaseDate.Location = new Point(27, 32);
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.Size = new Size(96, 20);
            ReleaseDate.TabIndex = 2;
            ReleaseDate.Text = "Release Date";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(1082, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 413);
            vScrollBar1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(1108, 112);
            panel2.TabIndex = 2;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1108, 585);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(settingsLabel);
            Name = "Settings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settingsLabel;
        private Panel panel1;
        private Panel panel2;
        private VScrollBar vScrollBar1;
        private Label ReleaseDate;
    }
}