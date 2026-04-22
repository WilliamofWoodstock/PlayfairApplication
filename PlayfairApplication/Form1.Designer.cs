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
            label1 = new Label();
            label2 = new Label();
            playfairGrid = new Panel();
            playfairGrid.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Lucida Sans Unicode", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(97, 7);
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
            modeBox.Location = new Point(303, 110);
            modeBox.Margin = new Padding(2);
            modeBox.Name = "modeBox";
            modeBox.Size = new Size(175, 26);
            modeBox.TabIndex = 1;
            // 
            // modeLabel
            // 
            modeLabel.Anchor = AnchorStyles.Top;
            modeLabel.AutoSize = true;
            modeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modeLabel.Location = new Point(327, 91);
            modeLabel.Margin = new Padding(2, 0, 2, 0);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(127, 18);
            modeLabel.TabIndex = 2;
            modeLabel.Text = "Mode/Language";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("MS Reference Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(100, 100);
            label1.TabIndex = 4;
            label1.Tag = "";
            label1.Text = "L";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("MS Reference Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(100, 100);
            label2.TabIndex = 5;
            label2.Tag = "";
            label2.Text = "P";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playfairGrid
            // 
            playfairGrid.Controls.Add(label2);
            playfairGrid.Controls.Add(label1);
            playfairGrid.Location = new Point(154, 205);
            playfairGrid.Name = "playfairGrid";
            playfairGrid.Size = new Size(500, 500);
            playfairGrid.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 853);
            Controls.Add(playfairGrid);
            Controls.Add(modeLabel);
            Controls.Add(modeBox);
            Controls.Add(title);
            Margin = new Padding(2);
            MinimumSize = new Size(800, 900);
            Name = "Form1";
            Text = "Playfair Application";
            playfairGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private ComboBox modeBox;
        private Label modeLabel;
        private Label label1;
        private Label label2;
        private Panel playfairGrid;
    }
}
