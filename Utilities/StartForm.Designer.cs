using System.Drawing;
using System.Windows.Forms;

namespace Pormatics
{
    partial class StartForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private PictureBox logoPic;
        private Label lblTitle;
        private Button startBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            mainLayout = new TableLayoutPanel();
            logoPic = new PictureBox();
            lblTitle = new Label();
            startBtn = new Button();
            mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(244, 233, 233);
            mainLayout.ColumnCount = 3;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainLayout.Controls.Add(logoPic, 1, 1);
            mainLayout.Controls.Add(lblTitle, 1, 2);
            mainLayout.Controls.Add(startBtn, 1, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(40, 20, 40, 40);
            mainLayout.RowCount = 5;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            mainLayout.Size = new Size(1173, 630);
            mainLayout.TabIndex = 0;
            // 
            // logoPic
            // 
            logoPic.BackColor = Color.FromArgb(244, 233, 233);
            logoPic.Dock = DockStyle.Fill;
            logoPic.Image = (Image)resources.GetObject("logoPic.Image");
            logoPic.Location = new Point(313, 52);
            logoPic.Margin = new Padding(0);
            logoPic.Name = "logoPic";
            logoPic.Size = new Size(546, 254);
            logoPic.TabIndex = 0;
            logoPic.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Komikazoom", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(313, 306);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(546, 65);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "PORMATICS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(195, 180, 208);
            startBtn.Cursor = Cursors.Hand;
            startBtn.Dock = DockStyle.Fill;
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startBtn.ForeColor = Color.FromArgb(45, 38, 64);
            startBtn.Location = new Point(373, 386);
            startBtn.Margin = new Padding(60, 15, 60, 15);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(426, 65);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            startBtn.MouseEnter += startBtn_MouseEnter;
            startBtn.MouseLeave += startBtn_MouseLeave;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1173, 630);
            Controls.Add(mainLayout);
            MinimumSize = new Size(900, 600);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PORMATICS";
            mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            ResumeLayout(false);
        }
    }
}