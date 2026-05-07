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
            gridENG[0][0] = label1ENG; gridENG[0][1] = label2ENG; gridENG[0][2] = label3ENG; gridENG[0][3] = label4ENG; gridENG[0][4] = label5ENG;
            gridENG[1][0] = label6ENG; gridENG[1][1] = label7ENG; gridENG[1][2] = label8ENG; gridENG[1][3] = label9ENG; gridENG[1][4] = label10ENG;
            gridENG[2][0] = label11ENG; gridENG[2][1] = label12ENG; gridENG[2][2] = label13ENG; gridENG[2][3] = label14ENG; gridENG[2][4] = label15ENG;
            gridENG[3][0] = label16ENG; gridENG[3][1] = label17ENG; gridENG[3][2] = label18ENG; gridENG[3][3] = label19ENG; gridENG[3][4] = label20ENG;
            gridENG[4][0] = label21ENG; gridENG[4][1] = label22ENG; gridENG[4][2] = label23ENG; gridENG[4][3] = label24ENG; gridENG[4][4] = label25ENG;
        }

        private void Center()
        {
            int formWidth = ClientSize.Width;
            title.Location = new Point((formWidth - title.Size.Width) / 2, title.Location.Y);
            modeLabel.Location = new Point((formWidth - modeLabel.Size.Width) / 2, modeLabel.Location.Y);
            modeBox.Location = new Point((formWidth - modeBox.Size.Width) / 2, modeBox.Location.Y);
            playfairGrid.Location = new Point((formWidth - playfairGrid.Size.Width) / 2, playfairGrid.Location.Y);
            scrambleButton.Location = new Point((formWidth - scrambleButton.Size.Width) / 2, scrambleButton.Location.Y);
        }
    }
}
