namespace Pormatics
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            mainMenu.LoadDefault(); // auto-selects closetBtn and loads ClosetForm
            this.Hide();
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoPic_Click(object sender, EventArgs e)
        {

        }

        private void startPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}