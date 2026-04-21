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
            modeLabel = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Lucida Sans Unicode", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(34, 7);
            title.Margin = new Padding(2, 0, 2, 0);
            title.Name = "title";
            title.Size = new Size(591, 57);
            title.TabIndex = 0;
            title.Text = "The Playfair Application";
            // 
            // modeBox
            // 
            modeBox.Anchor = AnchorStyles.Top;
            modeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeBox.FormattingEnabled = true;
            modeBox.Location = new Point(224, 110);
            modeBox.Margin = new Padding(2, 2, 2, 2);
            modeBox.Name = "modeBox";
            modeBox.Size = new Size(175, 26);
            modeBox.TabIndex = 1;
            // 
            // modeLabel
            // 
            modeLabel.Anchor = AnchorStyles.Top;
            modeLabel.AutoSize = true;
            modeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modeLabel.Location = new Point(246, 91);
            modeLabel.Margin = new Padding(2, 0, 2, 0);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(127, 18);
            modeLabel.TabIndex = 2;
            modeLabel.Text = "Mode/Language";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 602);
            Controls.Add(modeLabel);
            Controls.Add(modeBox);
            Controls.Add(title);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(644, 649);
            Name = "Form1";
            Text = "Playfair Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private ComboBox modeBox;
        private Label modeLabel;
    }
}
