namespace Pormatics
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoPic = new PictureBox();
            logoPanel = new Panel();
            startBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            logoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoPic
            // 
            logoPic.BackgroundImageLayout = ImageLayout.None;
            logoPic.Dock = DockStyle.Fill;
            logoPic.Image = Properties.Resources.LOGO1;
            logoPic.Location = new Point(0, 0);
            logoPic.Name = "logoPic";
            logoPic.Size = new Size(850, 450);
            logoPic.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPic.TabIndex = 0;
            logoPic.TabStop = false;
            logoPic.Click += logoPic_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(logoPic);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(850, 450);
            logoPanel.TabIndex = 3;
            logoPanel.Paint += logoPanel_Paint;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(195, 180, 208);
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Location = new Point(313, 456);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(226, 85);
            startBtn.TabIndex = 1;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // StartForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(850, 593);
            Controls.Add(startBtn);
            Controls.Add(logoPanel);
            Name = "StartForm";
            Text = "PORMATICS";
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            logoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoPic;
        private Panel logoPanel;
        private Button startBtn;
    }
}
