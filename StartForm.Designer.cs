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
            startBtn = new Button();
            startPanel = new Panel();
            logoPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            startPanel.SuspendLayout();
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
            logoPic.Size = new Size(1173, 465);
            logoPic.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPic.TabIndex = 0;
            logoPic.TabStop = false;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(195, 180, 208);
            startBtn.Dock = DockStyle.Fill;
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Location = new Point(0, 0);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(1173, 165);
            startBtn.TabIndex = 1;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // startPanel
            // 
            startPanel.Controls.Add(startBtn);
            startPanel.Dock = DockStyle.Bottom;
            startPanel.Location = new Point(0, 465);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(1173, 165);
            startPanel.TabIndex = 2;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(logoPic);
            logoPanel.Dock = DockStyle.Fill;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(1173, 465);
            logoPanel.TabIndex = 3;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1173, 630);
            Controls.Add(logoPanel);
            Controls.Add(startPanel);
            Name = "StartForm";
            Text = "PORMATICS";
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            startPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoPic;
        private Button startBtn;
        private Panel startPanel;
        private Panel logoPanel;
    }
}
