namespace Clinic
{
    public partial class VisualMenu : Form
    {   
        public VisualMenu()
        {
            InitializeComponent();
        }

        private void getStartedBtn_Click(object sender, EventArgs e)
        {
            VisualClient client = new VisualClient();
            client.Show();
        }

        private void viewGitHubBtn_Click(object sender, EventArgs e)
        {
            VisualGithub visualGithub = new VisualGithub();
            visualGithub.Show();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            VisualClient client = new VisualClient();
            client.Show();
        }

        private void animalBtn_Click(object sender, EventArgs e)
        {
            VisualAnimal animal = new VisualAnimal();
            animal.Show();
        }

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            VisualAppointment appointment = new VisualAppointment();
            appointment.Show();
        }

        private void vetBtn_Click(object sender, EventArgs e)
        {
            VisualVet visualVet = new VisualVet();
            visualVet.Show();
        }

        private void observatoryBtn_Click(object sender, EventArgs e)
        {
            VisualObservatory observatory = new VisualObservatory();
            observatory.Show();
        }
    }
}
