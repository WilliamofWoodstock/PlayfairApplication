namespace PlayfairApplication
{
    public partial class Form1 : Form
    {
        public readonly string[] modeOptions = { "English", "German", "Polish", "Bulgarian", "Russian", "Tajik Persian" };

        Label[][] gridENG = new Label[5][];

        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Center();
            modeBox.Items.AddRange(modeOptions);
            modeBox.SelectedIndex = 0;

            for(int i = 0; i < 5; i++)
            {
                gridENG[i] = new Label[5];
            }
        }

        private void Center()
        {
            int formWidth = ClientSize.Width;
            title.Location = new Point((formWidth - title.Size.Width) / 2, title.Location.Y);
            modeLabel.Location = new Point((formWidth - modeLabel.Size.Width) / 2, modeLabel.Location.Y);
            modeBox.Location = new Point((formWidth - modeBox.Size.Width) / 2, modeBox.Location.Y);
            playfairGrid.Location = new Point((formWidth - playfairGrid.Size.Width) / 2, playfairGrid.Location.Y);
        }
    }
}
