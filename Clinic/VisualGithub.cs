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
        /// Redireciona para o repositório GitHub numa nova janela de um navegador Web.
        /// </summary>
        /// <param name="sender">Utilizador</param>
        /// <param name="e">Evento</param>
        private void githubBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo si = new ProcessStartInfo
            {
                FileName = "https://github.com/rrenildopereiraa/appet",
                UseShellExecute = true
            };
            Process.Start(si);
        }
    }
}
