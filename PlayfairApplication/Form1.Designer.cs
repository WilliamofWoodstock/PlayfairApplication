namespace PlayfairApplication
{
    partial class Form1
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
            title = new Label();
            modeBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Lucida Sans Unicode", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(42, 9);
            title.Name = "title";
            title.Size = new Size(695, 67);
            title.TabIndex = 0;
            title.Text = "The Playfair Application";
            // 
            // modeBox
            // 
            modeBox.Anchor = AnchorStyles.Top;
            modeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeBox.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeBox.FormattingEnabled = true;
            modeBox.Location = new Point(280, 138);
            modeBox.Name = "modeBox";
            modeBox.Size = new Size(218, 29);
            modeBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 114);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 2;
            label1.Text = "Mode/Language";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 744);
            Controls.Add(label1);
            Controls.Add(modeBox);
            Controls.Add(title);
            MinimumSize = new Size(800, 800);
            Name = "Form1";
            Text = "Playfair Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private ComboBox modeBox;
        private Label label1;
    }
}
