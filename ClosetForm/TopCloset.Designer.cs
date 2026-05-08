namespace Pormatics.ClosetForm
{
    partial class TopCloset
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
            addLabel = new Label();
            SuspendLayout();
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Dock = DockStyle.Top;
            addLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLabel.Location = new Point(14, 14);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(153, 25);
            addLabel.TabIndex = 0;
            addLabel.Text = "Add Clothes...";
            // 
            // TopCloset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            Controls.Add(addLabel);
            Name = "TopCloset";
            Size = new Size(1565, 807);
            Controls.SetChildIndex(addLabel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addLabel;
    }
}