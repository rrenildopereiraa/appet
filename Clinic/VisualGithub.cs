using System.Diagnostics;
namespace Clinic
{
    public partial class VisualGithub : Form
    {
        public VisualGithub()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Redireciona para o repositório GitHub numa nova jenela de um nabegador Web.
        /// </summary>
        /// <param name="sender">Utilizador</param>
        /// <param name="e">Evento</param>
        private void githubBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo si = new ProcessStartInfo("https://github.com/rrenildopereiraa/appet");
            Process.Start(si);
        }
    }
}
