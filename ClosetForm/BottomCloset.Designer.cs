namespace Pormatics.ClosetForm
{
    partial class BottomCloset
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
            addLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLabel.Location = new Point(0, 0);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(153, 25);
            addLabel.TabIndex = 0;
            addLabel.Text = "Add Clothes...";
            // 
            // BottomCloset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1179, 632);
            Controls.Add(addLabel);
            Name = "BottomCloset";
            Text = "BottomCloset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addLabel;
    }
}