namespace Pormatics.FuctionalityForm.OutfitGenerationForm
{
    partial class UploadFilter
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
            panel1 = new Panel();
            filterLabel = new Label();
            seasonPanel = new Panel();
            button2 = new Button();
            summerBtn = new Button();
            seasonLabel = new Label();
            stylePanel = new Panel();
            styleLabel = new Label();
            colorPanel = new Panel();
            colorLabel = new Label();
            typePanel = new Panel();
            typeLabel = new Label();
            doneBtn = new Button();
            btnPanel = new Panel();
            panel1.SuspendLayout();
            seasonPanel.SuspendLayout();
            stylePanel.SuspendLayout();
            colorPanel.SuspendLayout();
            typePanel.SuspendLayout();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(filterLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 49);
            panel1.TabIndex = 0;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Dock = DockStyle.Top;
            filterLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterLabel.Location = new Point(0, 0);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(236, 33);
            filterLabel.TabIndex = 0;
            filterLabel.Text = "CLOTHES FILTER";
            // 
            // seasonPanel
            // 
            seasonPanel.Controls.Add(button2);
            seasonPanel.Controls.Add(summerBtn);
            seasonPanel.Controls.Add(seasonLabel);
            seasonPanel.Dock = DockStyle.Top;
            seasonPanel.Location = new Point(0, 49);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(1160, 152);
            seasonPanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(824, 59);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Rainy";
            button2.UseVisualStyleBackColor = true;
            // 
            // summerBtn
            // 
            summerBtn.Location = new Point(291, 59);
            summerBtn.Name = "summerBtn";
            summerBtn.Size = new Size(94, 29);
            summerBtn.TabIndex = 2;
            summerBtn.Text = "Summer";
            summerBtn.UseVisualStyleBackColor = true;
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Dock = DockStyle.Top;
            seasonLabel.FlatStyle = FlatStyle.Flat;
            seasonLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seasonLabel.Location = new Point(0, 0);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(117, 33);
            seasonLabel.TabIndex = 1;
            seasonLabel.Text = "Season";
            // 
            // stylePanel
            // 
            stylePanel.Controls.Add(styleLabel);
            stylePanel.Dock = DockStyle.Top;
            stylePanel.Location = new Point(0, 201);
            stylePanel.Name = "stylePanel";
            stylePanel.Size = new Size(1160, 197);
            stylePanel.TabIndex = 2;
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Dock = DockStyle.Top;
            styleLabel.FlatStyle = FlatStyle.Flat;
            styleLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            styleLabel.Location = new Point(0, 0);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new Size(96, 33);
            styleLabel.TabIndex = 1;
            styleLabel.Text = "Style";
            // 
            // colorPanel
            // 
            colorPanel.Controls.Add(colorLabel);
            colorPanel.Dock = DockStyle.Top;
            colorPanel.Location = new Point(0, 398);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(1160, 101);
            colorPanel.TabIndex = 4;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Dock = DockStyle.Top;
            colorLabel.FlatStyle = FlatStyle.Flat;
            colorLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorLabel.Location = new Point(0, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(102, 33);
            colorLabel.TabIndex = 1;
            colorLabel.Text = "Color";
            // 
            // typePanel
            // 
            typePanel.Controls.Add(typeLabel);
            typePanel.Dock = DockStyle.Top;
            typePanel.Location = new Point(0, 499);
            typePanel.Name = "typePanel";
            typePanel.Size = new Size(1160, 93);
            typePanel.TabIndex = 5;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.CausesValidation = false;
            typeLabel.Dock = DockStyle.Top;
            typeLabel.FlatStyle = FlatStyle.Flat;
            typeLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeLabel.Location = new Point(0, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(83, 33);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type";
            // 
            // doneBtn
            // 
            doneBtn.Location = new Point(1054, 19);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(94, 29);
            doneBtn.TabIndex = 6;
            doneBtn.Text = "Done";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(doneBtn);
            btnPanel.Dock = DockStyle.Bottom;
            btnPanel.Location = new Point(0, 592);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(1160, 75);
            btnPanel.TabIndex = 7;
            // 
            // UploadFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 233, 233);
            ClientSize = new Size(1160, 667);
            Controls.Add(btnPanel);
            Controls.Add(typePanel);
            Controls.Add(colorPanel);
            Controls.Add(stylePanel);
            Controls.Add(seasonPanel);
            Controls.Add(panel1);
            Name = "UploadFilter";
            Text = "UploadFilter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            seasonPanel.ResumeLayout(false);
            seasonPanel.PerformLayout();
            stylePanel.ResumeLayout(false);
            stylePanel.PerformLayout();
            colorPanel.ResumeLayout(false);
            colorPanel.PerformLayout();
            typePanel.ResumeLayout(false);
            typePanel.PerformLayout();
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label filterLabel;
        private Panel seasonPanel;
        private Panel stylePanel;
        private Panel colorPanel;
        private Panel typePanel;
        private Label seasonLabel;
        private Label styleLabel;
        private Label colorLabel;
        private Label typeLabel;
        private Button button2;
        private Button summerBtn;
        private Button doneBtn;
        private Panel btnPanel;
    }
}