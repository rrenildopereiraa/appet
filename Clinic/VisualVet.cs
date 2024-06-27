using Lib;

namespace Clinic
{
    public partial class VisualVet : Form
    {
        private List<Vet> vets;
        private string vetFile = "vets.txt";

        public VisualVet()
        {
            InitializeComponent();
            vets = new List<Vet>();
            LoadData();
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(vetFile);

            foreach (var rowData in data)
            {
                vets.Add(new Vet
                {
                    Id = Convert.ToInt32(rowData[0]),
                    Name = rowData[1],
                    Specialization = rowData[2],
                    Phone = rowData[3]
                });
            }

            RefreshVetList();
        }

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var vet in vets)
            {
                data.Add(new string[] { 
                    vet.Id.ToString(), 
                    vet.Name, 
                    vet.Specialization, 
                    vet.Phone 
                });
            }

            FileHandler.SaveData(data, vetFile);
        }

        /// <summary>
        /// Obtém a lista de veterinários do ficheiro - vets.txt
        /// </summary>
        /// <returns>Retorna a lista de veterinários(as).</returns>
        public static List<Vet> GetVets()
        {
            VisualVet vv = new VisualVet();
            return vv.vets;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Vet vet = new Vet
                {
                    Id = GetNextVetId(),
                    Name = nameInp.Text,
                    Specialization = specializationInp.Text,
                    Phone = phoneInp.Text
                };

                vets.Add(vet);
                SaveData();
                RefreshVetList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Vet selectedVet = (Vet)vetList.SelectedItem;

                if (selectedVet != null)
                {
                    selectedVet.Name = nameInp.Text;
                    selectedVet.Specialization = specializationInp.Text;
                    selectedVet.Phone = phoneInp.Text;

                    SaveData();
                    RefreshVetList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Vet selectedVet = (Vet)vetList.SelectedItem;

            if (selectedVet != null)
            {
                var res = MessageBox.Show($"Are you absolutely sure you want to dismiss {selectedVet.Name}?", "Dismiss Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    vets.Remove(selectedVet);
                    SaveData();
                    RefreshVetList();
                    ClearForm();

                    MessageBox.Show($"The dismissal of {selectedVet.Name} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (res == DialogResult.No)
                {
                    DialogResult confirmAllResult = MessageBox.Show("Do you intend to dismiss all individuals instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmAllResult == DialogResult.Yes)
                    {
                        vets.Clear();
                        SaveData();
                        RefreshVetList();
                        ClearForm();

                        MessageBox.Show("All dismissals have been successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela carateres alfabéticos.
        /// </summary>
        /// <param name="sender">Utilizador.</param>
        /// <param name="e">Evento.</param>
        private void phoneInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("That doesn't appear to be a number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshVetList()
        {
            vetList.DataSource = null;
            vetList.DataSource = vets;
            vetList.DisplayMember = "Name";
        }

        private void ClearForm()
        {
            nameInp.Text = "";
            specializationInp.Text = "";
            phoneInp.Text = "";
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos ou vazios ou possuem somente espaços.
        /// </summary>
        /// <returns>Retorna verdadeiro se os campos encontram-se devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text) || string.IsNullOrWhiteSpace(specializationInp.Text))
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtém o próximo ID do veterinário(a)
        /// </summary>
        /// <returns>Retorna o próximo ID</returns>
        private int GetNextVetId()
        {
            return vets.Count > 0 ? vets[^1].Id + 1 : 1;
        }

        private void vetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vet selectedVet = (Vet)vetList.SelectedItem;
            if (selectedVet != null)
            {
                nameInp.Text = selectedVet.Name;
                specializationInp.Text = selectedVet.Specialization;
                phoneInp.Text = selectedVet.Phone;
            }
        }
    }
}