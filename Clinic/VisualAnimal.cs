using Lib;

namespace Clinic
{
    public partial class VisualAnimal : Form
    {
        private List<Animal> animals;
        private List<Client> clients;
        private string animalFile = "animals.txt";

        public VisualAnimal()
        {
            InitializeComponent();
            animals = new List<Animal>();
            LoadData();
            LoadClients();
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(animalFile);

            foreach (var rowData in data)
            {
                animals.Add(new Animal
                {
                    Id = Convert.ToInt32(rowData[0]),
                    Name = rowData[1],
                    Species = rowData[2],
                    Owner = rowData[3]
                });
            }

            RefreshAnimalList();
        }

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var animal in animals)
            {
                data.Add(new string[] {
                    animal.Id.ToString(),
                    animal.Name, animal.Species,
                    animal.Owner
                });
            }

            FileHandler.SaveData(data, animalFile);
        }

        private void LoadClients()
        {
            clients = VisualClient.GetClients();
            ownerCb.DataSource = clients;
            ownerCb.DisplayMember = "Name";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Animal animal = new Animal
                {
                    Id = GetNextAnimalId(),
                    Name = nameInp.Text,
                    Species = speciesInp.Text,
                    Owner = (ownerCb.SelectedItem as Client)?.Name
                };

                animals.Add(animal);
                SaveData();
                RefreshAnimalList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Animal selectedAnimal = (Animal)animalList.SelectedItem;

                if (selectedAnimal != null)
                {
                    selectedAnimal.Name = nameInp.Text;
                    selectedAnimal.Species = speciesInp.Text;
                    selectedAnimal.Owner = (ownerCb.SelectedItem as Client)?.Name;

                    SaveData();
                    RefreshAnimalList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Animal selectedAnimal = (Animal)animalList.SelectedItem;

            if (selectedAnimal != null)
            {
                var result = MessageBox.Show($"Are you absolutely sure you want to remove {selectedAnimal.Name} the {selectedAnimal.Species}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    animals.Remove(selectedAnimal);
                    SaveData();
                    RefreshAnimalList();
                    ClearForm();

                    MessageBox.Show($"The removal of {selectedAnimal.Name} the {selectedAnimal.Species} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    DialogResult confirmAllResult = MessageBox.Show("Do you intend to remove all animals instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmAllResult == DialogResult.Yes)
                    {
                        animals.Clear();
                        SaveData();
                        RefreshAnimalList();
                        ClearForm();

                        MessageBox.Show("All removals have been successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshAnimalList()
        {
            animalList.DataSource = null;
            animalList.DataSource = animals;
            animalList.DisplayMember = "Name";
        }

        private void ClearForm()
        {
            nameInp.Text = "";
            speciesInp.Text = "";
            ownerCb.SelectedItem = null;
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos ou vazios ou possuem somente espaços.
        /// </summary>
        /// <returns>Retorna verdadeiro se os campos encontram-se devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text) || string.IsNullOrWhiteSpace(speciesInp.Text) || ownerCb.SelectedItem == null)
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtém o próximo ID do animal
        /// </summary>
        /// <returns>Retorna o próximo ID</returns>
        private int GetNextAnimalId()
        {
            return animals.Count > 0 ? animals[^1].Id + 1 : 1;
        }

        private void animalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal selectedAnimal = (Animal)animalList.SelectedItem;
            if (selectedAnimal != null)
            {
                nameInp.Text = selectedAnimal.Name;
                speciesInp.Text = selectedAnimal.Species;
                ownerCb.SelectedItem = clients.Find(c => c.Name == selectedAnimal.Owner);
            }
        }
    }
}
