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
            rightPanel = new Panel();
            leftPanel = new Panel();
            panel3 = new Panel();
            startBtn = new Button();
            bottomPanel = new Panel();
            btnPanel = new Panel();
            logoPanel = new Panel();
            pictureBox1 = new PictureBox();
            leftPanel.SuspendLayout();
            btnPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(680, 450);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(493, 180);
            rightPanel.TabIndex = 4;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panel3);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 450);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(505, 180);
            leftPanel.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(250, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 7;
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
            // bottomPanel
            // 
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(505, 533);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(175, 97);
            bottomPanel.TabIndex = 6;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(startBtn);
            btnPanel.Dock = DockStyle.Bottom;
            btnPanel.Location = new Point(505, 448);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(175, 85);
            btnPanel.TabIndex = 7;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(pictureBox1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(1173, 450);
            logoPanel.TabIndex = 3;
            logoPanel.Paint += logoPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(493, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            leftPanel.ResumeLayout(false);
            btnPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel rightPanel;
        private Panel leftPanel;
        private Panel panel3;
        private Button startBtn;
        private Panel bottomPanel;
        private Panel btnPanel;
        private Panel logoPanel;
        private PictureBox pictureBox1;
    }
}
