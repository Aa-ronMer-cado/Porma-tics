namespace Pormatics
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            mainMenu.LoadDefault(); // auto-selects closetBtn and loads ClosetForm
            this.Hide();
        }
    }
}