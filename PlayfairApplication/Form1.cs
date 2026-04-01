namespace PlayfairApplication
{
    public partial class Form1 : Form
    {
        public readonly string[] modeOptions = { "English", "German", "Bulgarian Cyrillic", "Tajik Persian"};
        public Form1()
        {
            InitializeComponent();
            modeBox.Items.AddRange(modeOptions);
            modeBox.SelectedIndex = 0;
        }

        private void Mode_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
    }
}
