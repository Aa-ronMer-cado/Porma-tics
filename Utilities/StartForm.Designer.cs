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
            mainLayout = new TableLayoutPanel();
            logoPic = new PictureBox();
            lblTitle = new Label();
            startBtn = new Button();

            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            SuspendLayout();

            // mainLayout
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.BackColor = Color.FromArgb(244, 233, 233);
            mainLayout.ColumnCount = 3;
            mainLayout.RowCount = 5;
            mainLayout.Padding = new Padding(40, 20, 40, 40);

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            // logoPic
            logoPic.Dock = DockStyle.Fill;
            logoPic.BackColor = Color.FromArgb(244, 233, 233);
            logoPic.Margin = new Padding(0);
            logoPic.SizeMode = PictureBoxSizeMode.Normal;
            logoPic.TabStop = false;

            // lblTitle
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Text = "PORMATICS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Font = new Font("Komikazoom", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Margin = new Padding(0);

            // startBtn
            startBtn.Dock = DockStyle.Fill;
            startBtn.Text = "Start";
            startBtn.BackColor = Color.FromArgb(195, 180, 208);
            startBtn.ForeColor = Color.FromArgb(45, 38, 64);
            startBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.Cursor = Cursors.Hand;
            startBtn.Margin = new Padding(60, 15, 60, 15);
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            startBtn.MouseEnter += startBtn_MouseEnter;
            startBtn.MouseLeave += startBtn_MouseLeave;

            // add controls
            mainLayout.Controls.Add(logoPic, 1, 1);
            mainLayout.Controls.Add(lblTitle, 1, 2);
            mainLayout.Controls.Add(startBtn, 1, 3);

            // StartForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1173, 630);
            Controls.Add(mainLayout);
            MinimumSize = new Size(900, 600);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PORMATICS";

            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            ResumeLayout(false);
        }
    }
}